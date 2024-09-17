namespace ESPGUITOOL
{
    partial class ESPGUITOOL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESPGUITOOL));
            this.portBox = new System.Windows.Forms.ComboBox();
            this.flashFileBox = new System.Windows.Forms.ComboBox();
            this.espToolBox = new System.Windows.Forms.ComboBox();
            this.scanPortsBtn = new System.Windows.Forms.Button();
            this.flashFileBtn = new System.Windows.Forms.Button();
            this.espToolBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.theCOMPort = new System.Windows.Forms.TextBox();
            this.theFlashBin = new System.Windows.Forms.TextBox();
            this.esptoolFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flashBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flashProgress = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // portBox
            // 
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(21, 49);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(482, 21);
            this.portBox.TabIndex = 1;
            this.portBox.SelectedIndexChanged += new System.EventHandler(this.portBox_SelectedIndexChanged);
            // 
            // flashFileBox
            // 
            this.flashFileBox.FormattingEnabled = true;
            this.flashFileBox.Location = new System.Drawing.Point(21, 102);
            this.flashFileBox.Name = "flashFileBox";
            this.flashFileBox.Size = new System.Drawing.Size(482, 21);
            this.flashFileBox.TabIndex = 2;
            this.flashFileBox.SelectedIndexChanged += new System.EventHandler(this.flashFileBox_SelectedIndexChanged);
            // 
            // espToolBox
            // 
            this.espToolBox.FormattingEnabled = true;
            this.espToolBox.Location = new System.Drawing.Point(21, 156);
            this.espToolBox.Name = "espToolBox";
            this.espToolBox.Size = new System.Drawing.Size(482, 21);
            this.espToolBox.TabIndex = 3;
            this.espToolBox.SelectedIndexChanged += new System.EventHandler(this.espToolBox_SelectedIndexChanged);
            // 
            // scanPortsBtn
            // 
            this.scanPortsBtn.Location = new System.Drawing.Point(410, 75);
            this.scanPortsBtn.Name = "scanPortsBtn";
            this.scanPortsBtn.Size = new System.Drawing.Size(93, 21);
            this.scanPortsBtn.TabIndex = 4;
            this.scanPortsBtn.Text = "Re-Scan Ports";
            this.scanPortsBtn.UseVisualStyleBackColor = true;
            // 
            // flashFileBtn
            // 
            this.flashFileBtn.Location = new System.Drawing.Point(410, 129);
            this.flashFileBtn.Name = "flashFileBtn";
            this.flashFileBtn.Size = new System.Drawing.Size(93, 21);
            this.flashFileBtn.TabIndex = 5;
            this.flashFileBtn.Text = "Flash File";
            this.flashFileBtn.UseVisualStyleBackColor = true;
            this.flashFileBtn.Click += new System.EventHandler(this.flashFileBtn_Click);
            // 
            // espToolBtn
            // 
            this.espToolBtn.Location = new System.Drawing.Point(410, 183);
            this.espToolBtn.Name = "espToolBtn";
            this.espToolBtn.Size = new System.Drawing.Size(93, 21);
            this.espToolBtn.TabIndex = 6;
            this.espToolBtn.Text = "ESPTool File";
            this.espToolBtn.UseVisualStyleBackColor = true;
            this.espToolBtn.Click += new System.EventHandler(this.espToolBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.espToolBtn);
            this.groupBox1.Controls.Add(this.flashFileBtn);
            this.groupBox1.Controls.Add(this.scanPortsBtn);
            this.groupBox1.Controls.Add(this.espToolBox);
            this.groupBox1.Controls.Add(this.flashFileBox);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 214);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESP Flash Parameters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "The selected \"esptool.exe\" file for flashing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available Flash Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Availabe COM Ports";
            // 
            // theCOMPort
            // 
            this.theCOMPort.Location = new System.Drawing.Point(21, 48);
            this.theCOMPort.Name = "theCOMPort";
            this.theCOMPort.ReadOnly = true;
            this.theCOMPort.Size = new System.Drawing.Size(482, 20);
            this.theCOMPort.TabIndex = 8;
            // 
            // theFlashBin
            // 
            this.theFlashBin.Location = new System.Drawing.Point(21, 92);
            this.theFlashBin.Name = "theFlashBin";
            this.theFlashBin.ReadOnly = true;
            this.theFlashBin.Size = new System.Drawing.Size(482, 20);
            this.theFlashBin.TabIndex = 9;
            // 
            // esptoolFile
            // 
            this.esptoolFile.Location = new System.Drawing.Point(21, 138);
            this.esptoolFile.Name = "esptoolFile";
            this.esptoolFile.ReadOnly = true;
            this.esptoolFile.Size = new System.Drawing.Size(482, 20);
            this.esptoolFile.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flashBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.esptoolFile);
            this.groupBox2.Controls.Add(this.theFlashBin);
            this.groupBox2.Controls.Add(this.theCOMPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 203);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ESP Flash Variables";
            // 
            // flashBtn
            // 
            this.flashBtn.Location = new System.Drawing.Point(410, 174);
            this.flashBtn.Name = "flashBtn";
            this.flashBtn.Size = new System.Drawing.Size(93, 23);
            this.flashBtn.TabIndex = 13;
            this.flashBtn.Text = "FLASH ESP";
            this.flashBtn.UseVisualStyleBackColor = true;
            this.flashBtn.Click += new System.EventHandler(this.flashBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "esptools.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "File To Flash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selected COM Port";
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resultsBox.ForeColor = System.Drawing.Color.White;
            this.resultsBox.Location = new System.Drawing.Point(21, 29);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsBox.Size = new System.Drawing.Size(481, 166);
            this.resultsBox.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resetBtn);
            this.groupBox3.Controls.Add(this.flashProgress);
            this.groupBox3.Controls.Add(this.resultsBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 513);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 238);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FLASH Results";
            // 
            // flashProgress
            // 
            this.flashProgress.AutoSize = true;
            this.flashProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashProgress.Location = new System.Drawing.Point(19, 198);
            this.flashProgress.Name = "flashProgress";
            this.flashProgress.Size = new System.Drawing.Size(43, 13);
            this.flashProgress.TabIndex = 13;
            this.flashProgress.Text = "Ready";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(427, 209);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ESPGUITOOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 763);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ESPGUITOOL";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI ESPTools Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.ComboBox flashFileBox;
        private System.Windows.Forms.ComboBox espToolBox;
        private System.Windows.Forms.Button scanPortsBtn;
        private System.Windows.Forms.Button flashFileBtn;
        private System.Windows.Forms.Button espToolBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox theCOMPort;
        private System.Windows.Forms.TextBox theFlashBin;
        private System.Windows.Forms.TextBox esptoolFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button flashBtn;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label flashProgress;
        private System.Windows.Forms.Button resetBtn;
    }
}

