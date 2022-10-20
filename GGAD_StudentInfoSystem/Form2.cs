using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGAD_StudentInfoSystem
{
    public partial class Form2 : Form
    {
        bool sidebarExpand;
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

        }
        //side bar timer utilized for transition
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        //hamburger icon, triggering side bar timer to start
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //redirecting to update information form
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
        //log out button
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
