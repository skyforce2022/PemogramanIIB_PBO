using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714220017
{
    public partial class ReservationTicketAirline : Form
    {
        private bool valid;

        public ReservationTicketAirline()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTampilkan_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Validasi berhasil, lanjutkan untuk menghasilkan tiket pesawat
                string tiketPesawat = $"Tiket Pesawat\n" +
                $"Nama: {ReservasiNamaForm.Text}\n" +
                $"Dari: {DariForm.Text}\n" +
                $"Ke: {KeForm.Text}\n" +
                $"Tanggal: {TanggalDate.Text}\n" +
                $"Total Penumpang: {comboBoxtotal.Text}\n" +
                $"Kelas: {comboBoxKelas.Text}";

                // Tampilkan pesan informasi bahwa tiket berhasil dibuat
                MessageBox.Show("Tiket pesawat berhasil dibuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tampilkan tiket pesawat
                MessageBox.Show(tiketPesawat, "Tiket Pesawat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidateForm()
        {
            bool valid = true;

            // Validasi Numeric Textbox
            if (!IsNumeric(comboBoxtotal.Text))
            {
                MessageBox.Show("Total Penumpang harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            // Validasi Char Textbox (mengizinkan karakter apa pun termasuk huruf besar/kecil, spasi, dan simbol)
            if (!IsValidName(ReservasiNamaForm.Text))
            {
                MessageBox.Show("Nama hanya boleh mengandung huruf dan spasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            // Required Validator
            if (string.IsNullOrWhiteSpace(DariForm.Text) || string.IsNullOrWhiteSpace(KeForm.Text) || string.IsNullOrWhiteSpace(TanggalDate.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            // Regex Validator (Format tanggal)
            if (!IsValidDate(TanggalDate.Text))
            {
                MessageBox.Show("Format tanggal tidak valid. Gunakan format YYYY-MM-DD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            // Comparison (Total Penumpang harus lebih dari 0)
            if (!IsGreaterThanZero(comboBoxtotal.Text))
            {
                MessageBox.Show("Total Penumpang harus lebih dari 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            if (ReservasiNamaForm.Text.Length < 2)
            {
                MessageBox.Show("Nama harus memiliki setidaknya 2 karakter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            // Upper Case Textbox
            if (!IsUpperCase(comboBoxKelas.Text))
            {
                MessageBox.Show("Kelas harus ditulis dengan huruf besar dan kecil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }


            // Lower Case Textbox (mengizinkan huruf besar dan kecil)
            if (!IsLowerCase(DariForm.Text) || !IsLowerCase(KeForm.Text))
            {
                MessageBox.Show("Rute keberangkatan dan rute kedatangan harus ditulis dengan huruf besar dan kecil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = true;
            }

            return valid;
        }
        private bool IsNumeric(string text)
        {
            return int.TryParse(text, out _);
        }

        private bool IsValidName(string text)
        {
            // Menggunakan ekspresi reguler untuk validasi nama yang mengizinkan berbagai karakter
            return Regex.IsMatch(text, @"^[\p{L}0-9\s\p{P}]+$");
        }
        private bool IsAlpha(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter);
        }

        private bool IsValidDate(string text)
        {
            return DateTime.TryParse(text, out _);
        }

        private bool IsGreaterThanZero(string text)
        {
            return int.TryParse(text, out int number) && number > 0;
        }

        private bool IsUpperCase(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && text.All(char.IsUpper);

        }

        private bool IsLowerCase(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && text.All(char.IsLower);
        }

        private void ReservasiNamaForm_Leave(object sender, EventArgs e)
        {
            if (ReservasiNamaForm.Text == "")
            {
                EpWarningForm.SetError(ReservasiNamaForm, "");
                EpWrongForm.SetError(ReservasiNamaForm, "Reservasi nama tidak boleh kosong!");
                EpCorrectForm.SetError(ReservasiNamaForm, "");
            }
            else
            {

                if ((ReservasiNamaForm.Text).All(Char.IsLetter))
                {
                    EpWarningForm.SetError(ReservasiNamaForm, "");
                    EpWrongForm.SetError(ReservasiNamaForm, "");
                    EpCorrectForm.SetError(ReservasiNamaForm, "");
                }
                else
                {
                    EpWrongForm.SetError(ReservasiNamaForm, "");
                    EpWarningForm.SetError(ReservasiNamaForm, "");
                    EpCorrectForm.SetError(ReservasiNamaForm, "Inputan");

                }
            }
        }

        private void DariForm_Leave(object sender, EventArgs e)
        {

            if (DariForm.Text == "")
            {
                EpWarningForm.SetError(DariForm, "Input Rute Dari tidak boleh kosong!");
                EpWrongForm.SetError(DariForm, "");
                EpCorrectForm.SetError(DariForm, "");
            }
            else
            {
                if ((DariForm.Text).All(Char.IsLetter))
                {
                    EpWarningForm.SetError(DariForm, "");
                    EpWrongForm.SetError(DariForm, "inputan tidak ada");
                    EpCorrectForm.SetError(DariForm, "");
                }
                else
                {
                    EpWarningForm.SetError(DariForm, "");
                    EpWrongForm.SetError(DariForm, "");
                    EpCorrectForm.SetError(DariForm, "Input rute keberangkatan!");
                }
            }
        }

        private void KeForm_Leave(object sender, EventArgs e)
        {
            if (KeForm.Text == "")
            {
                EpWarningForm.SetError(KeForm, "");
                EpWrongForm.SetError(KeForm, "Input Rute Dari tidak boleh kosong!");
                EpCorrectForm.SetError(KeForm, "");
            }
            else
            {
                if ((KeForm.Text).All(Char.IsLetter))
                {
                    EpWarningForm.SetError(KeForm, "");
                    EpWrongForm.SetError(KeForm, "");
                    EpCorrectForm.SetError(KeForm, "Betul");
                }
                else
                {
                    EpWarningForm.SetError(KeForm, "");
                    EpWrongForm.SetError(KeForm, "");
                    EpCorrectForm.SetError(KeForm, "Input rute kedatangan!");
                }
            }
        }

        private void TanggalDate_Leave(object sender, EventArgs e)
        {
            if (!IsValidDate(TanggalDate.Text))
            {
                EpWarningForm.SetError(TanggalDate, "Format tanggal tidak valid. Gunakan format YYYY-MM-DD.");
                EpWrongForm.SetError(TanggalDate, "");
                EpCorrectForm.SetError(TanggalDate, "");
            }
            else
            {
                EpWarningForm.SetError(TanggalDate, "");
                EpWrongForm.SetError(TanggalDate, "");
                EpCorrectForm.SetError(TanggalDate, "Betul");
            }
        }

        private void comboBoxtotal_Leave(object sender, EventArgs e)
        {
            EpWarningForm.SetError(comboBoxtotal, "");
            EpWrongForm.SetError(comboBoxtotal, "");
            EpCorrectForm.SetError(comboBoxtotal, "");

            if (string.IsNullOrWhiteSpace(comboBoxtotal.Text))
            {
                EpCorrectForm.SetError(comboBoxtotal, "Betul");
            }
            else if (!IsNumeric(comboBoxtotal.Text))
            {
                EpWarningForm.SetError(comboBoxtotal, "Total Penumpang harus berupa angka.");
            }
            else
            {
                int totalPenumpang;
                if (int.TryParse(comboBoxtotal.Text, out totalPenumpang) && totalPenumpang > 0)
                {
                    EpCorrectForm.SetError(comboBoxtotal, "Betul");
                }
                else
                {
                    EpWrongForm.SetError(comboBoxtotal, "Total Penumpang harus lebih dari 0.");
                    EpWarningForm.SetError(comboBoxtotal, "Total Penumpang tidak valid.");
                }
            }
        }
        private void comboBoxKelas_Leave(object sender, EventArgs e)
        {
            EpWarningForm.SetError(comboBoxKelas, "");
            EpWrongForm.SetError(comboBoxKelas, "");
            EpCorrectForm.SetError(comboBoxKelas, "");

            if (string.IsNullOrWhiteSpace(comboBoxKelas.Text))
            {
                EpCorrectForm.SetError(comboBoxKelas, "Betul");
            }
            else if (IsValidName(comboBoxKelas.Text))
            {
                EpCorrectForm.SetError(comboBoxKelas, "Betul");
            }
            else
            {
                EpWrongForm.SetError(comboBoxKelas, "Kelas hanya boleh mengandung huruf, simbol, dan angka.");
                EpWarningForm.SetError(comboBoxKelas, "Kelas harus diisi.");
            }
        }

        private void SelesaiButton_Leave(object sender, EventArgs e)
        {
            this.Close();
            ReservasiNamaForm.Text = "";
            DariForm.Text = "";
            KeForm.Text = "";
            TanggalDate.Text = "";
            comboBoxtotal.Text = "";
            comboBoxKelas.Text = "";
        }

        private void ReservationTicketlabel_Click(object sender, EventArgs e)
        {

        }
    }
}

