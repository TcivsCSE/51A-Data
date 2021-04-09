
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
            this.label15 = new System.Windows.Forms.Label();
            this.txbox_news = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txbox_toKnow = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbox_cardDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbox_companyDescription = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_applySalerChange = new System.Windows.Forms.Button();
            this.btn_delUser = new System.Windows.Forms.Button();
            this.btn_useradd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txbox_workpoint = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbox_saleNameAdd = new System.Windows.Forms.TextBox();
            this.btn_searchSaler = new System.Windows.Forms.Button();
            this.btn_showUsers = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_salers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbox_usingAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_seartch = new System.Windows.Forms.Button();
            this.txbox_servicePoint = new System.Windows.Forms.TextBox();
            this.btn_applyChange = new System.Windows.Forms.Button();
            this.txbox_salerIneed = new System.Windows.Forms.TextBox();
            this.txbox_pointName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbox_salerName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txbox_news);
            this.tabPage2.Controls.Add(this.btn_apply);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txbox_toKnow);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txbox_cardDescription);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txbox_companyDescription);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(889, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "information control ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "news";
            // 
            // txbox_news
            // 
            this.txbox_news.Location = new System.Drawing.Point(3, 303);
            this.txbox_news.Multiline = true;
            this.txbox_news.Name = "txbox_news";
            this.txbox_news.Size = new System.Drawing.Size(881, 76);
            this.txbox_news.TabIndex = 7;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(809, 435);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 6;
            this.btn_apply.Text = "apply change";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "to know";
            // 
            // txbox_toKnow
            // 
            this.txbox_toKnow.Location = new System.Drawing.Point(3, 209);
            this.txbox_toKnow.Multiline = true;
            this.txbox_toKnow.Name = "txbox_toKnow";
            this.txbox_toKnow.Size = new System.Drawing.Size(881, 76);
            this.txbox_toKnow.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 12);
            this.label13.TabIndex = 3;
            this.label13.Text = "card description";
            // 
            // txbox_cardDescription
            // 
            this.txbox_cardDescription.Location = new System.Drawing.Point(3, 115);
            this.txbox_cardDescription.Multiline = true;
            this.txbox_cardDescription.Name = "txbox_cardDescription";
            this.txbox_cardDescription.Size = new System.Drawing.Size(881, 76);
            this.txbox_cardDescription.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "company description";
            // 
            // txbox_companyDescription
            // 
            this.txbox_companyDescription.Location = new System.Drawing.Point(3, 21);
            this.txbox_companyDescription.Multiline = true;
            this.txbox_companyDescription.Name = "txbox_companyDescription";
            this.txbox_companyDescription.Size = new System.Drawing.Size(881, 76);
            this.txbox_companyDescription.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.btn_searchSaler);
            this.tabPage3.Controls.Add(this.btn_showUsers);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dgv_salers);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.txbox_salerName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 463);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "operation control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_applySalerChange);
            this.groupBox3.Controls.Add(this.btn_delUser);
            this.groupBox3.Controls.Add(this.btn_useradd);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txbox_workpoint);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txbox_saleNameAdd);
            this.groupBox3.Location = new System.Drawing.Point(650, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 451);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "user control";
            // 
            // btn_applySalerChange
            // 
            this.btn_applySalerChange.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_applySalerChange.Location = new System.Drawing.Point(21, 124);
            this.btn_applySalerChange.Name = "btn_applySalerChange";
            this.btn_applySalerChange.Size = new System.Drawing.Size(188, 46);
            this.btn_applySalerChange.TabIndex = 20;
            this.btn_applySalerChange.Text = "apply chnge";
            this.btn_applySalerChange.UseVisualStyleBackColor = true;
            this.btn_applySalerChange.Click += new System.EventHandler(this.btn_applySalerChange_Click);
            // 
            // btn_delUser
            // 
            this.btn_delUser.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delUser.Location = new System.Drawing.Point(21, 388);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(188, 46);
            this.btn_delUser.TabIndex = 18;
            this.btn_delUser.Text = "delete user\r\n\r\n";
            this.btn_delUser.UseVisualStyleBackColor = true;
            this.btn_delUser.Click += new System.EventHandler(this.btn_delUser_Click);
            // 
            // btn_useradd
            // 
            this.btn_useradd.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_useradd.Location = new System.Drawing.Point(21, 336);
            this.btn_useradd.Name = "btn_useradd";
            this.btn_useradd.Size = new System.Drawing.Size(188, 46);
            this.btn_useradd.TabIndex = 17;
            this.btn_useradd.Text = "add user";
            this.btn_useradd.UseVisualStyleBackColor = true;
            this.btn_useradd.Click += new System.EventHandler(this.btn_useradd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(30, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 27);
            this.label10.TabIndex = 14;
            this.label10.Text = "work point";
            // 
            // txbox_workpoint
            // 
            this.txbox_workpoint.Location = new System.Drawing.Point(21, 96);
            this.txbox_workpoint.Name = "txbox_workpoint";
            this.txbox_workpoint.Size = new System.Drawing.Size(188, 22);
            this.txbox_workpoint.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(30, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 27);
            this.label12.TabIndex = 10;
            this.label12.Text = "saler Name";
            // 
            // txbox_saleNameAdd
            // 
            this.txbox_saleNameAdd.Location = new System.Drawing.Point(21, 41);
            this.txbox_saleNameAdd.Name = "txbox_saleNameAdd";
            this.txbox_saleNameAdd.Size = new System.Drawing.Size(188, 22);
            this.txbox_saleNameAdd.TabIndex = 9;
            // 
            // btn_searchSaler
            // 
            this.btn_searchSaler.Location = new System.Drawing.Point(548, 433);
            this.btn_searchSaler.Name = "btn_searchSaler";
            this.btn_searchSaler.Size = new System.Drawing.Size(92, 23);
            this.btn_searchSaler.TabIndex = 11;
            this.btn_searchSaler.Text = "search saler";
            this.btn_searchSaler.UseVisualStyleBackColor = true;
            this.btn_searchSaler.Click += new System.EventHandler(this.btn_searchSaler_Click);
            // 
            // btn_showUsers
            // 
            this.btn_showUsers.Location = new System.Drawing.Point(207, 434);
            this.btn_showUsers.Name = "btn_showUsers";
            this.btn_showUsers.Size = new System.Drawing.Size(92, 23);
            this.btn_showUsers.TabIndex = 10;
            this.btn_showUsers.Text = "show all users";
            this.btn_showUsers.UseVisualStyleBackColor = true;
            this.btn_showUsers.Click += new System.EventHandler(this.btn_showUsers_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(305, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "saler_name";
            // 
            // dgv_salers
            // 
            this.dgv_salers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salers.Location = new System.Drawing.Point(207, 7);
            this.dgv_salers.Name = "dgv_salers";
            this.dgv_salers.RowTemplate.Height = 24;
            this.dgv_salers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_salers.Size = new System.Drawing.Size(437, 422);
            this.dgv_salers.TabIndex = 1;
            this.dgv_salers.SelectionChanged += new System.EventHandler(this.dgv_salers_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbox_usingAccount);
            this.groupBox2.Controls.Add(this.label9);
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
            // txbox_usingAccount
            // 
            this.txbox_usingAccount.Location = new System.Drawing.Point(4, 260);
            this.txbox_usingAccount.Name = "txbox_usingAccount";
            this.txbox_usingAccount.Size = new System.Drawing.Size(182, 22);
            this.txbox_usingAccount.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "using account";
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
            this.btn_applyChange.Location = new System.Drawing.Point(0, 408);
            this.btn_applyChange.Name = "btn_applyChange";
            this.btn_applyChange.Size = new System.Drawing.Size(188, 33);
            this.btn_applyChange.TabIndex = 6;
            this.btn_applyChange.Text = "apply change";
            this.btn_applyChange.UseVisualStyleBackColor = true;
            this.btn_applyChange.Click += new System.EventHandler(this.btn_applyChange_Click);
            // 
            // txbox_salerIneed
            // 
            this.txbox_salerIneed.Location = new System.Drawing.Point(4, 384);
            this.txbox_salerIneed.Name = "txbox_salerIneed";
            this.txbox_salerIneed.Size = new System.Drawing.Size(182, 22);
            this.txbox_salerIneed.TabIndex = 5;
            // 
            // txbox_pointName
            // 
            this.txbox_pointName.Location = new System.Drawing.Point(4, 325);
            this.txbox_pointName.Name = "txbox_pointName";
            this.txbox_pointName.Size = new System.Drawing.Size(182, 22);
            this.txbox_pointName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(4, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "saler ineed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 292);
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
            // txbox_salerName
            // 
            this.txbox_salerName.Location = new System.Drawing.Point(405, 434);
            this.txbox_salerName.Name = "txbox_salerName";
            this.txbox_salerName.Size = new System.Drawing.Size(137, 22);
            this.txbox_salerName.TabIndex = 5;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbox_salerName;
        private System.Windows.Forms.Button btn_showUsers;
        private System.Windows.Forms.Button btn_searchSaler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delUser;
        private System.Windows.Forms.Button btn_useradd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbox_workpoint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbox_saleNameAdd;
        private System.Windows.Forms.Button btn_applySalerChange;
        private System.Windows.Forms.TextBox txbox_usingAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbox_companyDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbox_toKnow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbox_cardDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbox_news;
    }
}