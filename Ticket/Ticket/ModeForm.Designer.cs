namespace Ticket
{
    partial class ModeForm
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
            this.Flight = new System.Windows.Forms.Button();
            this.Train = new System.Windows.Forms.Button();
            this.Bus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flight
            // 
            this.Flight.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Flight.Location = new System.Drawing.Point(575, 269);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(154, 50);
            this.Flight.TabIndex = 9;
            this.Flight.Text = "Flight";
            this.Flight.UseVisualStyleBackColor = false;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // Train
            // 
            this.Train.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Train.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Train.Location = new System.Drawing.Point(352, 269);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(148, 50);
            this.Train.TabIndex = 8;
            this.Train.Text = "Train";
            this.Train.UseVisualStyleBackColor = false;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // Bus
            // 
            this.Bus.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bus.Location = new System.Drawing.Point(100, 269);
            this.Bus.Name = "Bus";
            this.Bus.Size = new System.Drawing.Size(144, 50);
            this.Bus.TabIndex = 7;
            this.Bus.Text = "Bus";
            this.Bus.UseVisualStyleBackColor = false;
            this.Bus.Click += new System.EventHandler(this.Bus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(293, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mode of Travel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome To Online Ticket Application";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(735, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(905, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Flight);
            this.Controls.Add(this.Train);
            this.Controls.Add(this.Bus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Flight;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.Button Bus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}