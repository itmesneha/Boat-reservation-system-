using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Transaction_UserControl : UserControl
    {

        private static Transaction_UserControl _instance;

        public static Transaction_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transaction_UserControl();
                }
                return _instance;
            }
        }
        public Transaction_UserControl()
        {
            InitializeComponent();
        }

        private void Transaction_UserControl_Load(object sender, EventArgs e)
        {
            
            

        }

        public string Boat1, Boat2, Borrower;
       

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
        public SqlCommand cmd;
        public SqlDataReader dr;

       

        private void searchboats_button_Click(object sender, EventArgs e)
        {
            //to get borrowed by 
            con.Open();
            String syntax = "SELECT borrower FROM boats where accNo='" + accno_textbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            borrowedby_label.Text = Borrower = dr[0].ToString();
            con.Close();
        }

        

        private void Searchborrowers_button_Click(object sender, EventArgs e)
        {
            //to get boat 1
            con.Open();
            String syntax = "SELECT Boat1 FROM Borrowers where brId='" + borrowerid_textbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            borrowedby1_label.Text = Boat1 = dr[0].ToString();
            con.Close();

            //to get boat 2
            con.Open();
            syntax = "SELECT Boat2 FROM Borrowers where brId='" + borrowerid_textbox.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            borrowedby2_label.Text = Boat2 = dr[0].ToString();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void transactionlog_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT * FROM Transactions_Log";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" error" +ex);
            }
        }

        private void clearall_button_Click(object sender, EventArgs e)
        {
            borrowerid_textbox.Text = "";
            accno_textbox.Text = "";
        }

        private void issueboat_button_Click(object sender, EventArgs e)
        {
            //see if boat is borrowed by someone
            searchboats_button.PerformClick();
            if(Borrower !="")
            {
                //someone has borrowed the boat
                MessageBox.Show("Boat is already borrowed by borrower with id: \n" + Borrower);
                return;
            }
             
            //see if borrower has already taken two boats
            Searchborrowers_button.PerformClick();
            if((Boat1!="")&&(Boat2!=""))
            {
                //borrower has already borrowed maximum number of boats
                MessageBox.Show("Borrower has already borrowed maximum number of books. \n");
                return;
            }

            //everything is fine, continue issue process

            //first set the value of boat1 or boat2 as accno of boat being issued in borrowers table
            try
            {
                if(Boat1 == "")
                {
                    //accno must be updated in book1 slot
                    cmd = new SqlCommand("Transact_Update_Boat1_SP",con);
                }
                else if(Boat2 == "")
                {
                    //accno must be updated in book2 slot
                    cmd = new SqlCommand("Transact_Update_Boat2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo",accno_textbox.Text);
                cmd.Parameters.AddWithValue("@brId", borrowerid_textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" +ex);
                }
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
            }

            //now we also update borrower id in boats table

            cmd = new SqlCommand("Transact_Update_Borrower_SP",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accno_textbox.Text);
            cmd.Parameters.AddWithValue("@brId", borrowerid_textbox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
            }
            con.Close();

            //insert details into transactions table
            cmd = new SqlCommand("Transactions_Insert_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@boat_num", accno_textbox.Text);
            cmd.Parameters.AddWithValue("@br_id", borrowerid_textbox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
            }
            con.Close();



            //this completes the whole transaction so now we perfom click event on both buttons so user can see the changes made
            Searchborrowers_button.PerformClick();
            searchboats_button.PerformClick();
            MessageBox.Show("Successfully issued.\n");
           
        }

        private void retrunboat_button_Click(object sender, EventArgs e)
        {
            //see if boat is borrowed by someone
            searchboats_button.PerformClick();
            Searchborrowers_button.PerformClick();
            if ((accno_textbox.Text != Boat1) && (accno_textbox.Text != Boat2))
            {

                MessageBox.Show("THE INPUTED BORROWER HAS NOT BORRWED THE BOAT INPUTED! \n");
                return;
            }


            //everything is fine, continue return process

            //first set the value of boat1 or boat2 as accno of boat being returned
            try
            {
                if (Boat1 == accno_textbox.Text)
                {
                    //accno must be updated in book1 slot
                    cmd = new SqlCommand("Transact_Update_Boat1_SP", con);
                }
                else
                {
                    //accno must be updated in book2 slot
                    cmd = new SqlCommand("Transact_Update_Boat2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brId", borrowerid_textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
            }

            //now we also update borrower id in boats table

            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", accno_textbox.Text);
            cmd.Parameters.AddWithValue("@brId", (object)DBNull.Value);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
            }
            con.Close();

            //insert details into transactions table
            cmd = new SqlCommand("Transactions_Delete_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@boat_num", accno_textbox.Text);
            cmd.Parameters.AddWithValue("@br_id", borrowerid_textbox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>  :\n" + ex);
            }
            con.Close();

            //this completes the whole transaction so now we perfom click event on both buttons so user can see the changes made
            Searchborrowers_button.PerformClick();
            searchboats_button.PerformClick();
            MessageBox.Show("Successfully returned.\n");
            
        }






    }
}
