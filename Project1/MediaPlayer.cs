using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {

        }

       

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
                axWindowsMediaPlayer1.settings.autoStart = true;
            }
        }

        private void increaseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume++;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume + 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume + 5;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume + 10;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume - 1;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume - 2;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume - 5;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = axWindowsMediaPlayer1.settings.volume - 10;
        }

        private void muteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = true;
            //axWindowsMediaPlayer1.newPlaylist()
        }

        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //axWindowsMediaPlayer1.newPlaylist(openFileDialog1.file, openFileDialog1.FileName);
                axWindowsMediaPlayer1.settings.autoStart = true;

            }
        }

        private void flashPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashPlayer fp = new FlashPlayer();
            fp.Show();
        }
    }
}
