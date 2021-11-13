using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_and_ProductionWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ProductionWorker worker = new ProductionWorker();
            try
            {
                string nameChar = textBox1.Text;
                string empNumChar = textBox2.Text;
                if (Char.IsLetter(nameChar[0])){
                    string name = textBox1.Text;
                    worker.EmployeeName = name;
                    if (Char.IsLetterOrDigit(empNumChar[0]))
                    {
                        
                        string empNum = textBox2.Text;
                        
                        worker.EmployeeNumber = empNum;
                    }
                    else
                    {
                        MessageBox.Show("Enter Employee number. Employee number can be digits or combiniation of letters and digits");
                        textBox2.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Name cannot contain numbers or special characters");
                    textBox1.Focus();
                    return;
                }
            
                int shift;
                double hourlyPay;
                int.TryParse(textBox3.Text, out shift);
                double.TryParse(textBox4.Text, out hourlyPay);
            
                if(!(shift <= 0 || shift >= 3))
                {
                    worker.ShiftNumber = shift;
                }
                else
                {
                    MessageBox.Show("Shift can only be 1 or 2. 1 for day shift, 2 for night shift");
                    textBox3.Focus();
                    return;
                }
            
                    worker.HourlyPayRate = hourlyPay;
                    lblName.Text = worker.EmployeeName;
                    lblNumber.Text = worker.EmployeeNumber;
                    lblShift.Text = worker.ShiftNumber.ToString();
                    lblHourly.Text = worker.HourlyPayRate.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + " something is wrong");
            }
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lblHourly.Text = "";
            lblName.Text = "";
            lblNumber.Text = "";
            lblShift.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
