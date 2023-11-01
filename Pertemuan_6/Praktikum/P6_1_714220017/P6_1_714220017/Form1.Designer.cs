namespace P6_1_714220017
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
            this.VisualBasic1label = new System.Windows.Forms.Label();
            this.vbButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisualBasic1label
            // 
            this.VisualBasic1label.AutoSize = true;
            this.VisualBasic1label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualBasic1label.Location = new System.Drawing.Point(474, 52);
            this.VisualBasic1label.Name = "VisualBasic1label";
            this.VisualBasic1label.Size = new System.Drawing.Size(459, 26);
            this.VisualBasic1label.TabIndex = 0;
            this.VisualBasic1label.Text = "Which do you think is better, Visual Basic or C#";
            this.VisualBasic1label.Click += new System.EventHandler(this.VisualBasic1label_Click);
            // 
            // vbButton
            // 
            this.vbButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton.ForeColor = System.Drawing.Color.Lime;
            this.vbButton.Location = new System.Drawing.Point(443, 246);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(117, 31);
            this.vbButton.TabIndex = 1;
            this.vbButton.Text = "Visual Basic";
            this.vbButton.UseVisualStyleBackColor = true;
            this.vbButton.Click += new System.EventHandler(this.vbButton_Click);
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // csButton
            // 
            this.csButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton.Location = new System.Drawing.Point(826, 246);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(123, 31);
            this.csButton.TabIndex = 2;
            this.csButton.Text = "C#";
            this.csButton.UseVisualStyleBackColor = true;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(327, 354);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(111, 31);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.vbButton);
            this.Controls.Add(this.VisualBasic1label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VisualBasic1label;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
    }
}

