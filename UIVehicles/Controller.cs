using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Entity;
using Vehicle;
using Engine;
using Fuel;
using Road;

namespace UIVehicles
{
    public class Controller
    {
        public Vehicle.Vehicle[] arrayOfVehicles = new Vehicle.Vehicle[5];

        public int numberOfVehicles;

        private DateTime startTime;
        private DateTime timeWhenStopped;
        private TimeSpan currMovingTime;
        private TimeSpan currStopTime;
        private TimeSpan tempStopTime;
        private TimeSpan lengthOfStopTime;

        public bool[] carBoxIsMoving = new bool[5];
        public bool[] RailwayExists = new bool[5];
        public bool[] WiresExists = new bool[5];

        public List<string> FuelTypes = new List<string>();

        public string bus;
        public string car;
        public string bike;
        public string truck;
        public string cart;
        public string motorbike;
        public string loader;
        public string scooter;
        public string tank;
        public string tram;
        public string trolleybus;

        public bool startIsClicked;
        public bool stopIsClicked;

        private int carBoxStartY;
        private int carBoxFinishY;

        private int howManyTimesStartWasClicked;
        private int howManyTimesStopWasClicked;

        public bool[] justDeleted = new bool[5];
        
        public Controller()
        {
            bus = "автобус";
            car = "автомобиль";
            bike = "велосипед";
            truck = "грузовик";
            cart = "гужевая повозка";
            motorbike = "мотоцикл";
            loader = "погрузчик";
            scooter = "самокат";
            tank = "танк";
            tram = "трамвай";
            trolleybus = "троллейбус";

            startIsClicked = false;
            stopIsClicked = false;
            numberOfVehicles = 0;

            tempStopTime = TimeSpan.Zero;
            currStopTime = TimeSpan.Zero;
            currMovingTime = TimeSpan.Zero;
            currStopTime = TimeSpan.Zero;
            lengthOfStopTime = TimeSpan.Zero;

            howManyTimesStartWasClicked = 0;
            howManyTimesStopWasClicked = 0;

            for (int i = 0; i < 5; i++)
            {
                justDeleted[i] = false;
                carBoxIsMoving[i] = false;
                RailwayExists[i] = false;
                WiresExists[i] = false;
            }
        }
        public int CarBoxStartY
        {
            get { return carBoxStartY; }
            set { carBoxStartY = value; }
        }
        public int CarBoxFinishY
        {
            get { return carBoxFinishY; }
            set { carBoxFinishY = value; }
        }
        public void FillVehicleTypes(ComboBox comboBox)
        {
            comboBox.Items.Add(bus);
            comboBox.Items.Add(car);
            comboBox.Items.Add(bike);
            comboBox.Items.Add(truck);
            comboBox.Items.Add(cart);
            comboBox.Items.Add(motorbike);
            comboBox.Items.Add(loader);
            comboBox.Items.Add(scooter);
            comboBox.Items.Add(tank);
            comboBox.Items.Add(tram);
            comboBox.Items.Add(trolleybus);
        }        
        public bool ThereAreRailways(int laneID)
        {
            bool thereAreRailways = false;
            for(int i = 0; i < 5; i++)
            {
                if (laneID == (i + 1) && RailwayExists[i])
                {
                    thereAreRailways = true;
                    return thereAreRailways;
                }
            }           
            return thereAreRailways;
        }
        public void thereAreNoPossibleLanes(ComboBox TypeVehicleBox, ComboBox LaneNumberBox, ComboBox FuelTypeBox,
            TextBox StartSpeedTextBox, TextBox MaxSpeedTextBox, TextBox FuelRateTextBox, TextBox FuelCapacityTextBox)
        {
            if (LaneNumberBox.Items.Count == 0)
            {
                MessageBox.Show("Невозможно создать выбранное ТС. Создайте дорогу иначе или выберите другое ТС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                return;
            }
        }
        private int ParsingToInt(string s)
        {
            int number = 0;
            if(s != "")
            {
                try
                {
                    number = Int32.Parse(s);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }            
            return number;
        }
        public void CombineForVehicleType(ComboBox TypeVehicleBox,ComboBox LaneNumberBox,ComboBox FuelTypeBox,
            TextBox FuelRateTextBox, TextBox FuelCapacityTextBox, TextBox StartSpeedTextBox, TextBox MaxSpeedTextBox)
        {
            FuelRateTextBox.ReadOnly = false;
            FuelCapacityTextBox.ReadOnly = false;

             if (TypeVehicleBox.SelectedIndex != -1 && TypeVehicleBox.SelectedItem.Equals(tram))
                {
                    LaneNumberBox.Items.Clear();
                    for (int i = 1; i < 6; i++)
                    {
                        if (ThereAreRailways(i) && !laneIsTaken(i))
                        {
                            string item = i.ToString();
                            LaneNumberBox.Items.Add(item);
                        }
                    }
                    if (TypeVehicleBox.SelectedItem == null)
                    {
                        return;
                    }
                    thereAreNoPossibleLanes(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                    FuelTypeBox.Items.Clear();
                    FuelTypeBox.Items.Add("электричество");



                    FuelRateTextBox.Text = "0";
                    FuelRateTextBox.ReadOnly = true;
                    FuelCapacityTextBox.ReadOnly = true;
                    FuelCapacityTextBox.Text = "0";
                }
                else if (TypeVehicleBox.SelectedItem != null && TypeVehicleBox.SelectedItem.Equals(trolleybus))
                {
                    LaneNumberBox.Items.Clear();
                    for (int i = 1; i < 6; i++)
                    {
                        if (ThereAreWires(i) && (!ThereAreRailways(i)) && !laneIsTaken(i))
                        {
                            string item = i.ToString();
                            LaneNumberBox.Items.Add(item);
                        }
                    }
                    thereAreNoPossibleLanes(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                    if (TypeVehicleBox.SelectedItem == null)
                    {
                        return;
                    }
                    FuelTypeBox.Items.Clear();
                    FuelTypeBox.Items.Add("электричество");
                    
                    FuelRateTextBox.Text = "0";
                    FuelRateTextBox.ReadOnly = true;
                    FuelCapacityTextBox.ReadOnly = true;
                    FuelCapacityTextBox.Text = "0";
                }
                else if (TypeVehicleBox.SelectedItem != null && (TypeVehicleBox.SelectedItem.Equals(car) ||
                    TypeVehicleBox.SelectedItem.Equals(bus) ||
                    TypeVehicleBox.SelectedItem.Equals(motorbike) ||
                    TypeVehicleBox.SelectedItem.Equals(truck) ||
                    TypeVehicleBox.SelectedItem.Equals(loader)))
                {
                    LaneNumberBox.Items.Clear();
                    for (int i = 1; i < 6; i++)
                    {
                        if (!ThereAreRailways(i) && !laneIsTaken(i))
                        {
                            string item = i.ToString();
                            LaneNumberBox.Items.Add(item);
                        }
                    }
                    thereAreNoPossibleLanes(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                    FuelTypeBox.Items.Clear();
                    if (TypeVehicleBox.SelectedItem != null && TypeVehicleBox.SelectedItem.Equals(bus) ||
                        TypeVehicleBox.SelectedItem.Equals(truck) ||
                        TypeVehicleBox.SelectedItem.Equals(loader))
                    {
                        FuelTypeBox.Items.Add("дизель");
                    }
                    else if (TypeVehicleBox.SelectedItem != null &&  TypeVehicleBox.SelectedItem.Equals(car))
                    {
                        FuelTypeBox.Items.Add("бензин");
                        FuelTypeBox.Items.Add("дизель");
                        FuelTypeBox.Items.Add("газ");
                        FuelTypeBox.Items.Add("электричество");
                    }
                    else
                    {
                        FuelTypeBox.Items.Add("бензин");
                    }
                }
                else if (TypeVehicleBox.SelectedItem != null && (TypeVehicleBox.SelectedItem.Equals(tank) ||
                    TypeVehicleBox.SelectedItem.Equals(cart) ||
                    TypeVehicleBox.SelectedItem.Equals(bike) ||
                    TypeVehicleBox.SelectedItem.Equals(scooter)))
                {
                    LaneNumberBox.Items.Clear();
                    if (!ThereAreRailways(1) && !laneIsTaken(1))
                    {
                        LaneNumberBox.Items.Add("1");
                    }
                    if (!ThereAreRailways(5) && !laneIsTaken(5))
                    {
                        LaneNumberBox.Items.Add("5");
                    }
                    thereAreNoPossibleLanes(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
                    FuelTypeBox.Items.Clear();
                    if (TypeVehicleBox.SelectedItem != null)
                    {
                        if (TypeVehicleBox.SelectedItem.Equals(tank))
                        {
                            FuelTypeBox.Items.Add("дизель");
                        }
                        else
                            FuelTypeBox.Items.Add("-");
                    }

                    if (TypeVehicleBox.SelectedItem != null && (TypeVehicleBox.SelectedItem.Equals(cart) ||
                    TypeVehicleBox.SelectedItem.Equals(bike) ||
                    TypeVehicleBox.SelectedItem.Equals(scooter)))
                    {
                        FuelRateTextBox.Text = "0";
                        FuelRateTextBox.ReadOnly = true;
                        FuelCapacityTextBox.Text = "0";
                        FuelCapacityTextBox.ReadOnly = true;
                    }
                }         
        }
        public bool ThereAreWires(int laneID)
        {
            bool thereAreWires = false;            
            for(int i = 0; i < 5; i++)
            {
                if (laneID == (i + 1) && WiresExists[i])
                {
                    thereAreWires = true;
                    return thereAreWires;
                }
            }    
            return thereAreWires;
        }
        public bool laneIsTaken(int lane)
        {
            bool laneIsTaken = false;
            for (int i = 0; i < 5;i++)
            {
                if(arrayOfVehicles[i] != null)
                {
                    if ((i + 1) == lane)
                    {
                        laneIsTaken = true;
                        return laneIsTaken;
                    }
                }                
            }
            return laneIsTaken;
        }
        private void LockAll(ComboBox TypeVehicleBox, ComboBox LaneNumberBox, 
            ComboBox FuelTypeBox,TextBox StartSpeedTextBox,
            TextBox MaxSpeedTextBox, TextBox FuelRateTextBox, TextBox FuelCapacityTextBox, bool thisCase)
        {
            TypeVehicleBox.Enabled = thisCase;
            LaneNumberBox.Enabled = thisCase;
            FuelTypeBox.Enabled = thisCase;
            StartSpeedTextBox.Enabled = thisCase;
            MaxSpeedTextBox.Enabled = thisCase;
            FuelRateTextBox.Enabled = thisCase;
            FuelCapacityTextBox.Enabled = thisCase;
        }
        public void ChooseVehicle(string vehicleType, string fuelType, int fuelRate, int fuelCapacity, int startSpeed, int maxSpeed, int laneID)
        {
            Engine.Engine eng = ChooseEngine(fuelType, fuelRate);
            if (vehicleType.Equals(car))
            {
                Vehicle.Car newCar = new Vehicle.Car(eng, startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newCar;
            }
            else if (vehicleType.Equals(cart))
            {
                Vehicle.Cart newCart = new Vehicle.Cart(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newCart;
            }
            else if (vehicleType.Equals(bike))
            {
                Vehicle.Cycle newBike = new Vehicle.Cycle(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newBike;
            }
            else if (vehicleType.Equals(bus))
            {
                Vehicle.Bus newBus = new Vehicle.Bus(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newBus;
            }
            else if (vehicleType.Equals(scooter))
            {
                Vehicle.Scooter newScooter = new Vehicle.Scooter(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newScooter;
            }
            else if (vehicleType.Equals(motorbike))
            {
                Vehicle.Motorbike newMotorbike = new Vehicle.Motorbike(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newMotorbike;
            }
            else if (vehicleType.Equals(truck))
            {
                Vehicle.Truck newTruck = new Vehicle.Truck(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newTruck;
            }
            else if (vehicleType.Equals(loader))
            {
                Vehicle.Loader newLoader = new Vehicle.Loader(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newLoader;
            }
            else if (vehicleType.Equals(tram))
            {
                Vehicle.Tram newTram = new Vehicle.Tram(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newTram;
            }
            else if (vehicleType.Equals(trolleybus))
            {
                Vehicle.Trolleybus newTrolleybus = new Vehicle.Trolleybus(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newTrolleybus;
            }
            else if (vehicleType.Equals(tank))
            {
                Vehicle.Tank newTank = new Vehicle.Tank(ChooseEngine(fuelType, fuelRate), startSpeed, maxSpeed, fuelCapacity, CarBoxStartY, laneID);
                arrayOfVehicles[laneID - 1] = newTank;
            }
        }
        public void ChoosePicture(PictureBox pb, string vehicleType)
        {
            if (vehicleType.Equals(car))
            {
                pb.Image = global::UIVehicles.Properties.Resources.BlueCar;
            }
            else if (vehicleType.Equals(cart))
            {
                pb.Image = global::UIVehicles.Properties.Resources.cart;
            }
            else if (vehicleType.Equals(bike))
            {
                pb.Image = global::UIVehicles.Properties.Resources.bike;
            }
            else if (vehicleType.Equals(bus))
            {
                pb.Image = global::UIVehicles.Properties.Resources.bus;
            }
            else if (vehicleType.Equals(scooter))
            {
                pb.Image = global::UIVehicles.Properties.Resources.scooter;
            }
            else if (vehicleType.Equals(motorbike))
            {
                pb.Image = global::UIVehicles.Properties.Resources.motorbike;
            }
            else if (vehicleType.Equals(truck))
            {
                pb.Image = global::UIVehicles.Properties.Resources.truck;
            }
            else if (vehicleType.Equals(loader))
            {
                pb.Image = global::UIVehicles.Properties.Resources.loader;
            }
            else if (vehicleType.Equals(tram))
            {
                pb.Image = global::UIVehicles.Properties.Resources.tram;
            }
            else if (vehicleType.Equals(trolleybus))
            {
                pb.Image = global::UIVehicles.Properties.Resources.trolleybus;
            }
            else if (vehicleType.Equals(tank))
            {
                pb.Image = global::UIVehicles.Properties.Resources.Tank;
            }
        }      
        public void CreateVehicle(ComboBox TypeVehicleBox, 
            ComboBox LaneNumberBox, ComboBox FuelTypeBox,TextBox StartSpeedTextBox, 
            PictureBox CarBox, Button deleteButton,RadioButton radioButton, 
            TextBox MaxSpeedTextBox, TextBox FuelRateTextBox,TextBox FuelCapacityTextBox)
        {       
            if (StartSpeedTextBox.Text != "" && MaxSpeedTextBox.Text != "" && 
                FuelRateTextBox.Text != "" && FuelCapacityTextBox.Text != "")
            {
                int fuelRate = ParsingToInt(FuelRateTextBox.Text);
                int fuelCapacity = ParsingToInt(FuelCapacityTextBox.Text);
                int startSpeed = ParsingToInt(StartSpeedTextBox.Text);
                int maxSpeed = ParsingToInt(MaxSpeedTextBox.Text);

                if (TypeVehicleBox.SelectedItem != null &&
                   LaneNumberBox.SelectedItem != null &&
                   FuelTypeBox.SelectedItem != null &&
                   startSpeed <= maxSpeed &&
                   startSpeed >=0  && maxSpeed >= 0 &&
                   fuelRate >= 0 && fuelCapacity >= 0)
                {                      
                    string typeVehicle = TypeVehicleBox.SelectedItem.ToString();
                    string laneNumber = LaneNumberBox.SelectedItem.ToString();
                    string fuelType = FuelTypeBox.SelectedItem.ToString();
                                        
                    SetVehicleOnLane(laneNumber, typeVehicle, startSpeed, CarBox, fuelType, fuelRate, fuelCapacity, maxSpeed, startSpeed);
                    EnableDeleteButtons(deleteButton, radioButton);
                    //LockTakenVehicles(TypeVehicleBox);
                }
                else
                {
                    MessageBox.Show("Заполните все поля и проверьте на наличие ошибок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Clear(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox);
            }
            else
            {
                MessageBox.Show("Заполните все поля и проверьте на наличие ошибок", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void checkIfAllLanesTaken(ComboBox TypeVehicleBox, ComboBox LaneNumberBox,
            ComboBox FuelTypeBox, TextBox StartSpeedTextBox,
            TextBox MaxSpeedTextBox, TextBox FuelRateTextBox, TextBox FuelCapacityTextBox)
        {
            if ((laneIsTaken(1)) &&
                (laneIsTaken(2)) &&
                (laneIsTaken(3)) &&
                (laneIsTaken(4)) &&
                (laneIsTaken(5)))
            {
                LockAll(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox, false);
                return;
            }
            else
            {
                LockAll(TypeVehicleBox, LaneNumberBox, FuelTypeBox, StartSpeedTextBox, MaxSpeedTextBox, FuelRateTextBox, FuelCapacityTextBox, true);
                return;
            }
        }
        public void Clear(ComboBox TypeVehicleBox, ComboBox LaneNumberBox, ComboBox FuelTypeBox,
            TextBox StartSpeedTextBox, TextBox MaxSpeedTextBox, TextBox FuelRateTextBox, TextBox FuelCapacityTextBox)
        {
            TypeVehicleBox.SelectedIndex = -1;
            LaneNumberBox.SelectedIndex = -1;
            FuelTypeBox.SelectedIndex = -1;
            StartSpeedTextBox.Text = "";
            MaxSpeedTextBox.Text = "";
            FuelRateTextBox.Text = "";
            FuelCapacityTextBox.Text = "";
        }
        public void DeleteVehicleFromLane(int laneId)
        {
            if (arrayOfVehicles[0] != null && laneId == 1)
            {
                arrayOfVehicles[0] = null;
                justDeleted[0] = true;
                //UnlockTakenVehicles(TypeVehicleBox, Vehicle1[0]);
            }
            else if (arrayOfVehicles[1] != null && laneId == 2)
            {
                arrayOfVehicles[1] = null;
                justDeleted[1] = true;
                //UnlockTakenVehicles(TypeVehicleBox, Vehicle2[0]);
            }
            else if (arrayOfVehicles[2] != null && laneId == 3)
            {
                arrayOfVehicles[2] = null;
                justDeleted[2] = true; 
                //UnlockTakenVehicles(TypeVehicleBox, Vehicle3[0]);
            }
            else if (arrayOfVehicles[3] != null && laneId == 4)
            {
                arrayOfVehicles[3] = null; 
                justDeleted[3] = true;
                //UnlockTakenVehicles(TypeVehicleBox, Vehicle4[0]);
            }
            else if (arrayOfVehicles[4] != null && laneId == 5)
            {
                arrayOfVehicles[4] = null;
                justDeleted[4] = true;
                //UnlockTakenVehicles(TypeVehicleBox, Vehicle5[0]);
            }
        }
        public void EnableDeleteButtons(Button deleteButton, RadioButton radioButton)
        {
            deleteButton.Enabled = true;
            radioButton.Enabled = true;
        }
        public void DeleteVehicle(RadioButton radioButton, PictureBox CarBox, int laneID)
        {
            CarBox.Visible = false;
            DeleteVehicleFromLane(laneID);
            radioButton.Enabled = false;

            CarBox.Top = CarBoxStartY;
            numberOfVehicles--;
        }
        public void SetVehicleOnLane(string laneIDS, string vehicleType, int speed, PictureBox CarBox, 
            string fuelType, int fuelRate, int fuelCapacity, int maxSpeed, int startSpeed)
        {

            int laneID = ParsingToInt(laneIDS);

            CarBox.Visible = true;
            ChoosePicture(CarBox, vehicleType);
            ChooseVehicle(vehicleType, fuelType, fuelRate, fuelCapacity,startSpeed, maxSpeed, laneID);
            CarBox.BringToFront();

            numberOfVehicles++;       
        }
        public void StartAllVehicles()
        {
            for (int i = 0; i < 5; i++)
            {
                if (laneIsTaken(i + 1))
                {
                    arrayOfVehicles[i].start(DateTime.Now);
                }
            }
            if (!(laneIsTaken(1)) &&
                !(laneIsTaken(2)) &&
                !(laneIsTaken(3)) &&
                !(laneIsTaken(4)) &&
                !(laneIsTaken(5)))
                MessageBox.Show("Сначала создайте ТС", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (CheckIfSmthCreated())
            {
                if (howManyTimesStartWasClicked == 0)
                {
                    startTime = DateTime.Now;
                }
                howManyTimesStartWasClicked++;
                stopIsClicked = false;
                startIsClicked = true;
            }                
        }
        public bool CheckIfSmthCreated()
        {
            for (int i = 0; i < 5; i++)
            {
                if (arrayOfVehicles[i] != null)
                {
                    return true;
                }
            }
            return false;
        }
        public void StopAllVehicles()
        {
            timeWhenStopped = DateTime.Now;
            if (howManyTimesStopWasClicked != 0)
            {
                lengthOfStopTime += tempStopTime;
            }
            howManyTimesStopWasClicked++;

            stopIsClicked = true;
            startIsClicked = false;

            if (laneIsTaken(1) ||
               laneIsTaken(2) ||
               laneIsTaken(3) ||
               laneIsTaken(4) ||
               laneIsTaken(5))
            {
                for (int i = 0; i < 5; i++)
                {
                    if (arrayOfVehicles[i] != null)
                    {
                        arrayOfVehicles[i].stop(DateTime.Now);
                    }                    
                    //currentSpeed[i] = 0;
                }
                for (int i = 0; i < 5; i++)
                {
                    carBoxIsMoving[i] = false;
                }
            }
            else
                MessageBox.Show("Сначала запустите ТС", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void DisplayTime(Label TimeFromStartLabel, Label WholeStopTimeLabel, Label WholeTimeLabel)
        {
            TimeSpan stopTime = TimeSpan.Zero;
            TimeSpan movingTime = TimeSpan.Zero;
            TimeSpan currTimeFromStart = DateTime.Now - startTime;
            TimeSpan timeFromStart = currTimeFromStart;

            if(arrayOfVehicles[0] == null && 
               arrayOfVehicles[1] == null && 
               arrayOfVehicles[2] == null &&
               arrayOfVehicles[3] == null &&
               arrayOfVehicles[4] == null)
            {
                timeFromStart = currTimeFromStart;
                stopTime = currStopTime;
                movingTime = currMovingTime;
            }     
            else
            {   
                if (stopIsClicked)
                {
                    tempStopTime = DateTime.Now - timeWhenStopped;
                    currStopTime = lengthOfStopTime + tempStopTime;
                    stopTime = currStopTime;

                    movingTime = currMovingTime;    
                }
                else if (startIsClicked)
                {
                    stopTime = currStopTime;

                    currMovingTime = TimeSpan.FromTicks(timeFromStart.Ticks) - currStopTime;
                    movingTime = currMovingTime;  
                }                  
                else if((arrayOfVehicles[0] == null || arrayOfVehicles[0].CurrentSpeed == 0) &&
                        (arrayOfVehicles[1] == null || arrayOfVehicles[1].CurrentSpeed == 0) &&
                        (arrayOfVehicles[2] == null || arrayOfVehicles[2].CurrentSpeed == 0) &&
                        (arrayOfVehicles[3] == null || arrayOfVehicles[3].CurrentSpeed == 0) &&
                        (arrayOfVehicles[4] == null || arrayOfVehicles[4].CurrentSpeed == 0))
                {
                    stopTime = currStopTime;
                    movingTime = currMovingTime;   
                }    
            }
            TimeFromStartLabel.Text = timeFromStart.ToString();
            WholeStopTimeLabel.Text = stopTime.ToString();
            WholeTimeLabel.Text = movingTime.ToString(); 
        }
        private void MoveVehicle(Vehicle.Vehicle vehicle, bool isMoving, PictureBox CarBox)
        {
            if (vehicle != null)
            {
                vehicle.calculateCoordinate(CarBoxStartY, CarBoxFinishY, DateTime.Now);
                CarBox.Top = vehicle.CoordinateY;
            }
            isMoving = true;
        }
        public void Move(PictureBox CarBox1, PictureBox CarBox2, PictureBox CarBox3, PictureBox CarBox4, PictureBox CarBox5)
        {
            if (CarBox1.Top > CarBoxFinishY)
            {
                if (arrayOfVehicles[0] != null)
                {
                    MoveVehicle(arrayOfVehicles[0], carBoxIsMoving[0], CarBox1);
                }
            }
            if (CarBox2.Top > CarBoxFinishY)
            {
                if (arrayOfVehicles[1] != null)
                {
                    MoveVehicle(arrayOfVehicles[1], carBoxIsMoving[1], CarBox2);
                }
            }
            if (CarBox3.Top > CarBoxFinishY)
            {
                if (arrayOfVehicles[2] != null)
                {
                    MoveVehicle(arrayOfVehicles[2], carBoxIsMoving[2], CarBox3);
                }
            }
            if (CarBox4.Top > CarBoxFinishY)
            {
                if (arrayOfVehicles[3] != null)
                {
                    MoveVehicle(arrayOfVehicles[3], carBoxIsMoving[3], CarBox4);
                }
            }
            if (CarBox5.Top > CarBoxFinishY)
            {
                if (arrayOfVehicles[4] != null)
                {
                    MoveVehicle(arrayOfVehicles[4], carBoxIsMoving[4], CarBox5);
                }
            }
        }
        private void RailwaysOrWiresExist(int laneID, int modificationID)
        {
              for(int i = 0; i < 5; i++){

                   if(laneID == i)
                   {
                        switch(modificationID)
                        {
                            case 0:
                                RailwayExists[i-1] = false;
                                WiresExists[i-1] = false;
                                break;
                            case 1:
                                RailwayExists[i-1] = false;
                                WiresExists[i-1] = true;
                                break;
                            case 2:
                                RailwayExists[i-1] = true;
                                WiresExists[i-1] = false;
                                break;
                            default:
                                break;
                        }
                  }
              }
        }
        public void CreateRoad(PictureBox RailwayBox, PictureBox WiresBox, int laneID, int modificationID)
        {          
            switch(modificationID)
            {
                case 0:
                    RailwayBox.Visible = false;
                    WiresBox.Visible = false;

                    RailwaysOrWiresExist(laneID, 0);
                    break;
                case 1:
                    WiresBox.Visible = true;
                    RailwayBox.Visible = false;

                    RailwaysOrWiresExist(laneID, 1);
                    break;
                case 2:
                    RailwayBox.Visible = true;
                    WiresBox.Visible = false;

                    RailwaysOrWiresExist(laneID, 2);
                    break;
                default:
                    break;
            }
               
        }
        private Engine.Engine ChooseEngine(string fuelType, int fuelRateInt)
        {
            switch (fuelType)
            {
                case "электричество":
                    Engine.Engine electricEngine = new Engine.Engine(Engine.EngineType.ElectricMotor, Fuel.FuelType.Electricity, fuelRateInt);
                    return electricEngine;
                default:
                    Engine.Engine musleEngine = new Engine.Engine(Engine.EngineType.MuscleStrength, Fuel.FuelType.Nothing, fuelRateInt);
                    return musleEngine;
                case "бензин":
                    Engine.Engine petrolEngine = new Engine.Engine(Engine.EngineType.InternalCombustionEngine, Fuel.FuelType.Petrol, fuelRateInt);
                    return petrolEngine;
                case "дизель":
                    Engine.Engine dieselEngine = new Engine.Engine(Engine.EngineType.MuscleStrength, Fuel.FuelType.Diesel, fuelRateInt);
                    return dieselEngine;
                case "газ":
                    Engine.Engine gasEngine = new Engine.Engine(Engine.EngineType.MuscleStrength, Fuel.FuelType.Gas, fuelRateInt);
                    return gasEngine;
            }            
        }
        public  void DisplayLogInWord(int number)
        {
            if (number == 6)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (arrayOfVehicles[i] != null)
                    {
                        arrayOfVehicles[i].showLogInWord();
                        return;
                    }
                }
            }     
            for (int i = 0; i < 5; i++)
            {
                if (number == i + 1)
                {
                    if (arrayOfVehicles[i] != null)
                    {
                        arrayOfVehicles[i].showLogInWord();
                        return;
                    }
                }

            }
                               
        }
        public void DisplayLogInExcel(int number)
        {
            if (number == 6)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (arrayOfVehicles[i] != null)
                    {
                        try
                        {
                            arrayOfVehicles[i].showLogInExcel();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (number == i + 1)
                {
                    if (arrayOfVehicles[i] != null)
                    {
                        try
                        {
                            arrayOfVehicles[i].showLogInExcel();
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return;
                    }
                }

            }
        }
        public void FillFuelList(Label fuelListALl)
        {
            fuelListALl.Text = "1. электричество\n";
            fuelListALl.Text += "3. бензин\n";
            fuelListALl.Text += "4. дизель\n";
            fuelListALl.Text += "5. газ\n";      
        }
        public bool EnableVehicleNumberButtons(int i, RadioButton radioButton1)
        {
            if (arrayOfVehicles[i] != null)
            {
                radioButton1.Enabled = true;
                return true;
            }
            else if (arrayOfVehicles[i] == null)
            {
                radioButton1.Enabled = false;
                return false;
            }
            return false;
        }
    }
}