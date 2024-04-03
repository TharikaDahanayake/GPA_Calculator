using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course1 = textBox1.Text;
            string course2 = textBox2.Text;
            string course3 = textBox3.Text;
            string course4 = textBox4.Text;
            string course5 = textBox5.Text;
            string course6 = textBox6.Text;
            string course7 = textBox7.Text;
            string course8 = textBox8.Text;
            

            double credit1 = Convert.ToDouble(textBox9.Text);
            double credit2 = Convert.ToDouble(textBox10.Text);
            double credit3 = Convert.ToDouble(textBox11.Text);
            double credit4 = Convert.ToDouble(textBox12.Text);
            double credit5 = Convert.ToDouble(textBox13.Text);
            double credit6 = Convert.ToDouble(textBox14.Text);
            double credit7 = Convert.ToDouble(textBox15.Text);
            double credit8 = Convert.ToDouble(textBox16.Text);


            double gpv_1 = Convert.ToDouble(textBox17.Text);
            double gpv_2 = Convert.ToDouble(textBox18.Text);
            double gpv_3 = Convert.ToDouble(textBox19.Text);
            double gpv_4 = Convert.ToDouble(textBox20.Text);
            double gpv_5 = Convert.ToDouble(textBox21.Text);
            double gpv_6 = Convert.ToDouble(textBox22.Text);
            double gpv_7 = Convert.ToDouble(textBox23.Text);
            double gpv_8 = Convert.ToDouble(textBox24.Text);


            string Grade(double gpv)
            {

                string grade = "";
                if (gpv == 4.0)
                {
                    grade = "A+";

                }
                else if (gpv == 4.0)
                {
                    grade = "A";
                }
                else if (gpv == 3.7)
                {
                    grade = "A-";
                }
                else if (gpv == 3.3)
                {
                    grade = "B+";
                }
                else if (gpv == 3.0)
                {
                    grade = "B";
                }
                else if (gpv == 2.7)
                {
                    grade = "B-";
                }
                else if (gpv == 2.3)
                {
                    grade = "C+";
                }
                else if (gpv == 2.0)
                {
                    grade = "C";
                }
                else if (gpv == 1.7)
                {
                    grade = "C-";
                }
                else if (gpv == 1.3)
                {
                    grade = "D+";
                }
                else if (gpv == 0.0)
                {
                    grade = "F";
                }
                return grade;
            }

                textBox25.Text = Grade(gpv_1);
                textBox26.Text = Grade(gpv_2);
                textBox27.Text = Grade(gpv_3);
                textBox28.Text = Grade(gpv_4);
                textBox29.Text = Grade(gpv_5);
                textBox30.Text = Grade(gpv_6);
                textBox31.Text = Grade(gpv_7);
                textBox32.Text = Grade(gpv_8);

                double GP1 = credit1 * gpv_1;
                double GP2 = credit2 * gpv_2;
                double GP3 = credit3 * gpv_3;
                double GP4 = credit4 * gpv_4;
                double GP5 = credit5 * gpv_5;
                double GP6 = credit6 * gpv_6;
                double GP7 = credit7 * gpv_7;
                double GP8 = credit8 * gpv_8;

                textBox33.Text = GP1.ToString();
                textBox34.Text = GP2.ToString();
                textBox35.Text = GP3.ToString();
                textBox36.Text = GP4.ToString();
                textBox37.Text = GP5.ToString();
                textBox38.Text = GP6.ToString();
                textBox39.Text = GP7.ToString();
                textBox40.Text = GP8.ToString();

                double Total_GP = GP1 + GP2 + GP3 + GP4 + GP5 + GP6 + GP7 + GP8;
                textBox41.Text = Total_GP.ToString();

                double Total_credit = credit1 + credit2 + credit3 + credit4 + credit5 + credit6 + credit7 + credit8;
                textBox42.Text = Total_credit.ToString();


                double Grade_Point_Average = Total_GP / Total_credit;
                textBox43.Text = Grade_Point_Average.ToString();



                Console.ReadLine();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
