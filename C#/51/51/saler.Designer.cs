﻿
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
            this.txbox_cardTypeIdBuy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.con_saler = new System.Windows.Forms.TabControl();
            this.tp_buyCard = new System.Windows.Forms.TabPage();
            this.dgv_cardId = new System.Windows.Forms.DataGridView();
            this.tp_refundCard = new System.Windows.Forms.TabPage();
            this.tp_fixCard = new System.Windows.Forms.TabPage();
            this.txbox_cardIdRefund = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.con_saler.SuspendLayout();
            this.tp_buyCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardId)).BeginInit();
            this.tp_refundCard.SuspendLayout();
            this.tp_fixCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1070, 18);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(112, 34);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_buyCard
            // 
            this.btn_buyCard.Location = new System.Drawing.Point(752, 548);
            this.btn_buyCard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buyCard.Name = "btn_buyCard";
            this.btn_buyCard.Size = new System.Drawing.Size(250, 51);
            this.btn_buyCard.TabIndex = 1;
            this.btn_buyCard.Text = "buy card";
            this.btn_buyCard.UseVisualStyleBackColor = true;
            this.btn_buyCard.Click += new System.EventHandler(this.btn_buyCard_Click);
            // 
            // btn_refundCard
            // 
            this.btn_refundCard.Location = new System.Drawing.Point(774, 548);
            this.btn_refundCard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refundCard.Name = "btn_refundCard";
            this.btn_refundCard.Size = new System.Drawing.Size(250, 51);
            this.btn_refundCard.TabIndex = 2;
            this.btn_refundCard.Text = "refund card";
            this.btn_refundCard.UseVisualStyleBackColor = true;
            this.btn_refundCard.Click += new System.EventHandler(this.btn_refundCard_Click);
            // 
            // btn_cardFixing
            // 
            this.btn_cardFixing.Location = new System.Drawing.Point(774, 548);
            this.btn_cardFixing.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cardFixing.Name = "btn_cardFixing";
            this.btn_cardFixing.Size = new System.Drawing.Size(250, 51);
            this.btn_cardFixing.TabIndex = 3;
            this.btn_cardFixing.Text = "card fixing";
            this.btn_cardFixing.UseVisualStyleBackColor = true;
            // 
            // txbox_userAccountBuy
            // 
            this.txbox_userAccountBuy.Location = new System.Drawing.Point(755, 353);
            this.txbox_userAccountBuy.Margin = new System.Windows.Forms.Padding(4);
            this.txbox_userAccountBuy.Name = "txbox_userAccountBuy";
            this.txbox_userAccountBuy.Size = new System.Drawing.Size(148, 29);
            this.txbox_userAccountBuy.TabIndex = 4;
            // 
            // txbox_cardTypeIdBuy
            // 
            this.txbox_cardTypeIdBuy.Location = new System.Drawing.Point(755, 487);
            this.txbox_cardTypeIdBuy.Margin = new System.Windows.Forms.Padding(4);
            this.txbox_cardTypeIdBuy.Name = "txbox_cardTypeIdBuy";
            this.txbox_cardTypeIdBuy.Size = new System.Drawing.Size(148, 29);
            this.txbox_cardTypeIdBuy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(746, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "user account";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(746, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "card type id";
            // 
            // con_saler
            // 
            this.con_saler.Controls.Add(this.tp_buyCard);
            this.con_saler.Controls.Add(this.tp_refundCard);
            this.con_saler.Controls.Add(this.tp_fixCard);
            this.con_saler.Location = new System.Drawing.Point(12, 18);
            this.con_saler.Name = "con_saler";
            this.con_saler.SelectedIndex = 0;
            this.con_saler.Size = new System.Drawing.Size(1039, 638);
            this.con_saler.TabIndex = 8;
            // 
            // tp_buyCard
            // 
            this.tp_buyCard.Controls.Add(this.dgv_cardId);
            this.tp_buyCard.Controls.Add(this.txbox_cardTypeIdBuy);
            this.tp_buyCard.Controls.Add(this.btn_buyCard);
            this.tp_buyCard.Controls.Add(this.txbox_userAccountBuy);
            this.tp_buyCard.Controls.Add(this.label2);
            this.tp_buyCard.Controls.Add(this.label1);
            this.tp_buyCard.Location = new System.Drawing.Point(4, 28);
            this.tp_buyCard.Name = "tp_buyCard";
            this.tp_buyCard.Padding = new System.Windows.Forms.Padding(3);
            this.tp_buyCard.Size = new System.Drawing.Size(1031, 606);
            this.tp_buyCard.TabIndex = 0;
            this.tp_buyCard.Text = "buy card";
            this.tp_buyCard.UseVisualStyleBackColor = true;
            // 
            // dgv_cardId
            // 
            this.dgv_cardId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cardId.Location = new System.Drawing.Point(6, 6);
            this.dgv_cardId.Name = "dgv_cardId";
            this.dgv_cardId.RowHeadersWidth = 62;
            this.dgv_cardId.RowTemplate.Height = 31;
            this.dgv_cardId.Size = new System.Drawing.Size(718, 593);
            this.dgv_cardId.TabIndex = 8;
            // 
            // tp_refundCard
            // 
            this.tp_refundCard.Controls.Add(this.txbox_cardIdRefund);
            this.tp_refundCard.Controls.Add(this.label3);
            this.tp_refundCard.Controls.Add(this.btn_refundCard);
            this.tp_refundCard.Location = new System.Drawing.Point(4, 28);
            this.tp_refundCard.Name = "tp_refundCard";
            this.tp_refundCard.Padding = new System.Windows.Forms.Padding(3);
            this.tp_refundCard.Size = new System.Drawing.Size(1031, 606);
            this.tp_refundCard.TabIndex = 1;
            this.tp_refundCard.Text = "refund card";
            this.tp_refundCard.UseVisualStyleBackColor = true;
            // 
            // tp_fixCard
            // 
            this.tp_fixCard.Controls.Add(this.btn_cardFixing);
            this.tp_fixCard.Location = new System.Drawing.Point(4, 28);
            this.tp_fixCard.Name = "tp_fixCard";
            this.tp_fixCard.Padding = new System.Windows.Forms.Padding(3);
            this.tp_fixCard.Size = new System.Drawing.Size(1031, 606);
            this.tp_fixCard.TabIndex = 2;
            this.tp_fixCard.Text = "fix card";
            this.tp_fixCard.UseVisualStyleBackColor = true;
            // 
            // txbox_cardIdRefund
            // 
            this.txbox_cardIdRefund.Location = new System.Drawing.Point(811, 482);
            this.txbox_cardIdRefund.Margin = new System.Windows.Forms.Padding(4);
            this.txbox_cardIdRefund.Name = "txbox_cardIdRefund";
            this.txbox_cardIdRefund.Size = new System.Drawing.Size(148, 29);
            this.txbox_cardIdRefund.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(802, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "card id";
            // 
            // saler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 668);
            this.Controls.Add(this.con_saler);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "saler";
            this.Text = "saler";
            this.Load += new System.EventHandler(this.saler_Load);
            this.con_saler.ResumeLayout(false);
            this.tp_buyCard.ResumeLayout(false);
            this.tp_buyCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardId)).EndInit();
            this.tp_refundCard.ResumeLayout(false);
            this.tp_refundCard.PerformLayout();
            this.tp_fixCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_buyCard;
        private System.Windows.Forms.Button btn_refundCard;
        private System.Windows.Forms.Button btn_cardFixing;
        private System.Windows.Forms.TextBox txbox_userAccountBuy;
        private System.Windows.Forms.TextBox txbox_cardTypeIdBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl con_saler;
        private System.Windows.Forms.TabPage tp_buyCard;
        private System.Windows.Forms.TabPage tp_refundCard;
        private System.Windows.Forms.TabPage tp_fixCard;
        private System.Windows.Forms.DataGridView dgv_cardId;
        private System.Windows.Forms.TextBox txbox_cardIdRefund;
        private System.Windows.Forms.Label label3;
    }
}