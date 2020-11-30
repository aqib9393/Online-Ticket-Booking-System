namespace Ticket
{
    partial class AdminEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBus = new System.Windows.Forms.Button();
            this.DeleteBus = new System.Windows.Forms.Button();
            this.UpdateBus = new System.Windows.Forms.Button();
            this.ViewBus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminCombo = new System.Windows.Forms.ComboBox();
            this.Data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Departure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Arrive = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome To Online Ticket Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(399, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Admin Form ";
            // 
            // AddBus
            // 
            this.AddBus.BackColor = System.Drawing.SystemColors.InfoText;
            this.AddBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddBus.Location = new System.Drawing.Point(205, 323);
            this.AddBus.Name = "AddBus";
            this.AddBus.Size = new System.Drawing.Size(57, 36);
            this.AddBus.TabIndex = 45;
            this.AddBus.Text = "Add";
            this.AddBus.UseVisualStyleBackColor = false;
            this.AddBus.Click += new System.EventHandler(this.AddBus_Click);
            // 
            // DeleteBus
            // 
            this.DeleteBus.BackColor = System.Drawing.SystemColors.InfoText;
            this.DeleteBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteBus.Location = new System.Drawing.Point(492, 323);
            this.DeleteBus.Name = "DeleteBus";
            this.DeleteBus.Size = new System.Drawing.Size(84, 36);
            this.DeleteBus.TabIndex = 47;
            this.DeleteBus.Text = "Delete";
            this.DeleteBus.UseVisualStyleBackColor = false;
            this.DeleteBus.Click += new System.EventHandler(this.DeleteBus_Click);
            // 
            // UpdateBus
            // 
            this.UpdateBus.BackColor = System.Drawing.SystemColors.InfoText;
            this.UpdateBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UpdateBus.Location = new System.Drawing.Point(666, 323);
            this.UpdateBus.Name = "UpdateBus";
            this.UpdateBus.Size = new System.Drawing.Size(84, 36);
            this.UpdateBus.TabIndex = 48;
            this.UpdateBus.Text = "Update";
            this.UpdateBus.UseVisualStyleBackColor = false;
            this.UpdateBus.Click += new System.EventHandler(this.UpdateBus_Click);
            // 
            // ViewBus
            // 
            this.ViewBus.BackColor = System.Drawing.SystemColors.InfoText;
            this.ViewBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewBus.Location = new System.Drawing.Point(353, 323);
            this.ViewBus.Name = "ViewBus";
            this.ViewBus.Size = new System.Drawing.Size(57, 36);
            this.ViewBus.TabIndex = 49;
            this.ViewBus.Text = "View";
            this.ViewBus.UseVisualStyleBackColor = false;
            this.ViewBus.Click += new System.EventHandler(this.ViewBus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(808, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 50);
            this.button1.TabIndex = 65;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminCombo
            // 
            this.AdminCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdminCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCombo.FormattingEnabled = true;
            this.AdminCombo.Items.AddRange(new object[] {
            "Bus",
            "Train ",
            "Pk Flight ",
            "Foreign"});
            this.AdminCombo.Location = new System.Drawing.Point(395, 118);
            this.AdminCombo.Name = "AdminCombo";
            this.AdminCombo.Size = new System.Drawing.Size(233, 28);
            this.AdminCombo.TabIndex = 66;
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(395, 152);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(204, 29);
            this.Data.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(199, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 68;
            this.label7.Text = "Enter data";
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(395, 274);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(204, 29);
            this.Time.TabIndex = 69;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 150);
            this.dataGridView1.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(199, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 71;
            this.label3.Text = "Enter Time";
            // 
            // Departure
            // 
            this.Departure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departure.Location = new System.Drawing.Point(395, 198);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(204, 29);
            this.Departure.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(199, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 31);
            this.label4.TabIndex = 73;
            this.label4.Text = "Enter Depart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(426, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 74;
            this.label5.Text = "Select Travel";
            // 
            // Arrive
            // 
            this.Arrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrive.Location = new System.Drawing.Point(395, 239);
            this.Arrive.Name = "Arrive";
            this.Arrive.Size = new System.Drawing.Size(204, 29);
            this.Arrive.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(199, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 31);
            this.label6.TabIndex = 76;
            this.label6.Text = "Enter Arrive";
            // 
            // AdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(964, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Arrive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.AdminCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewBus);
            this.Controls.Add(this.UpdateBus);
            this.Controls.Add(this.DeleteBus);
            this.Controls.Add(this.AddBus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AdminEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBus;
        private System.Windows.Forms.Button DeleteBus;
        private System.Windows.Forms.Button UpdateBus;
        private System.Windows.Forms.Button ViewBus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox AdminCombo;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Departure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Arrive;
        private System.Windows.Forms.Label label6;
    }
}