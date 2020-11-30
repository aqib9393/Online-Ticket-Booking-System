namespace Ticket
{
    partial class FlightForm
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
            this.TavelForeign = new System.Windows.Forms.Button();
            this.TravelPakistan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TavelForeign
            // 
            this.TavelForeign.BackColor = System.Drawing.SystemColors.MenuText;
            this.TavelForeign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TavelForeign.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TavelForeign.Location = new System.Drawing.Point(479, 279);
            this.TavelForeign.Name = "TavelForeign";
            this.TavelForeign.Size = new System.Drawing.Size(258, 55);
            this.TavelForeign.TabIndex = 10;
            this.TavelForeign.Text = "Travel In Foreign ";
            this.TavelForeign.UseVisualStyleBackColor = false;
            this.TavelForeign.Click += new System.EventHandler(this.TavelForeign_Click);
            // 
            // TravelPakistan
            // 
            this.TravelPakistan.BackColor = System.Drawing.SystemColors.InfoText;
            this.TravelPakistan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelPakistan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TravelPakistan.Location = new System.Drawing.Point(127, 279);
            this.TravelPakistan.Name = "TravelPakistan";
            this.TravelPakistan.Size = new System.Drawing.Size(259, 55);
            this.TravelPakistan.TabIndex = 9;
            this.TravelPakistan.Text = "Travel In Pakistan";
            this.TravelPakistan.UseVisualStyleBackColor = false;
            this.TravelPakistan.Click += new System.EventHandler(this.TravelPakistan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(298, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Travel By Flight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome To Online Ticket Application";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenu.Location = new System.Drawing.Point(288, 391);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(296, 61);
            this.MainMenu.TabIndex = 18;
            this.MainMenu.Text = "Back To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(869, 505);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.TavelForeign);
            this.Controls.Add(this.TravelPakistan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TavelForeign;
        private System.Windows.Forms.Button TravelPakistan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu;
    }
}