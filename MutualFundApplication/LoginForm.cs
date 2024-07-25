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

namespace MutualFundApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //Btn_Login.Enabled = false;
            //Btn_Reg.Enabled = false;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=TantranshsolutionDB;Integrated Security=True");

        //private string registeredUsername = "textBox_Username";
        //private string registeredPassword = "textBox_Password";
        private void Btn_Login_Click(object sender, EventArgs e)
        {


            //if (textBox_UsernameL.Text == "Admin" && textBox_PasswordL.Text == "123")
            //{
            //    MessageBox.Show("Go to the database");
            ////}
            








            //if (enteredUsername == registeredUsername && enteredPassword == registeredPassword)
            //{
            //    DialogResult dr = MessageBox.Show(this, "Do you want to login", "Confirmation", MessageBoxButtons.OKCancel);
            //    if (dr == DialogResult.OK)
            //    {
            //        MessageBox.Show("User Login Successfully");

            //        Form1 f1 = new Form1();
            //        f1.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid User");
            //        textBox_UsernameL.Clear();
            //        textBox_PasswordL.Clear();
            //        RdBtn_Admin.Checked = false;
            //        RdBtn_User.Checked = false;
            //        textBox_UsernameL.Focus();
            //    }

            //}

            string enteredUsername = textBox_UsernameL.Text;
           // string enteredPassword = textBox_PasswordL.Text;

            string query = "SELECT * FROM RegiTbl WHERE Username = @Uname;";
           

            using (SqlCommand cmd = new SqlCommand(query, con))
                {
              
                cmd.Parameters.AddWithValue("@Uname", enteredUsername);
               

                try
                    {
                    
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        {


                      
                        if (reader.Read())
                            {

                           

                            string registeredUsername = reader["username"].ToString();
                                string registeredPassword = reader["password"].ToString();


                            Btn_Login.Enabled = true;
                            Btn_Reg.Enabled = false;

                            DialogResult dr = MessageBox.Show(this, "User Login Successfully","Confirm", MessageBoxButtons.OKCancel);

                            if(dr==DialogResult.Cancel)
                            {
                                textBox_UsernameL.Clear();
                                textBox_PasswordL.Clear();
                               Btn_Reg.Enabled = true;
                            }
                            else
                            {
                                Form1 f1 = new Form1();
                                f1.Show();
                                this.Hide();
                            }

                            }
               
                            else
                            {

                                MessageBox.Show("Invalid User");
                                textBox_UsernameL.Clear();
                                textBox_PasswordL.Clear();
                                textBox_UsernameL.Focus();
                            }
                        }
                        con.Close();

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show("Sql Error:" + ex.Message);
                    }



                }
            }
        


        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            //textBox_UsernameL.Clear();
            //textBox_PasswordL.Clear();
            //RdBtn_Admin.Checked = false;
            //RdBtn_User.Checked = false;

        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {

            Registration rg = new Registration();
            rg.Show();
            this.Hide();

        }

    }
}

