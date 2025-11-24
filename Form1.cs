using System.Media;
namespace Plane_Simulator
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

        private void landing_prep_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\Nicat\\Desktop\\C#\\sound\\landing_prep.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Əvvəlcə təyyarəni işə salın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void turbulence_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\Nicat\\Desktop\\C#\\sound\\turbulence.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Əvvəlcə təyyarəni işə salın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void belts_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\Nicat\\Desktop\\C#\\sound\\belts.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Əvvəlcə təyyarəni işə salın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thanks_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\Nicat\\Desktop\\C#\\sound\\thanks.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Əvvəlcə təyyarəni işə salın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void beep_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                SoundPlayer sound = new SoundPlayer("C:\\Users\\Nicat\\Desktop\\C#\\sound\\beep.wav");
                sound.Play();
            }
            else
            {
                MessageBox.Show("Əvvəlcə təyyarəni işə salın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void forward_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Əvvəlcə təyyarəni işə salın!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            speed = 0;
        }

        private void power_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer("C:\\Users\\Nicat\\Desktop\\C#\\sound\\power.wav");
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
