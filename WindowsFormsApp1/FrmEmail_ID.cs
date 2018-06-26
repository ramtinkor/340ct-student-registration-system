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
            Random rnd = new Random();
            int single = rnd.Next(100000,999999);
            lblSID.Text = Convert.ToString( single);

            Student.studentID = Convert.ToInt16( lblSID.Text);



            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEmail.Text = Student.username + Student.UniversityEmail;

        }
    }
}
