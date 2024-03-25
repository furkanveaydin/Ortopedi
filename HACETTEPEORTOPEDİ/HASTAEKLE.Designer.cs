namespace HACETTEPEORTOPEDİ
{
    partial class HASTAEKLE
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxTc = new TextBox();
            textBoxDt = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            textBoxCepT = new TextBox();
            btnHastaEkle = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 28);
            label1.TabIndex = 0;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(140, 28);
            label3.TabIndex = 2;
            label3.Text = "TC KİMLİK NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 215);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 3;
            label4.Text = "DOĞUM TARİHİ";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(6, 63);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(155, 27);
            textBoxAd.TabIndex = 4;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(6, 124);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(155, 27);
            textBoxSoyad.TabIndex = 5;
            // 
            // textBoxTc
            // 
            textBoxTc.Location = new Point(6, 185);
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(158, 27);
            textBoxTc.TabIndex = 6;
            // 
            // textBoxDt
            // 
            textBoxDt.Location = new Point(6, 246);
            textBoxDt.Name = "textBoxDt";
            textBoxDt.Size = new Size(158, 27);
            textBoxDt.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 37);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(-1, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 50);
            panel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(6, 276);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 12;
            label6.Text = "CEP TELEFONU";
            // 
            // textBoxCepT
            // 
            textBoxCepT.Location = new Point(6, 307);
            textBoxCepT.Name = "textBoxCepT";
            textBoxCepT.Size = new Size(158, 27);
            textBoxCepT.TabIndex = 13;
            // 
            // btnHastaEkle
            // 
            btnHastaEkle.BackColor = SystemColors.ActiveBorder;
            btnHastaEkle.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnHastaEkle.ForeColor = Color.Green;
            btnHastaEkle.Location = new Point(488, 61);
            btnHastaEkle.Name = "btnHastaEkle";
            btnHastaEkle.Size = new Size(100, 39);
            btnHastaEkle.TabIndex = 14;
            btnHastaEkle.Text = "EKLE";
            btnHastaEkle.UseVisualStyleBackColor = false;
            btnHastaEkle.Click += btnHastaEkle_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 192, 128);
            button2.Location = new Point(594, 61);
            button2.Name = "button2";
            button2.Size = new Size(100, 39);
            button2.TabIndex = 15;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(700, 61);
            button3.Name = "button3";
            button3.Size = new Size(100, 39);
            button3.TabIndex = 16;
            button3.Text = "SİL";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(167, 106);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(633, 295);
            dataGridView2.TabIndex = 17;
            // 
            // HASTAEKLE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 466);
            Controls.Add(dataGridView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnHastaEkle);
            Controls.Add(textBoxCepT);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxDt);
            Controls.Add(textBoxTc);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HASTAEKLE";
            Text = "HASTAEKLE";
            Load += HASTAEKLE_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private TextBox textBoxTc;
        private TextBox textBoxDt;
        private Panel panel1;
        private Panel panel2;
        private Label label6;
        private TextBox textBoxCepT;
        private Button btnHastaEkle;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView2;
    }
}