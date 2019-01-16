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
    public partial class LoginForm2 : Form
    {
        public LoginForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageViewer iv = new ImageViewer();
            iv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextEditor te = new TextEditor();
            te.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MediaPlayer mp = new MediaPlayer();
            mp.Show();
        }
    }
}
