using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MutualFundApplication
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Insert_Btn.Enabled = false;
            Modify_Btn.Enabled = false;
            Delete_Btn.Enabled = false;
            Clear_Btn.Enabled = false;

            //Calculate Amount 
            textBox_Unit.TextChanged += UpdateAmountLabel;

            UpdateTextBox();

            EventHandler();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-2713M6I\\SQLEXPRESS;Initial Catalog=MutalFundDB;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter();
       

        
        private void UpdateTextBox()
        {
            textBox_folio.TextChanged += TextBox_TextChanged;
            textBox_Scheme.TextChanged += TextBox_TextChanged;
            textBox_NAV.TextChanged += TextBox_TextChanged;
            textBox_Unit.TextChanged += TextBox_TextChanged;
            Amount_Lbl.TextChanged += TextBox_TextChanged;
        }

        private bool anyTextboxUpdate;
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (anyTextboxUpdate = textBox_folio.Text.Trim() == "" ||
                           textBox_Scheme.Text.Trim() == "" ||
                           textBox_NAV.Text.Trim() == "" ||
                           textBox_Unit.Text.Trim() == "" ||
                           Amount_Lbl.Text.Trim() == "" || (isModify == 1) && (isModify == 0))



            {
                Insert_Btn.Enabled = false;
                //Modify_Btn.Enabled = true;
               // Delete_Btn.Enabled = true; 
                

            }
           /* if (anyTextboxUpdate = textBox_folio.Text.Trim() == "" &&*/
           //               textBox_Scheme.Text.Trim() == "" &&
           //               textBox_NAV.Text.Trim() == ""  &&                        
           //               textBox_Unit.Text.Trim() == "" &&
           //
           //    Amount_Lbl.Text.Trim() == "" && (isModify == 0) || (isModify == 0))
            else
            {
                Insert_Btn.Enabled = true;
                // Modify_Btn.Enabled = false;
                //Delete_Btn.Enabled = false;
            }
            

        }

        

         

        //if user enter value in textbox then automatically amount show in the Amount Lable
        private void UpdateAmountLabel(object sender, EventArgs e)
        {
            //decimal nav;
            //decimal unit;

            if (decimal.TryParse(textBox_NAV.Text, out decimal nav) &&
                decimal.TryParse(textBox_Unit.Text, out decimal unit))
            {
                decimal amount = (nav * unit);
                Amount_Lbl.Text = amount.ToString();
            }
            else
            {
                Amount_Lbl.Text = "Invalid Output";
                //MessageBox.Show("Error: Invalid Input");
            }
        }

        private void EventHandler()
        {
            //textBox_folio.TextChanged += AllTextboxFill;
            //textBox_Scheme.TextChanged += AllTextboxFill;
            //textBox_NAV.TextChanged += AllTextboxFill;
            //textBox_Unit.TextChanged += AllTextboxFill;
            //Amount_Lbl.TextChanged += AllTextboxFill;

            //  dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // bool isRowSelected = dataGridView1.SelectedRows.Count > 0;
        }

        private int isModify = 0;
        private bool AreAllTextBoxesFilled()

        {
            return(true);

            if ((textBox_folio.Text.Trim() != ""
                && textBox_Scheme.Text.Trim() != ""
                && textBox_NAV.Text.Trim() != ""
                && textBox_Unit.Text.Trim() != ""
                && Amount_Lbl.Text.Trim() != "") /*&& (isModify == 0)*/)
            {
                Insert_Btn.Enabled = AreAllTextBoxesFilled();
                //Modify_Btn.Enabled = false;
                //Delete_Btn.Enabled = false;
            }
            else
            {
                Insert_Btn.Enabled = false;
                //Modify_Btn.Enabled = true;
                //Delete_Btn.Enabled = true;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateTotalAmount();
            
        }
        private void LoadData()
        {
            sda = new SqlDataAdapter("Select Mid, FolioNumber,SchemeName,NAV,PurchaseDate,Units,Amount from MfaTB where isDeleted = 0 ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public int Mid { get; set; }
        private void Insert_Btn_Click(object sender, EventArgs e)
        {
            try
            { 
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    SqlParameter p1 = new SqlParameter("@folioNumber", SqlDbType.Int);
                    p1.Value = textBox_folio.Text.Trim();

                    SqlParameter p2 = new SqlParameter("@schemeName", SqlDbType.VarChar);
                    p2.Value = textBox_Scheme.Text.Trim();

                    SqlParameter p3 = new SqlParameter("@nav", SqlDbType.Decimal);
                    p3.Value = textBox_NAV.Text.Trim();

                    SqlParameter p4 = new SqlParameter("@purchaseDate", SqlDbType.NVarChar);
                    p4.Value = dateTimePicker1.Value.ToShortDateString();

                    SqlParameter p5 = new SqlParameter("@unit", SqlDbType.Decimal);
                    p5.Value = textBox_Unit.Text.Trim();

                    SqlParameter p6 = new SqlParameter("@amount", SqlDbType.Decimal);
                    p6.Value = Amount_Lbl.Text.Trim();

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    DialogResult dr = MessageBox.Show("Do you want to Insert Data", "Confirmation", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        cmd.CommandText = "INSERT INTO MfaTB(FolioNumber, SchemeName, NAV, PurchaseDate, Units, Amount, isDeleted) VALUES (@folioNumber, @schemeName, @nav, @purchaseDate, @unit, @amount, 0 )";

                        con.Open();
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Insert Data Successfully");

                        textBox_folio.Clear();
                        textBox_Scheme.Clear();
                        textBox_NAV.Clear();
                        textBox_Unit.Clear();
                        Amount_Lbl.Text = "";
                        textBox_folio.Focus();

                        LoadData();
                    }
                    else
                    {
                        textBox_folio.Text = "";
                        textBox_Scheme.Text = "";
                        textBox_NAV.Text = "";
                        textBox_Unit.Text = "";
                        Amount_Lbl.Text = "";
                        textBox_folio.Focus();
                    }
                }
                con.Close();
                UpdateTotalAmount();
                //Insert_Btn.Enabled = true;
                //Modify_Btn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Modify_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    SqlParameter p1 = new SqlParameter("@folioNumber", SqlDbType.Int);
                    p1.Value = textBox_folio.Text.Trim();
                    //int folioNumber;

                    //// Attempt to parse the value from textBox_folio.Text to an integer
                    //if (int.TryParse(textBox_folio.Text.Trim(), out folioNumber))
                    //{
                    //    // Conversion successful, assign the integer value to the parameter
                    //    p1.Value = folioNumber;
                    //}
                    //else
                    //{
                    //    // Conversion failed, handle the error or provide a default value
                    //    // For example, you could assign null to the parameter value
                    //    p1.Value = DBNull.Value;
                    //}

                    SqlParameter p2 = new SqlParameter("@schemeName", SqlDbType.VarChar);
                    p2.Value = textBox_Scheme.Text.Trim();
                    
                    SqlParameter p3 = new SqlParameter("@nav", SqlDbType.Decimal);
                    p3.Value = textBox_NAV.Text.Trim();
                    
                    SqlParameter p4 = new SqlParameter("@purchaseDate", SqlDbType.NVarChar);
                    p4.Value = dateTimePicker1.Value.ToShortDateString();
                    
                    SqlParameter p5 = new SqlParameter("@unit", SqlDbType.Decimal);
                    p5.Value = textBox_Unit.Text.Trim();
                    
                    SqlParameter p6 = new SqlParameter("@amount", SqlDbType.Decimal);
                    p6.Value = Amount_Lbl.Text.Trim();
                    

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    
                        DialogResult dr = MessageBox.Show("Do you want to update data", "Confirmation", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            cmd.CommandText = "UPDATE MfaTB SET FolioNumber=@folioNumber, SchemeName=@schemeName, NAV=@nav, PurchaseDate=@purchaseDate, Units=@unit, Amount=@amount WHERE Mid=" + Mid;

                            con.Open();
                            cmd.ExecuteNonQuery();

                        Insert_Btn.Enabled = true;
                        MessageBox.Show("Update Data Successfully");

                            textBox_folio.Clear();
                            textBox_Scheme.Clear();
                            textBox_NAV.Clear();
                            textBox_Unit.Clear();
                            textBox_folio.Focus();

                        Modify_Btn.Enabled = false;
                        Delete_Btn.Enabled = false;
                            LoadData();
                        }
                        else
                        {
                            textBox_folio.Text = "";
                            textBox_Scheme.Text = "";
                            textBox_NAV.Text = "";
                            textBox_Unit.Text = "";
                            Amount_Lbl.Text = "";
                            textBox_folio.Focus();

                        Modify_Btn.Enabled = false;
                        Delete_Btn.Enabled = false;
                        }
                    }
               
                UpdateTotalAmount();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();

           

        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    if (dataGridView1.SelectedRows.Count > 0)
                    {

                        DialogResult dr = MessageBox.Show("Do you want to delete data", "Confirmation", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            con.Open();

                            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                            {
                                int selectedID = Convert.ToInt32(row.Cells["Mid"].Value);
                                cmd.CommandText = "UPDATE MfaTB SET isDeleted = 1 WHERE Mid = @Mid";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@Mid", selectedID);
                                cmd.ExecuteNonQuery();
                            }
                            
                            MessageBox.Show("Data Deleted Successfully");

                            textBox_folio.Clear();
                            textBox_Scheme.Clear();
                            textBox_NAV.Clear();
                            textBox_Unit.Clear();
                            textBox_folio.Focus();
                            Modify_Btn.Enabled = false;
                            Delete_Btn.Enabled = false;

                            LoadData();
                        }
                        else
                        {

                            textBox_folio.Text = "";
                            textBox_Scheme.Text = "";
                            textBox_NAV.Text = "";
                            textBox_Unit.Text = "";
                            Amount_Lbl.Text = "";
                            textBox_folio.Focus();

                            Modify_Btn.Enabled = false;
                            Delete_Btn.Enabled = false;

                        }

                    }

                }
                con.Close();
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                isModify = 1;

                Mid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox_folio.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_Scheme.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_NAV.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string cellValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_Unit.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Amount_Lbl.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();



                Modify_Btn.Enabled = true;
                Delete_Btn.Enabled = true;
                Insert_Btn.Enabled = false;
                Clear_Btn.Enabled = true;

            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
             
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (cellValue != DBNull.Value)
                {
                    Mid = Convert.ToInt32(cellValue);
                }
                else
                {
                    Mid = 0; 
                }
                isModify = 1;

                textBox_folio.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_Scheme.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_NAV.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cellValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_Unit.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Amount_Lbl.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                Modify_Btn.Enabled = true;
                Delete_Btn.Enabled = true;
                Insert_Btn.Enabled = false;
                Clear_Btn.Enabled = true;
            }

        }
        private void textBox_folio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
            
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 8 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
            


        }
        private void textBox_Scheme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox_NAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            

            Insert_Btn.Enabled = false;
            Modify_Btn.Enabled = false;
            Delete_Btn.Enabled = false;


            textBox_folio.Clear();
            textBox_Scheme.Clear();
            textBox_NAV.Clear();
            textBox_Unit.Clear();
            textBox_folio.Focus();

        }

        //if user insert data in grid then update total amount in automatically
        private void UpdateTotalAmount()
        {
            decimal totalAmount = CalculateTotalAmount();
            TotalAmount_Lbl.Text = "" + totalAmount.ToString("0.00");
        }

        //Calculate total amount code by @trupti
        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Amount"].Value != null && decimal.TryParse(row.Cells["Amount"].Value.ToString(), out decimal amount))
                {
                    if (amount >= 0)
                    {
                        totalAmount += amount;

                    }
                    else
                    {
                        totalAmount -= amount;

                    }
                }
            }
            return totalAmount;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;

            if (selectedDate > today)
            {
                // MessageBox.Show(this, "Selected date cannot be greater than today's date. Please select a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DTP_Lbl.Text = "Selected date cannot be greater than today's date. Please select a valid date";

                dateTimePicker1.Value = today;

            }
            else if(selectedDate < today)
            {
                DTP_Lbl.Text = "";
            }
            else
            {

            }
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();

        }

        
    } 
}

      
