using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace SQLToSQL
{
    public partial class SQLToSQL : Form
    {

        public SQLToSQL()
        {
            InitializeComponent();
            ct.Text = "";
            status.Text = "";
        }

        private long threadLock = 0, threadError=0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Properties.Settings.Default.Save();
            try
            {
                using (SqlConnection sourceCon = new SqlConnection("Server=" + serverSource.Text + ";Initial Catalog=" + dbSource.Text + (userSource.Text == "" ? ";Trusted_Connection=True;" : ";Persist Security Info=False;User ID=" + userSource.Text + ";Password=" + passSource.Text + ";Connection Timeout=30;")))
                {
                    sourceCon.Open();
                    using (SqlConnection con = new SqlConnection("Server=" + server.Text + ";Initial Catalog=" + db.Text + (user.Text == "" ? ";Trusted_Connection=True;" : ";Persist Security Info=False;User ID=" + user.Text + ";Password=" + pass.Text + ";Connection Timeout=30;")))
                    {
                        con.Open();

                        List<string> rows = new List<string>();
                        string q = "";
                        DataTable t = new System.Data.DataTable();
                        int i = 0;

                        using (SqlCommand com = new SqlCommand(tableSource.Text, sourceCon))
                        {
                            com.CommandTimeout = 3600;
                            using (SqlDataReader r = com.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    i++;
                                    status.Text = "Reading...";
                                    ct.Text = "Row " + i;
                                    if (i % 10000 == 0) Application.DoEvents();

                                    if (i == 1)
                                    {
                                        for (int x = 0; x < r.FieldCount; x++)
                                            t.Columns.Add(r.GetName(x), r.GetFieldType(x));
                                    }

                                    object[] cells = new object[r.FieldCount];
                                    for (int x = 0; x < r.FieldCount; x++)
                                        cells[x] = r.GetValue(x);

                                    t.Rows.Add(cells);

                                    if (t.Rows.Count >= 100000)
                                    {
                                        Application.DoEvents();
                                        status.Text = "Inserting...";
                                        Interlocked.Increment(ref threadLock);
                                        ThreadPool.QueueUserWorkItem(new WaitCallback(Insert), new object[] { con, table.Text, t });
                                        while (threadLock > 0)
                                        {
                                            Thread.Sleep(1000);
                                            Application.DoEvents();
                                        }
                                        if (threadError > 0)
                                        {
                                            status.Text = "Errored.";
                                            button1.Enabled = true;
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        if (t.Rows.Count > 0)
                        {
                            Application.DoEvents();
                            status.Text = "Inserting...";
                            Interlocked.Increment(ref threadLock);
                            ThreadPool.QueueUserWorkItem(new WaitCallback(Insert), new object[] { con, table.Text, t });
                            while (threadLock > 0)
                            {
                                Thread.Sleep(1000);
                                Application.DoEvents();
                            }
                            if (threadError > 0)
                            {
                                status.Text = "Errored.";
                                button1.Enabled = true;
                                return;
                            }
                        }

                        con.Close();
                    }
                    sourceCon.Close();
                }
                status.Text = "Done!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                status.Text = "Errored.";
            }
            button1.Enabled = true;
        }

        private void Insert(object o)
        {
            try
            {
                using (SqlBulkCopy s = new SqlBulkCopy((SqlConnection)((object[])o)[0]))
                {
                    s.DestinationTableName = (string)((object[])o)[1];
                    s.BulkCopyTimeout =3600;
                    s.WriteToServer((DataTable)((object[])o)[2]);
                }
                ((DataTable)((object[])o)[2]).Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on insert: " + ex);
                Interlocked.Increment(ref threadError);
            }
            Interlocked.Decrement(ref threadLock);
        }
    }
}
