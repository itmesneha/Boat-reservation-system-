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
    public partial class Settings_UserControl : UserControl
    {

        private static Settings_UserControl _instance;

        public static Settings_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Settings_UserControl();
                }
                return _instance;
            }
        }
        public Settings_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True");
        public SqlCommand cmd;

        private void Settings_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("changeuserpass_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username_textbox.Text);
            cmd.Parameters.AddWithValue("@password", password_textbox.Text);

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
            success_label.Text = "Success!!";
        }
    }
}
