using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Boolean err = false;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Set your User Name");
                err = true;
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter your name");
                err = true;
            }

            else if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Password");
                err = true;
            }

            else if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Passwords don't match");
                err = true;
            }

            if (err == false)
            {
                try
                {
                    String str = "Data Source=(localdb)\\Projects;Initial Catalog=Database2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                    

                    String sql = "insert into dbo.test (username, password, name, mobile) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    
                    SqlConnection conn = new SqlConnection(str);
                    
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    
                    cmd.ExecuteNonQuery();

                    //SqlDataAdapter adapter = new SqlDataAdapter();
                    //DataSet ds =new DataSet();
                    //DataRow dr;
                    //dr = ds.Tables[0].NewRow();
                    //dr["username"] = textBox1.Text;
                    //dr["name"] = textBox2.Text;
                    //dr["mobile"] = textBox3.Text;
                    //dr["password"] = textBox4.Text;
                    //ds.Tables[0].Rows.Add(dr);

                    //SqlCommandBuilder builder;
                    //builder = new SqlCommandBuilder(adapter);
                    //adapter = builder.DataAdapter;
                    //adapter.Update(ds,"UserDetails");
                    conn.Close();
                    LoginForm2 lf2 = new LoginForm2();
                    lf2.Show();
                    this.Hide();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); Console.WriteLine(ex.ToString()); }

               

            }
        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
