namespace TestAppTabunganku
{
    partial class FormTarget
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
            this.button500 = new System.Windows.Forms.Button();
            this.button1JT = new System.Windows.Forms.Button();
            this.button2JT = new System.Windows.Forms.Button();
            this.button3JT = new System.Windows.Forms.Button();
            this.button5JT = new System.Windows.Forms.Button();
            this.button10JT = new System.Windows.Forms.Button();
            this.labelTabungan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button500
            // 
            this.button500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button500.Location = new System.Drawing.Point(101, 108);
            this.button500.Margin = new System.Windows.Forms.Padding(4);
            this.button500.Name = "button500";
            this.button500.Size = new System.Drawing.Size(135, 45);
            this.button500.TabIndex = 0;
            this.button500.Text = "Rp. 500.000";
            this.button500.UseVisualStyleBackColor = true;
            this.button500.Click += new System.EventHandler(this.button500_Click);
            // 
            // button1JT
            // 
            this.button1JT.Location = new System.Drawing.Point(265, 108);
            this.button1JT.Margin = new System.Windows.Forms.Padding(4);
            this.button1JT.Name = "button1JT";
            this.button1JT.Size = new System.Drawing.Size(135, 45);
            this.button1JT.TabIndex = 1;
            this.button1JT.Text = "Rp. 1.000.000";
            this.button1JT.UseVisualStyleBackColor = true;
            // 
            // button2JT
            // 
            this.button2JT.Location = new System.Drawing.Point(428, 108);
            this.button2JT.Name = "button2JT";
            this.button2JT.Size = new System.Drawing.Size(135, 45);
            this.button2JT.TabIndex = 2;
            this.button2JT.Text = "Rp. 2.000.000";
            this.button2JT.UseVisualStyleBackColor = true;
            // 
            // button3JT
            // 
            this.button3JT.Location = new System.Drawing.Point(101, 174);
            this.button3JT.Name = "button3JT";
            this.button3JT.Size = new System.Drawing.Size(135, 45);
            this.button3JT.TabIndex = 3;
            this.button3JT.Text = "Rp. 3.000.000";
            this.button3JT.UseVisualStyleBackColor = true;
            // 
            // button5JT
            // 
            this.button5JT.Location = new System.Drawing.Point(265, 174);
            this.button5JT.Name = "button5JT";
            this.button5JT.Size = new System.Drawing.Size(135, 45);
            this.button5JT.TabIndex = 4;
            this.button5JT.Text = "Rp. 5.000.000";
            this.button5JT.UseVisualStyleBackColor = true;
            // 
            // button10JT
            // 
            this.button10JT.Location = new System.Drawing.Point(428, 174);
            this.button10JT.Name = "button10JT";
            this.button10JT.Size = new System.Drawing.Size(135, 45);
            this.button10JT.TabIndex = 5;
            this.button10JT.Text = "Rp. 10.000.000";
            this.button10JT.UseVisualStyleBackColor = true;
            // 
            // labelTabungan
            // 
            this.labelTabungan.AutoSize = true;
            this.labelTabungan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabungan.Location = new System.Drawing.Point(74, 47);
            this.labelTabungan.Name = "labelTabungan";
            this.labelTabungan.Size = new System.Drawing.Size(533, 58);
            this.labelTabungan.TabIndex = 6;
            this.labelTabungan.Text = "TARGET TABUNGAN";
            this.labelTabungan.Click += new System.EventHandler(this.labelTabungan_Click);
            // 
            // FormTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 299);
            this.Controls.Add(this.labelTabungan);
            this.Controls.Add(this.button10JT);
            this.Controls.Add(this.button5JT);
            this.Controls.Add(this.button3JT);
            this.Controls.Add(this.button2JT);
            this.Controls.Add(this.button1JT);
            this.Controls.Add(this.button500);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTarget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Target Tabunganku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button500;
        private System.Windows.Forms.Button button1JT;
        private System.Windows.Forms.Button button2JT;
        private System.Windows.Forms.Button button3JT;
        private System.Windows.Forms.Button button5JT;
        private System.Windows.Forms.Button button10JT;
        private System.Windows.Forms.Label labelTabungan;
    }
}