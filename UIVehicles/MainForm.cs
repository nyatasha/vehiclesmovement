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
    public partial class MainForm : Form
    {        
        AddVehicleForm addVehicleForm = new AddVehicleForm();
        LogForm logForm = new LogForm();
        ListOfFuelForm listOfFuelForm = new ListOfFuelForm();
        CreateRoadForm createRoadForm = new CreateRoadForm();
        public Controller controller = new Controller();

        public MainForm()
        {
            InitializeComponent();

            addVehicleForm.Owner = this;
            createRoadForm.Owner = this;
            logForm.Owner = this;
            listOfFuelForm.Owner = this;
        }
        private void createRoadForm_Click(object sender, EventArgs e)
        {
            createRoadForm.Show();
            addVehicleForm.SetDesktopLocation(this.Location.X + this.Size.Width - 20, this.Location.Y);
        }
        private void addVehicleForm_Click(object sender, EventArgs e)
        { 
            addVehicleForm.Show();
            addVehicleForm.SetDesktopLocation(this.Location.X + this.Size.Width - 20, this.Location.Y);
        }
        private void Start_Click(object sender, EventArgs e)
        {           
            controller.StartAllVehicles();
            controller.Clear(addVehicleForm.TypeVehicleBox, addVehicleForm.LaneNumberBox, 
                addVehicleForm.FuelTypeBox, addVehicleForm.StartSpeedTextBox, addVehicleForm.MaxSpeedTextBox, 
                addVehicleForm.FuelRateTextBox, addVehicleForm.FuelCapacityTextBox);

            if (controller.CheckIfSmthCreated())
            {
                TimeFromStartLabel.Visible = true;
                WholeStopTimeLabel.Visible = true;
                WholeTimeLabel.Visible = true;
            }
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            controller.StopAllVehicles();
        }
        private void logForm_Click(object sender, EventArgs e)
        {
            logForm.Show();

            addVehicleForm.SetDesktopLocation(this.Location.X + this.Size.Width - 20, this.Location.Y);
        }
        private void listOfFuelForm_Click(object sender, EventArgs e)
        {
            listOfFuelForm.Show();
            addVehicleForm.SetDesktopLocation(this.Location.X + this.Size.Width - 20, this.Location.Y);
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {      

        }       
        private void timerCarBox_Tick(object sender, EventArgs e)
        {
            controller.checkIfAllLanesTaken(addVehicleForm.TypeVehicleBox, addVehicleForm.LaneNumberBox,
                addVehicleForm.FuelTypeBox, addVehicleForm.StartSpeedTextBox, addVehicleForm.MaxSpeedTextBox,
                addVehicleForm.FuelRateTextBox, addVehicleForm.FuelCapacityTextBox);
            NumberOfVehiclesLabel.Text = controller.numberOfVehicles.ToString();
            
            controller.DisplayTime(TimeFromStartLabel, WholeStopTimeLabel, WholeTimeLabel);

            controller.Move(CarBox1,CarBox2,CarBox3,CarBox4,CarBox5);

            EnableLogButtons();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {          
            controller.CarBoxStartY = CarBox1.Top;
            controller.CarBoxFinishY = pictureBox1.Top;
        }  
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
        private void EnableLogButtons()
        {
            if (controller.EnableVehicleNumberButtons(0, logForm.radioButton1) ||
                controller.EnableVehicleNumberButtons(1, logForm.radioButton2) ||
                controller.EnableVehicleNumberButtons(2, logForm.radioButton3) ||
                controller.EnableVehicleNumberButtons(3, logForm.radioButton4) ||
                controller.EnableVehicleNumberButtons(4, logForm.radioButton5))
            {
                logForm.radioButton6.Enabled = true;
                logForm.WordBTN.Enabled = true;
                logForm.ExcelBTN.Enabled = true;
            }
            if (controller.EnableVehicleNumberButtons(0, logForm.radioButton1) &&
                controller.EnableVehicleNumberButtons(1, logForm.radioButton2) &&
                controller.EnableVehicleNumberButtons(2, logForm.radioButton3) &&
                controller.EnableVehicleNumberButtons(3, logForm.radioButton4) &&
                controller.EnableVehicleNumberButtons(4, logForm.radioButton5))
            {
                logForm.radioButton6.Enabled = false;
                logForm.WordBTN.Enabled = false;
                logForm.ExcelBTN.Enabled = false;
            }  
            
        }
                      
    }
}
