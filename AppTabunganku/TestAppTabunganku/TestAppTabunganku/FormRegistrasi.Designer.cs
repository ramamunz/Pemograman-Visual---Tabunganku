namespace TestAppTabunganku
{
    partial class FormRegistrasi
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
            this.SignUp = new System.Windows.Forms.Label();
            this.TextNama = new System.Windows.Forms.Label();
            this.TextEmail = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextConfirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.HaveAccount = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(180, 31);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(191, 46);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "SIGN UP";
            this.SignUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextNama
            // 
            this.TextNama.AutoSize = true;
            this.TextNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextNama.Location = new System.Drawing.Point(145, 88);
            this.TextNama.Name = "TextNama";
            this.TextNama.Size = new System.Drawing.Size(45, 17);
            this.TextNama.TabIndex = 1;
            this.TextNama.Text = "Nama";
            this.TextNama.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextEmail
            // 
            this.TextEmail.AutoSize = true;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextEmail.Location = new System.Drawing.Point(148, 123);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(42, 17);
            this.TextEmail.TabIndex = 2;
            this.TextEmail.Text = "Email";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextPassword.Location = new System.Drawing.Point(121, 157);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(69, 17);
            this.TextPassword.TabIndex = 3;
            this.TextPassword.Text = "Password";
            this.TextPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // TextConfirmPassword
            // 
            this.TextConfirmPassword.AutoSize = true;
            this.TextConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextConfirmPassword.Location = new System.Drawing.Point(69, 187);
            this.TextConfirmPassword.Name = "TextConfirmPassword";
            this.TextConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.TextConfirmPassword.TabIndex = 4;
            this.TextConfirmPassword.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(196, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSignUp.Location = new System.Drawing.Point(234, 220);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 30);
            this.buttonSignUp.TabIndex = 9;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // HaveAccount
            // 
            this.HaveAccount.AutoSize = true;
            this.HaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.HaveAccount.Location = new System.Drawing.Point(159, 258);
            this.HaveAccount.Name = "HaveAccount";
            this.HaveAccount.Size = new System.Drawing.Size(173, 17);
            this.HaveAccount.TabIndex = 10;
            this.HaveAccount.Text = "Already have an account?";
            this.HaveAccount.Click += new System.EventHandler(this.HaveAccount_Click);
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkSignUp.Location = new System.Drawing.Point(327, 257);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(43, 17);
            this.linkSignUp.TabIndex = 11;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Login";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.HaveAccount);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextConfirmPassword);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextNama);
            this.Controls.Add(this.SignUp);
            this.Name = "FormRegistrasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrasi Aplikasi Tabunganku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Label TextNama;
        private System.Windows.Forms.Label TextEmail;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.Label TextConfirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label HaveAccount;
        private System.Windows.Forms.LinkLabel linkSignUp;
    }
}