namespace HACETTEPEORTOPEDİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn1Giris = new Button();
            textBox2sifre = new TextBox();
            textBox1kullaniciadi = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn1Giris
            // 
            btn1Giris.BackColor = SystemColors.ActiveCaption;
            btn1Giris.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn1Giris.Location = new Point(304, 274);
            btn1Giris.Name = "btn1Giris";
            btn1Giris.Size = new Size(132, 33);
            btn1Giris.TabIndex = 2;
            btn1Giris.Text = "GİRİŞ YAP";
            btn1Giris.UseVisualStyleBackColor = false;
            btn1Giris.Click += btn1Giris_Click;
            // 
            // textBox2sifre
            // 
            textBox2sifre.Location = new Point(218, 241);
            textBox2sifre.Name = "textBox2sifre";
            textBox2sifre.PlaceholderText = "----------";
            textBox2sifre.Size = new Size(218, 27);
            textBox2sifre.TabIndex = 1;
            textBox2sifre.UseSystemPasswordChar = true;
            // 
            // textBox1kullaniciadi
            // 
            textBox1kullaniciadi.Location = new Point(218, 208);
            textBox1kullaniciadi.Name = "textBox1kullaniciadi";
            textBox1kullaniciadi.PlaceholderText = "----------";
            textBox1kullaniciadi.Size = new Size(218, 27);
            textBox1kullaniciadi.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 147);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(21, 45);
            label3.Name = "label3";
            label3.Size = new Size(528, 46);
            label3.TabIndex = 0;
            label3.Text = "HACETTEPE ORTOPEDİ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 38);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 211);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 248);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn1Giris);
            Controls.Add(textBox2sifre);
            Controls.Add(textBox1kullaniciadi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "KULLANICI GİRİŞ";
      
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn1Giris;
        private TextBox textBox2sifre;
        private TextBox textBox1kullaniciadi;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
