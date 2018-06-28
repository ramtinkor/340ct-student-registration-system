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
    public partial class FrmEmail_ID : Form
    {

        


        public FrmEmail_ID()
        {
            InitializeComponent();
        }

        private void FrmEmail_ID_Load(object sender, EventArgs e)
        {
            //event is the page loading which is triggered from the register page. once the user
            //has submitted his information and clicked on submit they are nagivgated to this page
            //at which point this event is triggered. 


            //a six digit student ID is randomly generated and displayed on the screen

            Random rnd = new Random();
            int single = rnd.Next(100000,999999);
            lblSID.Text = Convert.ToString( single);

            Student.studentID = Convert.ToInt32( lblSID.Text);//the ID is saved to the students record. 


            lbl.Text = " enrolment complete use your username and password to log in. Here is university email and student ID number. ";


            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //the username is retrived and together along with the university email combins to form a unquie email for the student
            lblEmail.Text = Student.username + Student.UniversityEmail;
            Student.studentEmail = lblEmail.Text;// the email is then saved. 

        }

    }
}
