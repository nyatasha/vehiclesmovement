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
    public partial class ListOfFuelForm : Form
    {
        public ListOfFuelForm()
        {
            InitializeComponent();
        }

        private void ListOfFuelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ListOfFuelForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {                
                mainForm.controller.FillFuelList(fuelListAll);
            }
        }
    }
}
