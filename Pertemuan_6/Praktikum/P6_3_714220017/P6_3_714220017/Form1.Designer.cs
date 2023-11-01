namespace P6_3_714220017
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HurufLabel = new System.Windows.Forms.Label();
            this.Angkalabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Angka1Angka2label = new System.Windows.Forms.Label();
            this.Angka1label = new System.Windows.Forms.Label();
            this.Angka2label = new System.Windows.Forms.Label();
            this.txtHuruf = new System.Windows.Forms.TextBox();
            this.txtAngka = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // HurufLabel
            // 
            this.HurufLabel.AutoSize = true;
            this.HurufLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HurufLabel.Location = new System.Drawing.Point(172, 37);
            this.HurufLabel.Name = "HurufLabel";
            this.HurufLabel.Size = new System.Drawing.Size(49, 20);
            this.HurufLabel.TabIndex = 0;
            this.HurufLabel.Text = "Huruf";
            // 
            // Angkalabel
            // 
            this.Angkalabel.AutoSize = true;
            this.Angkalabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angkalabel.Location = new System.Drawing.Point(172, 95);
            this.Angkalabel.Name = "Angkalabel";
            this.Angkalabel.Size = new System.Drawing.Size(52, 20);
            this.Angkalabel.TabIndex = 1;
            this.Angkalabel.Text = "Angka";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillabel.Location = new System.Drawing.Point(174, 159);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(50, 18);
            this.Emaillabel.TabIndex = 2;
            this.Emaillabel.Text = "Email";
            // 
            // Angka1Angka2label
            // 
            this.Angka1Angka2label.AutoSize = true;
            this.Angka1Angka2label.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angka1Angka2label.Location = new System.Drawing.Point(172, 215);
            this.Angka1Angka2label.Name = "Angka1Angka2label";
            this.Angka1Angka2label.Size = new System.Drawing.Size(142, 20);
            this.Angka1Angka2label.TabIndex = 3;
            this.Angka1Angka2label.Text = "*Angka1 > Angka 2";
            // 
            // Angka1label
            // 
            this.Angka1label.AutoSize = true;
            this.Angka1label.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angka1label.Location = new System.Drawing.Point(173, 278);
            this.Angka1label.Name = "Angka1label";
            this.Angka1label.Size = new System.Drawing.Size(66, 20);
            this.Angka1label.TabIndex = 4;
            this.Angka1label.Text = "Angka 1";
            // 
            // Angka2label
            // 
            this.Angka2label.AutoSize = true;
            this.Angka2label.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Angka2label.Location = new System.Drawing.Point(173, 344);
            this.Angka2label.Name = "Angka2label";
            this.Angka2label.Size = new System.Drawing.Size(66, 20);
            this.Angka2label.TabIndex = 5;
            this.Angka2label.Text = "Angka 2";
            // 
            // txtHuruf
            // 
            this.txtHuruf.Location = new System.Drawing.Point(499, 37);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(523, 22);
            this.txtHuruf.TabIndex = 6;
            this.txtHuruf.TextChanged += new System.EventHandler(this.txtHuruf_TextChanged);
            this.txtHuruf.Leave += new System.EventHandler(this.txtHuruf_Leave);
            // 
            // txtAngka
            // 
            this.txtAngka.Location = new System.Drawing.Point(499, 93);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(523, 22);
            this.txtAngka.TabIndex = 7;
            this.txtAngka.Leave += new System.EventHandler(this.txtAngka_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(499, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(516, 22);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(499, 278);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(516, 22);
            this.txtAngka1.TabIndex = 9;
            this.txtAngka1.TextChanged += new System.EventHandler(this.txtAngka1_TextChanged);
            this.txtAngka1.Leave += new System.EventHandler(this.txtAngka1_Leave);
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(499, 344);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(516, 22);
            this.txtAngka2.TabIndex = 10;
            this.txtAngka2.TextChanged += new System.EventHandler(this.txtAngka2_TextChanged);
            this.txtAngka2.Leave += new System.EventHandler(this.txtAngka2_Leave);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 472);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Controls.Add(this.Angka2label);
            this.Controls.Add(this.Angka1label);
            this.Controls.Add(this.Angka1Angka2label);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Angkalabel);
            this.Controls.Add(this.HurufLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HurufLabel;
        private System.Windows.Forms.Label Angkalabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Angka1Angka2label;
        private System.Windows.Forms.Label Angka1label;
        private System.Windows.Forms.Label Angka2label;
        private System.Windows.Forms.TextBox txtHuruf;
        private System.Windows.Forms.TextBox txtAngka;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

