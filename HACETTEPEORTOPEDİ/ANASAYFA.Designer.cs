namespace HACETTEPEORTOPEDİ
{
    partial class ANASAYFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANASAYFA));
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnyenihastaekle = new Button();
            dataGridView1 = new DataGridView();
            btnTumu = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(6, 125);
            button1.Name = "button1";
            button1.Size = new Size(291, 38);
            button1.TabIndex = 1;
            button1.Text = "AYRINTILI BİLGİ GETİR";
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 169);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(33, 34);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "TC KİMLİK";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 27);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(52, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "SOYAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(79, 66);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 3;
            label1.Text = "AD";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 3;
            // 
            // btnyenihastaekle
            // 
            btnyenihastaekle.BackColor = SystemColors.ActiveCaption;
            btnyenihastaekle.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnyenihastaekle.Location = new Point(651, 12);
            btnyenihastaekle.Name = "btnyenihastaekle";
            btnyenihastaekle.Size = new Size(137, 54);
            btnyenihastaekle.TabIndex = 6;
            btnyenihastaekle.Text = "YENİ HASTA EKLE";
            btnyenihastaekle.UseVisualStyleBackColor = false;
            btnyenihastaekle.Click += btnyenihastaekle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 251);
            dataGridView1.TabIndex = 7;
          
            // 
            // btnTumu
            // 
            btnTumu.BackColor = SystemColors.ActiveCaption;
            btnTumu.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumu.Location = new Point(651, 127);
            btnTumu.Name = "btnTumu";
            btnTumu.Size = new Size(137, 54);
            btnTumu.TabIndex = 8;
            btnTumu.Text = "TÜMÜNÜ GETİR";
            btnTumu.UseVisualStyleBackColor = false;
            btnTumu.Click += btnTumu_Click;
            // 
            // ANASAYFA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTumu);
            Controls.Add(dataGridView1);
            Controls.Add(btnyenihastaekle);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ANASAYFA";
            Text = "ANASAYFA";
            Load += ANASAYFA_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnyenihastaekle;
        private DataGridView dataGridView1;
  
        private Label label3;
        private TextBox textBox3;
        private Button btnTumu;
    }
}