namespace ATS_714220017
{
    partial class FormPilihanMatkul
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPilihanMatkul));
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelNIM = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJeniskelamin = new System.Windows.Forms.Label();
            this.labelAdresss = new System.Windows.Forms.Label();
            this.labelProdi = new System.Windows.Forms.Label();
            this.labeltahunAkademik = new System.Windows.Forms.Label();
            this.labelsemester = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTahunAkademik = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.comboBoxProdi = new System.Windows.Forms.ComboBox();
            this.radioButtonLakiLaki = new System.Windows.Forms.RadioButton();
            this.radioButtonPerempuan = new System.Windows.Forms.RadioButton();
            this.groupBoxKurikulumPilihan = new System.Windows.Forms.GroupBox();
            this.radioButtonKurikulumMerdeka = new System.Windows.Forms.RadioButton();
            this.radioButtonKurikulum2006 = new System.Windows.Forms.RadioButton();
            this.radioButtonKurikulum2013 = new System.Windows.Forms.RadioButton();
            this.groupBoxMatakuliahPilihan = new System.Windows.Forms.GroupBox();
            this.checkBoxRantaiPasok = new System.Windows.Forms.CheckBox();
            this.SistemOperasiCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxJaringanKomputer = new System.Windows.Forms.CheckBox();
            this.checkBoxPengantar = new System.Windows.Forms.CheckBox();
            this.checkBoxPendidikanKewarnegaraan = new System.Windows.Forms.CheckBox();
            this.checkBoxPendidikanAgama = new System.Windows.Forms.CheckBox();
            this.checkBoxFisika = new System.Windows.Forms.CheckBox();
            this.checkBoxPemrograman4 = new System.Windows.Forms.CheckBox();
            this.checkBoxPemrograman3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPemrograman2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPemrograman1 = new System.Windows.Forms.CheckBox();
            this.checkBoxmatematika = new System.Windows.Forms.CheckBox();
            this.buttonPilihMATakuliah = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.groupBoxKurikulumPilihan.SuspendLayout();
            this.groupBoxMatakuliahPilihan.SuspendLayout();
            this.SuspendLayout();
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(668, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(299, 26);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Pilihan Mata Kuliah Mahasiswa";
            this.labelJudul.Click += new System.EventHandler(this.labelJudul_Click);
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(52, 109);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(35, 20);
            this.labelNIM.TabIndex = 1;
            this.labelNIM.Text = "NIM";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(52, 174);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(48, 20);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama";
            // 
            // labelJeniskelamin
            // 
            this.labelJeniskelamin.AutoSize = true;
            this.labelJeniskelamin.Location = new System.Drawing.Point(52, 233);
            this.labelJeniskelamin.Name = "labelJeniskelamin";
            this.labelJeniskelamin.Size = new System.Drawing.Size(106, 20);
            this.labelJeniskelamin.TabIndex = 3;
            this.labelJeniskelamin.Text = "Jenis Kelamin";
            // 
            // labelAdresss
            // 
            this.labelAdresss.AutoSize = true;
            this.labelAdresss.Location = new System.Drawing.Point(52, 306);
            this.labelAdresss.Name = "labelAdresss";
            this.labelAdresss.Size = new System.Drawing.Size(58, 20);
            this.labelAdresss.TabIndex = 4;
            this.labelAdresss.Text = "Alamat";
            // 
            // labelProdi
            // 
            this.labelProdi.AutoSize = true;
            this.labelProdi.Location = new System.Drawing.Point(886, 114);
            this.labelProdi.Name = "labelProdi";
            this.labelProdi.Size = new System.Drawing.Size(108, 20);
            this.labelProdi.TabIndex = 5;
            this.labelProdi.Text = "Program Studi";
            this.labelProdi.Click += new System.EventHandler(this.labelProdi_Click);
            // 
            // labeltahunAkademik
            // 
            this.labeltahunAkademik.AutoSize = true;
            this.labeltahunAkademik.Location = new System.Drawing.Point(886, 170);
            this.labeltahunAkademik.Name = "labeltahunAkademik";
            this.labeltahunAkademik.Size = new System.Drawing.Size(124, 20);
            this.labeltahunAkademik.TabIndex = 6;
            this.labeltahunAkademik.Text = "Tahun Akademik";
            // 
            // labelsemester
            // 
            this.labelsemester.AutoSize = true;
            this.labelsemester.Location = new System.Drawing.Point(892, 231);
            this.labelsemester.Name = "labelsemester";
            this.labelsemester.Size = new System.Drawing.Size(75, 20);
            this.labelsemester.TabIndex = 7;
            this.labelsemester.Text = "Semester";
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(161, 109);
            this.textBoxNIM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(518, 25);
            this.textBoxNIM.TabIndex = 8;
            this.textBoxNIM.TextChanged += new System.EventHandler(this.textBoxNIM_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(161, 170);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(518, 25);
            this.textBoxNama.TabIndex = 9;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(161, 306);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(311, 78);
            this.textBoxAlamat.TabIndex = 10;
            // 
            // textBoxTahunAkademik
            // 
            this.textBoxTahunAkademik.Location = new System.Drawing.Point(1070, 167);
            this.textBoxTahunAkademik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTahunAkademik.Name = "textBoxTahunAkademik";
            this.textBoxTahunAkademik.Size = new System.Drawing.Size(441, 25);
            this.textBoxTahunAkademik.TabIndex = 11;
            this.textBoxTahunAkademik.TextChanged += new System.EventHandler(this.textBoxTahunAkademik_TextChanged);
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(1070, 228);
            this.textBoxSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(441, 25);
            this.textBoxSemester.TabIndex = 12;
            this.textBoxSemester.TextChanged += new System.EventHandler(this.textBoxSemester_TextChanged);
            // 
            // comboBoxProdi
            // 
            this.comboBoxProdi.FormattingEnabled = true;
            this.comboBoxProdi.Items.AddRange(new object[] {
            "D4-Teknik Informatika",
            "S1-Teknik Informatika"});
            this.comboBoxProdi.Location = new System.Drawing.Point(1070, 111);
            this.comboBoxProdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxProdi.Name = "comboBoxProdi";
            this.comboBoxProdi.Size = new System.Drawing.Size(441, 28);
            this.comboBoxProdi.TabIndex = 13;
            // 
            // radioButtonLakiLaki
            // 
            this.radioButtonLakiLaki.AutoSize = true;
            this.radioButtonLakiLaki.Location = new System.Drawing.Point(164, 231);
            this.radioButtonLakiLaki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonLakiLaki.Name = "radioButtonLakiLaki";
            this.radioButtonLakiLaki.Size = new System.Drawing.Size(92, 24);
            this.radioButtonLakiLaki.TabIndex = 14;
            this.radioButtonLakiLaki.TabStop = true;
            this.radioButtonLakiLaki.Text = "Laki-Laki";
            this.radioButtonLakiLaki.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerempuan
            // 
            this.radioButtonPerempuan.AutoSize = true;
            this.radioButtonPerempuan.Location = new System.Drawing.Point(330, 231);
            this.radioButtonPerempuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPerempuan.Name = "radioButtonPerempuan";
            this.radioButtonPerempuan.Size = new System.Drawing.Size(110, 24);
            this.radioButtonPerempuan.TabIndex = 15;
            this.radioButtonPerempuan.TabStop = true;
            this.radioButtonPerempuan.Text = "Perempuan";
            this.radioButtonPerempuan.UseVisualStyleBackColor = true;
            // 
            // groupBoxKurikulumPilihan
            // 
            this.groupBoxKurikulumPilihan.Controls.Add(this.radioButtonKurikulumMerdeka);
            this.groupBoxKurikulumPilihan.Controls.Add(this.radioButtonKurikulum2006);
            this.groupBoxKurikulumPilihan.Controls.Add(this.radioButtonKurikulum2013);
            this.groupBoxKurikulumPilihan.Location = new System.Drawing.Point(52, 441);
            this.groupBoxKurikulumPilihan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxKurikulumPilihan.Name = "groupBoxKurikulumPilihan";
            this.groupBoxKurikulumPilihan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxKurikulumPilihan.Size = new System.Drawing.Size(399, 235);
            this.groupBoxKurikulumPilihan.TabIndex = 16;
            this.groupBoxKurikulumPilihan.TabStop = false;
            this.groupBoxKurikulumPilihan.Text = "Kurikulum Pilihan";
            // 
            // radioButtonKurikulumMerdeka
            // 
            this.radioButtonKurikulumMerdeka.AutoSize = true;
            this.radioButtonKurikulumMerdeka.Location = new System.Drawing.Point(0, 176);
            this.radioButtonKurikulumMerdeka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonKurikulumMerdeka.Name = "radioButtonKurikulumMerdeka";
            this.radioButtonKurikulumMerdeka.Size = new System.Drawing.Size(167, 24);
            this.radioButtonKurikulumMerdeka.TabIndex = 20;
            this.radioButtonKurikulumMerdeka.Text = "Kurikulum Merdeka";
            this.radioButtonKurikulumMerdeka.UseVisualStyleBackColor = true;
            this.radioButtonKurikulumMerdeka.CheckedChanged += new System.EventHandler(this.radioButtonKurikulumMerdeka_CheckedChanged);
            // 
            // radioButtonKurikulum2006
            // 
            this.radioButtonKurikulum2006.AutoSize = true;
            this.radioButtonKurikulum2006.Location = new System.Drawing.Point(3, 55);
            this.radioButtonKurikulum2006.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonKurikulum2006.Name = "radioButtonKurikulum2006";
            this.radioButtonKurikulum2006.Size = new System.Drawing.Size(142, 24);
            this.radioButtonKurikulum2006.TabIndex = 18;
            this.radioButtonKurikulum2006.Text = "Kurikulum 2006";
            this.radioButtonKurikulum2006.UseVisualStyleBackColor = true;
            this.radioButtonKurikulum2006.CheckedChanged += new System.EventHandler(this.radioButtonKurikulum2006_CheckedChanged);
            // 
            // radioButtonKurikulum2013
            // 
            this.radioButtonKurikulum2013.AutoSize = true;
            this.radioButtonKurikulum2013.Location = new System.Drawing.Point(0, 113);
            this.radioButtonKurikulum2013.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonKurikulum2013.Name = "radioButtonKurikulum2013";
            this.radioButtonKurikulum2013.Size = new System.Drawing.Size(142, 24);
            this.radioButtonKurikulum2013.TabIndex = 19;
            this.radioButtonKurikulum2013.Text = "Kurikulum 2013";
            this.radioButtonKurikulum2013.UseVisualStyleBackColor = true;
            this.radioButtonKurikulum2013.CheckedChanged += new System.EventHandler(this.radioButtonKurikulum2013_CheckedChanged);
            // 
            // groupBoxMatakuliahPilihan
            // 
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxRantaiPasok);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.SistemOperasiCheckBox);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxJaringanKomputer);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPengantar);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPendidikanKewarnegaraan);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPendidikanAgama);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxFisika);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPemrograman4);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPemrograman3);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPemrograman2);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxPemrograman1);
            this.groupBoxMatakuliahPilihan.Controls.Add(this.checkBoxmatematika);
            this.groupBoxMatakuliahPilihan.Location = new System.Drawing.Point(554, 441);
            this.groupBoxMatakuliahPilihan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMatakuliahPilihan.Name = "groupBoxMatakuliahPilihan";
            this.groupBoxMatakuliahPilihan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMatakuliahPilihan.Size = new System.Drawing.Size(714, 235);
            this.groupBoxMatakuliahPilihan.TabIndex = 17;
            this.groupBoxMatakuliahPilihan.TabStop = false;
            this.groupBoxMatakuliahPilihan.Text = "Mata Kuliah Pilihan";
            this.groupBoxMatakuliahPilihan.EnabledChanged += new System.EventHandler(this.groupBoxMatakuliahPilihan_EnabledChanged);
            // 
            // checkBoxRantaiPasok
            // 
            this.checkBoxRantaiPasok.AutoSize = true;
            this.checkBoxRantaiPasok.Enabled = false;
            this.checkBoxRantaiPasok.Location = new System.Drawing.Point(504, 191);
            this.checkBoxRantaiPasok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRantaiPasok.Name = "checkBoxRantaiPasok";
            this.checkBoxRantaiPasok.Size = new System.Drawing.Size(206, 24);
            this.checkBoxRantaiPasok.TabIndex = 11;
            this.checkBoxRantaiPasok.Text = "Manajemen Rantai Pasok";
            this.checkBoxRantaiPasok.UseVisualStyleBackColor = true;
            // 
            // SistemOperasiCheckBox
            // 
            this.SistemOperasiCheckBox.AutoSize = true;
            this.SistemOperasiCheckBox.Enabled = false;
            this.SistemOperasiCheckBox.Location = new System.Drawing.Point(504, 136);
            this.SistemOperasiCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SistemOperasiCheckBox.Name = "SistemOperasiCheckBox";
            this.SistemOperasiCheckBox.Size = new System.Drawing.Size(135, 24);
            this.SistemOperasiCheckBox.TabIndex = 10;
            this.SistemOperasiCheckBox.Text = "Sistem Operasi";
            this.SistemOperasiCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxJaringanKomputer
            // 
            this.checkBoxJaringanKomputer.AutoSize = true;
            this.checkBoxJaringanKomputer.Enabled = false;
            this.checkBoxJaringanKomputer.Location = new System.Drawing.Point(504, 88);
            this.checkBoxJaringanKomputer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxJaringanKomputer.Name = "checkBoxJaringanKomputer";
            this.checkBoxJaringanKomputer.Size = new System.Drawing.Size(165, 24);
            this.checkBoxJaringanKomputer.TabIndex = 9;
            this.checkBoxJaringanKomputer.Text = "Jaringan Komputer";
            this.checkBoxJaringanKomputer.UseVisualStyleBackColor = true;
            // 
            // checkBoxPengantar
            // 
            this.checkBoxPengantar.AutoSize = true;
            this.checkBoxPengantar.Enabled = false;
            this.checkBoxPengantar.Location = new System.Drawing.Point(504, 38);
            this.checkBoxPengantar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPengantar.Name = "checkBoxPengantar";
            this.checkBoxPengantar.Size = new System.Drawing.Size(159, 24);
            this.checkBoxPengantar.TabIndex = 8;
            this.checkBoxPengantar.Text = "Pengantar Logistik";
            this.checkBoxPengantar.UseVisualStyleBackColor = true;
            // 
            // checkBoxPendidikanKewarnegaraan
            // 
            this.checkBoxPendidikanKewarnegaraan.AutoSize = true;
            this.checkBoxPendidikanKewarnegaraan.Enabled = false;
            this.checkBoxPendidikanKewarnegaraan.Location = new System.Drawing.Point(254, 191);
            this.checkBoxPendidikanKewarnegaraan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPendidikanKewarnegaraan.Name = "checkBoxPendidikanKewarnegaraan";
            this.checkBoxPendidikanKewarnegaraan.Size = new System.Drawing.Size(222, 24);
            this.checkBoxPendidikanKewarnegaraan.TabIndex = 7;
            this.checkBoxPendidikanKewarnegaraan.Text = "Pendidikan Kewarnegaraan";
            this.checkBoxPendidikanKewarnegaraan.UseVisualStyleBackColor = true;
            // 
            // checkBoxPendidikanAgama
            // 
            this.checkBoxPendidikanAgama.AutoSize = true;
            this.checkBoxPendidikanAgama.Enabled = false;
            this.checkBoxPendidikanAgama.Location = new System.Drawing.Point(254, 136);
            this.checkBoxPendidikanAgama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPendidikanAgama.Name = "checkBoxPendidikanAgama";
            this.checkBoxPendidikanAgama.Size = new System.Drawing.Size(159, 24);
            this.checkBoxPendidikanAgama.TabIndex = 6;
            this.checkBoxPendidikanAgama.Text = "Pendidikan Agama";
            this.checkBoxPendidikanAgama.UseVisualStyleBackColor = true;
            // 
            // checkBoxFisika
            // 
            this.checkBoxFisika.AutoSize = true;
            this.checkBoxFisika.Enabled = false;
            this.checkBoxFisika.Location = new System.Drawing.Point(254, 88);
            this.checkBoxFisika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFisika.Name = "checkBoxFisika";
            this.checkBoxFisika.Size = new System.Drawing.Size(70, 24);
            this.checkBoxFisika.TabIndex = 5;
            this.checkBoxFisika.Text = "Fisika";
            this.checkBoxFisika.UseVisualStyleBackColor = true;
            // 
            // checkBoxPemrograman4
            // 
            this.checkBoxPemrograman4.AutoSize = true;
            this.checkBoxPemrograman4.Enabled = false;
            this.checkBoxPemrograman4.Location = new System.Drawing.Point(254, 38);
            this.checkBoxPemrograman4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPemrograman4.Name = "checkBoxPemrograman4";
            this.checkBoxPemrograman4.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPemrograman4.TabIndex = 4;
            this.checkBoxPemrograman4.Text = "Pemrograman 4";
            this.checkBoxPemrograman4.UseVisualStyleBackColor = true;
            // 
            // checkBoxPemrograman3
            // 
            this.checkBoxPemrograman3.AutoSize = true;
            this.checkBoxPemrograman3.Enabled = false;
            this.checkBoxPemrograman3.Location = new System.Drawing.Point(18, 191);
            this.checkBoxPemrograman3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPemrograman3.Name = "checkBoxPemrograman3";
            this.checkBoxPemrograman3.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPemrograman3.TabIndex = 3;
            this.checkBoxPemrograman3.Text = "Pemrograman 3";
            this.checkBoxPemrograman3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPemrograman2
            // 
            this.checkBoxPemrograman2.AutoSize = true;
            this.checkBoxPemrograman2.Enabled = false;
            this.checkBoxPemrograman2.Location = new System.Drawing.Point(18, 136);
            this.checkBoxPemrograman2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPemrograman2.Name = "checkBoxPemrograman2";
            this.checkBoxPemrograman2.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPemrograman2.TabIndex = 2;
            this.checkBoxPemrograman2.Text = "Pemrograman 2";
            this.checkBoxPemrograman2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPemrograman1
            // 
            this.checkBoxPemrograman1.AutoSize = true;
            this.checkBoxPemrograman1.Enabled = false;
            this.checkBoxPemrograman1.Location = new System.Drawing.Point(18, 88);
            this.checkBoxPemrograman1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPemrograman1.Name = "checkBoxPemrograman1";
            this.checkBoxPemrograman1.Size = new System.Drawing.Size(141, 24);
            this.checkBoxPemrograman1.TabIndex = 1;
            this.checkBoxPemrograman1.Text = "Pemrograman 1";
            this.checkBoxPemrograman1.UseVisualStyleBackColor = true;
            // 
            // checkBoxmatematika
            // 
            this.checkBoxmatematika.AutoSize = true;
            this.checkBoxmatematika.Enabled = false;
            this.checkBoxmatematika.Location = new System.Drawing.Point(18, 38);
            this.checkBoxmatematika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxmatematika.Name = "checkBoxmatematika";
            this.checkBoxmatematika.Size = new System.Drawing.Size(113, 24);
            this.checkBoxmatematika.TabIndex = 0;
            this.checkBoxmatematika.Text = "Matematika";
            this.checkBoxmatematika.UseVisualStyleBackColor = true;
            // 
            // buttonPilihMATakuliah
            // 
            this.buttonPilihMATakuliah.Location = new System.Drawing.Point(1034, 306);
            this.buttonPilihMATakuliah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPilihMATakuliah.Name = "buttonPilihMATakuliah";
            this.buttonPilihMATakuliah.Size = new System.Drawing.Size(168, 43);
            this.buttonPilihMATakuliah.TabIndex = 18;
            this.buttonPilihMATakuliah.Text = "Pilih Mata Kuliah";
            this.buttonPilihMATakuliah.UseVisualStyleBackColor = true;
            this.buttonPilihMATakuliah.Click += new System.EventHandler(this.buttonPilihMATakuliah_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(403, 692);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(114, 46);
            this.buttonSimpan.TabIndex = 19;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonBatal
            // 
            this.buttonBatal.Location = new System.Drawing.Point(721, 692);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(118, 46);
            this.buttonBatal.TabIndex = 20;
            this.buttonBatal.Text = "Batal";
            this.buttonBatal.UseVisualStyleBackColor = true;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // FormPilihanMatkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 831);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonPilihMATakuliah);
            this.Controls.Add(this.groupBoxMatakuliahPilihan);
            this.Controls.Add(this.groupBoxKurikulumPilihan);
            this.Controls.Add(this.radioButtonPerempuan);
            this.Controls.Add(this.radioButtonLakiLaki);
            this.Controls.Add(this.comboBoxProdi);
            this.Controls.Add(this.textBoxSemester);
            this.Controls.Add(this.textBoxTahunAkademik);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.labelsemester);
            this.Controls.Add(this.labeltahunAkademik);
            this.Controls.Add(this.labelProdi);
            this.Controls.Add(this.labelAdresss);
            this.Controls.Add(this.labelJeniskelamin);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNIM);
            this.Controls.Add(this.labelJudul);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPilihanMatkul";
            this.Text = "Form Pilihan Matkul";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.groupBoxKurikulumPilihan.ResumeLayout(false);
            this.groupBoxKurikulumPilihan.PerformLayout();
            this.groupBoxMatakuliahPilihan.ResumeLayout(false);
            this.groupBoxMatakuliahPilihan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Label labelsemester;
        private System.Windows.Forms.Label labeltahunAkademik;
        private System.Windows.Forms.Label labelProdi;
        private System.Windows.Forms.Label labelAdresss;
        private System.Windows.Forms.Label labelJeniskelamin;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNIM;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.GroupBox groupBoxMatakuliahPilihan;
        private System.Windows.Forms.CheckBox checkBoxFisika;
        private System.Windows.Forms.CheckBox checkBoxPemrograman4;
        private System.Windows.Forms.CheckBox checkBoxPemrograman3;
        private System.Windows.Forms.CheckBox checkBoxPemrograman2;
        private System.Windows.Forms.CheckBox checkBoxPemrograman1;
        private System.Windows.Forms.CheckBox checkBoxmatematika;
        private System.Windows.Forms.GroupBox groupBoxKurikulumPilihan;
        private System.Windows.Forms.RadioButton radioButtonKurikulumMerdeka;
        private System.Windows.Forms.RadioButton radioButtonKurikulum2006;
        private System.Windows.Forms.RadioButton radioButtonKurikulum2013;
        private System.Windows.Forms.RadioButton radioButtonPerempuan;
        private System.Windows.Forms.RadioButton radioButtonLakiLaki;
        private System.Windows.Forms.ComboBox comboBoxProdi;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxTahunAkademik;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonPilihMATakuliah;
        private System.Windows.Forms.CheckBox checkBoxRantaiPasok;
        private System.Windows.Forms.CheckBox SistemOperasiCheckBox;
        private System.Windows.Forms.CheckBox checkBoxJaringanKomputer;
        private System.Windows.Forms.CheckBox checkBoxPengantar;
        private System.Windows.Forms.CheckBox checkBoxPendidikanKewarnegaraan;
        private System.Windows.Forms.CheckBox checkBoxPendidikanAgama;
    }
}

