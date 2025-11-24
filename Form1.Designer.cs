namespace Plane_Simulator
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
            landing_prep = new Button();
            turbulence = new Button();
            belts = new Button();
            thanks = new Button();
            beep = new Button();
            forward = new Button();
            stop = new Button();
            power = new Button();
            exit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)light).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plane).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(light);
            panel1.Controls.Add(plane);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 552);
            panel1.TabIndex = 0;
            // 
            // light
            // 
            light.Image = (Image)resources.GetObject("light.Image");
            light.Location = new Point(134, 278);
            light.Margin = new Padding(3, 2, 3, 2);
            light.Name = "light";
            light.Size = new Size(35, 30);
            light.SizeMode = PictureBoxSizeMode.StretchImage;
            light.TabIndex = 10;
            light.TabStop = false;
            // 
            // plane
            // 
            plane.Image = (Image)resources.GetObject("plane.Image");
            plane.Location = new Point(80, 431);
            plane.Name = "plane";
            plane.Size = new Size(190, 280);
            plane.SizeMode = PictureBoxSizeMode.StretchImage;
            plane.TabIndex = 0;
            plane.TabStop = false;
            // 
            // landing_prep
            // 
            landing_prep.BackColor = Color.Teal;
            landing_prep.Cursor = Cursors.Hand;
            landing_prep.FlatStyle = FlatStyle.Flat;
            landing_prep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            landing_prep.ForeColor = Color.White;
            landing_prep.Location = new Point(326, 14);
            landing_prep.Margin = new Padding(3, 2, 3, 2);
            landing_prep.Name = "landing_prep";
            landing_prep.Size = new Size(326, 46);
            landing_prep.TabIndex = 1;
            landing_prep.Text = "Eniş hazırlığı";
            landing_prep.UseVisualStyleBackColor = false;
            landing_prep.Click += landing_prep_Click;
            // 
            // turbulence
            // 
            turbulence.BackColor = Color.Teal;
            turbulence.Cursor = Cursors.Hand;
            turbulence.FlatStyle = FlatStyle.Flat;
            turbulence.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turbulence.ForeColor = Color.White;
            turbulence.Location = new Point(326, 70);
            turbulence.Margin = new Padding(3, 2, 3, 2);
            turbulence.Name = "turbulence";
            turbulence.Size = new Size(326, 46);
            turbulence.TabIndex = 2;
            turbulence.Text = "Turbulans";
            turbulence.UseVisualStyleBackColor = false;
            turbulence.Click += turbulence_Click;
            // 
            // belts
            // 
            belts.BackColor = Color.Teal;
            belts.Cursor = Cursors.Hand;
            belts.FlatStyle = FlatStyle.Flat;
            belts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            belts.ForeColor = Color.White;
            belts.Location = new Point(326, 124);
            belts.Margin = new Padding(3, 2, 3, 2);
            belts.Name = "belts";
            belts.Size = new Size(326, 46);
            belts.TabIndex = 3;
            belts.Text = "Kəmərlər";
            belts.UseVisualStyleBackColor = false;
            belts.Click += belts_Click;
            // 
            // thanks
            // 
            thanks.BackColor = Color.Teal;
            thanks.Cursor = Cursors.Hand;
            thanks.FlatStyle = FlatStyle.Flat;
            thanks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thanks.ForeColor = Color.White;
            thanks.Location = new Point(326, 180);
            thanks.Margin = new Padding(3, 2, 3, 2);
            thanks.Name = "thanks";
            thanks.Size = new Size(326, 46);
            thanks.TabIndex = 4;
            thanks.Text = "Təşəkkürlər";
            thanks.UseVisualStyleBackColor = false;
            thanks.Click += thanks_Click;
            // 
            // beep
            // 
            beep.BackColor = Color.Teal;
            beep.Cursor = Cursors.Hand;
            beep.FlatStyle = FlatStyle.Flat;
            beep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            beep.ForeColor = Color.White;
            beep.Location = new Point(326, 236);
            beep.Margin = new Padding(3, 2, 3, 2);
            beep.Name = "beep";
            beep.Size = new Size(326, 46);
            beep.TabIndex = 5;
            beep.Text = "Səs siqnalı";
            beep.UseVisualStyleBackColor = false;
            beep.Click += beep_Click;
            // 
            // forward
            // 
            forward.BackColor = Color.Green;
            forward.Cursor = Cursors.Hand;
            forward.FlatStyle = FlatStyle.Flat;
            forward.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forward.ForeColor = Color.White;
            forward.Location = new Point(326, 308);
            forward.Margin = new Padding(3, 2, 3, 2);
            forward.Name = "forward";
            forward.Size = new Size(140, 68);
            forward.TabIndex = 6;
            forward.Text = "İRƏLİ";
            forward.UseVisualStyleBackColor = false;
            forward.Click += forward_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.DarkRed;
            stop.Cursor = Cursors.Hand;
            stop.FlatStyle = FlatStyle.Flat;
            stop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stop.ForeColor = Color.White;
            stop.Location = new Point(511, 308);
            stop.Margin = new Padding(3, 2, 3, 2);
            stop.Name = "stop";
            stop.Size = new Size(140, 68);
            stop.TabIndex = 7;
            stop.Text = "DAYAN";
            stop.UseVisualStyleBackColor = false;
            stop.Click += stop_Click;
            // 
            // power
            // 
            power.BackColor = Color.Blue;
            power.Cursor = Cursors.Hand;
            power.FlatStyle = FlatStyle.Flat;
            power.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            power.ForeColor = Color.White;
            power.Location = new Point(326, 392);
            power.Margin = new Padding(3, 2, 3, 2);
            power.Name = "power";
            power.Size = new Size(326, 46);
            power.TabIndex = 8;
            power.Text = "İŞƏ SAL/SÖNDÜR";
            power.UseVisualStyleBackColor = false;
            power.Click += power_Click;
            // 
            // exit
            // 
            exit.Location = new Point(0, 0);
            exit.Margin = new Padding(3, 2, 3, 2);
            exit.Name = "exit";
            exit.Size = new Size(66, 17);
            exit.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(670, 552);
            Controls.Add(exit);
            Controls.Add(power);
            Controls.Add(stop);
            Controls.Add(forward);
            Controls.Add(beep);
            Controls.Add(thanks);
            Controls.Add(belts);
            Controls.Add(turbulence);
            Controls.Add(landing_prep);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Plane simulator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)light).EndInit();
            ((System.ComponentModel.ISupportInitialize)plane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox plane;
        private Button landing_prep;
        private Button turbulence;
        private Button belts;
        private Button thanks;
        private Button beep;
        private Button forward;
        private Button stop;
        private Button power;
        private Button exit;
        private System.Windows.Forms.Timer timer1;
        private PictureBox light;
    }
}
