namespace AFP_2018_C
{
    partial class FormTanuloMatek
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
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.questionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Controls.Add(this.questionLabel);
            this.questionBox.Location = new System.Drawing.Point(13, 13);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(775, 262);
            this.questionBox.TabIndex = 0;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Kérdés";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(3, 16);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(51, 20);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "label1";
            // 
            // answerButton1
            // 
            this.answerButton1.Location = new System.Drawing.Point(13, 313);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(373, 47);
            this.answerButton1.TabIndex = 1;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = true;
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(404, 313);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(384, 47);
            this.answerButton2.TabIndex = 2;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = true;
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(209, 379);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(373, 47);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.Text = "button4";
            this.answerButton3.UseVisualStyleBackColor = true;
            // 
            // FormTanuloMatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.Controls.Add(this.questionBox);
            this.Name = "FormTanuloMatek";
            this.Text = "FormTanuloMatek";
            this.questionBox.ResumeLayout(false);
            this.questionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
    }
}