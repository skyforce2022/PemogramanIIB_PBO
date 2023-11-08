using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714220017
{
    public partial class Form1 : Form
    {
        private string errorMessage;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1203, 323);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cekbutton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(NamaForm.Text)) 
            {
              errorMessage += "Nama Belum diisi\n";
            }

            if (string.IsNullOrWhiteSpace(ProdiForm.Text))
            {
                errorMessage += "Prodi Belum diisi\n";
            }

            else if (!Regex.IsMatch(ProdiForm.Text, @"^[A-Za-z0-9]+-[A-Za-z0-9]+$"))
            {
                errorMessage += "Prodi harus berformat {Strata}-{Prodi}\n";
            }

            if (string.IsNullOrWhiteSpace(KelasForm.Text))
            {
                errorMessage += "Kelas Belum diisi\n";
            }

            if (string.IsNullOrEmpty(errorMessage)) 
            {
                MessageBox.Show(
                    "Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK,MessageBoxIcon.Information
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

        private void SeninradioButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeninradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SeninradioButton.Checked) 
            {
                KuliahcheckBox.Enabled = true; KuliahcheckBox.Enabled = true;
                TravellingcheckBox.Enabled = false; TravellingcheckBox.Enabled = false;
                TidurcheckBox.Enabled = true; TidurcheckBox.Enabled = false;
            }
        }

        private void MingguradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MingguradioButton.Checked)
            {
                KuliahcheckBox.Enabled = false;
                TravellingcheckBox.Enabled = true;
                TidurcheckBox.Enabled = true;
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            //NamaForm.Text = null;
            //ProdiForm.Text = null;
            //KelasForm.Text = null;

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

            this.Size = new Size(1203, 323);
        }
    }
}
