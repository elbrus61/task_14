
using System.Media;

namespace task_14
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        bool isOn = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            light.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Downloads\\inishazirliklari.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Teyyareni ise salin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Downloads\\turbulans.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Teyyareni ise salin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Downloads\\kemerler.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Teyyareni ise salin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Downloads\\tesekkurler.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Teyyareni ise salin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Downloads\\beep.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Teyyareni ise salin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
     

        private void button6_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Teyyareni ise salin", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            speed = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("C:\\Users\\user\\Downloads\\isikacmakapamasesi.wav");
            sound.Play();
            if (isOn)
            {
                isOn = false;
                light.Visible = false;
                timer1.Stop();
                speed = 0;
            }
            else
            {
                isOn = true;
                light.Visible = true;
            }
        }
        int speed = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (light.Top - speed <= 0)
            {
                light.Top = 0;
                plane.Top = 60;
                timer1.Stop();
            }
            else
            {
                speed++;
                plane.Top -= speed;
                light.Top -= speed;
            }
        }

     
    }
}

