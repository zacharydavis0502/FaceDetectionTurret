namespace FaceDetectionCoronaTurret
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.Label();
            this.yPos = new System.Windows.Forms.Label();
            this.pumpBtn = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.soundBox = new System.Windows.Forms.CheckBox();
            this.sendToPort = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enableRecogBox = new System.Windows.Forms.CheckBox();
            this.voiceRecBox = new System.Windows.Forms.CheckBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(243, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(0, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device:";
            // 
            // port
            // 
            this.port.PortName = "COM6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(32, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(32, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // xPos
            // 
            this.xPos.AutoSize = true;
            this.xPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.xPos.Location = new System.Drawing.Point(50, 549);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(30, 17);
            this.xPos.TabIndex = 7;
            this.xPos.Text = "null";
            // 
            // yPos
            // 
            this.yPos.AutoSize = true;
            this.yPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yPos.Location = new System.Drawing.Point(50, 566);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(30, 17);
            this.yPos.TabIndex = 8;
            this.yPos.Text = "null";
            // 
            // pumpBtn
            // 
            this.pumpBtn.Location = new System.Drawing.Point(243, 642);
            this.pumpBtn.Name = "pumpBtn";
            this.pumpBtn.Size = new System.Drawing.Size(114, 23);
            this.pumpBtn.TabIndex = 10;
            this.pumpBtn.Text = "pump";
            this.pumpBtn.UseVisualStyleBackColor = true;
            this.pumpBtn.Click += new System.EventHandler(this.pumpBtn_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(12, 36);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(700, 500);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // soundBox
            // 
            this.soundBox.AutoSize = true;
            this.soundBox.Location = new System.Drawing.Point(243, 549);
            this.soundBox.Name = "soundBox";
            this.soundBox.Size = new System.Drawing.Size(57, 17);
            this.soundBox.TabIndex = 16;
            this.soundBox.Text = "Sound";
            this.soundBox.UseVisualStyleBackColor = true;
            // 
            // sendToPort
            // 
            this.sendToPort.AutoSize = true;
            this.sendToPort.Checked = true;
            this.sendToPort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendToPort.Location = new System.Drawing.Point(243, 573);
            this.sendToPort.Name = "sendToPort";
            this.sendToPort.Size = new System.Drawing.Size(89, 17);
            this.sendToPort.TabIndex = 21;
            this.sendToPort.Text = "Send To Port";
            this.sendToPort.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(745, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // enableRecogBox
            // 
            this.enableRecogBox.AutoSize = true;
            this.enableRecogBox.Location = new System.Drawing.Point(243, 597);
            this.enableRecogBox.Name = "enableRecogBox";
            this.enableRecogBox.Size = new System.Drawing.Size(114, 17);
            this.enableRecogBox.TabIndex = 23;
            this.enableRecogBox.Text = "Facial Recognition";
            this.enableRecogBox.UseVisualStyleBackColor = true;
            // 
            // voiceRecBox
            // 
            this.voiceRecBox.AutoSize = true;
            this.voiceRecBox.Checked = true;
            this.voiceRecBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.voiceRecBox.Location = new System.Drawing.Point(243, 619);
            this.voiceRecBox.Name = "voiceRecBox";
            this.voiceRecBox.Size = new System.Drawing.Size(113, 17);
            this.voiceRecBox.TabIndex = 24;
            this.voiceRecBox.Text = "Voice Recognition";
            this.voiceRecBox.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(363, 547);
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputBox.Size = new System.Drawing.Size(349, 96);
            this.outputBox.TabIndex = 25;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 691);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.voiceRecBox);
            this.Controls.Add(this.enableRecogBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendToPort);
            this.Controls.Add(this.soundBox);
            this.Controls.Add(this.pumpBtn);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label xPos;
        private System.Windows.Forms.Label yPos;
        private System.Windows.Forms.Button pumpBtn;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.CheckBox soundBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.CheckBox sendToPort;
        public System.Windows.Forms.CheckBox enableRecogBox;
        private System.Windows.Forms.CheckBox voiceRecBox;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

