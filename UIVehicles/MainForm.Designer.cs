namespace UIVehicles
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddVehicle = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.ListOfFuel = new System.Windows.Forms.Button();
            this.CreateRoadBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerCarBox = new System.Windows.Forms.Timer(this.components);
            this.CarBox5 = new System.Windows.Forms.PictureBox();
            this.CarBox4 = new System.Windows.Forms.PictureBox();
            this.CarBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuCarBox1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.начатьДвижениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яХочуУвидетьТвойЖуранлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarBox2 = new System.Windows.Forms.PictureBox();
            this.CarBox3 = new System.Windows.Forms.PictureBox();
            this.Wires2Box = new System.Windows.Forms.PictureBox();
            this.Wires3Box = new System.Windows.Forms.PictureBox();
            this.Wires5Box = new System.Windows.Forms.PictureBox();
            this.Wires4Box = new System.Windows.Forms.PictureBox();
            this.Wires1Box = new System.Windows.Forms.PictureBox();
            this.Railway2Box = new System.Windows.Forms.PictureBox();
            this.Railway3Box = new System.Windows.Forms.PictureBox();
            this.Railway5Box = new System.Windows.Forms.PictureBox();
            this.Railway4Box = new System.Windows.Forms.PictureBox();
            this.Railway1Box = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeFromStartLabel = new System.Windows.Forms.Label();
            this.WholeTimeLabel = new System.Windows.Forms.Label();
            this.NumberOfVehiclesLabel = new System.Windows.Forms.Label();
            this.WholeStopTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox1)).BeginInit();
            this.contextMenuCarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires5Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires4Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway5Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway4Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddVehicle
            // 
            this.AddVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVehicle.Location = new System.Drawing.Point(514, 86);
            this.AddVehicle.Name = "AddVehicle";
            this.AddVehicle.Size = new System.Drawing.Size(75, 53);
            this.AddVehicle.TabIndex = 2;
            this.AddVehicle.Text = "Добавить ТС";
            this.AddVehicle.UseVisualStyleBackColor = true;
            this.AddVehicle.Click += new System.EventHandler(this.addVehicleForm_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(514, 144);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 53);
            this.Start.TabIndex = 3;
            this.Start.Text = "Старт всех ТС";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(514, 203);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 53);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Остановить все ТС";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(514, 262);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(75, 53);
            this.Log.TabIndex = 5;
            this.Log.Text = "Вывести на экран журнал";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.logForm_Click);
            // 
            // ListOfFuel
            // 
            this.ListOfFuel.Location = new System.Drawing.Point(514, 321);
            this.ListOfFuel.Name = "ListOfFuel";
            this.ListOfFuel.Size = new System.Drawing.Size(75, 53);
            this.ListOfFuel.TabIndex = 6;
            this.ListOfFuel.Text = "Список видов топлива";
            this.ListOfFuel.UseVisualStyleBackColor = true;
            this.ListOfFuel.Click += new System.EventHandler(this.listOfFuelForm_Click);
            // 
            // CreateRoadBTN
            // 
            this.CreateRoadBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateRoadBTN.Location = new System.Drawing.Point(514, 28);
            this.CreateRoadBTN.Name = "CreateRoadBTN";
            this.CreateRoadBTN.Size = new System.Drawing.Size(75, 52);
            this.CreateRoadBTN.TabIndex = 7;
            this.CreateRoadBTN.Text = "Создание дороги";
            this.CreateRoadBTN.UseVisualStyleBackColor = true;
            this.CreateRoadBTN.Click += new System.EventHandler(this.createRoadForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Время с момента старта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Суммарное время движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Суммарное время остановок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во движущихся ТС";
            // 
            // timerCarBox
            // 
            this.timerCarBox.Enabled = true;
            this.timerCarBox.Tick += new System.EventHandler(this.timerCarBox_Tick);
            // 
            // CarBox5
            // 
            this.CarBox5.Location = new System.Drawing.Point(433, 369);
            this.CarBox5.Name = "CarBox5";
            this.CarBox5.Size = new System.Drawing.Size(26, 50);
            this.CarBox5.TabIndex = 27;
            this.CarBox5.TabStop = false;
            this.CarBox5.Visible = false;
            // 
            // CarBox4
            // 
            this.CarBox4.Location = new System.Drawing.Point(343, 369);
            this.CarBox4.Name = "CarBox4";
            this.CarBox4.Size = new System.Drawing.Size(26, 50);
            this.CarBox4.TabIndex = 18;
            this.CarBox4.TabStop = false;
            this.CarBox4.Visible = false;
            // 
            // CarBox1
            // 
            this.CarBox1.ContextMenuStrip = this.contextMenuCarBox1;
            this.CarBox1.Location = new System.Drawing.Point(47, 369);
            this.CarBox1.Name = "CarBox1";
            this.CarBox1.Size = new System.Drawing.Size(26, 50);
            this.CarBox1.TabIndex = 24;
            this.CarBox1.TabStop = false;
            this.CarBox1.Visible = false;
            // 
            // contextMenuCarBox1
            // 
            this.contextMenuCarBox1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьДвижениеToolStripMenuItem,
            this.остановитьToolStripMenuItem,
            this.яХочуУвидетьТвойЖуранлToolStripMenuItem});
            this.contextMenuCarBox1.Name = "contextMenuStrip1";
            this.contextMenuCarBox1.Size = new System.Drawing.Size(228, 70);
            // 
            // начатьДвижениеToolStripMenuItem
            // 
            this.начатьДвижениеToolStripMenuItem.Name = "начатьДвижениеToolStripMenuItem";
            this.начатьДвижениеToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.начатьДвижениеToolStripMenuItem.Text = "Начать движение";
            // 
            // остановитьToolStripMenuItem
            // 
            this.остановитьToolStripMenuItem.Name = "остановитьToolStripMenuItem";
            this.остановитьToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.остановитьToolStripMenuItem.Text = "Остановить";
            // 
            // яХочуУвидетьТвойЖуранлToolStripMenuItem
            // 
            this.яХочуУвидетьТвойЖуранлToolStripMenuItem.Name = "яХочуУвидетьТвойЖуранлToolStripMenuItem";
            this.яХочуУвидетьТвойЖуранлToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.яХочуУвидетьТвойЖуранлToolStripMenuItem.Text = "Я хочу увидеть твой журнал";
            // 
            // CarBox2
            // 
            this.CarBox2.Location = new System.Drawing.Point(138, 369);
            this.CarBox2.Name = "CarBox2";
            this.CarBox2.Size = new System.Drawing.Size(26, 50);
            this.CarBox2.TabIndex = 25;
            this.CarBox2.TabStop = false;
            this.CarBox2.Visible = false;
            // 
            // CarBox3
            // 
            this.CarBox3.Location = new System.Drawing.Point(243, 369);
            this.CarBox3.Name = "CarBox3";
            this.CarBox3.Size = new System.Drawing.Size(26, 50);
            this.CarBox3.TabIndex = 26;
            this.CarBox3.TabStop = false;
            this.CarBox3.Visible = false;
            // 
            // Wires2Box
            // 
            this.Wires2Box.Image = global::UIVehicles.Properties.Resources.проводаNEW;
            this.Wires2Box.Location = new System.Drawing.Point(111, 3);
            this.Wires2Box.Name = "Wires2Box";
            this.Wires2Box.Size = new System.Drawing.Size(73, 416);
            this.Wires2Box.TabIndex = 37;
            this.Wires2Box.TabStop = false;
            this.Wires2Box.Visible = false;
            // 
            // Wires3Box
            // 
            this.Wires3Box.Image = global::UIVehicles.Properties.Resources.проводаNEW;
            this.Wires3Box.Location = new System.Drawing.Point(217, 3);
            this.Wires3Box.Name = "Wires3Box";
            this.Wires3Box.Size = new System.Drawing.Size(73, 416);
            this.Wires3Box.TabIndex = 36;
            this.Wires3Box.TabStop = false;
            this.Wires3Box.Visible = false;
            // 
            // Wires5Box
            // 
            this.Wires5Box.Image = global::UIVehicles.Properties.Resources.проводаNEW;
            this.Wires5Box.Location = new System.Drawing.Point(406, 3);
            this.Wires5Box.Name = "Wires5Box";
            this.Wires5Box.Size = new System.Drawing.Size(73, 416);
            this.Wires5Box.TabIndex = 35;
            this.Wires5Box.TabStop = false;
            this.Wires5Box.Visible = false;
            // 
            // Wires4Box
            // 
            this.Wires4Box.Image = global::UIVehicles.Properties.Resources.проводаNEW;
            this.Wires4Box.Location = new System.Drawing.Point(317, 3);
            this.Wires4Box.Name = "Wires4Box";
            this.Wires4Box.Size = new System.Drawing.Size(73, 416);
            this.Wires4Box.TabIndex = 34;
            this.Wires4Box.TabStop = false;
            this.Wires4Box.Visible = false;
            // 
            // Wires1Box
            // 
            this.Wires1Box.Image = global::UIVehicles.Properties.Resources.проводаNEW;
            this.Wires1Box.Location = new System.Drawing.Point(20, 3);
            this.Wires1Box.Name = "Wires1Box";
            this.Wires1Box.Size = new System.Drawing.Size(73, 416);
            this.Wires1Box.TabIndex = 33;
            this.Wires1Box.TabStop = false;
            this.Wires1Box.Visible = false;
            // 
            // Railway2Box
            // 
            this.Railway2Box.Image = global::UIVehicles.Properties.Resources.рельсыNEW;
            this.Railway2Box.Location = new System.Drawing.Point(121, 3);
            this.Railway2Box.Name = "Railway2Box";
            this.Railway2Box.Size = new System.Drawing.Size(63, 416);
            this.Railway2Box.TabIndex = 32;
            this.Railway2Box.TabStop = false;
            this.Railway2Box.Visible = false;
            // 
            // Railway3Box
            // 
            this.Railway3Box.Image = global::UIVehicles.Properties.Resources.рельсыNEW;
            this.Railway3Box.Location = new System.Drawing.Point(222, 3);
            this.Railway3Box.Name = "Railway3Box";
            this.Railway3Box.Size = new System.Drawing.Size(63, 416);
            this.Railway3Box.TabIndex = 31;
            this.Railway3Box.TabStop = false;
            this.Railway3Box.Visible = false;
            // 
            // Railway5Box
            // 
            this.Railway5Box.Image = global::UIVehicles.Properties.Resources.рельсыNEW;
            this.Railway5Box.Location = new System.Drawing.Point(410, 3);
            this.Railway5Box.Name = "Railway5Box";
            this.Railway5Box.Size = new System.Drawing.Size(63, 416);
            this.Railway5Box.TabIndex = 30;
            this.Railway5Box.TabStop = false;
            this.Railway5Box.Visible = false;
            // 
            // Railway4Box
            // 
            this.Railway4Box.Image = global::UIVehicles.Properties.Resources.рельсыNEW;
            this.Railway4Box.Location = new System.Drawing.Point(321, 3);
            this.Railway4Box.Name = "Railway4Box";
            this.Railway4Box.Size = new System.Drawing.Size(63, 416);
            this.Railway4Box.TabIndex = 29;
            this.Railway4Box.TabStop = false;
            this.Railway4Box.Visible = false;
            // 
            // Railway1Box
            // 
            this.Railway1Box.Image = global::UIVehicles.Properties.Resources.рельсыNEW;
            this.Railway1Box.Location = new System.Drawing.Point(27, 3);
            this.Railway1Box.Name = "Railway1Box";
            this.Railway1Box.Size = new System.Drawing.Size(63, 416);
            this.Railway1Box.TabIndex = 28;
            this.Railway1Box.TabStop = false;
            this.Railway1Box.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::UIVehicles.Properties.Resources.OwSPC1EYT9Q;
            this.pictureBox1.Location = new System.Drawing.Point(12, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 427);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TimeFromStartLabel
            // 
            this.TimeFromStartLabel.AutoSize = true;
            this.TimeFromStartLabel.Location = new System.Drawing.Point(162, 438);
            this.TimeFromStartLabel.Name = "TimeFromStartLabel";
            this.TimeFromStartLabel.Size = new System.Drawing.Size(25, 13);
            this.TimeFromStartLabel.TabIndex = 39;
            this.TimeFromStartLabel.Text = "123";
            this.TimeFromStartLabel.Visible = false;
            // 
            // WholeTimeLabel
            // 
            this.WholeTimeLabel.AutoSize = true;
            this.WholeTimeLabel.Location = new System.Drawing.Point(162, 462);
            this.WholeTimeLabel.Name = "WholeTimeLabel";
            this.WholeTimeLabel.Size = new System.Drawing.Size(25, 13);
            this.WholeTimeLabel.TabIndex = 40;
            this.WholeTimeLabel.Text = "123";
            this.WholeTimeLabel.Visible = false;
            // 
            // NumberOfVehiclesLabel
            // 
            this.NumberOfVehiclesLabel.AutoSize = true;
            this.NumberOfVehiclesLabel.Location = new System.Drawing.Point(349, 438);
            this.NumberOfVehiclesLabel.Name = "NumberOfVehiclesLabel";
            this.NumberOfVehiclesLabel.Size = new System.Drawing.Size(13, 13);
            this.NumberOfVehiclesLabel.TabIndex = 41;
            this.NumberOfVehiclesLabel.Text = "0";
            // 
            // WholeStopTimeLabel
            // 
            this.WholeStopTimeLabel.AutoSize = true;
            this.WholeStopTimeLabel.Location = new System.Drawing.Point(381, 462);
            this.WholeStopTimeLabel.Name = "WholeStopTimeLabel";
            this.WholeStopTimeLabel.Size = new System.Drawing.Size(25, 13);
            this.WholeStopTimeLabel.TabIndex = 42;
            this.WholeStopTimeLabel.Text = "123";
            this.WholeStopTimeLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WholeStopTimeLabel);
            this.Controls.Add(this.NumberOfVehiclesLabel);
            this.Controls.Add(this.CarBox1);
            this.Controls.Add(this.CarBox2);
            this.Controls.Add(this.CarBox5);
            this.Controls.Add(this.CarBox4);
            this.Controls.Add(this.CarBox3);
            this.Controls.Add(this.Wires2Box);
            this.Controls.Add(this.Wires3Box);
            this.Controls.Add(this.Wires5Box);
            this.Controls.Add(this.Wires4Box);
            this.Controls.Add(this.Wires1Box);
            this.Controls.Add(this.Railway2Box);
            this.Controls.Add(this.Railway3Box);
            this.Controls.Add(this.Railway5Box);
            this.Controls.Add(this.Railway4Box);
            this.Controls.Add(this.Railway1Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateRoadBTN);
            this.Controls.Add(this.ListOfFuel);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.AddVehicle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimeFromStartLabel);
            this.Controls.Add(this.WholeTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Имитация дорожного движения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.CarBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox1)).EndInit();
            this.contextMenuCarBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires5Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires4Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wires1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway5Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway4Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Railway1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddVehicle;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button ListOfFuel;
        private System.Windows.Forms.Button CreateRoadBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerCarBox;
        public System.Windows.Forms.PictureBox CarBox4;
        public System.Windows.Forms.PictureBox CarBox1;
        public System.Windows.Forms.PictureBox CarBox2;
        public System.Windows.Forms.PictureBox CarBox3;
        public System.Windows.Forms.PictureBox CarBox5;
        public System.Windows.Forms.PictureBox Railway1Box;
        public System.Windows.Forms.PictureBox Railway4Box;
        public System.Windows.Forms.PictureBox Railway5Box;
        public System.Windows.Forms.PictureBox Railway3Box;
        public System.Windows.Forms.PictureBox Railway2Box;
        public System.Windows.Forms.PictureBox Wires1Box;
        public System.Windows.Forms.PictureBox Wires4Box;
        public System.Windows.Forms.PictureBox Wires5Box;
        public System.Windows.Forms.PictureBox Wires3Box;
        public System.Windows.Forms.PictureBox Wires2Box;
        private System.Windows.Forms.Label TimeFromStartLabel;
        private System.Windows.Forms.Label WholeTimeLabel;
        private System.Windows.Forms.Label WholeStopTimeLabel;
        public System.Windows.Forms.Label NumberOfVehiclesLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuCarBox1;
        private System.Windows.Forms.ToolStripMenuItem начатьДвижениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яХочуУвидетьТвойЖуранлToolStripMenuItem;
    }
}

