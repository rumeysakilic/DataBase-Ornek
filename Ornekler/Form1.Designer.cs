namespace Ornekler
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
            dateTimePicker1 = new DateTimePicker();
            btnHavaDurumuGoster = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            btnGoster = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(11, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnHavaDurumuGoster
            // 
            btnHavaDurumuGoster.Location = new Point(255, 23);
            btnHavaDurumuGoster.Name = "btnHavaDurumuGoster";
            btnHavaDurumuGoster.Size = new Size(235, 29);
            btnHavaDurumuGoster.TabIndex = 1;
            btnHavaDurumuGoster.Text = "Hava Durumu Bilgisi Göster";
            btnHavaDurumuGoster.UseVisualStyleBackColor = true;
            btnHavaDurumuGoster.Click += btnHavaDurumuGoster_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(11, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(478, 380);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "İL";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "DURUM";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "MAKSİMUM SICAKLIK";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 461);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 3;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(349, 505);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(140, 38);
            btnGoster.TabIndex = 4;
            btnGoster.Text = "Seçili Şehiri Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 505);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 542);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 27);
            textBox3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 464);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 7;
            label1.Text = "İL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 508);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 8;
            label2.Text = "DURUM:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 549);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 9;
            label3.Text = "MAKSİMUM SICAKLIK:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 581);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnGoster);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnHavaDurumuGoster);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hava Durumu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnHavaDurumuGoster;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox textBox1;
        private Button btnGoster;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}