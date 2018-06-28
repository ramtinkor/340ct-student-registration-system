﻿using System;
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
    public partial class frmRegistration_page : Form
    {
        public frmRegistration_page()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }


        FrmEmail_ID enrol = new FrmEmail_ID(); 
        private void button1_Click(object sender, EventArgs e)
        {
            
            //click event
            //once the user has entered all the information reuired then they click on the sumbit button. this tiggers
            //two new process. one to open the enrolement screen and to close this one. also to store all the information
            //into the student records. 


            //enrolment page being opened. 
            enrol.Show();
            this.Hide();


            //student information being saved 
            Student.username = txtUsername.Text;
            Student.Address = txtAddress.Text;
            Student.Fname = txtFName.Text;
            Student.Sname = txtSName.Text;
            Student.CNumber = txtNumber.Text;
            Student.course = comboBox1.Text;






        }

        private void txtFName_Click(object sender, EventArgs e)
        {
            //click event_ purpose i have used text within the textbox to inform the user where what the information should
            //be entered rather than use labels. this event simply removes the prewritten text. 

            if (txtFName.Text == "First Name") 

            {
                txtFName.Clear(); //removes the prewritten text so the user doesn't have to first delete the text. 
            }
             
        }

        private void txtSName_Click(object sender, EventArgs e)
        {
            if (txtSName.Text == "Surname")

            {
                txtSName.Clear(); 
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //text was used to label the textboxes once the user startes to enter information an event is triggered. 

            textBox1.PasswordChar = '*'; // passwords are represented by symbol so to protect the password from being seen. 
        }
    }
}
