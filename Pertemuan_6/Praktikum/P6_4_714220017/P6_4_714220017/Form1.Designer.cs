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
            this.ReservationTicketlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReservationTicketlabel
            // 
            this.ReservationTicketlabel.AutoSize = true;
            this.ReservationTicketlabel.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationTicketlabel.Location = new System.Drawing.Point(682, 9);
            this.ReservationTicketlabel.Name = "ReservationTicketlabel";
            this.ReservationTicketlabel.Size = new System.Drawing.Size(332, 28);
            this.ReservationTicketlabel.TabIndex = 0;
            this.ReservationTicketlabel.Text = "Form Reservasi Tiket Pesawat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // ReservationTicketAirline
            // 
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1913, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReservationTicketlabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReservationTicketAirline";
            this.Text = "Reservasi Tiket Pesawat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReservationTicketlabel;
        private System.Windows.Forms.Label label1;
    }
}

