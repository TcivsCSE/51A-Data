﻿
namespace _51
{
    partial class admin
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_showAllUsers = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_seartchUser = new System.Windows.Forms.Button();
            this.txbox_user = new System.Windows.Forms.TextBox();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbox_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbox_account = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_salers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_seartch = new System.Windows.Forms.Button();
            this.txbox_servicePoint = new System.Windows.Forms.TextBox();
            this.btn_applyChange = new System.Windows.Forms.Button();
            this.txbox_salerIneed = new System.Windows.Forms.TextBox();
            this.txbox_pointName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(909, 8);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(79, 24);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 489);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_showAllUsers);
            this.tabPage1.Controls.Add(this.btn_deleteUser);
            this.tabPage1.Controls.Add(this.btn_seartchUser);
            this.tabPage1.Controls.Add(this.txbox_user);
            this.tabPage1.Controls.Add(this.dgv_users);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(889, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "user control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_showAllUsers
            // 
            this.btn_showAllUsers.Location = new System.Drawing.Point(211, 429);
            this.btn_showAllUsers.Name = "btn_showAllUsers";
            this.btn_showAllUsers.Size = new System.Drawing.Size(92, 23);
            this.btn_showAllUsers.TabIndex = 5;
            this.btn_showAllUsers.Text = "show all users";
            this.btn_showAllUsers.UseVisualStyleBackColor = true;
            this.btn_showAllUsers.Click += new System.EventHandler(this.btn_showAllUsers_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Location = new System.Drawing.Point(809, 430);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteUser.TabIndex = 4;
            this.btn_deleteUser.Text = "delete user ";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_seartchUser
            // 
            this.btn_seartchUser.Location = new System.Drawing.Point(728, 430);
            this.btn_seartchUser.Name = "btn_seartchUser";
            this.btn_seartchUser.Size = new System.Drawing.Size(75, 23);
            this.btn_seartchUser.TabIndex = 3;
            this.btn_seartchUser.Text = "seartch user";
            this.btn_seartchUser.UseVisualStyleBackColor = true;
            this.btn_seartchUser.Click += new System.EventHandler(this.btn_seartchUser_Click);
            // 
            // txbox_user
            // 
            this.txbox_user.Location = new System.Drawing.Point(309, 430);
            this.txbox_user.Name = "txbox_user";
            this.txbox_user.Size = new System.Drawing.Size(413, 22);
            this.txbox_user.TabIndex = 2;
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(211, 5);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowTemplate.Height = 24;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(673, 418);
            this.dgv_users.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbox_group);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbox_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbox_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbox_account);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增使用者";
            // 
            // btn_addUser
            // 
            this.btn_addUser.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addUser.Location = new System.Drawing.Point(6, 401);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(188, 46);
            this.btn_addUser.TabIndex = 8;
            this.btn_addUser.Text = "add user";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "group";
            // 
            // cbbox_group
            // 
            this.cbbox_group.FormattingEnabled = true;
            this.cbbox_group.Items.AddRange(new object[] {
            "admin",
            "saler",
            "user"});
            this.cbbox_group.Location = new System.Drawing.Point(6, 236);
            this.cbbox_group.Name = "cbbox_group";
            this.cbbox_group.Size = new System.Drawing.Size(188, 20);
            this.cbbox_group.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // txbox_password
            // 
            this.txbox_password.Location = new System.Drawing.Point(6, 103);
            this.txbox_password.Name = "txbox_password";
            this.txbox_password.Size = new System.Drawing.Size(188, 22);
            this.txbox_password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "name";
            // 
            // txbox_name
            // 
            this.txbox_name.Location = new System.Drawing.Point(6, 158);
            this.txbox_name.Name = "txbox_name";
            this.txbox_name.Size = new System.Drawing.Size(188, 22);
            this.txbox_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "account";
            // 
            // txbox_account
            // 
            this.txbox_account.Location = new System.Drawing.Point(6, 48);
            this.txbox_account.Name = "txbox_account";
            this.txbox_account.Size = new System.Drawing.Size(188, 22);
            this.txbox_account.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(889, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "information control ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_salers);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "operation control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_salers
            // 
            this.dgv_salers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salers.Location = new System.Drawing.Point(207, 7);
            this.dgv_salers.Name = "dgv_salers";
            this.dgv_salers.RowTemplate.Height = 24;
            this.dgv_salers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_salers.Size = new System.Drawing.Size(676, 450);
            this.dgv_salers.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_seartch);
            this.groupBox2.Controls.Add(this.txbox_servicePoint);
            this.groupBox2.Controls.Add(this.btn_applyChange);
            this.groupBox2.Controls.Add(this.txbox_salerIneed);
            this.groupBox2.Controls.Add(this.txbox_pointName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 450);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "service point";
            // 
            // btn_seartch
            // 
            this.btn_seartch.Location = new System.Drawing.Point(4, 104);
            this.btn_seartch.Name = "btn_seartch";
            this.btn_seartch.Size = new System.Drawing.Size(188, 33);
            this.btn_seartch.TabIndex = 8;
            this.btn_seartch.Text = "seartch";
            this.btn_seartch.UseVisualStyleBackColor = true;
            this.btn_seartch.Click += new System.EventHandler(this.btn_seartch_Click);
            // 
            // txbox_servicePoint
            // 
            this.txbox_servicePoint.Location = new System.Drawing.Point(6, 64);
            this.txbox_servicePoint.Name = "txbox_servicePoint";
            this.txbox_servicePoint.Size = new System.Drawing.Size(182, 22);
            this.txbox_servicePoint.TabIndex = 7;
            // 
            // btn_applyChange
            // 
            this.btn_applyChange.Location = new System.Drawing.Point(0, 411);
            this.btn_applyChange.Name = "btn_applyChange";
            this.btn_applyChange.Size = new System.Drawing.Size(188, 33);
            this.btn_applyChange.TabIndex = 6;
            this.btn_applyChange.Text = "apply change";
            this.btn_applyChange.UseVisualStyleBackColor = true;
            this.btn_applyChange.Click += new System.EventHandler(this.btn_applyChange_Click);
            // 
            // txbox_salerIneed
            // 
            this.txbox_salerIneed.Location = new System.Drawing.Point(4, 387);
            this.txbox_salerIneed.Name = "txbox_salerIneed";
            this.txbox_salerIneed.Size = new System.Drawing.Size(182, 22);
            this.txbox_salerIneed.TabIndex = 5;
            // 
            // txbox_pointName
            // 
            this.txbox_pointName.Location = new System.Drawing.Point(4, 328);
            this.txbox_pointName.Name = "txbox_pointName";
            this.txbox_pointName.Size = new System.Drawing.Size(182, 22);
            this.txbox_pointName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(4, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "saler ineed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "point name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "seartch service point";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(889, 463);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "statistical report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 505);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbox_group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbox_account;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_seartchUser;
        private System.Windows.Forms.TextBox txbox_user;
        private System.Windows.Forms.Button btn_showAllUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbox_salerIneed;
        private System.Windows.Forms.TextBox txbox_pointName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_applyChange;
        private System.Windows.Forms.TextBox txbox_servicePoint;
        private System.Windows.Forms.Button btn_seartch;
        private System.Windows.Forms.DataGridView dgv_salers;
    }
}