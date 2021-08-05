using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void showButton_Click(object sender, EventArgs e)
        {
            //Method 1- Hard Coded Value:
            string value = departmentComboBox.Text;
            string txt = "Your Selected Department Name is: ";
            MessageBox.Show(txt + value);

            //Radio Button
            if (maleRadioButton.Checked)
            {
                MessageBox.Show("Male Radio Button is Checked");
            }
            if (femaleRadioButton.Checked)
            {
                MessageBox.Show("Female Radio Button is Checked");
            }
            if (otherRadioButton.Checked)
            {
                MessageBox.Show("Other Radio Button is Checked");
            }
            
            //Check Box
            if (maleCheckBox.Checked)
            {
                MessageBox.Show("Male is Checked");
            }
            if (femaleCheckBox.Checked)
            {
                MessageBox.Show("Female is Checked");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Method 2- List Collection: Best

            List<string> departmentList = new List<string>();
            departmentList.Add("CSE");
            departmentList.Add("EEE");
            departmentList.Add("ME");
            departmentList.Add("CE");
            departmentList.Add("BBA");
            departmentList.Add("ENG");
            departmentList.Add("PHY");
            departmentList.Add("MATH");

            foreach (var data in departmentList)
            {
                departmentComboBox.Items.Add(data);
            }

            //departmentComboBox.DataSource = departmentList;

            //Method 3:

            //departmentComboBox.Items.Add("CSE");
            //departmentComboBox.Items.Add("EEE");
            //departmentComboBox.Items.Add("ME");
            //departmentComboBox.Items.Add("CE");
            //departmentComboBox.Items.Add("BBA");
            //departmentComboBox.Items.Add("ENG");
            //departmentComboBox.Items.Add("PHY");
            //departmentComboBox.Items.Add("MATH");

            //Method 4- Foreach Loop :



        }

        private void anotherFormButton_Click(object sender, EventArgs e)
        {
            AnotherForm form2=new AnotherForm();
            form2.Show();
        }
    }
}
