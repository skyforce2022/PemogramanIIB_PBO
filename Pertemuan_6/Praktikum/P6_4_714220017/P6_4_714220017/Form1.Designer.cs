namespace P6_4_714220017
{
    partial class ReservationTicketAirline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationTicketAirline));
            this.ReservationTicketlabel = new System.Windows.Forms.Label();
            this.NamaForm = new System.Windows.Forms.Label();
            this.RouteForm = new System.Windows.Forms.Label();
            this.ReservasiNamaForm = new System.Windows.Forms.TextBox();
            this.DariForm = new System.Windows.Forms.ComboBox();
            this.KeForm = new System.Windows.Forms.ComboBox();
            this.KeberangkatanForm = new System.Windows.Forms.Label();
            this.TanggalDate = new System.Windows.Forms.DateTimePicker();
            this.Totalform = new System.Windows.Forms.Label();
            this.comboBoxtotal = new System.Windows.Forms.ComboBox();
            this.KelasForm = new System.Windows.Forms.Label();
            this.comboBoxKelas = new System.Windows.Forms.ComboBox();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.SelesaiButton = new System.Windows.Forms.Button();
            this.EpWarningForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.EpWrongForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.EpCorrectForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EpWarningForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpWrongForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpCorrectForm)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationTicketlabel
            // 
            this.ReservationTicketlabel.AutoSize = true;
            this.ReservationTicketlabel.BackColor = System.Drawing.Color.Transparent;
            this.ReservationTicketlabel.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationTicketlabel.Location = new System.Drawing.Point(663, 9);
            this.ReservationTicketlabel.Name = "ReservationTicketlabel";
            this.ReservationTicketlabel.Size = new System.Drawing.Size(332, 28);
            this.ReservationTicketlabel.TabIndex = 0;
            this.ReservationTicketlabel.Text = "Form Reservasi Tiket Pesawat";
            this.ReservationTicketlabel.Click += new System.EventHandler(this.ReservationTicketlabel_Click);
            // 
            // NamaForm
            // 
            this.NamaForm.AutoSize = true;
            this.NamaForm.BackColor = System.Drawing.Color.Transparent;
            this.NamaForm.Location = new System.Drawing.Point(154, 97);
            this.NamaForm.Name = "NamaForm";
            this.NamaForm.Size = new System.Drawing.Size(133, 23);
            this.NamaForm.TabIndex = 1;
            this.NamaForm.Text = "Nama Reservasi";
            this.NamaForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // RouteForm
            // 
            this.RouteForm.AutoSize = true;
            this.RouteForm.BackColor = System.Drawing.Color.Transparent;
            this.RouteForm.Location = new System.Drawing.Point(154, 161);
            this.RouteForm.Name = "RouteForm";
            this.RouteForm.Size = new System.Drawing.Size(47, 23);
            this.RouteForm.TabIndex = 2;
            this.RouteForm.Text = "Rute";
            // 
            // ReservasiNamaForm
            // 
            this.ReservasiNamaForm.Location = new System.Drawing.Point(394, 97);
            this.ReservasiNamaForm.Name = "ReservasiNamaForm";
            this.ReservasiNamaForm.Size = new System.Drawing.Size(928, 27);
            this.ReservasiNamaForm.TabIndex = 3;
            this.ReservasiNamaForm.Leave += new System.EventHandler(this.ReservasiNamaForm_Leave);
            // 
            // DariForm
            // 
            this.DariForm.FormattingEnabled = true;
            this.DariForm.Items.AddRange(new object[] {
            "Jakarta (CGK)",
            "Palembang (PLM)",
            "Bandung/Kertajati (KJT)",
            "Surabaya (SUB)",
            "Medan (KNO)"});
            this.DariForm.Location = new System.Drawing.Point(394, 161);
            this.DariForm.Name = "DariForm";
            this.DariForm.Size = new System.Drawing.Size(928, 31);
            this.DariForm.TabIndex = 4;
            this.DariForm.Text = "-------------------------------------------------------------------Dari----------" +
    "-------------------------------------------------------------------";
            this.DariForm.Leave += new System.EventHandler(this.DariForm_Leave);
            // 
            // KeForm
            // 
            this.KeForm.FormattingEnabled = true;
            this.KeForm.Items.AddRange(new object[] {
            "Jakarta (CGK)",
            "Palembang (PLM)",
            "Bandung/Kertajati (KJT)",
            "Surabaya (SUB)",
            "Medan (KNO)"});
            this.KeForm.Location = new System.Drawing.Point(394, 231);
            this.KeForm.Name = "KeForm";
            this.KeForm.Size = new System.Drawing.Size(928, 31);
            this.KeForm.TabIndex = 5;
            this.KeForm.Text = "------------------------------------------------Ke-------------------------------" +
    "--------------------------------------------------------------------------------" +
    "--------------------";
            this.KeForm.Leave += new System.EventHandler(this.KeForm_Leave);
            // 
            // KeberangkatanForm
            // 
            this.KeberangkatanForm.AutoSize = true;
            this.KeberangkatanForm.BackColor = System.Drawing.Color.Transparent;
            this.KeberangkatanForm.Location = new System.Drawing.Point(154, 311);
            this.KeberangkatanForm.Name = "KeberangkatanForm";
            this.KeberangkatanForm.Size = new System.Drawing.Size(128, 23);
            this.KeberangkatanForm.TabIndex = 8;
            this.KeberangkatanForm.Text = "Keberangkatan";
            // 
            // TanggalDate
            // 
            this.TanggalDate.Location = new System.Drawing.Point(394, 311);
            this.TanggalDate.Name = "TanggalDate";
            this.TanggalDate.Size = new System.Drawing.Size(928, 27);
            this.TanggalDate.TabIndex = 9;
            this.TanggalDate.Leave += new System.EventHandler(this.TanggalDate_Leave);
            // 
            // Totalform
            // 
            this.Totalform.AutoSize = true;
            this.Totalform.BackColor = System.Drawing.Color.Transparent;
            this.Totalform.Location = new System.Drawing.Point(154, 401);
            this.Totalform.Name = "Totalform";
            this.Totalform.Size = new System.Drawing.Size(146, 23);
            this.Totalform.TabIndex = 10;
            this.Totalform.Text = "Total Penumpang";
            // 
            // comboBoxtotal
            // 
            this.comboBoxtotal.FormattingEnabled = true;
            this.comboBoxtotal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxtotal.Location = new System.Drawing.Point(394, 401);
            this.comboBoxtotal.Name = "comboBoxtotal";
            this.comboBoxtotal.Size = new System.Drawing.Size(928, 31);
            this.comboBoxtotal.TabIndex = 11;
            this.comboBoxtotal.Leave += new System.EventHandler(this.comboBoxtotal_Leave);
            // 
            // KelasForm
            // 
            this.KelasForm.AutoSize = true;
            this.KelasForm.BackColor = System.Drawing.Color.Transparent;
            this.KelasForm.Location = new System.Drawing.Point(154, 471);
            this.KelasForm.Name = "KelasForm";
            this.KelasForm.Size = new System.Drawing.Size(52, 23);
            this.KelasForm.TabIndex = 12;
            this.KelasForm.Text = "Kelas";
            // 
            // comboBoxKelas
            // 
            this.comboBoxKelas.FormattingEnabled = true;
            this.comboBoxKelas.Items.AddRange(new object[] {
            "EXECUTIVE ClASS",
            "BUSSINESS CLASS",
            "PREMIUM ECONOMY CLASS",
            "ECONOMY CLASS"});
            this.comboBoxKelas.Location = new System.Drawing.Point(394, 471);
            this.comboBoxKelas.Name = "comboBoxKelas";
            this.comboBoxKelas.Size = new System.Drawing.Size(928, 31);
            this.comboBoxKelas.TabIndex = 13;
            this.comboBoxKelas.Leave += new System.EventHandler(this.comboBoxKelas_Leave);
            // 
            // buttonTampilkan
            // 
            this.buttonTampilkan.BackColor = System.Drawing.Color.White;
            this.buttonTampilkan.Location = new System.Drawing.Point(561, 614);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(128, 32);
            this.buttonTampilkan.TabIndex = 14;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = false;
            this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
            // 
            // SelesaiButton
            // 
            this.SelesaiButton.Location = new System.Drawing.Point(1022, 614);
            this.SelesaiButton.Name = "SelesaiButton";
            this.SelesaiButton.Size = new System.Drawing.Size(119, 32);
            this.SelesaiButton.TabIndex = 15;
            this.SelesaiButton.Text = "Selesai";
            this.SelesaiButton.UseVisualStyleBackColor = true;
            this.SelesaiButton.Leave += new System.EventHandler(this.SelesaiButton_Leave);
            // 
            // EpWarningForm
            // 
            this.EpWarningForm.ContainerControl = this;
            this.EpWarningForm.Icon = ((System.Drawing.Icon)(resources.GetObject("EpWarningForm.Icon")));
            // 
            // EpWrongForm
            // 
            this.EpWrongForm.ContainerControl = this;
            this.EpWrongForm.Icon = ((System.Drawing.Icon)(resources.GetObject("EpWrongForm.Icon")));
            // 
            // EpCorrectForm
            // 
            this.EpCorrectForm.ContainerControl = this;
            this.EpCorrectForm.Icon = ((System.Drawing.Icon)(resources.GetObject("EpCorrectForm.Icon")));
            // 
            // ReservationTicketAirline
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::P6_4_714220017.Properties.Resources.Parked_planes_cover_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1913, 730);
            this.Controls.Add(this.SelesaiButton);
            this.Controls.Add(this.buttonTampilkan);
            this.Controls.Add(this.comboBoxKelas);
            this.Controls.Add(this.KelasForm);
            this.Controls.Add(this.comboBoxtotal);
            this.Controls.Add(this.Totalform);
            this.Controls.Add(this.TanggalDate);
            this.Controls.Add(this.KeberangkatanForm);
            this.Controls.Add(this.KeForm);
            this.Controls.Add(this.DariForm);
            this.Controls.Add(this.ReservasiNamaForm);
            this.Controls.Add(this.RouteForm);
            this.Controls.Add(this.NamaForm);
            this.Controls.Add(this.ReservationTicketlabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReservationTicketAirline";
            this.Text = "Reservasi Tiket Pesawat";
            ((System.ComponentModel.ISupportInitialize)(this.EpWarningForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpWrongForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpCorrectForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReservationTicketlabel;
        private System.Windows.Forms.Label NamaForm;
        private System.Windows.Forms.Label RouteForm;
        private System.Windows.Forms.TextBox ReservasiNamaForm;
        private System.Windows.Forms.ComboBox DariForm;
        private System.Windows.Forms.ComboBox KeForm;
        private System.Windows.Forms.Label KeberangkatanForm;
        private System.Windows.Forms.DateTimePicker TanggalDate;
        private System.Windows.Forms.Label Totalform;
        private System.Windows.Forms.ComboBox comboBoxtotal;
        private System.Windows.Forms.Label KelasForm;
        private System.Windows.Forms.ComboBox comboBoxKelas;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.Button SelesaiButton;
        private System.Windows.Forms.ErrorProvider EpWarningForm;
        private System.Windows.Forms.ErrorProvider EpWrongForm;
        private System.Windows.Forms.ErrorProvider EpCorrectForm;
    }
}

