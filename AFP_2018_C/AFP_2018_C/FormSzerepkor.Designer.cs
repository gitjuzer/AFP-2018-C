﻿namespace AFP_2018_C
{
    partial class FormSzerepkor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSzerepkor));
            this.buttonSzerepkorTanulo = new System.Windows.Forms.Button();
            this.buttonSzerepkorTanar = new System.Windows.Forms.Button();
            this.buttonSzerepkorSzulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_kilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSzerepkorTanulo
            // 
            this.buttonSzerepkorTanulo.Location = new System.Drawing.Point(12, 300);
            this.buttonSzerepkorTanulo.Name = "buttonSzerepkorTanulo";
            this.buttonSzerepkorTanulo.Size = new System.Drawing.Size(100, 35);
            this.buttonSzerepkorTanulo.TabIndex = 0;
            this.buttonSzerepkorTanulo.Text = "Tanuló";
            this.buttonSzerepkorTanulo.UseVisualStyleBackColor = true;
            this.buttonSzerepkorTanulo.Click += new System.EventHandler(this.buttonSzerepkorTanulo_Click);
            // 
            // buttonSzerepkorTanar
            // 
            this.buttonSzerepkorTanar.Location = new System.Drawing.Point(280, 300);
            this.buttonSzerepkorTanar.Name = "buttonSzerepkorTanar";
            this.buttonSzerepkorTanar.Size = new System.Drawing.Size(100, 35);
            this.buttonSzerepkorTanar.TabIndex = 1;
            this.buttonSzerepkorTanar.Text = "Tanár";
            this.buttonSzerepkorTanar.UseVisualStyleBackColor = true;
            this.buttonSzerepkorTanar.Click += new System.EventHandler(this.buttonSzerepkorTanar_Click);
            // 
            // buttonSzerepkorSzulo
            // 
            this.buttonSzerepkorSzulo.Location = new System.Drawing.Point(526, 300);
            this.buttonSzerepkorSzulo.Name = "buttonSzerepkorSzulo";
            this.buttonSzerepkorSzulo.Size = new System.Drawing.Size(100, 35);
            this.buttonSzerepkorSzulo.TabIndex = 2;
            this.buttonSzerepkorSzulo.Text = "Szülő";
            this.buttonSzerepkorSzulo.UseVisualStyleBackColor = true;
            this.buttonSzerepkorSzulo.Click += new System.EventHandler(this.buttonSzerepkorSzulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(203, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Válassz szerepkört!";
            // 
            // button_kilepes
            // 
            this.button_kilepes.Location = new System.Drawing.Point(10, 11);
            this.button_kilepes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_kilepes.Name = "button_kilepes";
            this.button_kilepes.Size = new System.Drawing.Size(100, 35);
            this.button_kilepes.TabIndex = 4;
            this.button_kilepes.Text = "Kilépés";
            this.button_kilepes.UseVisualStyleBackColor = true;
            this.button_kilepes.Click += new System.EventHandler(this.button_kilepes_Click);
            // 
            // FormSzerepkor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 363);
            this.Controls.Add(this.button_kilepes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSzerepkorSzulo);
            this.Controls.Add(this.buttonSzerepkorTanar);
            this.Controls.Add(this.buttonSzerepkorTanulo);
            this.Name = "FormSzerepkor";
            this.Text = "Játékos tanulás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSzerepkorTanulo;
        private System.Windows.Forms.Button buttonSzerepkorTanar;
        private System.Windows.Forms.Button buttonSzerepkorSzulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kilepes;
    }
}

