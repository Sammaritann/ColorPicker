namespace TestColor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorEditorManager1 = new Cyotek.Windows.Forms.ColorEditorManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RGB1 = new System.Windows.Forms.NumericUpDown();
            this.RGB2 = new System.Windows.Forms.NumericUpDown();
            this.RGB3 = new System.Windows.Forms.NumericUpDown();
            this.XYZ3 = new System.Windows.Forms.NumericUpDown();
            this.XYZ2 = new System.Windows.Forms.NumericUpDown();
            this.XYZ1 = new System.Windows.Forms.NumericUpDown();
            this.CMYK3 = new System.Windows.Forms.NumericUpDown();
            this.CMYK2 = new System.Windows.Forms.NumericUpDown();
            this.CMYK1 = new System.Windows.Forms.NumericUpDown();
            this.CMYK4 = new System.Windows.Forms.NumericUpDown();
            this.RGBBar1 = new System.Windows.Forms.TrackBar();
            this.RGBBar2 = new System.Windows.Forms.TrackBar();
            this.RGBBar3 = new System.Windows.Forms.TrackBar();
            this.XYZBar3 = new System.Windows.Forms.TrackBar();
            this.XYZBar2 = new System.Windows.Forms.TrackBar();
            this.XYZBar1 = new System.Windows.Forms.TrackBar();
            this.CMYKBar3 = new System.Windows.Forms.TrackBar();
            this.CMYKBar2 = new System.Windows.Forms.TrackBar();
            this.CMYKBar1 = new System.Windows.Forms.TrackBar();
            this.CMYKBar4 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RGB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.ShowHelp = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RGB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMYK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "XYZ";
            // 
            // RGB1
            // 
            this.RGB1.Location = new System.Drawing.Point(16, 36);
            this.RGB1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGB1.Name = "RGB1";
            this.RGB1.Size = new System.Drawing.Size(45, 20);
            this.RGB1.TabIndex = 3;
            // 
            // RGB2
            // 
            this.RGB2.Location = new System.Drawing.Point(16, 70);
            this.RGB2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGB2.Name = "RGB2";
            this.RGB2.Size = new System.Drawing.Size(45, 20);
            this.RGB2.TabIndex = 4;
            // 
            // RGB3
            // 
            this.RGB3.Location = new System.Drawing.Point(16, 109);
            this.RGB3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RGB3.Name = "RGB3";
            this.RGB3.Size = new System.Drawing.Size(45, 20);
            this.RGB3.TabIndex = 5;
            // 
            // XYZ3
            // 
            this.XYZ3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYZ3.DecimalPlaces = 4;
            this.XYZ3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.XYZ3.Location = new System.Drawing.Point(594, 111);
            this.XYZ3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XYZ3.Name = "XYZ3";
            this.XYZ3.Size = new System.Drawing.Size(66, 20);
            this.XYZ3.TabIndex = 8;
            this.XYZ3.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // XYZ2
            // 
            this.XYZ2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYZ2.DecimalPlaces = 4;
            this.XYZ2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.XYZ2.Location = new System.Drawing.Point(594, 75);
            this.XYZ2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XYZ2.Name = "XYZ2";
            this.XYZ2.Size = new System.Drawing.Size(66, 20);
            this.XYZ2.TabIndex = 7;
            // 
            // XYZ1
            // 
            this.XYZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYZ1.DecimalPlaces = 4;
            this.XYZ1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.XYZ1.Location = new System.Drawing.Point(594, 40);
            this.XYZ1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XYZ1.Name = "XYZ1";
            this.XYZ1.Size = new System.Drawing.Size(66, 20);
            this.XYZ1.TabIndex = 6;
            // 
            // CMYK3
            // 
            this.CMYK3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYK3.Location = new System.Drawing.Point(16, 281);
            this.CMYK3.Name = "CMYK3";
            this.CMYK3.Size = new System.Drawing.Size(45, 20);
            this.CMYK3.TabIndex = 11;
            // 
            // CMYK2
            // 
            this.CMYK2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYK2.Location = new System.Drawing.Point(16, 245);
            this.CMYK2.Name = "CMYK2";
            this.CMYK2.Size = new System.Drawing.Size(45, 20);
            this.CMYK2.TabIndex = 10;
            // 
            // CMYK1
            // 
            this.CMYK1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYK1.Location = new System.Drawing.Point(16, 210);
            this.CMYK1.Name = "CMYK1";
            this.CMYK1.Size = new System.Drawing.Size(45, 20);
            this.CMYK1.TabIndex = 9;
            // 
            // CMYK4
            // 
            this.CMYK4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYK4.Location = new System.Drawing.Point(16, 318);
            this.CMYK4.Name = "CMYK4";
            this.CMYK4.Size = new System.Drawing.Size(45, 20);
            this.CMYK4.TabIndex = 12;
            // 
            // RGBBar1
            // 
            this.RGBBar1.LargeChange = 1;
            this.RGBBar1.Location = new System.Drawing.Point(97, 40);
            this.RGBBar1.Maximum = 255;
            this.RGBBar1.Name = "RGBBar1";
            this.RGBBar1.Size = new System.Drawing.Size(104, 45);
            this.RGBBar1.TabIndex = 1;
            // 
            // RGBBar2
            // 
            this.RGBBar2.LargeChange = 1;
            this.RGBBar2.Location = new System.Drawing.Point(97, 75);
            this.RGBBar2.Maximum = 255;
            this.RGBBar2.Name = "RGBBar2";
            this.RGBBar2.Size = new System.Drawing.Size(104, 45);
            this.RGBBar2.TabIndex = 13;
            // 
            // RGBBar3
            // 
            this.RGBBar3.LargeChange = 1;
            this.RGBBar3.Location = new System.Drawing.Point(97, 111);
            this.RGBBar3.Maximum = 255;
            this.RGBBar3.Name = "RGBBar3";
            this.RGBBar3.Size = new System.Drawing.Size(104, 45);
            this.RGBBar3.TabIndex = 14;
            // 
            // XYZBar3
            // 
            this.XYZBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYZBar3.LargeChange = 1;
            this.XYZBar3.Location = new System.Drawing.Point(658, 111);
            this.XYZBar3.Maximum = 10000;
            this.XYZBar3.Name = "XYZBar3";
            this.XYZBar3.Size = new System.Drawing.Size(104, 45);
            this.XYZBar3.TabIndex = 17;
            // 
            // XYZBar2
            // 
            this.XYZBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYZBar2.LargeChange = 1;
            this.XYZBar2.Location = new System.Drawing.Point(658, 75);
            this.XYZBar2.Maximum = 10000;
            this.XYZBar2.Name = "XYZBar2";
            this.XYZBar2.Size = new System.Drawing.Size(104, 45);
            this.XYZBar2.TabIndex = 16;
            // 
            // XYZBar1
            // 
            this.XYZBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYZBar1.LargeChange = 1;
            this.XYZBar1.Location = new System.Drawing.Point(658, 40);
            this.XYZBar1.Maximum = 10000;
            this.XYZBar1.Name = "XYZBar1";
            this.XYZBar1.Size = new System.Drawing.Size(104, 45);
            this.XYZBar1.TabIndex = 15;
            // 
            // CMYKBar3
            // 
            this.CMYKBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYKBar3.LargeChange = 1;
            this.CMYKBar3.Location = new System.Drawing.Point(97, 281);
            this.CMYKBar3.Maximum = 100;
            this.CMYKBar3.Name = "CMYKBar3";
            this.CMYKBar3.Size = new System.Drawing.Size(104, 45);
            this.CMYKBar3.TabIndex = 20;
            // 
            // CMYKBar2
            // 
            this.CMYKBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYKBar2.LargeChange = 1;
            this.CMYKBar2.Location = new System.Drawing.Point(97, 245);
            this.CMYKBar2.Maximum = 100;
            this.CMYKBar2.Name = "CMYKBar2";
            this.CMYKBar2.Size = new System.Drawing.Size(104, 45);
            this.CMYKBar2.TabIndex = 19;
            // 
            // CMYKBar1
            // 
            this.CMYKBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYKBar1.LargeChange = 1;
            this.CMYKBar1.Location = new System.Drawing.Point(97, 210);
            this.CMYKBar1.Maximum = 100;
            this.CMYKBar1.Name = "CMYKBar1";
            this.CMYKBar1.Size = new System.Drawing.Size(104, 45);
            this.CMYKBar1.TabIndex = 18;
            // 
            // CMYKBar4
            // 
            this.CMYKBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMYKBar4.LargeChange = 1;
            this.CMYKBar4.Location = new System.Drawing.Point(97, 318);
            this.CMYKBar4.Maximum = 100;
            this.CMYKBar4.Name = "CMYKBar4";
            this.CMYKBar4.Size = new System.Drawing.Size(104, 45);
            this.CMYKBar4.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(242, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 254);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // colorWheel1
            // 
            this.colorWheel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(594, 156);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(168, 170);
            this.colorWheel1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(242, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "rounding occurred to limit values";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "G";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "C";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "M";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "K";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(577, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "X";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(577, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Z";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorWheel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CMYKBar4);
            this.Controls.Add(this.CMYKBar3);
            this.Controls.Add(this.CMYKBar2);
            this.Controls.Add(this.CMYKBar1);
            this.Controls.Add(this.XYZBar3);
            this.Controls.Add(this.XYZBar2);
            this.Controls.Add(this.XYZBar1);
            this.Controls.Add(this.RGBBar3);
            this.Controls.Add(this.RGBBar2);
            this.Controls.Add(this.RGBBar1);
            this.Controls.Add(this.CMYK4);
            this.Controls.Add(this.CMYK3);
            this.Controls.Add(this.CMYK2);
            this.Controls.Add(this.CMYK1);
            this.Controls.Add(this.XYZ3);
            this.Controls.Add(this.XYZ2);
            this.Controls.Add(this.XYZ1);
            this.Controls.Add(this.RGB3);
            this.Controls.Add(this.RGB2);
            this.Controls.Add(this.RGB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RGB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYK4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGBBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYZBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CMYKBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private Cyotek.Windows.Forms.ColorEditorManager colorEditorManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RGB1;
        private System.Windows.Forms.NumericUpDown RGB2;
        private System.Windows.Forms.NumericUpDown RGB3;
        private System.Windows.Forms.NumericUpDown XYZ3;
        private System.Windows.Forms.NumericUpDown XYZ2;
        private System.Windows.Forms.NumericUpDown XYZ1;
        private System.Windows.Forms.NumericUpDown CMYK3;
        private System.Windows.Forms.NumericUpDown CMYK2;
        private System.Windows.Forms.NumericUpDown CMYK1;
        private System.Windows.Forms.NumericUpDown CMYK4;
        private System.Windows.Forms.TrackBar RGBBar1;
        private System.Windows.Forms.TrackBar RGBBar2;
        private System.Windows.Forms.TrackBar RGBBar3;
        private System.Windows.Forms.TrackBar XYZBar3;
        private System.Windows.Forms.TrackBar XYZBar2;
        private System.Windows.Forms.TrackBar XYZBar1;
        private System.Windows.Forms.TrackBar CMYKBar3;
        private System.Windows.Forms.TrackBar CMYKBar2;
        private System.Windows.Forms.TrackBar CMYKBar1;
        private System.Windows.Forms.TrackBar CMYKBar4;
        private System.Windows.Forms.Button button1;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

