using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.govno;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.zvuk_ponosa_21);
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ssaki;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.zvuk_pisaniya_v_unitaz);
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.pngwing_com;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.smyv_unitaza_7);
            player.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
