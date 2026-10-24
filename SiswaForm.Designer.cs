namespace AplikasiDataSiswa
{
    partial class SiswaForm
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
            groupBox3 = new GroupBox();
            btnKosong = new Button();
            btnSimpan = new Button();
            groupBox2 = new GroupBox();
            btnPilihGambar = new Button();
            pbFoto = new PictureBox();
            groupBox1 = new GroupBox();
            cbKelas = new ComboBox();
            label12 = new Label();
            cbJurusan = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            rtbAlamat = new RichTextBox();
            cbAgama = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            rbPerempuan = new RadioButton();
            rbLaki = new RadioButton();
            dtpTanggalLahir = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txtTempatLahir = new TextBox();
            label5 = new Label();
            txtNamaSiswa = new TextBox();
            label4 = new Label();
            txtNis = new TextBox();
            label3 = new Label();
            txtNisn = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dgvSiswa = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnKosong);
            groupBox3.Controls.Add(btnSimpan);
            groupBox3.Location = new Point(564, 480);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 150);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // btnKosong
            // 
            btnKosong.Location = new Point(17, 85);
            btnKosong.Name = "btnKosong";
            btnKosong.Size = new Size(232, 34);
            btnKosong.TabIndex = 3;
            btnKosong.Text = "KosongKan";
            btnKosong.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(17, 45);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(232, 34);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPilihGambar);
            groupBox2.Controls.Add(pbFoto);
            groupBox2.Location = new Point(564, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 359);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "foto siswa";
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.Location = new Point(17, 307);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(232, 34);
            btnPilihGambar.TabIndex = 1;
            btnPilihGambar.Text = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = true;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(17, 38);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(232, 255);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbKelas);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbJurusan);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rtbAlamat);
            groupBox1.Controls.Add(cbAgama);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(rbPerempuan);
            groupBox1.Controls.Add(rbLaki);
            groupBox1.Controls.Add(dtpTanggalLahir);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTempatLahir);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNamaSiswa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNis);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNisn);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 536);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "identitas Siswa";
            // 
            // cbKelas
            // 
            cbKelas.FormattingEnabled = true;
            cbKelas.Items.AddRange(new object[] { "X", "XI", "XII" });
            cbKelas.Location = new Point(181, 451);
            cbKelas.Name = "cbKelas";
            cbKelas.Size = new Size(270, 33);
            cbKelas.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 459);
            label12.Name = "label12";
            label12.Size = new Size(52, 25);
            label12.TabIndex = 22;
            label12.Text = "Kelas";
            // 
            // cbJurusan
            // 
            cbJurusan.FormattingEnabled = true;
            cbJurusan.Items.AddRange(new object[] { "Rekayasa Perangkat Lunak", "Busana", "Agribisnis Perikanan", "Instalasi Listrik", "Teknik Otomotif" });
            cbJurusan.Location = new Point(181, 412);
            cbJurusan.Name = "cbJurusan";
            cbJurusan.Size = new Size(270, 33);
            cbJurusan.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 415);
            label11.Name = "label11";
            label11.Size = new Size(71, 25);
            label11.TabIndex = 20;
            label11.Text = "Jurusan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 317);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 19;
            label10.Text = "Alamat";
            // 
            // rtbAlamat
            // 
            rtbAlamat.Location = new Point(181, 317);
            rtbAlamat.Name = "rtbAlamat";
            rtbAlamat.Size = new Size(270, 89);
            rtbAlamat.TabIndex = 18;
            rtbAlamat.Text = "";
            // 
            // cbAgama
            // 
            cbAgama.FormattingEnabled = true;
            cbAgama.Items.AddRange(new object[] { "ISLAM", "KRISTEN", "HINDU", "BUDHA", "KATHOLIK", "KONGHUCU" });
            cbAgama.Location = new Point(181, 278);
            cbAgama.Name = "cbAgama";
            cbAgama.Size = new Size(270, 33);
            cbAgama.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 278);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 16;
            label9.Text = "Agama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 244);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 14;
            label8.Text = "Jenis Kelamin";
            // 
            // rbPerempuan
            // 
            rbPerempuan.AutoSize = true;
            rbPerempuan.Location = new Point(328, 243);
            rbPerempuan.Name = "rbPerempuan";
            rbPerempuan.Size = new Size(126, 29);
            rbPerempuan.TabIndex = 13;
            rbPerempuan.TabStop = true;
            rbPerempuan.Text = "Perempuan";
            rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLaki
            // 
            rbLaki.AutoSize = true;
            rbLaki.Location = new Point(181, 243);
            rbLaki.Name = "rbLaki";
            rbLaki.Size = new Size(104, 29);
            rbLaki.TabIndex = 12;
            rbLaki.TabStop = true;
            rbLaki.Text = "Laki-Laki";
            rbLaki.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(181, 206);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(300, 31);
            dtpTanggalLahir.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 203);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 10;
            label7.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 166);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 8;
            label6.Text = "Tempat Lahir";
            // 
            // txtTempatLahir
            // 
            txtTempatLahir.Location = new Point(181, 166);
            txtTempatLahir.Name = "txtTempatLahir";
            txtTempatLahir.Size = new Size(270, 31);
            txtTempatLahir.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 129);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 6;
            label5.Text = "Nama Siswa";
            // 
            // txtNamaSiswa
            // 
            txtNamaSiswa.Location = new Point(181, 129);
            txtNamaSiswa.Name = "txtNamaSiswa";
            txtNamaSiswa.Size = new Size(270, 31);
            txtNamaSiswa.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 92);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 4;
            label4.Text = "NIS";
            // 
            // txtNis
            // 
            txtNis.Location = new Point(181, 92);
            txtNis.Name = "txtNis";
            txtNis.Size = new Size(270, 31);
            txtNis.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 55);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "NISN";
            // 
            // txtNisn
            // 
            txtNisn.Location = new Point(181, 55);
            txtNisn.Name = "txtNisn";
            txtNisn.Size = new Size(270, 31);
            txtNisn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 49);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(67, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 3);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, -1);
            label1.Name = "label1";
            label1.Size = new Size(318, 48);
            label1.TabIndex = 6;
            label1.Text = "Input Data Siswa";
            // 
            // dgvSiswa
            // 
            dgvSiswa.AllowUserToOrderColumns = true;
            dgvSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiswa.Location = new Point(17, 652);
            dgvSiswa.Name = "dgvSiswa";
            dgvSiswa.RowHeadersWidth = 62;
            dgvSiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiswa.Size = new Size(811, 225);
            dgvSiswa.TabIndex = 11;
            dgvSiswa.CellMouseDoubleClick += dgvSiswa_CellMouseDoubleClick;
            // 
            // SiswaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 873);
            Controls.Add(dgvSiswa);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "SiswaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SiswaForm";
            Load += SiswaForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiswa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnKosong;
        private Button btnSimpan;
        private GroupBox groupBox2;
        private Button btnPilihGambar;
        private PictureBox pbFoto;
        private GroupBox groupBox1;
        private ComboBox cbKelas;
        private Label label12;
        private ComboBox cbJurusan;
        private Label label11;
        private Label label10;
        private RichTextBox rtbAlamat;
        private ComboBox cbAgama;
        private Label label9;
        private Label label8;
        private RadioButton rbPerempuan;
        private RadioButton rbLaki;
        private DateTimePicker dtpTanggalLahir;
        private Label label7;
        private Label label6;
        private TextBox txtTempatLahir;
        private Label label5;
        private TextBox txtNamaSiswa;
        private Label label4;
        private TextBox txtNis;
        private Label label3;
        private TextBox txtNisn;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvSiswa;
    }
}