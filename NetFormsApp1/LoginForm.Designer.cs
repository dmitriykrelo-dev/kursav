namespace NetFormsApp1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером форм Windows

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(118, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 22);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Вход в систему";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(43, 63);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(42, 16);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(130, 60);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 23);
            this.txtLogin.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(81, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 220);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}