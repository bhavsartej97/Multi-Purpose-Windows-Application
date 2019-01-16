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
    public partial class FlashPlayer : Form
    {
        public FlashPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Dock = DockStyle.Fill;
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axShockwaveFlash1.Movie = openFileDialog1.FileName;
                axShockwaveFlash1.Play();
            }
        }
    }
}
