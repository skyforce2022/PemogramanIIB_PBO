﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_714220017
{
    public partial class ChildForm : Form
    {
        private string outputText;
        internal ParentForm MidParent;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void OutputGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }

        private void DateOption_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }
    }
}
