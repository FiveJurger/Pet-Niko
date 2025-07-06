using System.Media;

namespace Niko
{
    public partial class Niko : Form
    {


        SoundPlayer player = new SoundPlayer(@"Resources\SFX\Cat.wav");
        public Niko()
        {
            InitializeComponent();

            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            Task.Run(() =>
            {
                player.SoundLocation = @"C:Resources\SFX\Cat.wav";
                player.Load();
                player.PlaySync();

                this.Invoke((MethodInvoker)delegate {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                });
            });
        }
    }
}
