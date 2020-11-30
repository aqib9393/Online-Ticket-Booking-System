namespace Ticket
{
    partial class BusForms
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.CNIC_bus = new System.Windows.Forms.TextBox();
            this.Name_bus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdultComb = new System.Windows.Forms.ComboBox();
            this.ChildComb = new System.Windows.Forms.ComboBox();
            this.InfntCombo = new System.Windows.Forms.ComboBox();
            this.BusComb = new System.Windows.Forms.ComboBox();
            this.BusDone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ViewBus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BusView = new System.Windows.Forms.DataGridView();
            this.ViewText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BusView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenu.Location = new System.Drawing.Point(348, 436);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(296, 61);
            this.MainMenu.TabIndex = 17;
            this.MainMenu.Text = "Back To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // CNIC_bus
            // 
            this.CNIC_bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC_bus.Location = new System.Drawing.Point(239, 332);
            this.CNIC_bus.Name = "CNIC_bus";
            this.CNIC_bus.Size = new System.Drawing.Size(245, 29);
            this.CNIC_bus.TabIndex = 16;
            // 
            // Name_bus
            // 
            this.Name_bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_bus.Location = new System.Drawing.Point(239, 285);
            this.Name_bus.Name = "Name_bus";
            this.Name_bus.Size = new System.Drawing.Size(245, 29);
            this.Name_bus.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter CNIC ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(354, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Travel by Bus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome To Online Ticket Application";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(268, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 42);
            this.label5.TabIndex = 18;
            this.label5.Text = "Required Information";
            // 
            // AdultComb
            // 
            this.AdultComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdultComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultComb.FormattingEnabled = true;
            this.AdultComb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AdultComb.Location = new System.Drawing.Point(119, 180);
            this.AdultComb.Name = "AdultComb";
            this.AdultComb.Size = new System.Drawing.Size(85, 28);
            this.AdultComb.TabIndex = 19;
            // 
            // ChildComb
            // 
            this.ChildComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChildComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildComb.FormattingEnabled = true;
            this.ChildComb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ChildComb.Location = new System.Drawing.Point(282, 180);
            this.ChildComb.Name = "ChildComb";
            this.ChildComb.Size = new System.Drawing.Size(85, 28);
            this.ChildComb.TabIndex = 20;
            // 
            // InfntCombo
            // 
            this.InfntCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InfntCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfntCombo.FormattingEnabled = true;
            this.InfntCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.InfntCombo.Location = new System.Drawing.Point(455, 180);
            this.InfntCombo.Name = "InfntCombo";
            this.InfntCombo.Size = new System.Drawing.Size(85, 28);
            this.InfntCombo.TabIndex = 21;
            // 
            // BusComb
            // 
            this.BusComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusComb.FormattingEnabled = true;
            this.BusComb.Location = new System.Drawing.Point(239, 244);
            this.BusComb.Name = "BusComb";
            this.BusComb.Size = new System.Drawing.Size(393, 28);
            this.BusComb.TabIndex = 23;
            // 
            // BusDone
            // 
            this.BusDone.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BusDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusDone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BusDone.Location = new System.Drawing.Point(192, 381);
            this.BusDone.Name = "BusDone";
            this.BusDone.Size = new System.Drawing.Size(120, 42);
            this.BusDone.TabIndex = 24;
            this.BusDone.Text = "Done";
            this.BusDone.UseVisualStyleBackColor = false;
            this.BusDone.Click += new System.EventHandler(this.BusDone_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancel Ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewBus
            // 
            this.ViewBus.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ViewBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewBus.Location = new System.Drawing.Point(782, 363);
            this.ViewBus.Name = "ViewBus";
            this.ViewBus.Size = new System.Drawing.Size(189, 42);
            this.ViewBus.TabIndex = 26;
            this.ViewBus.Text = "View Ticket";
            this.ViewBus.UseVisualStyleBackColor = false;
            this.ViewBus.Click += new System.EventHandler(this.ViewBus_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(739, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 50);
            this.button2.TabIndex = 27;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BusView
            // 
            this.BusView.AllowUserToAddRows = false;
            this.BusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusView.Location = new System.Drawing.Point(638, 122);
            this.BusView.Name = "BusView";
            this.BusView.Size = new System.Drawing.Size(419, 150);
            this.BusView.TabIndex = 29;
            // 
            // ViewText
            // 
            this.ViewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewText.Location = new System.Drawing.Point(769, 309);
            this.ViewText.Name = "ViewText";
            this.ViewText.Size = new System.Drawing.Size(245, 29);
            this.ViewText.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(574, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 31;
            this.label6.Text = "Enter Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(137, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adult";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(298, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Child";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(451, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Infantry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(298, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "Select Bus";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Error.Location = new System.Drawing.Point(501, 330);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(25, 29);
            this.Error.TabIndex = 36;
            this.Error.Text = "..";
            // 
            // BusForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1048, 509);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ViewText);
            this.Controls.Add(this.BusView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ViewBus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BusDone);
            this.Controls.Add(this.BusComb);
            this.Controls.Add(this.InfntCombo);
            this.Controls.Add(this.ChildComb);
            this.Controls.Add(this.AdultComb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.CNIC_bus);
            this.Controls.Add(this.Name_bus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BusForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusForm";
            this.Load += new System.EventHandler(this.BusForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BusView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.TextBox CNIC_bus;
        private System.Windows.Forms.TextBox Name_bus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AdultComb;
        private System.Windows.Forms.ComboBox ChildComb;
        private System.Windows.Forms.ComboBox InfntCombo;
        private System.Windows.Forms.ComboBox BusComb;
        private System.Windows.Forms.Button BusDone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ViewBus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView BusView;
        private System.Windows.Forms.TextBox ViewText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Error;
    }
}