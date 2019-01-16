using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // saveFileDialog1.ShowDialog();  
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)   
            {
                string name = saveFileDialog1.FileName + ".txt";   
                File.WriteAllText(name, richTextBox1.Text);                
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text|*.txt|All|*.*";
            //openFileDialog1.ShowDialog();   
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Contains(".txt")) //Checks if it's all ok and if the file name contains .txt  
            {
                string open = File.ReadAllText(openFileDialog1.FileName);   
                richTextBox1.Text = open;   
            }
            else   
            {
                MessageBox.Show("The file you've chosen is not a text file");
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fontDialog1.ShowDialog();    
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;   
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

       
    }
}
