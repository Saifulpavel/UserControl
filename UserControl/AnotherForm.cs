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
    public partial class AnotherForm : Form
    {
        public AnotherForm()
        {
            InitializeComponent();
        }

        private void AnotherForm_Load(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String value = departmentComboBox.Text;
            departmentListBox.Items.Add(value);
        }
    }
}
