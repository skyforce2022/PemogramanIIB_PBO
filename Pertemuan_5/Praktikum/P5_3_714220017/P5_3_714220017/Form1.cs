using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714220017
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string status;

        public Form()
        {
            InitializeComponent();
        }

        private void MerkHp_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";

            if (rb_android.Checked ==  true) 
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true) 
            {
                os = "iOS";
            }

            if (cbYa.Checked == true) 
            {
                status = "Ya, Sudah diperbaiki";
            }

             MessageBox.Show ("Merk HP: " + txtMerkHP.Text + "\n Sistem Operasi : " + os + "\nStatus Perbaikan : " + status, "Informasi Service Hp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
