
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.labelCaptchaText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelUsername.Location = new System.Drawing.Point(322, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(65, 25);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(322, 85);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 25);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxUsername.Location = new System.Drawing.Point(285, 49);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(166, 32);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Введите логин";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.Location = new System.Drawing.Point(285, 125);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(166, 32);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "Введите пароль";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.M_height;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.Location = new System.Drawing.Point(315, 355);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 49);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelCaptcha.Location = new System.Drawing.Point(310, 182);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(82, 25);
            this.labelCaptcha.TabIndex = 5;
            this.labelCaptcha.Text = "Каптча";
            // 
            // labelCaptchaText
            // 
            this.labelCaptchaText.AutoSize = true;
            this.labelCaptchaText.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelCaptchaText.Location = new System.Drawing.Point(280, 274);
            this.labelCaptchaText.Name = "labelCaptchaText";
            this.labelCaptchaText.Size = new System.Drawing.Size(169, 25);
            this.labelCaptchaText.TabIndex = 6;
            this.labelCaptchaText.Text = "Введите CAPTCHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(463, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Неверный логин или пароль";
            this.label5.Visible = false;
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxCaptcha.Location = new System.Drawing.Point(285, 210);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(166, 32);
            this.textBoxCaptcha.TabIndex = 8;
            this.textBoxCaptcha.TextChanged += new System.EventHandler(this.textBoxCaptcha_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cinema_rex;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCaptchaText);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.Label labelCaptchaText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCaptcha;
    }
}

