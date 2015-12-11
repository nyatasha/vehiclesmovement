using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIVehicles
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void WordBTN_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                if (radioButton1.Checked)
                {
                    mainForm.controller.DisplayLogInWord(1);
                }
                if (radioButton2.Checked)
                {
                    mainForm.controller.DisplayLogInWord(2);
                }
                if (radioButton3.Checked)
                {
                    mainForm.controller.DisplayLogInWord(3);
                }
                if (radioButton4.Checked)
                {
                    mainForm.controller.DisplayLogInWord(4);
                }
                if (radioButton5.Checked)
                {
                    mainForm.controller.DisplayLogInWord(5);
                }
                if (radioButton6.Checked)
                {
                    mainForm.controller.DisplayLogInWord(6);
                }
            }
        }

        private void ExcelBTN_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                if (radioButton1.Checked)
                {
                    mainForm.controller.DisplayLogInExcel(1);
                }
                if (radioButton2.Checked)
                {
                    mainForm.controller.DisplayLogInExcel(2);
                }
                if (radioButton3.Checked)
                {
                    mainForm.controller.DisplayLogInExcel(3);
                }
                if (radioButton4.Checked)
                {
                    mainForm.controller.DisplayLogInExcel(4);
                }
                if (radioButton5.Checked)
                {
                    mainForm.controller.DisplayLogInExcel(5);
                }
                if (radioButton6.Checked)
                {
                    mainForm.controller.DisplayLogInExcel(6);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                if (mainForm.controller.EnableVehicleNumberButtons(0, radioButton1) ||
                    mainForm.controller.EnableVehicleNumberButtons(1, radioButton2) ||
                    mainForm.controller.EnableVehicleNumberButtons(2, radioButton3) ||
                    mainForm.controller.EnableVehicleNumberButtons(3, radioButton4) ||
                    mainForm.controller.EnableVehicleNumberButtons(4, radioButton5))
                {
                    radioButton6.Enabled = true;
                    WordBTN.Enabled = true;
                    ExcelBTN.Enabled = true;
                }
            }
        }
    }
}
