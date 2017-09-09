namespace CV_lab1__reading_image_
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
            this.originalImagePbox = new System.Windows.Forms.PictureBox();
            this.open_Button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputImagePbox = new System.Windows.Forms.PictureBox();
            this.Threshold = new System.Windows.Forms.Button();
            this.minGrayTB = new System.Windows.Forms.TextBox();
            this.MaxGrayTB = new System.Windows.Forms.TextBox();
            this.thresholdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_ContrastTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplyHistogram = new System.Windows.Forms.Button();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.filterTypeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HarrisBT = new System.Windows.Forms.Button();
            this.harrisFeatureCountTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePbox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputImagePbox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImagePbox
            // 
            this.originalImagePbox.Location = new System.Drawing.Point(3, 3);
            this.originalImagePbox.Name = "originalImagePbox";
            this.originalImagePbox.Size = new System.Drawing.Size(450, 355);
            this.originalImagePbox.TabIndex = 0;
            this.originalImagePbox.TabStop = false;
            // 
            // open_Button1
            // 
            this.open_Button1.Location = new System.Drawing.Point(147, 403);
            this.open_Button1.Name = "open_Button1";
            this.open_Button1.Size = new System.Drawing.Size(75, 23);
            this.open_Button1.TabIndex = 1;
            this.open_Button1.Text = "Open";
            this.open_Button1.UseVisualStyleBackColor = true;
            this.open_Button1.Click += new System.EventHandler(this.open_Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.originalImagePbox);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 361);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.outputImagePbox);
            this.panel2.Location = new System.Drawing.Point(474, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 361);
            this.panel2.TabIndex = 3;
            // 
            // outputImagePbox
            // 
            this.outputImagePbox.Location = new System.Drawing.Point(0, 3);
            this.outputImagePbox.Name = "outputImagePbox";
            this.outputImagePbox.Size = new System.Drawing.Size(445, 355);
            this.outputImagePbox.TabIndex = 0;
            this.outputImagePbox.TabStop = false;
            // 
            // Threshold
            // 
            this.Threshold.Location = new System.Drawing.Point(956, 129);
            this.Threshold.Name = "Threshold";
            this.Threshold.Size = new System.Drawing.Size(75, 23);
            this.Threshold.TabIndex = 4;
            this.Threshold.Text = "Threshold";
            this.Threshold.UseVisualStyleBackColor = true;
            this.Threshold.Click += new System.EventHandler(this.Threshold_Click);
            // 
            // minGrayTB
            // 
            this.minGrayTB.Location = new System.Drawing.Point(1012, 25);
            this.minGrayTB.Name = "minGrayTB";
            this.minGrayTB.Size = new System.Drawing.Size(100, 20);
            this.minGrayTB.TabIndex = 5;
            // 
            // MaxGrayTB
            // 
            this.MaxGrayTB.Location = new System.Drawing.Point(1012, 51);
            this.MaxGrayTB.Name = "MaxGrayTB";
            this.MaxGrayTB.Size = new System.Drawing.Size(100, 20);
            this.MaxGrayTB.TabIndex = 6;
            // 
            // thresholdTB
            // 
            this.thresholdTB.Location = new System.Drawing.Point(956, 103);
            this.thresholdTB.Name = "thresholdTB";
            this.thresholdTB.Size = new System.Drawing.Size(100, 20);
            this.thresholdTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Min Gray";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max Gray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Threshold Value";
            // 
            // B_ContrastTB
            // 
            this.B_ContrastTB.Location = new System.Drawing.Point(1078, 103);
            this.B_ContrastTB.Name = "B_ContrastTB";
            this.B_ContrastTB.Size = new System.Drawing.Size(100, 20);
            this.B_ContrastTB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1075, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "B";
            // 
            // ApplyHistogram
            // 
            this.ApplyHistogram.Location = new System.Drawing.Point(1078, 129);
            this.ApplyHistogram.Name = "ApplyHistogram";
            this.ApplyHistogram.Size = new System.Drawing.Size(75, 23);
            this.ApplyHistogram.TabIndex = 13;
            this.ApplyHistogram.Text = "Contrast";
            this.ApplyHistogram.UseVisualStyleBackColor = true;
            this.ApplyHistogram.Click += new System.EventHandler(this.ApplyHistogram_Click);
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Location = new System.Drawing.Point(961, 226);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilter.TabIndex = 14;
            this.ApplyFilter.Text = "Apply Filter";
            this.ApplyFilter.UseVisualStyleBackColor = true;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(958, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filter Type";
            // 
            // filterTypeCB
            // 
            this.filterTypeCB.FormattingEnabled = true;
            this.filterTypeCB.Location = new System.Drawing.Point(958, 199);
            this.filterTypeCB.Name = "filterTypeCB";
            this.filterTypeCB.Size = new System.Drawing.Size(121, 21);
            this.filterTypeCB.TabIndex = 16;
            this.filterTypeCB.SelectedIndexChanged += new System.EventHandler(this.filterTypeCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Input Image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Output Image";
            // 
            // HarrisBT
            // 
            this.HarrisBT.Location = new System.Drawing.Point(931, 299);
            this.HarrisBT.Name = "HarrisBT";
            this.HarrisBT.Size = new System.Drawing.Size(75, 23);
            this.HarrisBT.TabIndex = 19;
            this.HarrisBT.Text = "Harris";
            this.HarrisBT.UseVisualStyleBackColor = true;
            this.HarrisBT.Click += new System.EventHandler(this.HarrisBT_Click);
            // 
            // harrisFeatureCountTB
            // 
            this.harrisFeatureCountTB.Location = new System.Drawing.Point(1024, 299);
            this.harrisFeatureCountTB.Name = "harrisFeatureCountTB";
            this.harrisFeatureCountTB.Size = new System.Drawing.Size(100, 20);
            this.harrisFeatureCountTB.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 503);
            this.Controls.Add(this.harrisFeatureCountTB);
            this.Controls.Add(this.HarrisBT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterTypeCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApplyFilter);
            this.Controls.Add(this.ApplyHistogram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B_ContrastTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thresholdTB);
            this.Controls.Add(this.MaxGrayTB);
            this.Controls.Add(this.minGrayTB);
            this.Controls.Add(this.Threshold);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.open_Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputImagePbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originalImagePbox;
        private System.Windows.Forms.Button open_Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox outputImagePbox;
        private System.Windows.Forms.Button Threshold;
        private System.Windows.Forms.TextBox minGrayTB;
        private System.Windows.Forms.TextBox MaxGrayTB;
        private System.Windows.Forms.TextBox thresholdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox B_ContrastTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ApplyHistogram;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filterTypeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button HarrisBT;
        private System.Windows.Forms.TextBox harrisFeatureCountTB;
    }
}

