namespace task_14
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            light = new PictureBox();
            plane = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)light).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plane).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(light);
            panel1.Controls.Add(plane);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 450);
            panel1.TabIndex = 0;
            // 
            // light
            // 
            light.Image = (Image)resources.GetObject("light.Image");
            light.Location = new Point(100, 186);
            light.Name = "light";
            light.Size = new Size(52, 44);
            light.SizeMode = PictureBoxSizeMode.Zoom;
            light.TabIndex = 1;
            light.TabStop = false;
            // 
            // plane
            // 
            plane.Image = (Image)resources.GetObject("plane.Image");
            plane.Location = new Point(45, 236);
            plane.Name = "plane";
            plane.Size = new Size(164, 202);
            plane.SizeMode = PictureBoxSizeMode.Zoom;
            plane.TabIndex = 0;
            plane.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(271, 12);
            button1.Name = "button1";
            button1.Size = new Size(301, 54);
            button1.TabIndex = 0;
            button1.Text = "Enis Hazirligi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(271, 72);
            button2.Name = "button2";
            button2.Size = new Size(301, 54);
            button2.TabIndex = 1;
            button2.Text = "Turbulans";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 0);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(271, 132);
            button3.Name = "button3";
            button3.Size = new Size(301, 54);
            button3.TabIndex = 2;
            button3.Text = "Kemerler";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(271, 192);
            button4.Name = "button4";
            button4.Size = new Size(301, 54);
            button4.TabIndex = 3;
            button4.Text = "Tesekkurler";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(271, 252);
            button5.Name = "button5";
            button5.Size = new Size(301, 54);
            button5.TabIndex = 4;
            button5.Text = "Beep";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(288, 324);
            button6.Name = "button6";
            button6.Size = new Size(114, 54);
            button6.TabIndex = 5;
            button6.Text = "Gas";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(440, 324);
            button7.Name = "button7";
            button7.Size = new Size(114, 54);
            button7.TabIndex = 6;
            button7.Text = "Break";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Blue;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(288, 395);
            button8.Name = "button8";
            button8.Size = new Size(266, 43);
            button8.TabIndex = 7;
            button8.Text = "ON/OFF";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)light).EndInit();
            ((System.ComponentModel.ISupportInitialize)plane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox light;
        private PictureBox plane;
        private System.Windows.Forms.Timer timer1;
    }
}
