﻿namespace P5_3_714220017
{
    partial class Form
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
            this.MerkHp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_ios = new System.Windows.Forms.RadioButton();
            this.cbYa = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MerkHp
            // 
            this.MerkHp.AutoSize = true;
            this.MerkHp.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MerkHp.Location = new System.Drawing.Point(16, 25);
            this.MerkHp.Name = "MerkHp";
            this.MerkHp.Size = new System.Drawing.Size(77, 23);
            this.MerkHp.TabIndex = 0;
            this.MerkHp.Text = "Merk HP";
            this.MerkHp.Click += new System.EventHandler(this.MerkHp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "OS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sudah Diperbaiki?";
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkHP.Location = new System.Drawing.Point(166, 25);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(344, 27);
            this.txtMerkHP.TabIndex = 3;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(209, 120);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(75, 20);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_ios
            // 
            this.rb_ios.AutoSize = true;
            this.rb_ios.Location = new System.Drawing.Point(365, 120);
            this.rb_ios.Name = "rb_ios";
            this.rb_ios.Size = new System.Drawing.Size(50, 20);
            this.rb_ios.TabIndex = 5;
            this.rb_ios.TabStop = true;
            this.rb_ios.Text = "iOS";
            this.rb_ios.UseVisualStyleBackColor = true;
            // 
            // cbYa
            // 
            this.cbYa.AutoSize = true;
            this.cbYa.Location = new System.Drawing.Point(209, 216);
            this.cbYa.Name = "cbYa";
            this.cbYa.Size = new System.Drawing.Size(46, 20);
            this.cbYa.TabIndex = 6;
            this.cbYa.Text = "Ya";
            this.cbYa.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(150, 316);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(94, 29);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(435, 316);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(88, 29);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(677, 369);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cbYa);
            this.Controls.Add(this.rb_ios);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MerkHp);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MerkHp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton rb_ios;
        private System.Windows.Forms.CheckBox cbYa;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

