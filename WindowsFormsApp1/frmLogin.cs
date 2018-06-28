using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username") { txtUsername.Clear(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username") { txtUsername.Clear(); }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == "Password") { txtPassword.Clear(); }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }





        frmRegistration_page reistration = new frmRegistration_page();
        
        private void lblRegister_Click(object sender, EventArgs e)
        {
            //click event once the student clicks on the register link then open the registration  screen. 

            this.Hide();
            reistration.Show();
            
        }
    }
}
