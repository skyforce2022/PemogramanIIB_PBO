namespace P5_4_714220017
{
    partial class AstraFormMusicSchool
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
            this.FormNama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.TglLahirForm = new System.Windows.Forms.Label();
            this.JenisKelamincomboBox = new System.Windows.Forms.ComboBox();
            this.TanggalDate = new System.Windows.Forms.DateTimePicker();
            this.PilihanJadwalgroupBox = new System.Windows.Forms.GroupBox();
            this.Jadwal1 = new System.Windows.Forms.RadioButton();
            this.Jadwal2 = new System.Windows.Forms.RadioButton();
            this.Jadwal3 = new System.Windows.Forms.RadioButton();
            this.Jadwal4 = new System.Windows.Forms.RadioButton();
            this.PilihanKelasgroupBox = new System.Windows.Forms.GroupBox();
            this.BiolaMusik = new System.Windows.Forms.CheckBox();
            this.GitarMusik = new System.Windows.Forms.CheckBox();
            this.SaxophoneMusik = new System.Windows.Forms.CheckBox();
            this.KomposerMusik = new System.Windows.Forms.CheckBox();
            this.KonduktorMusik = new System.Windows.Forms.CheckBox();
            this.VokalMusik = new System.Windows.Forms.CheckBox();
            this.PianoMusik = new System.Windows.Forms.CheckBox();
            this.DrumMusik = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.FormSelesai = new System.Windows.Forms.Button();
            this.JudulForm = new System.Windows.Forms.Label();
            this.TextNamaBox = new System.Windows.Forms.TextBox();
            this.astraFormMusicSchoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PilihanJadwalgroupBox.SuspendLayout();
            this.PilihanKelasgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.astraFormMusicSchoolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FormNama
            // 
            this.FormNama.AutoSize = true;
            this.FormNama.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNama.Location = new System.Drawing.Point(258, 82);
            this.FormNama.Name = "FormNama";
            this.FormNama.Size = new System.Drawing.Size(54, 23);
            this.FormNama.TabIndex = 7;
            this.FormNama.Text = "Nama\r\n";
            this.FormNama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormNama.Click += new System.EventHandler(this.label1_Click);
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisKelamin.Location = new System.Drawing.Point(258, 137);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(121, 23);
            this.JenisKelamin.TabIndex = 1;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // TglLahirForm
            // 
            this.TglLahirForm.AutoSize = true;
            this.TglLahirForm.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglLahirForm.Location = new System.Drawing.Point(258, 188);
            this.TglLahirForm.Name = "TglLahirForm";
            this.TglLahirForm.Size = new System.Drawing.Size(114, 23);
            this.TglLahirForm.TabIndex = 2;
            this.TglLahirForm.Text = "Tanggal Lahir";
            // 
            // JenisKelamincomboBox
            // 
            this.JenisKelamincomboBox.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisKelamincomboBox.FormattingEnabled = true;
            this.JenisKelamincomboBox.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.JenisKelamincomboBox.Location = new System.Drawing.Point(448, 136);
            this.JenisKelamincomboBox.Name = "JenisKelamincomboBox";
            this.JenisKelamincomboBox.Size = new System.Drawing.Size(466, 26);
            this.JenisKelamincomboBox.TabIndex = 1;
            this.JenisKelamincomboBox.Text = "-------------------------------------Pilih Jenis Kelamin-------------------------" +
    "---------------------------------------------------------------";
            this.JenisKelamincomboBox.UseWaitCursor = true;
            this.JenisKelamincomboBox.SelectedIndexChanged += new System.EventHandler(this.JenisKelaminForm_SelectedIndexChanged);
            // 
            // TanggalDate
            // 
            this.TanggalDate.Location = new System.Drawing.Point(448, 188);
            this.TanggalDate.Name = "TanggalDate";
            this.TanggalDate.Size = new System.Drawing.Size(466, 22);
            this.TanggalDate.TabIndex = 2;
            this.TanggalDate.Value = new System.DateTime(2023, 10, 26, 22, 2, 45, 0);
            // 
            // PilihanJadwalgroupBox
            // 
            this.PilihanJadwalgroupBox.Controls.Add(this.Jadwal1);
            this.PilihanJadwalgroupBox.Controls.Add(this.Jadwal2);
            this.PilihanJadwalgroupBox.Controls.Add(this.Jadwal3);
            this.PilihanJadwalgroupBox.Controls.Add(this.Jadwal4);
            this.PilihanJadwalgroupBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilihanJadwalgroupBox.Location = new System.Drawing.Point(660, 251);
            this.PilihanJadwalgroupBox.Name = "PilihanJadwalgroupBox";
            this.PilihanJadwalgroupBox.Size = new System.Drawing.Size(405, 203);
            this.PilihanJadwalgroupBox.TabIndex = 4;
            this.PilihanJadwalgroupBox.TabStop = false;
            this.PilihanJadwalgroupBox.Text = "Pilihan Jadwal";
            this.PilihanJadwalgroupBox.Enter += new System.EventHandler(this.JadwalForm_Enter);
            // 
            // Jadwal1
            // 
            this.Jadwal1.AutoSize = true;
            this.Jadwal1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jadwal1.Location = new System.Drawing.Point(25, 26);
            this.Jadwal1.Name = "Jadwal1";
            this.Jadwal1.Size = new System.Drawing.Size(241, 24);
            this.Jadwal1.TabIndex = 8;
            this.Jadwal1.TabStop = true;
            this.Jadwal1.Text = "Senin dan Rabu, 14.00-16.00";
            this.Jadwal1.UseVisualStyleBackColor = true;
            // 
            // Jadwal2
            // 
            this.Jadwal2.AutoSize = true;
            this.Jadwal2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jadwal2.Location = new System.Drawing.Point(25, 78);
            this.Jadwal2.Name = "Jadwal2";
            this.Jadwal2.Size = new System.Drawing.Size(250, 24);
            this.Jadwal2.TabIndex = 9;
            this.Jadwal2.TabStop = true;
            this.Jadwal2.Text = "Selasa dan Kamis, 14.00-16.00";
            this.Jadwal2.UseVisualStyleBackColor = true;
            // 
            // Jadwal3
            // 
            this.Jadwal3.AutoSize = true;
            this.Jadwal3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jadwal3.Location = new System.Drawing.Point(25, 128);
            this.Jadwal3.Name = "Jadwal3";
            this.Jadwal3.Size = new System.Drawing.Size(257, 24);
            this.Jadwal3.TabIndex = 10;
            this.Jadwal3.TabStop = true;
            this.Jadwal3.Text = "Sabtu dan Minggu, 09.00-11.00";
            this.Jadwal3.UseVisualStyleBackColor = true;
            this.Jadwal3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Jadwal4
            // 
            this.Jadwal4.AutoSize = true;
            this.Jadwal4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jadwal4.Location = new System.Drawing.Point(25, 173);
            this.Jadwal4.Name = "Jadwal4";
            this.Jadwal4.Size = new System.Drawing.Size(181, 24);
            this.Jadwal4.TabIndex = 11;
            this.Jadwal4.TabStop = true;
            this.Jadwal4.Text = "Minggu, 13.00-17.00";
            this.Jadwal4.UseVisualStyleBackColor = true;
            this.Jadwal4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // PilihanKelasgroupBox
            // 
            this.PilihanKelasgroupBox.Controls.Add(this.BiolaMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.GitarMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.SaxophoneMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.KomposerMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.KonduktorMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.VokalMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.PianoMusik);
            this.PilihanKelasgroupBox.Controls.Add(this.DrumMusik);
            this.PilihanKelasgroupBox.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilihanKelasgroupBox.Location = new System.Drawing.Point(247, 251);
            this.PilihanKelasgroupBox.Name = "PilihanKelasgroupBox";
            this.PilihanKelasgroupBox.Size = new System.Drawing.Size(371, 203);
            this.PilihanKelasgroupBox.TabIndex = 3;
            this.PilihanKelasgroupBox.TabStop = false;
            this.PilihanKelasgroupBox.Text = "Pilihan Kelas";
            this.PilihanKelasgroupBox.Enter += new System.EventHandler(this.FormKelas_Enter);
            // 
            // BiolaMusik
            // 
            this.BiolaMusik.AutoSize = true;
            this.BiolaMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiolaMusik.Location = new System.Drawing.Point(39, 38);
            this.BiolaMusik.Name = "BiolaMusik";
            this.BiolaMusik.Size = new System.Drawing.Size(64, 24);
            this.BiolaMusik.TabIndex = 12;
            this.BiolaMusik.Text = "Biola";
            this.BiolaMusik.UseVisualStyleBackColor = true;
            this.BiolaMusik.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GitarMusik
            // 
            this.GitarMusik.AutoSize = true;
            this.GitarMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitarMusik.Location = new System.Drawing.Point(39, 76);
            this.GitarMusik.Name = "GitarMusik";
            this.GitarMusik.Size = new System.Drawing.Size(65, 24);
            this.GitarMusik.TabIndex = 13;
            this.GitarMusik.Text = "Gitar";
            this.GitarMusik.UseVisualStyleBackColor = true;
            // 
            // SaxophoneMusik
            // 
            this.SaxophoneMusik.AutoSize = true;
            this.SaxophoneMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaxophoneMusik.Location = new System.Drawing.Point(39, 117);
            this.SaxophoneMusik.Name = "SaxophoneMusik";
            this.SaxophoneMusik.Size = new System.Drawing.Size(107, 24);
            this.SaxophoneMusik.TabIndex = 14;
            this.SaxophoneMusik.Text = "Saxophone";
            this.SaxophoneMusik.UseVisualStyleBackColor = true;
            this.SaxophoneMusik.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // KomposerMusik
            // 
            this.KomposerMusik.AutoSize = true;
            this.KomposerMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KomposerMusik.Location = new System.Drawing.Point(219, 157);
            this.KomposerMusik.Name = "KomposerMusik";
            this.KomposerMusik.Size = new System.Drawing.Size(99, 24);
            this.KomposerMusik.TabIndex = 19;
            this.KomposerMusik.Text = "Komposer";
            this.KomposerMusik.UseVisualStyleBackColor = true;
            this.KomposerMusik.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // KonduktorMusik
            // 
            this.KonduktorMusik.AutoSize = true;
            this.KonduktorMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KonduktorMusik.Location = new System.Drawing.Point(39, 157);
            this.KonduktorMusik.Name = "KonduktorMusik";
            this.KonduktorMusik.Size = new System.Drawing.Size(103, 24);
            this.KonduktorMusik.TabIndex = 15;
            this.KonduktorMusik.Text = "Konduktor";
            this.KonduktorMusik.UseVisualStyleBackColor = true;
            this.KonduktorMusik.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // VokalMusik
            // 
            this.VokalMusik.AutoSize = true;
            this.VokalMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VokalMusik.Location = new System.Drawing.Point(219, 117);
            this.VokalMusik.Name = "VokalMusik";
            this.VokalMusik.Size = new System.Drawing.Size(67, 24);
            this.VokalMusik.TabIndex = 18;
            this.VokalMusik.Text = "Vokal";
            this.VokalMusik.UseVisualStyleBackColor = true;
            // 
            // PianoMusik
            // 
            this.PianoMusik.AutoSize = true;
            this.PianoMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PianoMusik.Location = new System.Drawing.Point(219, 38);
            this.PianoMusik.Name = "PianoMusik";
            this.PianoMusik.Size = new System.Drawing.Size(69, 24);
            this.PianoMusik.TabIndex = 16;
            this.PianoMusik.Text = "Piano";
            this.PianoMusik.UseVisualStyleBackColor = true;
            // 
            // DrumMusik
            // 
            this.DrumMusik.AutoSize = true;
            this.DrumMusik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrumMusik.Location = new System.Drawing.Point(219, 76);
            this.DrumMusik.Name = "DrumMusik";
            this.DrumMusik.Size = new System.Drawing.Size(69, 24);
            this.DrumMusik.TabIndex = 17;
            this.DrumMusik.Text = "Drum";
            this.DrumMusik.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampilkan.Location = new System.Drawing.Point(533, 460);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(85, 25);
            this.btnTampilkan.TabIndex = 5;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // FormSelesai
            // 
            this.FormSelesai.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormSelesai.Location = new System.Drawing.Point(670, 460);
            this.FormSelesai.Name = "FormSelesai";
            this.FormSelesai.Size = new System.Drawing.Size(79, 25);
            this.FormSelesai.TabIndex = 6;
            this.FormSelesai.Text = "Selesai";
            this.FormSelesai.UseVisualStyleBackColor = true;
            this.FormSelesai.Click += new System.EventHandler(this.FormSelesai_Click);
            // 
            // JudulForm
            // 
            this.JudulForm.AutoSize = true;
            this.JudulForm.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulForm.ForeColor = System.Drawing.Color.DarkCyan;
            this.JudulForm.Location = new System.Drawing.Point(569, 22);
            this.JudulForm.Name = "JudulForm";
            this.JudulForm.Size = new System.Drawing.Size(248, 36);
            this.JudulForm.TabIndex = 22;
            this.JudulForm.Text = "Form Pendaftaran";
            this.JudulForm.Click += new System.EventHandler(this.JudulForm_Click);
            // 
            // TextNamaBox
            // 
            this.TextNamaBox.Location = new System.Drawing.Point(448, 82);
            this.TextNamaBox.Name = "TextNamaBox";
            this.TextNamaBox.Size = new System.Drawing.Size(466, 22);
            this.TextNamaBox.TabIndex = 23;
            // 
            // astraFormMusicSchoolBindingSource
            // 
            this.astraFormMusicSchoolBindingSource.DataSource = typeof(P5_4_714220017.AstraFormMusicSchool);
            // 
            // AstraFormMusicSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1431, 494);
            this.Controls.Add(this.TextNamaBox);
            this.Controls.Add(this.JudulForm);
            this.Controls.Add(this.FormSelesai);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.PilihanKelasgroupBox);
            this.Controls.Add(this.PilihanJadwalgroupBox);
            this.Controls.Add(this.TanggalDate);
            this.Controls.Add(this.JenisKelamincomboBox);
            this.Controls.Add(this.TglLahirForm);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.FormNama);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AstraFormMusicSchool";
            this.Text = "Astra Music School";
            this.Load += new System.EventHandler(this.AstraFormMusicSchool_Load);
            this.PilihanJadwalgroupBox.ResumeLayout(false);
            this.PilihanJadwalgroupBox.PerformLayout();
            this.PilihanKelasgroupBox.ResumeLayout(false);
            this.PilihanKelasgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.astraFormMusicSchoolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormNama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label TglLahirForm;
        private System.Windows.Forms.ComboBox JenisKelamincomboBox;
        private System.Windows.Forms.DateTimePicker TanggalDate;
        private System.Windows.Forms.GroupBox PilihanJadwalgroupBox;
        private System.Windows.Forms.GroupBox PilihanKelasgroupBox;
        private System.Windows.Forms.RadioButton Jadwal1;
        private System.Windows.Forms.RadioButton Jadwal2;
        private System.Windows.Forms.RadioButton Jadwal3;
        private System.Windows.Forms.RadioButton Jadwal4;
        private System.Windows.Forms.CheckBox BiolaMusik;
        private System.Windows.Forms.CheckBox GitarMusik;
        private System.Windows.Forms.CheckBox SaxophoneMusik;
        private System.Windows.Forms.CheckBox KonduktorMusik;
        private System.Windows.Forms.CheckBox PianoMusik;
        private System.Windows.Forms.CheckBox DrumMusik;
        private System.Windows.Forms.CheckBox VokalMusik;
        private System.Windows.Forms.CheckBox KomposerMusik;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button FormSelesai;
        private System.Windows.Forms.Label JudulForm;
        private System.Windows.Forms.BindingSource astraFormMusicSchoolBindingSource;
        private System.Windows.Forms.TextBox TextNamaBox;
    }
}

