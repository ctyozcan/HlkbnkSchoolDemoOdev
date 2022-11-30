namespace SchoolDemo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEgitmenAta = new System.Windows.Forms.Button();
            this.comboBoxEgitmenBransi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEgitmenSoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEgitmenAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSinifOlustur = new System.Windows.Forms.Button();
            this.comboBoxSube = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSinifNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listViewSiniflar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listBoxOgrenciler = new System.Windows.Forms.ListBox();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.textBoxOgrenciAdresi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1607, 1150);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEgitmenAta);
            this.groupBox2.Controls.Add(this.comboBoxEgitmenBransi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxEgitmenSoyadi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxEgitmenAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(40, 833);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(450, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Eğitmeni Ata";
            // 
            // buttonEgitmenAta
            // 
            this.buttonEgitmenAta.Location = new System.Drawing.Point(251, 220);
            this.buttonEgitmenAta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEgitmenAta.Name = "buttonEgitmenAta";
            this.buttonEgitmenAta.Size = new System.Drawing.Size(190, 38);
            this.buttonEgitmenAta.TabIndex = 7;
            this.buttonEgitmenAta.Text = "Sınıf Eğitmeni Ata";
            this.buttonEgitmenAta.UseVisualStyleBackColor = true;
            this.buttonEgitmenAta.Click += new System.EventHandler(this.buttonEgitmenAta_Click);
            // 
            // comboBoxEgitmenBransi
            // 
            this.comboBoxEgitmenBransi.FormattingEnabled = true;
            this.comboBoxEgitmenBransi.Location = new System.Drawing.Point(106, 143);
            this.comboBoxEgitmenBransi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxEgitmenBransi.Name = "comboBoxEgitmenBransi";
            this.comboBoxEgitmenBransi.Size = new System.Drawing.Size(171, 33);
            this.comboBoxEgitmenBransi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Branş";
            // 
            // textBoxEgitmenSoyadi
            // 
            this.textBoxEgitmenSoyadi.Location = new System.Drawing.Point(106, 95);
            this.textBoxEgitmenSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEgitmenSoyadi.Name = "textBoxEgitmenSoyadi";
            this.textBoxEgitmenSoyadi.Size = new System.Drawing.Size(141, 31);
            this.textBoxEgitmenSoyadi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyad";
            // 
            // textBoxEgitmenAdi
            // 
            this.textBoxEgitmenAdi.Location = new System.Drawing.Point(106, 47);
            this.textBoxEgitmenAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEgitmenAdi.Name = "textBoxEgitmenAdi";
            this.textBoxEgitmenAdi.Size = new System.Drawing.Size(141, 31);
            this.textBoxEgitmenAdi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSinifOlustur);
            this.groupBox1.Controls.Add(this.comboBoxSube);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxBolum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSinifNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(450, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf ";
            // 
            // buttonSinifOlustur
            // 
            this.buttonSinifOlustur.Location = new System.Drawing.Point(251, 258);
            this.buttonSinifOlustur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSinifOlustur.Name = "buttonSinifOlustur";
            this.buttonSinifOlustur.Size = new System.Drawing.Size(190, 38);
            this.buttonSinifOlustur.TabIndex = 6;
            this.buttonSinifOlustur.Text = "Sınıf Oluştur";
            this.buttonSinifOlustur.UseVisualStyleBackColor = true;
            this.buttonSinifOlustur.Click += new System.EventHandler(this.buttonSinifOlustur_Click);
            // 
            // comboBoxSube
            // 
            this.comboBoxSube.FormattingEnabled = true;
            this.comboBoxSube.Location = new System.Drawing.Point(104, 142);
            this.comboBoxSube.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSube.Name = "comboBoxSube";
            this.comboBoxSube.Size = new System.Drawing.Size(171, 33);
            this.comboBoxSube.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şube";
            // 
            // comboBoxBolum
            // 
            this.comboBoxBolum.FormattingEnabled = true;
            this.comboBoxBolum.Location = new System.Drawing.Point(104, 93);
            this.comboBoxBolum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxBolum.Name = "comboBoxBolum";
            this.comboBoxBolum.Size = new System.Drawing.Size(171, 33);
            this.comboBoxBolum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm";
            // 
            // textBoxSinifNo
            // 
            this.textBoxSinifNo.Location = new System.Drawing.Point(106, 42);
            this.textBoxSinifNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSinifNo.Name = "textBoxSinifNo";
            this.textBoxSinifNo.Size = new System.Drawing.Size(141, 31);
            this.textBoxSinifNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf No";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listViewSiniflar);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxOgrenciler);
            this.splitContainer2.Panel2.Controls.Add(this.buttonOgrenciEkle);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxOgrenciAdresi);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxOgrenciSoyadi);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxOgrenciAdi);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Size = new System.Drawing.Size(1066, 1150);
            this.splitContainer2.SplitterDistance = 681;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // listViewSiniflar
            // 
            this.listViewSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewSiniflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSiniflar.GridLines = true;
            this.listViewSiniflar.Location = new System.Drawing.Point(0, 0);
            this.listViewSiniflar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewSiniflar.Name = "listViewSiniflar";
            this.listViewSiniflar.Size = new System.Drawing.Size(1062, 677);
            this.listViewSiniflar.TabIndex = 0;
            this.listViewSiniflar.UseCompatibleStateImageBehavior = false;
            this.listViewSiniflar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sınıf Adı";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Sayısı";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sınıf Eğitmeni";
            this.columnHeader3.Width = 200;
            // 
            // listBoxOgrenciler
            // 
            this.listBoxOgrenciler.FormattingEnabled = true;
            this.listBoxOgrenciler.ItemHeight = 25;
            this.listBoxOgrenciler.Location = new System.Drawing.Point(607, 22);
            this.listBoxOgrenciler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxOgrenciler.Name = "listBoxOgrenciler";
            this.listBoxOgrenciler.Size = new System.Drawing.Size(437, 379);
            this.listBoxOgrenciler.TabIndex = 18;
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(270, 280);
            this.buttonOgrenciEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(149, 38);
            this.buttonOgrenciEkle.TabIndex = 17;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // textBoxOgrenciAdresi
            // 
            this.textBoxOgrenciAdresi.Location = new System.Drawing.Point(196, 200);
            this.textBoxOgrenciAdresi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOgrenciAdresi.Name = "textBoxOgrenciAdresi";
            this.textBoxOgrenciAdresi.Size = new System.Drawing.Size(221, 31);
            this.textBoxOgrenciAdresi.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Adres";
            // 
            // textBoxOgrenciSoyadi
            // 
            this.textBoxOgrenciSoyadi.Location = new System.Drawing.Point(196, 143);
            this.textBoxOgrenciSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOgrenciSoyadi.Name = "textBoxOgrenciSoyadi";
            this.textBoxOgrenciSoyadi.Size = new System.Drawing.Size(221, 31);
            this.textBoxOgrenciSoyadi.TabIndex = 14;
            // 
            // textBoxOgrenciAdi
            // 
            this.textBoxOgrenciAdi.Location = new System.Drawing.Point(196, 95);
            this.textBoxOgrenciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOgrenciAdi.Name = "textBoxOgrenciAdi";
            this.textBoxOgrenciAdi.Size = new System.Drawing.Size(221, 31);
            this.textBoxOgrenciAdi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1150);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Button buttonEgitmenAta;
        private ComboBox comboBoxEgitmenBransi;
        private Label label6;
        private TextBox textBoxEgitmenSoyadi;
        private Label label5;
        private TextBox textBoxEgitmenAdi;
        private Label label4;
        private GroupBox groupBox1;
        private Button buttonSinifOlustur;
        private ComboBox comboBoxSube;
        private Label label3;
        private ComboBox comboBoxBolum;
        private Label label2;
        private TextBox textBoxSinifNo;
        private Label label1;
        private SplitContainer splitContainer2;
        private ListView listViewSiniflar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListBox listBoxOgrenciler;
        private Button buttonOgrenciEkle;
        private TextBox textBoxOgrenciAdresi;
        private Label label9;
        private TextBox textBoxOgrenciSoyadi;
        private TextBox textBoxOgrenciAdi;
        private Label label7;
        private Label label8;
    }
}