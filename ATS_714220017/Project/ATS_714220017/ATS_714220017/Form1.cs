using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATS_714220017
{
    public partial class FormPilihanMatkul : System.Windows.Forms.Form
    {

        private ErrorProvider errorProvider;
        private string errorMessage;

        public FormPilihanMatkul()
        {
            InitializeComponent();
        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNIM_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTahunAkademik_TextChanged(object sender, EventArgs e)
        {
           
        }

   
        private void textBoxSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPilihMATakuliah_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(textBoxNIM.Text))
            {
                errorMessage += "NIM Belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage += "Nama Belum diisi\n";
            }

            else if (!Regex.IsMatch(textBoxTahunAkademik.Text, @"^\d{4}/\d{4}$"))
            {
                errorMessage += "Tahun Akademik belum diisi\n";
            }

            else if (!Regex.IsMatch(comboBoxProdi.Text, @"^(D4|S1)-[a-zA-Z\s]+$"))
            {
                errorMessage += "Prodi harus berformat {Strata}-{Prodi}\n";
            }

            if (string.IsNullOrWhiteSpace(textBoxSemester.Text))
            {
                errorMessage += "Semester Belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }

            else
            {
                MessageBox.Show(
                     errorMessage,
                     "Informasi Data Submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                     );
            }
        }

        private void radioButtonKurikulum2006_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurikulum2006.Checked) 
            {
                checkBoxmatematika.Enabled = true;
                checkBoxPemrograman1.Enabled = true;
                checkBoxPemrograman2.Enabled = true;
                checkBoxPemrograman3.Enabled = true;
                checkBoxPemrograman4.Enabled = true;
                checkBoxFisika.Enabled = true;
                checkBoxPendidikanAgama.Enabled = true;
                checkBoxPendidikanKewarnegaraan.Enabled = true;
                checkBoxPengantar.Enabled = false;
                checkBoxJaringanKomputer.Enabled = true;
                SistemOperasiCheckBox.Enabled = true;
                checkBoxRantaiPasok.Enabled = false;

            }
        }

        private void radioButtonKurikulum2013_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurikulum2013.Checked) 
            {
                checkBoxmatematika.Enabled = true;
                checkBoxPemrograman1.Enabled = true;
                checkBoxPemrograman2.Enabled = true;
                checkBoxPemrograman3.Enabled = true;
                checkBoxPemrograman4.Enabled = true;
                checkBoxFisika.Enabled = false;
                checkBoxPendidikanAgama.Enabled = true;
                checkBoxPendidikanKewarnegaraan.Enabled = false; checkBoxPendidikanKewarnegaraan.Checked = false;
                checkBoxPengantar.Enabled = true;
                checkBoxJaringanKomputer.Enabled = true;
                SistemOperasiCheckBox.Enabled = true;
                checkBoxRantaiPasok.Enabled = true;
            }
        }

        private void radioButtonKurikulumMerdeka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKurikulumMerdeka.Checked)
            {
                checkBoxmatematika.Enabled = false;
                checkBoxPemrograman1.Enabled = true;
                checkBoxPemrograman2.Enabled = true;
                checkBoxPemrograman3.Enabled = true;
                checkBoxPemrograman4.Enabled = true;
                checkBoxFisika.Enabled = false;
                checkBoxPendidikanAgama.Enabled = true;
                checkBoxPendidikanKewarnegaraan.Enabled = true;
                checkBoxPengantar.Enabled = false;
                checkBoxJaringanKomputer.Enabled = true;
                SistemOperasiCheckBox.Enabled = true;
                checkBoxRantaiPasok.Enabled = true;
            }
        }

        private void groupBoxMatakuliahPilihan_EnabledChanged(object sender, EventArgs e)
        {
            if (groupBoxMatakuliahPilihan.Enabled) 
            {
                checkBoxmatematika.Enabled = false;
                checkBoxPemrograman1.Enabled = false;
                checkBoxPemrograman2.Enabled = false;
                checkBoxPemrograman3.Enabled = false;
                checkBoxPemrograman4.Enabled = false;
                checkBoxFisika.Enabled = false;
                checkBoxPendidikanAgama.Enabled = false;
                checkBoxPendidikanKewarnegaraan.Enabled = false;
                checkBoxPengantar.Enabled = false;
                checkBoxJaringanKomputer.Enabled = false;
                SistemOperasiCheckBox.Enabled = false;
                checkBoxRantaiPasok.Enabled = false;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string info = GatherInformation();
                Font messageBoxFont = new Font("Arial", 28);
                MessageBox.Show(
                    info,
                    "Informasi Data Simpan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Harap isi semua informasi dengan benar.",
                    "Informasi Data Simpan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

            private string GatherInformation()
        {
            StringBuilder infoBuilder = new StringBuilder();

            infoBuilder.AppendLine($"NIM: {textBoxNIM.Text}");
            infoBuilder.AppendLine($"Nama: {textBoxNama.Text}");
            string jenisKelamin = radioButtonLakiLaki.Checked ? "Laki-Laki" : (radioButtonPerempuan.Checked ? "Perempuan" : "Belum dipilih");
            infoBuilder.AppendLine($"Jenis Kelamin: {jenisKelamin}");
            infoBuilder.AppendLine($"Alamat: {textBoxAlamat.Text}");
            infoBuilder.AppendLine($"Tahun Akademik: {textBoxTahunAkademik.Text}");
            infoBuilder.AppendLine($"Program Studi: {comboBoxProdi.Text}");
            infoBuilder.AppendLine($"Semester: {textBoxSemester.Text}");
            string kurikulum = GetSelectedKurikulum();
            infoBuilder.AppendLine($"Kurikulum: {kurikulum}");
            string mataKuliahPilihan = GetSelectedMataKuliahPilihan();
            infoBuilder.AppendLine($"Mata Kuliah: {mataKuliahPilihan}");

            return infoBuilder.ToString();
        }

        private string GetSelectedKurikulum()
        {
            if (radioButtonKurikulum2006.Checked)
            {
                return "Kurikulum 2006";
            }
            else if (radioButtonKurikulum2013.Checked)
            {
                return "Kurikulum 2013";
            }
            else if (radioButtonKurikulumMerdeka.Checked)
            {
                return "Kurikulum Merdeka";
            } 

            return "Belum dipilih";
        }

        private string GetSelectedMataKuliahPilihan()
        {
            List<string> selectedCourses = new List<string>();

            if (checkBoxmatematika.Checked)
            {
                selectedCourses.Add("Matematika");
            }

            if (checkBoxPemrograman1.Checked)
            {
                selectedCourses.Add("Pemrograman 1");
            }

            if (checkBoxPemrograman2.Checked)
            {
                selectedCourses.Add("Pemrograman 2");
            }

            if (checkBoxPemrograman3.Checked)
            {
                selectedCourses.Add("Pemrograman 3");
            }

            if (checkBoxPemrograman4.Checked)
            {
                selectedCourses.Add("Pemrograman 4");
            }

            if (checkBoxFisika.Checked)
            {
                selectedCourses.Add("Fisika");
            }

            if (checkBoxPendidikanAgama.Checked)
            {
                selectedCourses.Add("Pendidikan Agama");
            }

            if (checkBoxPendidikanKewarnegaraan.Checked)
            {
                selectedCourses.Add("Pendidikan Kewarnegaraan");
            }

            if (checkBoxPengantar.Checked)
            {
                selectedCourses.Add("Pengantar Logistik");
            }

            if (checkBoxJaringanKomputer.Checked)
            {
                selectedCourses.Add("Jaringan Komputer");
            }

            if (SistemOperasiCheckBox.Checked)
            {
                selectedCourses.Add("Sistem Operasi");
            }

            if (checkBoxRantaiPasok.Checked)
            {
                selectedCourses.Add("Manajemen Rantai Pasok");
            }

            return string.Join(", ", selectedCourses);
        }

        private bool ValidateForm()
        {
            string errorMessage = "";
            return string.IsNullOrEmpty(errorMessage);
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
            }


            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                    "Form Telah direset",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }

            else
            {
                MessageBox.Show(
                     errorMessage,
                     "Informasi Data Submit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning
                     );
            }
        }

        private void labelProdi_Click(object sender, EventArgs e)
        {

        }
    }
}
