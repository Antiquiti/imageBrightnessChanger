namespace lab1Obrazki
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
            this.openImageBtn = new System.Windows.Forms.Button();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessScrollBar = new System.Windows.Forms.HScrollBar();
            this.brightnessTB = new System.Windows.Forms.TextBox();
            this.cancelBrightness = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.changeBrightness = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(229, 487);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(75, 29);
            this.openImageBtn.TabIndex = 0;
            this.openImageBtn.Text = "Otwórz";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(628, 367);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 1;
            this.ImagePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zmiana jasności";
            // 
            // brightnessScrollBar
            // 
            this.brightnessScrollBar.Location = new System.Drawing.Point(182, 387);
            this.brightnessScrollBar.Maximum = 109;
            this.brightnessScrollBar.Name = "brightnessScrollBar";
            this.brightnessScrollBar.Size = new System.Drawing.Size(80, 23);
            this.brightnessScrollBar.TabIndex = 3;
            this.brightnessScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.brightnessScrollBar_Scroll);
            // 
            // brightnessTB
            // 
            this.brightnessTB.Location = new System.Drawing.Point(278, 387);
            this.brightnessTB.Name = "brightnessTB";
            this.brightnessTB.Size = new System.Drawing.Size(45, 20);
            this.brightnessTB.TabIndex = 4;
            this.brightnessTB.Text = "0";
            this.brightnessTB.TextChanged += new System.EventHandler(this.brightnessTB_TextChanged);
            // 
            // cancelBrightness
            // 
            this.cancelBrightness.Location = new System.Drawing.Point(495, 385);
            this.cancelBrightness.Name = "cancelBrightness";
            this.cancelBrightness.Size = new System.Drawing.Size(106, 29);
            this.cancelBrightness.TabIndex = 5;
            this.cancelBrightness.Text = "Anuluj";
            this.cancelBrightness.UseVisualStyleBackColor = true;
            this.cancelBrightness.Click += new System.EventHandler(this.cancelBrightnessBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "%";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(332, 487);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 29);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // changeBrightness
            // 
            this.changeBrightness.Location = new System.Drawing.Point(350, 385);
            this.changeBrightness.Name = "changeBrightness";
            this.changeBrightness.Size = new System.Drawing.Size(131, 29);
            this.changeBrightness.TabIndex = 11;
            this.changeBrightness.Text = "Zmień jasność";
            this.changeBrightness.UseVisualStyleBackColor = true;
            this.changeBrightness.Click += new System.EventHandler(this.changeBrightnessBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(205, 433);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(223, 29);
            this.progressBar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 528);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.changeBrightness);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBrightness);
            this.Controls.Add(this.brightnessTB);
            this.Controls.Add(this.brightnessScrollBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.openImageBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar brightnessScrollBar;
        private System.Windows.Forms.TextBox brightnessTB;
        private System.Windows.Forms.Button cancelBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button changeBrightness;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

