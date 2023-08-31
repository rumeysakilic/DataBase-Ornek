namespace SınavNotuHesaplaa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            bgtnHesapla = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 42);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // bgtnHesapla
            // 
            bgtnHesapla.BackColor = Color.FromArgb(255, 128, 128);
            bgtnHesapla.Location = new Point(429, 172);
            bgtnHesapla.Name = "bgtnHesapla";
            bgtnHesapla.Size = new Size(94, 29);
            bgtnHesapla.TabIndex = 2;
            bgtnHesapla.Text = "Hesapla";
            bgtnHesapla.UseVisualStyleBackColor = false;
            bgtnHesapla.Click += bgtnHesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 45);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 114);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Vize Notu:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(398, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 120);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Final Notu:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(398, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(203, 229);
            label5.Name = "label5";
            label5.Size = new Size(191, 40);
            label5.TabIndex = 9;
            label5.Text = "Sonuç Notu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 309);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(629, 391);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bgtnHesapla);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sınav Notu Hesaplama Ekranı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button bgtnHesapla;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
    }
}