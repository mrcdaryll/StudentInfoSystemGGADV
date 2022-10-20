using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGAD_StudentInfoSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //credentials input
        private void studentNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentNumber.Text))
            {
                e.Cancel = true;
                studentNumber.Focus();
                appErrorProvider.SetError(studentNumber, "Studet Number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                appErrorProvider.SetError(studentNumber, "");
            }
        }

        private void studentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pinNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pinNumber.Text))
            {
                e.Cancel = true;
                pinNumber.Focus();
                appErrorProvider.SetError(pinNumber, "Studet Number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                appErrorProvider.SetError(pinNumber, "");
            }
        }

        private void pinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //credentials validation
        private void signIn_Click(object sender, EventArgs e)
        {
            string studNumber, pin;
            studNumber = studentNumber.Text;
            pin = pinNumber.Text;

            if(studNumber.Equals("22001234") && pin.Equals("1234"))
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Try again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pinNumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}