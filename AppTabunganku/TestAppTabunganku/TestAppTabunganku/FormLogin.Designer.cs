namespace TestAppTabunganku
{
    partial class FormLogin
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
            this.TextEmail = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TextLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.NotHaveAccount = new System.Windows.Forms.Label();
            this.linkSignup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TextEmail
            // 
            this.TextEmail.AutoSize = true;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextEmail.Location = new System.Drawing.Point(125, 105);
            this.TextEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(51, 20);
            this.TextEmail.TabIndex = 0;
            this.TextEmail.Text = "Email";
            this.TextEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextPassword.Location = new System.Drawing.Point(89, 150);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(83, 20);
            this.TextPassword.TabIndex = 1;
            this.TextPassword.Text = "Password";
            this.TextPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLogin.Location = new System.Drawing.Point(204, 37);
            this.TextLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(186, 58);
            this.TextLogin.TabIndex = 4;
            this.TextLogin.Text = "LOGIN";
            this.TextLogin.Click += new System.EventHandler(this.TextLogin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLogin.Location = new System.Drawing.Point(248, 190);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 37);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotHaveAccount
            // 
            this.NotHaveAccount.AutoSize = true;
            this.NotHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotHaveAccount.Location = new System.Drawing.Point(177, 240);
            this.NotHaveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotHaveAccount.Name = "NotHaveAccount";
            this.NotHaveAccount.Size = new System.Drawing.Size(162, 20);
            this.NotHaveAccount.TabIndex = 6;
            this.NotHaveAccount.Text = "Don\'t have account?";
            this.NotHaveAccount.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkSignup
            // 
            this.linkSignup.AutoSize = true;
            this.linkSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignup.Location = new System.Drawing.Point(343, 240);
            this.linkSignup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkSignup.Name = "linkSignup";
            this.linkSignup.Size = new System.Drawing.Size(60, 20);
            this.linkSignup.TabIndex = 7;
            this.linkSignup.TabStop = true;
            this.linkSignup.Text = "Signup";
            this.linkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 297);
            this.Controls.Add(this.linkSignup);
            this.Controls.Add(this.NotHaveAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Aplikasi Tabunganku";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextEmail;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label NotHaveAccount;
        private System.Windows.Forms.LinkLabel linkSignup;
    }
}

