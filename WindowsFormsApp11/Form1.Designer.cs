namespace WindowsFormsApp11
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtÜcret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmnAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnÜcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnİndirimliÜcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnYasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnHastaEkle = new System.Windows.Forms.Button();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(88, 12);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // txtÜcret
            // 
            this.txtÜcret.Location = new System.Drawing.Point(286, 54);
            this.txtÜcret.Name = "txtÜcret";
            this.txtÜcret.Size = new System.Drawing.Size(121, 20);
            this.txtÜcret.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doğum Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinsiyeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ücret";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(286, 18);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnAdi,
            this.ClmnDyili,
            this.ClmnCinsiyet,
            this.ClmnÜcret,
            this.ClmnİndirimliÜcret,
            this.ClmnYasi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // ClmnAdi
            // 
            this.ClmnAdi.HeaderText = "Adi";
            this.ClmnAdi.Name = "ClmnAdi";
            // 
            // ClmnDyili
            // 
            this.ClmnDyili.HeaderText = "Doğum Yılı";
            this.ClmnDyili.Name = "ClmnDyili";
            // 
            // ClmnCinsiyet
            // 
            this.ClmnCinsiyet.HeaderText = "Cinsiyet";
            this.ClmnCinsiyet.Name = "ClmnCinsiyet";
            // 
            // ClmnÜcret
            // 
            this.ClmnÜcret.HeaderText = "Ücret";
            this.ClmnÜcret.Name = "ClmnÜcret";
            // 
            // ClmnİndirimliÜcret
            // 
            this.ClmnİndirimliÜcret.HeaderText = "İndirimli Ücret";
            this.ClmnİndirimliÜcret.Name = "ClmnİndirimliÜcret";
            // 
            // ClmnYasi
            // 
            this.ClmnYasi.HeaderText = "Yaşı";
            this.ClmnYasi.Name = "ClmnYasi";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(464, 19);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(75, 23);
            this.BtnHesapla.TabIndex = 10;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // BtnHastaEkle
            // 
            this.BtnHastaEkle.Location = new System.Drawing.Point(464, 48);
            this.BtnHastaEkle.Name = "BtnHastaEkle";
            this.BtnHastaEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnHastaEkle.TabIndex = 11;
            this.BtnHastaEkle.Text = "Hasta Ekle";
            this.BtnHastaEkle.UseVisualStyleBackColor = true;
            this.BtnHastaEkle.Click += new System.EventHandler(this.BtnHastaEkle_Click);
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Location = new System.Drawing.Point(88, 57);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(106, 20);
            this.dateDogumTarihi.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 303);
            this.Controls.Add(this.dateDogumTarihi);
            this.Controls.Add(this.BtnHastaEkle);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtÜcret);
            this.Controls.Add(this.txtAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtÜcret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDyili;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnÜcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnİndirimliÜcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnYasi;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnHastaEkle;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
    }
}

