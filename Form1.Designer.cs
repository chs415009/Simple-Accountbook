namespace AccountingApp
{
    partial class Form1
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
            this.TITLE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            this.TITLE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TITLE.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.TITLE.ForeColor = System.Drawing.Color.DarkGreen;
            this.TITLE.Location = new System.Drawing.Point(1, 139);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(925, 61);
            this.TITLE.TabIndex = 0;
            this.TITLE.Text = "                     歡迎來到簡易記帳";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(263, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "帳號 :";
            // 
            // textBox_account
            // 
            this.textBox_account.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_account.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox_account.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBox_account.Location = new System.Drawing.Point(353, 262);
            this.textBox_account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_account.Name = "textBox_account";
            this.textBox_account.Size = new System.Drawing.Size(295, 41);
            this.textBox_account.TabIndex = 2;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(263, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "密碼 :";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_password.Font = new System.Drawing.Font("新細明體", 14F);
            this.textBox_password.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBox_password.Location = new System.Drawing.Point(353, 335);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(295, 41);
            this.textBox_password.TabIndex = 4;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_login.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_login.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_login.Location = new System.Drawing.Point(369, 434);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(187, 43);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "登入";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TITLE);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
    }
}

