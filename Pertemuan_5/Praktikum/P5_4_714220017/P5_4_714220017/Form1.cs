using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5_4_714220017
{
    public partial class AstraFormMusicSchool : Form
    {
        private object OutputLabel;

        public AstraFormMusicSchool()
        {
            InitializeComponent();
        }

        private void AstraFormMusicSchool_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JadwalForm_Enter(object sender, EventArgs e)
        {

        }

        private void FormKelas_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void JudulForm_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string kelasTerpilih = "";
            string jadwalTerpilih = "";

            // Mengambil pilihan kelas
            if (BiolaMusik.Checked)
            {
                kelasTerpilih += "Biola, ";
            }
            if (GitarMusik.Checked)
            {
                kelasTerpilih += "Gitar, ";
            }
            if (SaxophoneMusik.Checked)
            {
                kelasTerpilih += "Saxophone, ";
            }
            if (KonduktorMusik.Checked)
            {
                kelasTerpilih += "Konduktor, ";
            }
            if (PianoMusik.Checked)
            {
                kelasTerpilih += "Piano, ";
            }
            if (DrumMusik.Checked)
            {
                kelasTerpilih += "Drum, ";
            }
            if (VokalMusik.Checked)
            {
                kelasTerpilih += "Vokal, ";
            }
            if (KomposerMusik.Checked)
            {
                kelasTerpilih += "Komposer, ";
            }

            // Mengambil pilihan jadwal
            if (Jadwal1.Checked)
            {
                jadwalTerpilih = "Senin dan Rabu, 14.00-16.00";
            }
            else if (Jadwal2.Checked)
            {
                jadwalTerpilih = "Selasa dan Kamis, 14.00-16.00";
            }
            else if (Jadwal3.Checked)
            {
                jadwalTerpilih = "Sabtu dan Minggu, 09.00-11.00";
            }
            else if (Jadwal4.Checked)
            {
                jadwalTerpilih = "Minggu, 13.00-17.00";
            }

            // Menampilkan hasil dalam MessageBox
            string message = "Nama: " + TextNamaBox.Text + "\nJenis Kelamin: " + JenisKelamincomboBox.Text +
                "\nTanggal Lahir: " + TanggalDate.Text +
                "\nPilihan Kelas: " + kelasTerpilih.TrimEnd(',', ' ') +
                "\nPilihan Jadwal: " + jadwalTerpilih;
            if (TextNamaBox.Text == "")
            {
                MessageBox.Show("Nama : " + TextNamaBox + "\nJenis Kelamin : " + JenisKelamincomboBox + "\nTanggal Lahir : " + TanggalDate + "\nPilihan Kelas : " + PilihanKelasGroupBox + "\nPilihan Jadwal : " + PilihanJadwalgroupBox, "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (JenisKelamincomboBox.Text == "")
            {
                MessageBox.Show("Pilih jenis kelamin anda, tidak boleh kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PilihanKelasGroupBox.Text == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PilihanJadwalgroupBox.Text == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            MessageBox.Show(message, "Kursus Musik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private object GetOutputLabel()
        {
            return OutputLabel;
        }

        private void JenisKelaminForm_SelectedIndexChanged(object sender, EventArgs e, object outputLabel)
        {
           
        }

        private void JenisKelaminForm_SelectedIndexChanged(object sender, EventArgs e) 
        {
         
        }

        private void FormSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
