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
    public partial class CreateRoadForm : Form
    {        
        public CreateRoadForm()
        {
            InitializeComponent();
        }
        private void RailsRadio1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway1Box,mainForm.Wires1Box, 1, 2);
            }
        }
        private void RailsRadio2_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway2Box, mainForm.Wires2Box, 2, 2);
            }
        }
        private void RailsRadio3_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway3Box, mainForm.Wires3Box, 3, 2);
            }
        }
        private void RailsRadio4_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway4Box, mainForm.Wires4Box, 4, 2);
            }
        }
        private void RailsRadio5_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway5Box, mainForm.Wires5Box, 5, 2);
            }
        }  
        private void SimpleRadio1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway1Box, mainForm.Wires1Box, 1, 0);
            }
        }
        private void SimpleRadio2_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway2Box, mainForm.Wires2Box, 2, 0);
            }
        }
        private void SimpleRadio3_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway3Box, mainForm.Wires3Box, 3, 0);
            }
        }
        private void SimpleRadio4_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway4Box, mainForm.Wires4Box, 4, 0);
            }
        }
        private void SimpleRadio5_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway5Box, mainForm.Wires5Box, 5, 0);
            }
        }
        private void WiresRadio1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway1Box, mainForm.Wires1Box, 1, 1);
            }
        }
        private void WiresRadio2_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway2Box, mainForm.Wires2Box, 2, 1);
            }
        }
        private void WiresRadio3_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway3Box, mainForm.Wires3Box, 3, 1);
            }
        }     
        private void WiresRadio4_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway4Box, mainForm.Wires4Box, 4, 1);
            }
        }
        private void WiresRadio5_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CreateRoad(mainForm.Railway5Box, mainForm.Wires5Box, 5, 1);
            }
        }
        private void CreateRoadForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateRoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }


    }
}
