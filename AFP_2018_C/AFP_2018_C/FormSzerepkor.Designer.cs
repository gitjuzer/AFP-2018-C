namespace AFP_2018_C
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
            this.buttonSzerepkorTanulo = new System.Windows.Forms.Button();
            this.buttonSzerepkorTanar = new System.Windows.Forms.Button();
            this.buttonSzerepkorSzulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSzerepkorTanulo
            // 
            this.buttonSzerepkorTanulo.Location = new System.Drawing.Point(109, 373);
            this.buttonSzerepkorTanulo.Name = "buttonSzerepkorTanulo";
            this.buttonSzerepkorTanulo.Size = new System.Drawing.Size(75, 23);
            this.buttonSzerepkorTanulo.TabIndex = 0;
            this.buttonSzerepkorTanulo.Text = "Tanuló";
            this.buttonSzerepkorTanulo.UseVisualStyleBackColor = true;
            // 
            // buttonSzerepkorTanar
            // 
            this.buttonSzerepkorTanar.Location = new System.Drawing.Point(354, 373);
            this.buttonSzerepkorTanar.Name = "buttonSzerepkorTanar";
            this.buttonSzerepkorTanar.Size = new System.Drawing.Size(75, 23);
            this.buttonSzerepkorTanar.TabIndex = 1;
            this.buttonSzerepkorTanar.Text = "Tanár";
            this.buttonSzerepkorTanar.UseVisualStyleBackColor = true;
            // 
            // buttonSzerepkorSzulo
            // 
            this.buttonSzerepkorSzulo.Location = new System.Drawing.Point(607, 373);
            this.buttonSzerepkorSzulo.Name = "buttonSzerepkorSzulo";
            this.buttonSzerepkorSzulo.Size = new System.Drawing.Size(75, 23);
            this.buttonSzerepkorSzulo.TabIndex = 2;
            this.buttonSzerepkorSzulo.Text = "Szülő";
            this.buttonSzerepkorSzulo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(272, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Válassz szerepkört!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 286);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormSzerepkor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSzerepkorSzulo);
            this.Controls.Add(this.buttonSzerepkorTanar);
            this.Controls.Add(this.buttonSzerepkorTanulo);
            this.Name = "FormSzerepkor";
            this.Text = "Játékos tanulás";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSzerepkorTanulo;
        private System.Windows.Forms.Button buttonSzerepkorTanar;
        private System.Windows.Forms.Button buttonSzerepkorSzulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

