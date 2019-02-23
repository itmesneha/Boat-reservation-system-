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
    public partial class Borrowers_UserControl : UserControl
    {
        private static Borrowers_UserControl _instance;

        public static Borrowers_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_UserControl();
                }
                return _instance;
            }
        }

        public Borrowers_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");


      

        private void addborrower_button_Click(object sender, EventArgs e)
        {
            if((id_textbox.Text=="")||(name_textbox.Text=="")||(address_textbox.Text=="")||(phone_textbox.Text==""))
            {
                MessageBox.Show("Please Fill all inputs!");
                return;
            }
            

            SqlCommand cmd = new SqlCommand("borrowersadd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@brId", id_textbox.Text);
            cmd.Parameters.AddWithValue("@Name", name_textbox.Text);
            cmd.Parameters.AddWithValue("@Address", address_textbox.Text);
            cmd.Parameters.AddWithValue("@Phone", phone_textbox.Text);
            

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>: \n" + ex);
            }
            con.Close();
            //displaying changes in datagrid
            try
            {
                con.Open();
                String query = "SELECT * FROM Borrowers";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" error" + ex);
            }
        }

        private void showdata_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "SELECT * FROM Borrowers";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" error" + ex);
            }
        }

        private void removeborrower_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("borrowersdelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@brId", id_textbox.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            //showing changes in datagrid
            try
            {
                con.Open();
                String query = "SELECT * FROM Borrowers";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(" error" + ex);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            id_textbox.Text = "";
            name_textbox.Text = "";
            phone_textbox.Text = "";
            address_textbox.Text = "";
        }
    }
}
