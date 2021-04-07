
namespace _51
{
    partial class user
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bel1 = new System.Windows.Forms.Label();
            this.btn_showAllCard = new System.Windows.Forms.Button();
            this.btn_searchCard = new System.Windows.Forms.Button();
            this.txbox_cardId = new System.Windows.Forms.TextBox();
            this.dgv_cardBalance = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbox_paymentMrnthod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbox_acountStoreValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbox_mainCardId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbox_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbox_subCardId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbox_hostCardId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardBalance)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(706, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(688, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(680, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "park&refuel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bel1);
            this.tabPage1.Controls.Add(this.btn_showAllCard);
            this.tabPage1.Controls.Add(this.btn_searchCard);
            this.tabPage1.Controls.Add(this.txbox_cardId);
            this.tabPage1.Controls.Add(this.dgv_cardBalance);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(680, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "show balance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bel1
            // 
            this.bel1.AutoSize = true;
            this.bel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bel1.Location = new System.Drawing.Point(87, 404);
            this.bel1.Name = "bel1";
            this.bel1.Size = new System.Drawing.Size(51, 16);
            this.bel1.TabIndex = 4;
            this.bel1.Text = "card id";
            // 
            // btn_showAllCard
            // 
            this.btn_showAllCard.Location = new System.Drawing.Point(6, 397);
            this.btn_showAllCard.Name = "btn_showAllCard";
            this.btn_showAllCard.Size = new System.Drawing.Size(75, 23);
            this.btn_showAllCard.TabIndex = 2;
            this.btn_showAllCard.Text = "show all card";
            this.btn_showAllCard.UseVisualStyleBackColor = true;
            this.btn_showAllCard.Click += new System.EventHandler(this.btn_showAllCard_Click);
            // 
            // btn_searchCard
            // 
            this.btn_searchCard.Location = new System.Drawing.Point(602, 397);
            this.btn_searchCard.Name = "btn_searchCard";
            this.btn_searchCard.Size = new System.Drawing.Size(75, 23);
            this.btn_searchCard.TabIndex = 3;
            this.btn_searchCard.Text = "search card";
            this.btn_searchCard.UseVisualStyleBackColor = true;
            this.btn_searchCard.Click += new System.EventHandler(this.btn_searchCard_Click);
            // 
            // txbox_cardId
            // 
            this.txbox_cardId.Location = new System.Drawing.Point(144, 398);
            this.txbox_cardId.Name = "txbox_cardId";
            this.txbox_cardId.Size = new System.Drawing.Size(452, 22);
            this.txbox_cardId.TabIndex = 1;
            // 
            // dgv_cardBalance
            // 
            this.dgv_cardBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cardBalance.Location = new System.Drawing.Point(6, 6);
            this.dgv_cardBalance.Name = "dgv_cardBalance";
            this.dgv_cardBalance.RowTemplate.Height = 24;
            this.dgv_cardBalance.Size = new System.Drawing.Size(671, 390);
            this.dgv_cardBalance.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(680, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "interactive with saler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(680, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "transfer&store_value";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbbox_paymentMrnthod);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbox_acountStoreValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbox_mainCardId);
            this.groupBox2.Location = new System.Drawing.Point(343, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "store_value";
            // 
            // cbbox_paymentMrnthod
            // 
            this.cbbox_paymentMrnthod.FormattingEnabled = true;
            this.cbbox_paymentMrnthod.Items.AddRange(new object[] {
            "cash"});
            this.cbbox_paymentMrnthod.Location = new System.Drawing.Point(6, 140);
            this.cbbox_paymentMrnthod.Name = "cbbox_paymentMrnthod";
            this.cbbox_paymentMrnthod.Size = new System.Drawing.Size(319, 20);
            this.cbbox_paymentMrnthod.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "payment_menhod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "amount";
            // 
            // txbox_acountStoreValue
            // 
            this.txbox_acountStoreValue.Location = new System.Drawing.Point(6, 91);
            this.txbox_acountStoreValue.Name = "txbox_acountStoreValue";
            this.txbox_acountStoreValue.Size = new System.Drawing.Size(319, 22);
            this.txbox_acountStoreValue.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "hostCard_id";
            // 
            // txbox_mainCardId
            // 
            this.txbox_mainCardId.Location = new System.Drawing.Point(6, 42);
            this.txbox_mainCardId.Name = "txbox_mainCardId";
            this.txbox_mainCardId.Size = new System.Drawing.Size(319, 22);
            this.txbox_mainCardId.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_transfer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbox_Amount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbox_subCardId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbox_hostCardId);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "transfer";
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(250, 388);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_transfer.TabIndex = 6;
            this.btn_transfer.Text = "transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "amount";
            // 
            // txbox_Amount
            // 
            this.txbox_Amount.Location = new System.Drawing.Point(6, 140);
            this.txbox_Amount.Name = "txbox_Amount";
            this.txbox_Amount.Size = new System.Drawing.Size(319, 22);
            this.txbox_Amount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "subCard_id";
            // 
            // txbox_subCardId
            // 
            this.txbox_subCardId.Location = new System.Drawing.Point(6, 91);
            this.txbox_subCardId.Name = "txbox_subCardId";
            this.txbox_subCardId.Size = new System.Drawing.Size(319, 22);
            this.txbox_subCardId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "hostCard_id";
            // 
            // txbox_hostCardId
            // 
            this.txbox_hostCardId.Location = new System.Drawing.Point(6, 42);
            this.txbox_hostCardId.Name = "txbox_hostCardId";
            this.txbox_hostCardId.Size = new System.Drawing.Size(319, 22);
            this.txbox_hostCardId.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "store";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardBalance)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_cardBalance;
        private System.Windows.Forms.Label bel1;
        private System.Windows.Forms.Button btn_showAllCard;
        private System.Windows.Forms.Button btn_searchCard;
        private System.Windows.Forms.TextBox txbox_cardId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbox_hostCardId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbox_Amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbox_subCardId;
        private System.Windows.Forms.ComboBox cbbox_paymentMrnthod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbox_acountStoreValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbox_mainCardId;
        private System.Windows.Forms.Button button1;
    }
}