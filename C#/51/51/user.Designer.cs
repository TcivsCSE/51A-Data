
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardBalance)).BeginInit();
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
    }
}