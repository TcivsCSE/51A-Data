
namespace _51
{
    partial class login
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txbox_account = new System.Windows.Forms.TextBox();
            this.txbox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.label_account_warning = new System.Windows.Forms.Label();
            this.label_password_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbox_account
            // 
            this.txbox_account.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbox_account.Location = new System.Drawing.Point(37, 109);
            this.txbox_account.Name = "txbox_account";
            this.txbox_account.Size = new System.Drawing.Size(357, 65);
            this.txbox_account.TabIndex = 0;
            // 
            // txbox_password
            // 
            this.txbox_password.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txbox_password.Location = new System.Drawing.Point(37, 222);
            this.txbox_password.Name = "txbox_password";
            this.txbox_password.Size = new System.Drawing.Size(357, 65);
            this.txbox_password.TabIndex = 1;
            this.txbox_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(178, 335);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(159, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "login";
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Location = new System.Drawing.Point(178, 377);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(75, 23);
            this.btn_sign_up.TabIndex = 4;
            this.btn_sign_up.Text = "sign up";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            // 
            // label_account_warning
            // 
            this.label_account_warning.AutoSize = true;
            this.label_account_warning.ForeColor = System.Drawing.Color.Red;
            this.label_account_warning.Location = new System.Drawing.Point(215, 191);
            this.label_account_warning.Name = "label_account_warning";
            this.label_account_warning.Size = new System.Drawing.Size(0, 12);
            this.label_account_warning.TabIndex = 5;
            // 
            // label_password_warning
            // 
            this.label_password_warning.AutoSize = true;
            this.label_password_warning.ForeColor = System.Drawing.Color.Red;
            this.label_password_warning.Location = new System.Drawing.Point(215, 304);
            this.label_password_warning.Name = "label_password_warning";
            this.label_password_warning.Size = new System.Drawing.Size(0, 12);
            this.label_password_warning.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 437);
            this.Controls.Add(this.label_password_warning);
            this.Controls.Add(this.label_account_warning);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txbox_password);
            this.Controls.Add(this.txbox_account);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbox_account;
        private System.Windows.Forms.TextBox txbox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Label label_account_warning;
        private System.Windows.Forms.Label label_password_warning;
    }
}

