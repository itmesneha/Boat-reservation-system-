using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class AppBody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public AppBody()
        {
            InitializeComponent();

            //initialize for sliding panel
            IsSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                Log_in_Timer.Stop();
            }
        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_Timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void TitleBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void expandSlidingPanelGUI()
        {
            //gui for expanding
            BoatsTab_Button.Text = "BOATS";
            borrowerstab_button.Text = "BORROWERS";
            TransactionTab_Button.Text = "TRANSACTIONS";
            settingstab_button.Text = "SETTINGS";
            AboutTab_Button.Text = "ABOUT";
            SlidingPanel_ToggleButton.Text = "<<";
            BoatsTab_Button.Image = null;
           
            TransactionTab_Button.Image = null;
            
            AboutTab_Button.Image = null;
        }

        public void retractSlidingPanelGUI()
        {
            //gui for expanding
            BoatsTab_Button.Text = "~~";
            borrowerstab_button.Text = "-->";
            TransactionTab_Button.Text = "#";
            settingstab_button.Text = "(|)";
            AboutTab_Button.Text = "?";
            SlidingPanel_ToggleButton.Text = ">>";
            
            BoatsTab_Button.Image = null;
           
            TransactionTab_Button.Image = null;
            
            AboutTab_Button.Image = null;
        }


        //slidingpanel code starts here
        bool IsSlidingPanelExpanded;
        const int MaxSliderWidth=300;
        const int MinSliderWidth=100;

        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                retractSlidingPanelGUI();
            }
            SlidingPanel_Timer.Start();
        }

        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                //retract panel
                SlidingPanel.Width -= 30;
                if(SlidingPanel.Width<=MinSliderWidth)
                {
                    //stop retract
                    IsSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                expandSlidingPanelGUI();
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    IsSlidingPanelExpanded = true;
                    SlidingPanel_Timer.Stop();

                    this.Refresh();
                }
            }
        }

        private void contentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BoatsTab_Button_Click(object sender, EventArgs e)
        {
            if(! contentpanel.Controls.Contains(Boats_UserControl.Instance))
            {
                contentpanel.Controls.Add(Boats_UserControl.Instance);
                Boats_UserControl.Instance.Dock = DockStyle.Fill;
                Boats_UserControl.Instance.BringToFront();

            }
            else
            {
                Boats_UserControl.Instance.BringToFront();
            }

        }

       

        private void TransactionTab_Button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Transaction_UserControl.Instance))
            {
                contentpanel.Controls.Add(Transaction_UserControl.Instance);
                Transaction_UserControl.Instance.Dock = DockStyle.Fill;
                Transaction_UserControl.Instance.BringToFront();

            }
            else
            {
                Transaction_UserControl.Instance.BringToFront();
            }
        }

        

        private void AboutTab_Button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(About_UserControl.Instance))
            {
                contentpanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock = DockStyle.Fill;
                About_UserControl.Instance.BringToFront();

            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }

        private void borrowers_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Borrowers_UserControl.Instance))
            {
                contentpanel.Controls.Add(Borrowers_UserControl.Instance);
                Borrowers_UserControl.Instance.Dock = DockStyle.Fill;
                Borrowers_UserControl.Instance.BringToFront();

            }
            else
            {
                Borrowers_UserControl.Instance.BringToFront();
            }
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(Settings_UserControl.Instance))
            {
                contentpanel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock = DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();

            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }
    }
}
