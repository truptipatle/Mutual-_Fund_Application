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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\MSSQLSERVER04;Initial Catalog=TantranshsolutionDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void GoToLogin_Lbl_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlParameter p1 = new SqlParameter("@name", SqlDbType.VarChar);
            p1.Value = textBox_Name.Text.Trim();

            SqlParameter p2 = new SqlParameter("@Uname", SqlDbType.NVarChar);
            p2.Value = textBox_Username.Text.Trim();

            SqlParameter p3 = new SqlParameter("@Pass", SqlDbType.NVarChar);
            p3.Value = textBox_Password.Text.Trim();

            SqlParameter p4 = new SqlParameter("@age", SqlDbType.Int);
            p4.Value = textBox_Age.Text.Trim();

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.Connection = con;
          

            cmd.CommandText = "Insert into RegiTbl(Name, Username, Password, Age) values (@name, @Uname, @Pass, @age )";
            
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
            MessageBox.Show("Insert Data Successfully");
            //alert_lbl.Text = "Registration Successsfully";

            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();


        }
    }
}
