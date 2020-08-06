﻿namespace SQLToSQL
{
    partial class SQLToSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TextBox();
            this.db = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.ct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableSource = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dbSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serverSource = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userSource = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.passSource = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(116, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table
            // 
            this.table.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "table", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.table.Location = new System.Drawing.Point(57, 236);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(238, 20);
            this.table.TabIndex = 25;
            this.table.Text = global::SQLToSQL.Properties.Settings.Default.table;
            // 
            // db
            // 
            this.db.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "db", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.db.Location = new System.Drawing.Point(57, 210);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(238, 20);
            this.db.TabIndex = 24;
            this.db.Text = global::SQLToSQL.Properties.Settings.Default.db;
            // 
            // server
            // 
            this.server.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.server.Location = new System.Drawing.Point(57, 184);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(238, 20);
            this.server.TabIndex = 23;
            this.server.Text = global::SQLToSQL.Properties.Settings.Default.server;
            // 
            // ct
            // 
            this.ct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ct.AutoSize = true;
            this.ct.Location = new System.Drawing.Point(22, 331);
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(29, 13);
            this.ct.TabIndex = 10;
            this.ct.Text = "Row";
            this.ct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Query:";
            // 
            // tableSource
            // 
            this.tableSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "tableSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tableSource.Location = new System.Drawing.Point(57, 82);
            this.tableSource.Name = "tableSource";
            this.tableSource.Size = new System.Drawing.Size(238, 20);
            this.tableSource.TabIndex = 16;
            this.tableSource.Text = global::SQLToSQL.Properties.Settings.Default.tableSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DB:";
            // 
            // dbSource
            // 
            this.dbSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "dbSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dbSource.Location = new System.Drawing.Point(57, 56);
            this.dbSource.Name = "dbSource";
            this.dbSource.Size = new System.Drawing.Size(238, 20);
            this.dbSource.TabIndex = 14;
            this.dbSource.Text = global::SQLToSQL.Properties.Settings.Default.dbSource;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Server:";
            // 
            // serverSource
            // 
            this.serverSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "serverSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverSource.Location = new System.Drawing.Point(57, 30);
            this.serverSource.Name = "serverSource";
            this.serverSource.Size = new System.Drawing.Size(238, 20);
            this.serverSource.TabIndex = 12;
            this.serverSource.Text = global::SQLToSQL.Properties.Settings.Default.serverSource;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "User:";
            // 
            // userSource
            // 
            this.userSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "userSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userSource.Location = new System.Drawing.Point(57, 108);
            this.userSource.Name = "userSource";
            this.userSource.Size = new System.Drawing.Size(238, 20);
            this.userSource.TabIndex = 19;
            this.userSource.Text = global::SQLToSQL.Properties.Settings.Default.userSource;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Pass:";
            // 
            // passSource
            // 
            this.passSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "passSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passSource.Location = new System.Drawing.Point(57, 134);
            this.passSource.Name = "passSource";
            this.passSource.Size = new System.Drawing.Size(238, 20);
            this.passSource.TabIndex = 21;
            this.passSource.Text = global::SQLToSQL.Properties.Settings.Default.passSource;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Pass:";
            // 
            // pass
            // 
            this.pass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "pass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pass.Location = new System.Drawing.Point(57, 288);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(238, 20);
            this.pass.TabIndex = 27;
            this.pass.Text = global::SQLToSQL.Properties.Settings.Default.pass;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "User:";
            // 
            // user
            // 
            this.user.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SQLToSQL.Properties.Settings.Default, "user", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.user.Location = new System.Drawing.Point(57, 262);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(238, 20);
            this.user.TabIndex = 26;
            this.user.Text = global::SQLToSQL.Properties.Settings.Default.user;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(242, 331);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 29;
            this.status.Text = "Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SQLToSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.passSource);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableSource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dbSource);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.serverSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server);
            this.MaximumSize = new System.Drawing.Size(325, 400);
            this.MinimumSize = new System.Drawing.Size(325, 400);
            this.Name = "SQLToSQL";
            this.Text = "SQLToSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox db;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox table;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tableSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dbSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serverSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label status;
    }
}