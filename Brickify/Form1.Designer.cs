namespace TestCustomCheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.original_image = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.finished_lego_pic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Save_Image = new System.Windows.Forms.Button();
            this.Load_Image = new System.Windows.Forms.Button();
            this.Generate_Image = new System.Windows.Forms.Button();
            this.OptionsBox = new System.Windows.Forms.GroupBox();
            this.OptionsList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllButton = new System.Windows.Forms.RadioButton();
            this.CommonButton = new System.Windows.Forms.RadioButton();
            this.GreyButton = new System.Windows.Forms.RadioButton();
            this.BrickColourList = new Qodex.CustomCheckedListBox();
            this.Gsat = new System.Windows.Forms.TextBox();
            this.Bsat = new System.Windows.Forms.TextBox();
            this.Rsat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.original_image)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finished_lego_pic)).BeginInit();
            this.panel3.SuspendLayout();
            this.OptionsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.original_image);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 611);
            this.panel1.TabIndex = 6;
            // 
            // original_image
            // 
            this.original_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.original_image.Location = new System.Drawing.Point(4, 4);
            this.original_image.Name = "original_image";
            this.original_image.Size = new System.Drawing.Size(524, 604);
            this.original_image.TabIndex = 0;
            this.original_image.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.finished_lego_pic);
            this.panel2.Location = new System.Drawing.Point(539, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 611);
            this.panel2.TabIndex = 7;
            // 
            // finished_lego_pic
            // 
            this.finished_lego_pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finished_lego_pic.Location = new System.Drawing.Point(3, 4);
            this.finished_lego_pic.Name = "finished_lego_pic";
            this.finished_lego_pic.Size = new System.Drawing.Size(524, 604);
            this.finished_lego_pic.TabIndex = 0;
            this.finished_lego_pic.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.Save_Image);
            this.panel3.Controls.Add(this.Load_Image);
            this.panel3.Controls.Add(this.Generate_Image);
            this.panel3.Controls.Add(this.OptionsBox);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.BrickColourList);
            this.panel3.Location = new System.Drawing.Point(1078, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 611);
            this.panel3.TabIndex = 8;
            // 
            // Save_Image
            // 
            this.Save_Image.Location = new System.Drawing.Point(95, 367);
            this.Save_Image.Name = "Save_Image";
            this.Save_Image.Size = new System.Drawing.Size(86, 50);
            this.Save_Image.TabIndex = 10;
            this.Save_Image.Text = "Save Image and Bricks";
            this.Save_Image.UseVisualStyleBackColor = true;
            this.Save_Image.Click += new System.EventHandler(this.Save_Image_Click);
            // 
            // Load_Image
            // 
            this.Load_Image.Location = new System.Drawing.Point(3, 367);
            this.Load_Image.Name = "Load_Image";
            this.Load_Image.Size = new System.Drawing.Size(86, 50);
            this.Load_Image.TabIndex = 9;
            this.Load_Image.Text = "Load Image";
            this.Load_Image.UseVisualStyleBackColor = true;
            this.Load_Image.Click += new System.EventHandler(this.Load_Image_Click_1);
            // 
            // Generate_Image
            // 
            this.Generate_Image.Location = new System.Drawing.Point(3, 423);
            this.Generate_Image.Name = "Generate_Image";
            this.Generate_Image.Size = new System.Drawing.Size(178, 50);
            this.Generate_Image.TabIndex = 8;
            this.Generate_Image.Text = "GENERATE";
            this.Generate_Image.UseVisualStyleBackColor = true;
            this.Generate_Image.Click += new System.EventHandler(this.Generate_Image_Click);
            // 
            // OptionsBox
            // 
            this.OptionsBox.Controls.Add(this.label6);
            this.OptionsBox.Controls.Add(this.label5);
            this.OptionsBox.Controls.Add(this.label4);
            this.OptionsBox.Controls.Add(this.label3);
            this.OptionsBox.Controls.Add(this.Rsat);
            this.OptionsBox.Controls.Add(this.Bsat);
            this.OptionsBox.Controls.Add(this.Gsat);
            this.OptionsBox.Controls.Add(this.OptionsList);
            this.OptionsBox.Controls.Add(this.label2);
            this.OptionsBox.Controls.Add(this.label1);
            this.OptionsBox.Controls.Add(this.HeightBox);
            this.OptionsBox.Controls.Add(this.WidthBox);
            this.OptionsBox.Location = new System.Drawing.Point(3, 105);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(178, 261);
            this.OptionsBox.TabIndex = 7;
            this.OptionsBox.TabStop = false;
            this.OptionsBox.Text = "Options";
            // 
            // OptionsList
            // 
            this.OptionsList.FormattingEnabled = true;
            this.OptionsList.Items.AddRange(new object[] {
            "maintain aspect ratio",
            "dithering"});
            this.OptionsList.Location = new System.Drawing.Point(6, 22);
            this.OptionsList.Name = "OptionsList";
            this.OptionsList.Size = new System.Drawing.Size(166, 89);
            this.OptionsList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(92, 135);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(80, 22);
            this.HeightBox.TabIndex = 2;
            this.HeightBox.Text = "0";
            this.HeightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            this.HeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Heightbox_input);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(7, 135);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(79, 22);
            this.WidthBox.TabIndex = 1;
            this.WidthBox.Text = "0";
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            this.WidthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Widthbox_input);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllButton);
            this.groupBox1.Controls.Add(this.CommonButton);
            this.groupBox1.Controls.Add(this.GreyButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colour Palette";
            // 
            // AllButton
            // 
            this.AllButton.AutoSize = true;
            this.AllButton.Location = new System.Drawing.Point(7, 56);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(44, 21);
            this.AllButton.TabIndex = 2;
            this.AllButton.TabStop = true;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.CheckedChanged += new System.EventHandler(this.radio_button_updater);
            // 
            // CommonButton
            // 
            this.CommonButton.AutoSize = true;
            this.CommonButton.Location = new System.Drawing.Point(7, 38);
            this.CommonButton.Name = "CommonButton";
            this.CommonButton.Size = new System.Drawing.Size(84, 21);
            this.CommonButton.TabIndex = 1;
            this.CommonButton.TabStop = true;
            this.CommonButton.Text = "Common";
            this.CommonButton.UseVisualStyleBackColor = true;
            this.CommonButton.CheckedChanged += new System.EventHandler(this.radio_button_updater);
            // 
            // GreyButton
            // 
            this.GreyButton.AutoSize = true;
            this.GreyButton.Location = new System.Drawing.Point(7, 19);
            this.GreyButton.Name = "GreyButton";
            this.GreyButton.Size = new System.Drawing.Size(93, 21);
            this.GreyButton.TabIndex = 0;
            this.GreyButton.TabStop = true;
            this.GreyButton.Text = "Greyscale";
            this.GreyButton.UseVisualStyleBackColor = true;
            this.GreyButton.CheckedChanged += new System.EventHandler(this.radio_button_updater);
            // 
            // BrickColourList
            // 
            this.BrickColourList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BrickColourList.CheckOnClick = true;
            this.BrickColourList.DrawFocusedIndicator = true;
            this.BrickColourList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrickColourList.FormattingEnabled = true;
            this.BrickColourList.Location = new System.Drawing.Point(182, 5);
            this.BrickColourList.Margin = new System.Windows.Forms.Padding(4);
            this.BrickColourList.Name = "BrickColourList";
            this.BrickColourList.Size = new System.Drawing.Size(159, 592);
            this.BrickColourList.TabIndex = 5;
            this.BrickColourList.GetForeColor += new Qodex.CustomCheckedListBox.GetColorDelegate(this.customCheckedListBox1_GetFrontColor);
            this.BrickColourList.GetBackColor += new Qodex.CustomCheckedListBox.GetColorDelegate(this.customCheckedListBox1_GetBackColor);
            // 
            // Gsat
            // 
            this.Gsat.Location = new System.Drawing.Point(57, 206);
            this.Gsat.Name = "Gsat";
            this.Gsat.Size = new System.Drawing.Size(53, 22);
            this.Gsat.TabIndex = 6;
            this.Gsat.Text = "0";
            this.Gsat.TextChanged += new System.EventHandler(this.G_Saturation_TextChanged);
            this.Gsat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Saturation_input);
            // 
            // Bsat
            // 
            this.Bsat.Location = new System.Drawing.Point(57, 234);
            this.Bsat.Name = "Bsat";
            this.Bsat.Size = new System.Drawing.Size(53, 22);
            this.Bsat.TabIndex = 7;
            this.Bsat.Text = "0";
            this.Bsat.TextChanged += new System.EventHandler(this.B_Saturation_TextChanged);
            this.Bsat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Saturation_input);
            // 
            // Rsat
            // 
            this.Rsat.Location = new System.Drawing.Point(57, 178);
            this.Rsat.Name = "Rsat";
            this.Rsat.Size = new System.Drawing.Size(53, 22);
            this.Rsat.TabIndex = 8;
            this.Rsat.Text = "0";
            this.Rsat.TextChanged += new System.EventHandler(this.R_Saturation_TextChanged);
            this.Rsat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Saturation_input);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saturation";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Brickify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.original_image)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finished_lego_pic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.OptionsBox.ResumeLayout(false);
            this.OptionsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox original_image;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox finished_lego_pic;
        private Qodex.CustomCheckedListBox BrickColourList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Save_Image;
        private System.Windows.Forms.Button Load_Image;
        private System.Windows.Forms.Button Generate_Image;
        private System.Windows.Forms.GroupBox OptionsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AllButton;
        private System.Windows.Forms.RadioButton CommonButton;
        private System.Windows.Forms.RadioButton GreyButton;
        private System.Windows.Forms.CheckedListBox OptionsList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Rsat;
        private System.Windows.Forms.TextBox Bsat;
        private System.Windows.Forms.TextBox Gsat;
        private System.Windows.Forms.TextBox textBox1;
    }
}

