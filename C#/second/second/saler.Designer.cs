
namespace second
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_cardTypeButCard = new System.Windows.Forms.DataGridView();
            this.btn_buycard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_accountBuyCard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cardIdRefundCard = new System.Windows.Forms.TextBox();
            this.btn_refundCard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cardFixCard = new System.Windows.Forms.TextBox();
            this.btn_searchCard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_userIdFixCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cardTypeIdFixCard = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_balanceFixCard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_stateFixCard = new System.Windows.Forms.TextBox();
            this.btn_applyFixCard = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardTypeButCard)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_accountBuyCard);
            this.tabPage1.Controls.Add(this.btn_buycard);
            this.tabPage1.Controls.Add(this.dgv_cardTypeButCard);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "buy card";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_refundCard);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_cardIdRefundCard);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "refund card";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_applyFixCard);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tb_stateFixCard);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tb_balanceFixCard);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tb_cardTypeIdFixCard);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tb_userIdFixCard);
            this.tabPage3.Controls.Add(this.btn_searchCard);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tb_cardFixCard);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "fix card";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_cardTypeButCard
            // 
            this.dgv_cardTypeButCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cardTypeButCard.Location = new System.Drawing.Point(6, 6);
            this.dgv_cardTypeButCard.Name = "dgv_cardTypeButCard";
            this.dgv_cardTypeButCard.RowTemplate.Height = 31;
            this.dgv_cardTypeButCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cardTypeButCard.Size = new System.Drawing.Size(396, 513);
            this.dgv_cardTypeButCard.TabIndex = 0;
            // 
            // btn_buycard
            // 
            this.btn_buycard.Location = new System.Drawing.Point(740, 451);
            this.btn_buycard.Name = "btn_buycard";
            this.btn_buycard.Size = new System.Drawing.Size(131, 68);
            this.btn_buycard.TabIndex = 1;
            this.btn_buycard.Text = "buy card";
            this.btn_buycard.UseVisualStyleBackColor = true;
            this.btn_buycard.Click += new System.EventHandler(this.btn_buycard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "account";
            // 
            // tb_accountBuyCard
            // 
            this.tb_accountBuyCard.Location = new System.Drawing.Point(408, 27);
            this.tb_accountBuyCard.Name = "tb_accountBuyCard";
            this.tb_accountBuyCard.Size = new System.Drawing.Size(201, 29);
            this.tb_accountBuyCard.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "card id";
            // 
            // tb_cardIdRefundCard
            // 
            this.tb_cardIdRefundCard.Location = new System.Drawing.Point(6, 24);
            this.tb_cardIdRefundCard.Name = "tb_cardIdRefundCard";
            this.tb_cardIdRefundCard.Size = new System.Drawing.Size(201, 29);
            this.tb_cardIdRefundCard.TabIndex = 8;
            // 
            // btn_refundCard
            // 
            this.btn_refundCard.Location = new System.Drawing.Point(740, 451);
            this.btn_refundCard.Name = "btn_refundCard";
            this.btn_refundCard.Size = new System.Drawing.Size(131, 68);
            this.btn_refundCard.TabIndex = 10;
            this.btn_refundCard.Text = "refund";
            this.btn_refundCard.UseVisualStyleBackColor = true;
            this.btn_refundCard.Click += new System.EventHandler(this.btn_refundCard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "card id";
            // 
            // tb_cardFixCard
            // 
            this.tb_cardFixCard.Location = new System.Drawing.Point(6, 24);
            this.tb_cardFixCard.Name = "tb_cardFixCard";
            this.tb_cardFixCard.Size = new System.Drawing.Size(201, 29);
            this.tb_cardFixCard.TabIndex = 10;
            // 
            // btn_searchCard
            // 
            this.btn_searchCard.Location = new System.Drawing.Point(9, 60);
            this.btn_searchCard.Name = "btn_searchCard";
            this.btn_searchCard.Size = new System.Drawing.Size(115, 23);
            this.btn_searchCard.TabIndex = 12;
            this.btn_searchCard.Text = "search Card";
            this.btn_searchCard.UseVisualStyleBackColor = true;
            this.btn_searchCard.Click += new System.EventHandler(this.btn_searchCard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "user_id";
            // 
            // tb_userIdFixCard
            // 
            this.tb_userIdFixCard.Location = new System.Drawing.Point(6, 107);
            this.tb_userIdFixCard.Name = "tb_userIdFixCard";
            this.tb_userIdFixCard.Size = new System.Drawing.Size(201, 29);
            this.tb_userIdFixCard.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "card type id";
            // 
            // tb_cardTypeIdFixCard
            // 
            this.tb_cardTypeIdFixCard.Location = new System.Drawing.Point(6, 160);
            this.tb_cardTypeIdFixCard.Name = "tb_cardTypeIdFixCard";
            this.tb_cardTypeIdFixCard.Size = new System.Drawing.Size(201, 29);
            this.tb_cardTypeIdFixCard.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "balance";
            // 
            // tb_balanceFixCard
            // 
            this.tb_balanceFixCard.Location = new System.Drawing.Point(6, 213);
            this.tb_balanceFixCard.Name = "tb_balanceFixCard";
            this.tb_balanceFixCard.Size = new System.Drawing.Size(201, 29);
            this.tb_balanceFixCard.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "state";
            // 
            // tb_stateFixCard
            // 
            this.tb_stateFixCard.Location = new System.Drawing.Point(6, 266);
            this.tb_stateFixCard.Name = "tb_stateFixCard";
            this.tb_stateFixCard.Size = new System.Drawing.Size(201, 29);
            this.tb_stateFixCard.TabIndex = 19;
            // 
            // btn_applyFixCard
            // 
            this.btn_applyFixCard.Location = new System.Drawing.Point(9, 301);
            this.btn_applyFixCard.Name = "btn_applyFixCard";
            this.btn_applyFixCard.Size = new System.Drawing.Size(115, 49);
            this.btn_applyFixCard.TabIndex = 21;
            this.btn_applyFixCard.Text = "apply";
            this.btn_applyFixCard.UseVisualStyleBackColor = true;
            this.btn_applyFixCard.Click += new System.EventHandler(this.btn_applyFixCard_Click);
            // 
            // saler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "saler";
            this.Text = "saler";
            this.Load += new System.EventHandler(this.saler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardTypeButCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_cardTypeButCard;
        private System.Windows.Forms.Button btn_buycard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_accountBuyCard;
        private System.Windows.Forms.Button btn_refundCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cardIdRefundCard;
        private System.Windows.Forms.Button btn_applyFixCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_stateFixCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_balanceFixCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cardTypeIdFixCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_userIdFixCard;
        private System.Windows.Forms.Button btn_searchCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cardFixCard;
    }
}