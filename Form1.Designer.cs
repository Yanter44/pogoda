namespace pogoda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tempLabel = new Label();
            label4 = new Label();
            CityNameLabel = new Label();
            WindSpeedLabel = new Label();
            WindSpeedLabeJson = new Label();
            label5 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            Clearbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(12, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Menu;
            label1.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(144, 24);
            label1.TabIndex = 1;
            label1.Text = "Enter your city";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 208);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 14);
            label2.TabIndex = 4;
            label2.Text = "LATITUDE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 146);
            label3.Name = "label3";
            label3.Size = new Size(84, 14);
            label3.TabIndex = 5;
            label3.Text = "LONGTITUDE";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tempLabel.Location = new Point(237, 120);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(0, 25);
            tempLabel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 86);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Temperature";
            // 
            // CityNameLabel
            // 
            CityNameLabel.AutoSize = true;
            CityNameLabel.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CityNameLabel.Location = new Point(237, 29);
            CityNameLabel.Name = "CityNameLabel";
            CityNameLabel.Size = new Size(0, 23);
            CityNameLabel.TabIndex = 8;
            CityNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WindSpeedLabel
            // 
            WindSpeedLabel.AutoSize = true;
            WindSpeedLabel.Location = new Point(237, 163);
            WindSpeedLabel.Name = "WindSpeedLabel";
            WindSpeedLabel.Size = new Size(69, 15);
            WindSpeedLabel.TabIndex = 9;
            WindSpeedLabel.Text = "Wind speed";
            // 
            // WindSpeedLabeJson
            // 
            WindSpeedLabeJson.AutoSize = true;
            WindSpeedLabeJson.Location = new Point(237, 197);
            WindSpeedLabeJson.Name = "WindSpeedLabeJson";
            WindSpeedLabeJson.Size = new Size(0, 15);
            WindSpeedLabeJson.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 197);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "meters per second";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 128);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 12;
            label6.Text = "degrees";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(237, 426);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(291, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Узнать широту и долготу вашего города можно тут";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.MouseEnter += linkLabel1_MouseEnter;
            linkLabel1.MouseLeave += linkLabel1_MouseLeave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 37);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(403, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Clearbutton
            // 
            Clearbutton.FlatStyle = FlatStyle.Flat;
            Clearbutton.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Clearbutton.Location = new Point(12, 260);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(144, 32);
            Clearbutton.TabIndex = 16;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = true;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Clearbutton);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(WindSpeedLabeJson);
            Controls.Add(WindSpeedLabel);
            Controls.Add(CityNameLabel);
            Controls.Add(label4);
            Controls.Add(tempLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Погода";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label tempLabel;
        private Label label4;
        private Label CityNameLabel;
        private Label WindSpeedLabel;
        private Label WindSpeedLabeJson;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label7;
        private PictureBox pictureBox1;
        private Button Clearbutton;
    }
}