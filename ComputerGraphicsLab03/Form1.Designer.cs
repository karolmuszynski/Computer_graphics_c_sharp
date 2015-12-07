namespace ComputerGraphicsLab03
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
            this.textbox_chooseSize = new System.Windows.Forms.TextBox();
            this.numericUD_size = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_chooseColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_deleteLine = new System.Windows.Forms.Button();
            this.check_circle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_chooseSize
            // 
            this.textbox_chooseSize.Enabled = false;
            this.textbox_chooseSize.Location = new System.Drawing.Point(9, 58);
            this.textbox_chooseSize.Margin = new System.Windows.Forms.Padding(2);
            this.textbox_chooseSize.Multiline = true;
            this.textbox_chooseSize.Name = "textbox_chooseSize";
            this.textbox_chooseSize.ReadOnly = true;
            this.textbox_chooseSize.Size = new System.Drawing.Size(84, 20);
            this.textbox_chooseSize.TabIndex = 1;
            this.textbox_chooseSize.Text = "Choose size:";
            this.textbox_chooseSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUD_size
            // 
            this.numericUD_size.Location = new System.Drawing.Point(9, 83);
            this.numericUD_size.Margin = new System.Windows.Forms.Padding(2);
            this.numericUD_size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUD_size.Name = "numericUD_size";
            this.numericUD_size.Size = new System.Drawing.Size(82, 20);
            this.numericUD_size.TabIndex = 2;
            this.numericUD_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUD_size.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUD_size.ValueChanged += new System.EventHandler(this.numericUD_size_ValueChanged);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_image.Location = new System.Drawing.Point(114, 10);
            this.pictureBox_image.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(526, 570);
            this.pictureBox_image.TabIndex = 3;
            this.pictureBox_image.TabStop = false;
            this.pictureBox_image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(9, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 20);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btn_chooseColor
            // 
            this.btn_chooseColor.Location = new System.Drawing.Point(9, 10);
            this.btn_chooseColor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chooseColor.Name = "btn_chooseColor";
            this.btn_chooseColor.Size = new System.Drawing.Size(82, 20);
            this.btn_chooseColor.TabIndex = 6;
            this.btn_chooseColor.Text = "Choose color";
            this.btn_chooseColor.UseVisualStyleBackColor = true;
            this.btn_chooseColor.Click += new System.EventHandler(this.btn_chooseColor_Click);
            // 
            // btn_deleteLine
            // 
            this.btn_deleteLine.Location = new System.Drawing.Point(9, 106);
            this.btn_deleteLine.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deleteLine.Name = "btn_deleteLine";
            this.btn_deleteLine.Size = new System.Drawing.Size(82, 20);
            this.btn_deleteLine.TabIndex = 7;
            this.btn_deleteLine.Text = "Delete line";
            this.btn_deleteLine.UseVisualStyleBackColor = true;
            this.btn_deleteLine.Click += new System.EventHandler(this.btn_deleteLine_Click);
            // 
            // check_circle
            // 
            this.check_circle.AutoSize = true;
            this.check_circle.Location = new System.Drawing.Point(13, 132);
            this.check_circle.Name = "check_circle";
            this.check_circle.Size = new System.Drawing.Size(80, 17);
            this.check_circle.TabIndex = 8;
            this.check_circle.Text = "Draw Circle";
            this.check_circle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 582);
            this.Controls.Add(this.check_circle);
            this.Controls.Add(this.btn_deleteLine);
            this.Controls.Add(this.btn_chooseColor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.numericUD_size);
            this.Controls.Add(this.textbox_chooseSize);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUD_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_chooseSize;
        private System.Windows.Forms.NumericUpDown numericUD_size;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_chooseColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_deleteLine;
        private System.Windows.Forms.CheckBox check_circle;
    }
}

