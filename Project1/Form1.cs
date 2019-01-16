using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                String uname, pass, dbuname, dbpass;
                uname = textBox1.Text;
                pass = textBox2.Text;
                String str = "Data Source=(localdb)\\Projects;Initial Catalog=Database2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

                
                String sql = "Select username, password from dbo.test where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'";
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand(sql);
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dbuname = rdr["username"].ToString();
                    dbpass = rdr["password"].ToString();
                    if (pass == dbpass)
                    {

                        MessageBox.Show("Invalid Username!!!");
                    }

                    else
                    {
                        LoginForm2 lf2 = new LoginForm2();
                        lf2.Show();
                        this.Hide();
                    }
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
