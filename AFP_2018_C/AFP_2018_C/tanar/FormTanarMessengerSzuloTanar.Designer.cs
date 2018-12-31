namespace AFP_2018_C
{
    partial class FormTanarMessengerSzuloTanar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTanarMessengerSzuloTanar));
            this.Messenger = new System.Windows.Forms.Label();
            this.Chat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Szoveg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Messenger
            // 
            this.Messenger.AutoSize = true;
            this.Messenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Messenger.Location = new System.Drawing.Point(35, 28);
            this.Messenger.Name = "Messenger";
            this.Messenger.Size = new System.Drawing.Size(79, 16);
            this.Messenger.TabIndex = 12;
            this.Messenger.Text = "Messenger:";
            // 
            // Chat
            // 
            this.Chat.FormattingEnabled = true;
            this.Chat.Location = new System.Drawing.Point(38, 56);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(391, 173);
            this.Chat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(35, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Üzeneted:";
            // 
            // Szoveg
            // 
            this.Szoveg.Location = new System.Drawing.Point(38, 273);
            this.Szoveg.Name = "Szoveg";
            this.Szoveg.Size = new System.Drawing.Size(391, 20);
            this.Szoveg.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Küldés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(38, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Vissza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTanarMessengerSzuloTanar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Szoveg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.Messenger);
            this.Name = "FormTanarMessengerSzuloTanar";
            this.Text = "Szülő - Tanár szoba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Messenger;
        private System.Windows.Forms.ListBox Chat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Szoveg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}