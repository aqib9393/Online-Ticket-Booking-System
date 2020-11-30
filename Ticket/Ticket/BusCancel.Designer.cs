namespace Ticket
{
    partial class BusCancel
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BusCancl = new System.Windows.Forms.Button();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.C_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.BusBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(388, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ticket Cancel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(386, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "Travel by Bus";
            // 
            // BusCancl
            // 
            this.BusCancl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BusCancl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusCancl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BusCancl.Location = new System.Drawing.Point(451, 347);
            this.BusCancl.Name = "BusCancl";
            this.BusCancl.Size = new System.Drawing.Size(120, 42);
            this.BusCancl.TabIndex = 29;
            this.BusCancl.Text = "Done";
            this.BusCancl.UseVisualStyleBackColor = false;
            this.BusCancl.Click += new System.EventHandler(this.BusCancl_Click);
            // 
            // CNIC
            // 
            this.CNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC.Location = new System.Drawing.Point(395, 302);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(245, 29);
            this.CNIC.TabIndex = 28;
            // 
            // C_Name
            // 
            this.C_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Name.Location = new System.Drawing.Point(395, 253);
            this.C_Name.Name = "C_Name";
            this.C_Name.Size = new System.Drawing.Size(245, 29);
            this.C_Name.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enter CNIC ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(878, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 55);
            this.label1.TabIndex = 19;
            this.label1.Text = "Welcome To Online Ticket Application";
            // 
            // BusBack
            // 
            this.BusBack.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BusBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BusBack.Location = new System.Drawing.Point(56, 427);
            this.BusBack.Name = "BusBack";
            this.BusBack.Size = new System.Drawing.Size(144, 50);
            this.BusBack.TabIndex = 31;
            this.BusBack.Text = "Back";
            this.BusBack.UseVisualStyleBackColor = false;
            this.BusBack.Click += new System.EventHandler(this.BusBack_Click);
            // 
            // BusCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1058, 514);
            this.Controls.Add(this.BusBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BusCancl);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.C_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BusCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusCancel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BusCancl;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.TextBox C_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BusBack;
    }
}