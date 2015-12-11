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
    public partial class AddVehicleForm : Form
    {          
       
        public AddVehicleForm()
        {
            InitializeComponent();

        }
       
        private void TypeVehicleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.CombineForVehicleType(TypeVehicleBox, LaneNumberBox, FuelTypeBox, FuelRateTextBox, FuelCapacityTextBox, StartSpeedTextBox, MaxSpeedTextBox);
            }
        }
        private void CreateVehicleButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                string laneID = "";
                if (LaneNumberBox.SelectedItem != null) 
                {
                    laneID = LaneNumberBox.SelectedItem.ToString();
                }                
                switch (laneID)
                {
                    case "1":
                        mainForm.controller.CreateVehicle(TypeVehicleBox, LaneNumberBox, FuelTypeBox, 
                            StartSpeedTextBox, mainForm.CarBox1, DeleteVehicleButton, RadioDelete1,MaxSpeedTextBox, FuelRateTextBox,FuelCapacityTextBox);
                        break;
                    case "2":
                        mainForm.controller.CreateVehicle(TypeVehicleBox, LaneNumberBox, FuelTypeBox,
                            StartSpeedTextBox, mainForm.CarBox2, DeleteVehicleButton, RadioDelete2,MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                        break;
                    case "3":
                        mainForm.controller.CreateVehicle(TypeVehicleBox, LaneNumberBox, FuelTypeBox,
                            StartSpeedTextBox, mainForm.CarBox3, DeleteVehicleButton, RadioDelete3, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                        break;
                    case "4":
                        mainForm.controller.CreateVehicle(TypeVehicleBox, LaneNumberBox, FuelTypeBox,
                            StartSpeedTextBox, mainForm.CarBox4, DeleteVehicleButton, RadioDelete4, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                        break;
                    case "5":
                        mainForm.controller.CreateVehicle(TypeVehicleBox, LaneNumberBox, FuelTypeBox,
                            StartSpeedTextBox, mainForm.CarBox5, DeleteVehicleButton, RadioDelete5, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                        break;
                }

            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.Clear(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
            }
        }     
        private void DeleteVehicleButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                if (RadioDelete1.Checked)
                {
                    mainForm.controller.DeleteVehicle(RadioDelete1, mainForm.CarBox1, 1);
                }
                if (RadioDelete2.Checked)
                {
                    mainForm.controller.DeleteVehicle(RadioDelete2, mainForm.CarBox2, 2);
                }
                if (RadioDelete3.Checked)
                {
                    mainForm.controller.DeleteVehicle(RadioDelete3, mainForm.CarBox3, 3);
                }
                if (RadioDelete4.Checked)
                {
                    mainForm.controller.DeleteVehicle(RadioDelete4, mainForm.CarBox4, 4);
                }
                if (RadioDelete5.Checked)
                {
                    mainForm.controller.DeleteVehicle(RadioDelete5, mainForm.CarBox5, 5);
                }
            }
        }       
        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.FillVehicleTypes(TypeVehicleBox);
            }
        }     
        private void AddVehicleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm mainForm = (MainForm)this.Owner;
            if (mainForm != null)
            {
                mainForm.controller.Clear(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
            }
            e.Cancel = true;
        }
    }
}