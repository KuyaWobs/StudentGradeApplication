using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Student_Name = textBox1.Text;
            double English = Convert.ToDouble(textBox2.Text);
            double Math = Convert.ToDouble(textBox3.Text);
            double Science = Convert.ToDouble(textBox4.Text);
            double Filipino = Convert.ToDouble(textBox5.Text);
            double History = Convert.ToDouble(textBox6.Text);

            double Total_Grades = English + Math + Science + Filipino + History;

            double Total_Ave = Total_Grades / 5;

            Result.Text = Total_Ave >= 75 ? Student_Name + " You Passed! \n Your General Average is " + Total_Ave : Student_Name + " You Failed! \n Your Genaral Average is " + Total_Ave;



        }
    }
}
