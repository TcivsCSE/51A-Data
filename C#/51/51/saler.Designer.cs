
namespace _51
{
    partial class saler
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
            this.btn_buyCard = new System.Windows.Forms.Button();
            this.btn_refundCard = new System.Windows.Forms.Button();
            this.btn_cardFixing = new System.Windows.Forms.Button();
            this.txbox_userAccountBuy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.con_saler = new System.Windows.Forms.TabControl();
            this.tp_buyCard = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_cardId = new System.Windows.Forms.DataGridView();
            this.tp_refundCard = new System.Windows.Forms.TabPage();
            this.txbox_cardIdRefund = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tp_fixCard = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txbox_state = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbox_balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbox_userAccount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_searchCard = new System.Windows.Forms.Button();
            this.dgv_cards = new System.Windows.Forms.DataGridView();
            this.txbox_cardIdfix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_news = new System.Windows.Forms.Label();
            this.label_toKnow = new System.Windows.Forms.Label();
            this.label_cardDescription = new System.Windows.Forms.Label();
            this.label_companyDescription = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.con_saler.SuspendLayout();
            this.tp_buyCard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardId)).BeginInit();
            this.tp_refundCard.SuspendLayout();
            this.tp_fixCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(713, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_buyCard
            // 
            this.btn_buyCard.Location = new System.Drawing.Point(9, 349);
            this.btn_buyCard.Name = "btn_buyCard";
            this.btn_buyCard.Size = new System.Drawing.Size(167, 34);
            this.btn_buyCard.TabIndex = 1;
            this.btn_buyCard.Text = "buy card";
            this.btn_buyCard.UseVisualStyleBackColor = true;
            this.btn_buyCard.Click += new System.EventHandler(this.btn_buyCard_Click);
            // 
            // btn_refundCard
            // 
            this.btn_refundCard.Location = new System.Drawing.Point(190, 234);
            this.btn_refundCard.Name = "btn_refundCard";
            this.btn_refundCard.Size = new System.Drawing.Size(321, 34);
            this.btn_refundCard.TabIndex = 2;
            this.btn_refundCard.Text = "refund card";
            this.btn_refundCard.UseVisualStyleBackColor = true;
            this.btn_refundCard.Click += new System.EventHandler(this.btn_refundCard_Click);
            // 
            // btn_cardFixing
            // 
            this.btn_cardFixing.Location = new System.Drawing.Point(515, 360);
            this.btn_cardFixing.Name = "btn_cardFixing";
            this.btn_cardFixing.Size = new System.Drawing.Size(167, 34);
            this.btn_cardFixing.TabIndex = 3;
            this.btn_cardFixing.Text = "card fixing";
            this.btn_cardFixing.UseVisualStyleBackColor = true;
            this.btn_cardFixing.Click += new System.EventHandler(this.btn_cardFixing_Click);
            // 
            // txbox_userAccountBuy
            // 
            this.txbox_userAccountBuy.Location = new System.Drawing.Point(11, 91);
            this.txbox_userAccountBuy.Name = "txbox_userAccountBuy";
            this.txbox_userAccountBuy.Size = new System.Drawing.Size(150, 22);
            this.txbox_userAccountBuy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "user account";
            // 
            // con_saler
            // 
            this.con_saler.Controls.Add(this.tp_buyCard);
            this.con_saler.Controls.Add(this.tp_refundCard);
            this.con_saler.Controls.Add(this.tp_fixCard);
            this.con_saler.Controls.Add(this.tabPage1);
            this.con_saler.Location = new System.Drawing.Point(8, 12);
            this.con_saler.Margin = new System.Windows.Forms.Padding(2);
            this.con_saler.Name = "con_saler";
            this.con_saler.SelectedIndex = 0;
            this.con_saler.Size = new System.Drawing.Size(693, 425);
            this.con_saler.TabIndex = 8;
            // 
            // tp_buyCard
            // 
            this.tp_buyCard.Controls.Add(this.groupBox1);
            this.tp_buyCard.Controls.Add(this.dgv_cardId);
            this.tp_buyCard.Location = new System.Drawing.Point(4, 22);
            this.tp_buyCard.Margin = new System.Windows.Forms.Padding(2);
            this.tp_buyCard.Name = "tp_buyCard";
            this.tp_buyCard.Padding = new System.Windows.Forms.Padding(2);
            this.tp_buyCard.Size = new System.Drawing.Size(685, 399);
            this.tp_buyCard.TabIndex = 0;
            this.tp_buyCard.Text = "buy card";
            this.tp_buyCard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbox_userAccountBuy);
            this.groupBox1.Controls.Add(this.btn_buyCard);
            this.groupBox1.Location = new System.Drawing.Point(488, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 389);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "buy card";
            // 
            // dgv_cardId
            // 
            this.dgv_cardId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cardId.Location = new System.Drawing.Point(4, 4);
            this.dgv_cardId.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cardId.Name = "dgv_cardId";
            this.dgv_cardId.RowHeadersWidth = 62;
            this.dgv_cardId.RowTemplate.Height = 31;
            this.dgv_cardId.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cardId.Size = new System.Drawing.Size(479, 395);
            this.dgv_cardId.TabIndex = 8;
            // 
            // tp_refundCard
            // 
            this.tp_refundCard.Controls.Add(this.txbox_cardIdRefund);
            this.tp_refundCard.Controls.Add(this.label3);
            this.tp_refundCard.Controls.Add(this.btn_refundCard);
            this.tp_refundCard.Location = new System.Drawing.Point(4, 22);
            this.tp_refundCard.Margin = new System.Windows.Forms.Padding(2);
            this.tp_refundCard.Name = "tp_refundCard";
            this.tp_refundCard.Padding = new System.Windows.Forms.Padding(2);
            this.tp_refundCard.Size = new System.Drawing.Size(685, 399);
            this.tp_refundCard.TabIndex = 1;
            this.tp_refundCard.Text = "refund card";
            this.tp_refundCard.UseVisualStyleBackColor = true;
            // 
            // txbox_cardIdRefund
            // 
            this.txbox_cardIdRefund.Location = new System.Drawing.Point(215, 190);
            this.txbox_cardIdRefund.Name = "txbox_cardIdRefund";
            this.txbox_cardIdRefund.Size = new System.Drawing.Size(254, 22);
            this.txbox_cardIdRefund.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(209, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "card id";
            // 
            // tp_fixCard
            // 
            this.tp_fixCard.Controls.Add(this.label6);
            this.tp_fixCard.Controls.Add(this.txbox_state);
            this.tp_fixCard.Controls.Add(this.label5);
            this.tp_fixCard.Controls.Add(this.txbox_balance);
            this.tp_fixCard.Controls.Add(this.label4);
            this.tp_fixCard.Controls.Add(this.txbox_userAccount);
            this.tp_fixCard.Controls.Add(this.button1);
            this.tp_fixCard.Controls.Add(this.btn_searchCard);
            this.tp_fixCard.Controls.Add(this.dgv_cards);
            this.tp_fixCard.Controls.Add(this.txbox_cardIdfix);
            this.tp_fixCard.Controls.Add(this.label2);
            this.tp_fixCard.Controls.Add(this.btn_cardFixing);
            this.tp_fixCard.Location = new System.Drawing.Point(4, 22);
            this.tp_fixCard.Margin = new System.Windows.Forms.Padding(2);
            this.tp_fixCard.Name = "tp_fixCard";
            this.tp_fixCard.Padding = new System.Windows.Forms.Padding(2);
            this.tp_fixCard.Size = new System.Drawing.Size(685, 399);
            this.tp_fixCard.TabIndex = 2;
            this.tp_fixCard.Text = "fix card";
            this.tp_fixCard.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "state";
            // 
            // txbox_state
            // 
            this.txbox_state.Location = new System.Drawing.Point(512, 146);
            this.txbox_state.Name = "txbox_state";
            this.txbox_state.Size = new System.Drawing.Size(169, 22);
            this.txbox_state.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "balance";
            // 
            // txbox_balance
            // 
            this.txbox_balance.Location = new System.Drawing.Point(512, 103);
            this.txbox_balance.Name = "txbox_balance";
            this.txbox_balance.Size = new System.Drawing.Size(169, 22);
            this.txbox_balance.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "user_account";
            // 
            // txbox_userAccount
            // 
            this.txbox_userAccount.Location = new System.Drawing.Point(512, 60);
            this.txbox_userAccount.Name = "txbox_userAccount";
            this.txbox_userAccount.Size = new System.Drawing.Size(169, 22);
            this.txbox_userAccount.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "show all ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_searchCard
            // 
            this.btn_searchCard.Location = new System.Drawing.Point(371, 372);
            this.btn_searchCard.Name = "btn_searchCard";
            this.btn_searchCard.Size = new System.Drawing.Size(132, 23);
            this.btn_searchCard.TabIndex = 12;
            this.btn_searchCard.Text = "serach card";
            this.btn_searchCard.UseVisualStyleBackColor = true;
            this.btn_searchCard.Click += new System.EventHandler(this.btn_searchCard_Click);
            // 
            // dgv_cards
            // 
            this.dgv_cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cards.Location = new System.Drawing.Point(1, 0);
            this.dgv_cards.Name = "dgv_cards";
            this.dgv_cards.RowTemplate.Height = 24;
            this.dgv_cards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cards.Size = new System.Drawing.Size(508, 366);
            this.dgv_cards.TabIndex = 0;
            this.dgv_cards.TabStop = false;
            this.dgv_cards.SelectionChanged += new System.EventHandler(this.dgv_cards_SelectionChanged);
            // 
            // txbox_cardIdfix
            // 
            this.txbox_cardIdfix.Location = new System.Drawing.Point(147, 372);
            this.txbox_cardIdfix.Name = "txbox_cardIdfix";
            this.txbox_cardIdfix.Size = new System.Drawing.Size(218, 22);
            this.txbox_cardIdfix.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(75, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "card id";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_news);
            this.tabPage1.Controls.Add(this.label_toKnow);
            this.tabPage1.Controls.Add(this.label_cardDescription);
            this.tabPage1.Controls.Add(this.label_companyDescription);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(685, 399);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_news
            // 
            this.label_news.BackColor = System.Drawing.Color.LightGray;
            this.label_news.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_news.Location = new System.Drawing.Point(3, 303);
            this.label_news.Name = "label_news";
            this.label_news.Size = new System.Drawing.Size(679, 78);
            this.label_news.TabIndex = 16;
            // 
            // label_toKnow
            // 
            this.label_toKnow.BackColor = System.Drawing.Color.LightGray;
            this.label_toKnow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_toKnow.Location = new System.Drawing.Point(3, 209);
            this.label_toKnow.Name = "label_toKnow";
            this.label_toKnow.Size = new System.Drawing.Size(679, 78);
            this.label_toKnow.TabIndex = 15;
            // 
            // label_cardDescription
            // 
            this.label_cardDescription.BackColor = System.Drawing.Color.LightGray;
            this.label_cardDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_cardDescription.Location = new System.Drawing.Point(3, 119);
            this.label_cardDescription.Name = "label_cardDescription";
            this.label_cardDescription.Size = new System.Drawing.Size(679, 78);
            this.label_cardDescription.TabIndex = 14;
            // 
            // label_companyDescription
            // 
            this.label_companyDescription.BackColor = System.Drawing.Color.LightGray;
            this.label_companyDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_companyDescription.Location = new System.Drawing.Point(3, 25);
            this.label_companyDescription.Name = "label_companyDescription";
            this.label_companyDescription.Size = new System.Drawing.Size(679, 78);
            this.label_companyDescription.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(0, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 12);
            this.label15.TabIndex = 12;
            this.label15.Text = "news";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "to know";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "card description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "company description";
            // 
            // saler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.con_saler);
            this.Controls.Add(this.btn_logout);
            this.Name = "saler";
            this.Text = "saler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saler_FormClosing);
            this.Load += new System.EventHandler(this.saler_Load);
            this.con_saler.ResumeLayout(false);
            this.tp_buyCard.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardId)).EndInit();
            this.tp_refundCard.ResumeLayout(false);
            this.tp_refundCard.PerformLayout();
            this.tp_fixCard.ResumeLayout(false);
            this.tp_fixCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_buyCard;
        private System.Windows.Forms.Button btn_refundCard;
        private System.Windows.Forms.Button btn_cardFixing;
        private System.Windows.Forms.TextBox txbox_userAccountBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl con_saler;
        private System.Windows.Forms.TabPage tp_buyCard;
        private System.Windows.Forms.TabPage tp_refundCard;
        private System.Windows.Forms.TabPage tp_fixCard;
        private System.Windows.Forms.DataGridView dgv_cardId;
        private System.Windows.Forms.TextBox txbox_cardIdRefund;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_companyDescription;
        private System.Windows.Forms.Label label_news;
        private System.Windows.Forms.Label label_toKnow;
        private System.Windows.Forms.Label label_cardDescription;
        private System.Windows.Forms.TextBox txbox_cardIdfix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_searchCard;
        private System.Windows.Forms.DataGridView dgv_cards;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbox_state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbox_balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbox_userAccount;
    }
}