namespace UIVehicles
{
    partial class AddVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeVehicleBox = new System.Windows.Forms.ComboBox();
            this.LaneNumberLabel = new System.Windows.Forms.Label();
            this.LaneNumberBox = new System.Windows.Forms.ComboBox();
            this.FuelTypeLabel = new System.Windows.Forms.Label();
            this.FuelTypeBox = new System.Windows.Forms.ComboBox();
            this.StartSpeedTextBox = new System.Windows.Forms.TextBox();
            this.StartSpeedLabel = new System.Windows.Forms.Label();
            this.CreateVehicle1Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FuelRateLabel = new System.Windows.Forms.Label();
            this.FuelRateTextBox = new System.Windows.Forms.TextBox();
            this.FuelCapacityLabel = new System.Windows.Forms.Label();
            this.FuelCapacityTextBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteVehicleButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioDelete5 = new System.Windows.Forms.RadioButton();
            this.RadioDelete4 = new System.Windows.Forms.RadioButton();
            this.RadioDelete3 = new System.Windows.Forms.RadioButton();
            this.RadioDelete2 = new System.Windows.Forms.RadioButton();
            this.RadioDelete1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите характиристики для каждого ТС:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(72, 20);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 13);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Вид ТС";
            // 
            // TypeVehicleBox
            // 
            this.TypeVehicleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeVehicleBox.FormattingEnabled = true;
            this.TypeVehicleBox.Location = new System.Drawing.Point(121, 17);
            this.TypeVehicleBox.Name = "TypeVehicleBox";
            this.TypeVehicleBox.Size = new System.Drawing.Size(121, 21);
            this.TypeVehicleBox.TabIndex = 1;
            this.TypeVehicleBox.SelectedIndexChanged += new System.EventHandler(this.TypeVehicleBox_SelectedIndexChanged);
            // 
            // LaneNumberLabel
            // 
            this.LaneNumberLabel.AutoSize = true;
            this.LaneNumberLabel.Location = new System.Drawing.Point(33, 47);
            this.LaneNumberLabel.Name = "LaneNumberLabel";
            this.LaneNumberLabel.Size = new System.Drawing.Size(82, 13);
            this.LaneNumberLabel.TabIndex = 6;
            this.LaneNumberLabel.Text = "Номер полосы";
            // 
            // LaneNumberBox
            // 
            this.LaneNumberBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaneNumberBox.FormattingEnabled = true;
            this.LaneNumberBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LaneNumberBox.Location = new System.Drawing.Point(121, 44);
            this.LaneNumberBox.Name = "LaneNumberBox";
            this.LaneNumberBox.Size = new System.Drawing.Size(121, 21);
            this.LaneNumberBox.TabIndex = 2;
            // 
            // FuelTypeLabel
            // 
            this.FuelTypeLabel.AutoSize = true;
            this.FuelTypeLabel.Location = new System.Drawing.Point(45, 74);
            this.FuelTypeLabel.Name = "FuelTypeLabel";
            this.FuelTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.FuelTypeLabel.TabIndex = 8;
            this.FuelTypeLabel.Text = "Вид топлива";
            // 
            // FuelTypeBox
            // 
            this.FuelTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelTypeBox.FormattingEnabled = true;
            this.FuelTypeBox.Location = new System.Drawing.Point(121, 71);
            this.FuelTypeBox.Name = "FuelTypeBox";
            this.FuelTypeBox.Size = new System.Drawing.Size(121, 21);
            this.FuelTypeBox.TabIndex = 3;
            // 
            // StartSpeedTextBox
            // 
            this.StartSpeedTextBox.Location = new System.Drawing.Point(139, 98);
            this.StartSpeedTextBox.Name = "StartSpeedTextBox";
            this.StartSpeedTextBox.Size = new System.Drawing.Size(103, 20);
            this.StartSpeedTextBox.TabIndex = 4;
            // 
            // StartSpeedLabel
            // 
            this.StartSpeedLabel.AutoSize = true;
            this.StartSpeedLabel.Location = new System.Drawing.Point(3, 101);
            this.StartSpeedLabel.Name = "StartSpeedLabel";
            this.StartSpeedLabel.Size = new System.Drawing.Size(112, 13);
            this.StartSpeedLabel.TabIndex = 10;
            this.StartSpeedLabel.Text = "Начальная скорость";
            // 
            // CreateVehicle1Button
            // 
            this.CreateVehicle1Button.Location = new System.Drawing.Point(324, 242);
            this.CreateVehicle1Button.Name = "CreateVehicle1Button";
            this.CreateVehicle1Button.Size = new System.Drawing.Size(77, 23);
            this.CreateVehicle1Button.TabIndex = 8;
            this.CreateVehicle1Button.Text = "Создать";
            this.CreateVehicle1Button.UseVisualStyleBackColor = true;
            this.CreateVehicle1Button.Click += new System.EventHandler(this.CreateVehicleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FuelRateLabel);
            this.groupBox1.Controls.Add(this.FuelRateTextBox);
            this.groupBox1.Controls.Add(this.FuelCapacityLabel);
            this.groupBox1.Controls.Add(this.FuelCapacityTextBox);
            this.groupBox1.Controls.Add(this.MaxSpeedLabel);
            this.groupBox1.Controls.Add(this.MaxSpeedTextBox);
            this.groupBox1.Controls.Add(this.LaneNumberBox);
            this.groupBox1.Controls.Add(this.TypeVehicleBox);
            this.groupBox1.Controls.Add(this.TypeLabel);
            this.groupBox1.Controls.Add(this.StartSpeedLabel);
            this.groupBox1.Controls.Add(this.LaneNumberLabel);
            this.groupBox1.Controls.Add(this.StartSpeedTextBox);
            this.groupBox1.Controls.Add(this.FuelTypeBox);
            this.groupBox1.Controls.Add(this.FuelTypeLabel);
            this.groupBox1.Location = new System.Drawing.Point(159, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 196);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // FuelRateLabel
            // 
            this.FuelRateLabel.AutoSize = true;
            this.FuelRateLabel.Location = new System.Drawing.Point(3, 150);
            this.FuelRateLabel.Name = "FuelRateLabel";
            this.FuelRateLabel.Size = new System.Drawing.Size(87, 13);
            this.FuelRateLabel.TabIndex = 19;
            this.FuelRateLabel.Text = "Расход топлива";
            // 
            // FuelRateTextBox
            // 
            this.FuelRateTextBox.Location = new System.Drawing.Point(139, 147);
            this.FuelRateTextBox.Name = "FuelRateTextBox";
            this.FuelRateTextBox.Size = new System.Drawing.Size(103, 20);
            this.FuelRateTextBox.TabIndex = 6;
            // 
            // FuelCapacityLabel
            // 
            this.FuelCapacityLabel.AutoSize = true;
            this.FuelCapacityLabel.Location = new System.Drawing.Point(3, 176);
            this.FuelCapacityLabel.Name = "FuelCapacityLabel";
            this.FuelCapacityLabel.Size = new System.Drawing.Size(78, 13);
            this.FuelCapacityLabel.TabIndex = 17;
            this.FuelCapacityLabel.Text = "Емкость бака";
            // 
            // FuelCapacityTextBox
            // 
            this.FuelCapacityTextBox.Location = new System.Drawing.Point(139, 173);
            this.FuelCapacityTextBox.Name = "FuelCapacityTextBox";
            this.FuelCapacityTextBox.Size = new System.Drawing.Size(103, 20);
            this.FuelCapacityTextBox.TabIndex = 7;
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Location = new System.Drawing.Point(3, 124);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(134, 13);
            this.MaxSpeedLabel.TabIndex = 15;
            this.MaxSpeedLabel.Text = "Максимальная скорость";
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(139, 121);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(103, 20);
            this.MaxSpeedTextBox.TabIndex = 5;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(221, 242);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteVehicleButton
            // 
            this.DeleteVehicleButton.Enabled = false;
            this.DeleteVehicleButton.Location = new System.Drawing.Point(35, 92);
            this.DeleteVehicleButton.Name = "DeleteVehicleButton";
            this.DeleteVehicleButton.Size = new System.Drawing.Size(75, 25);
            this.DeleteVehicleButton.TabIndex = 18;
            this.DeleteVehicleButton.TabStop = false;
            this.DeleteVehicleButton.Text = "удалить";
            this.DeleteVehicleButton.UseVisualStyleBackColor = true;
            this.DeleteVehicleButton.Click += new System.EventHandler(this.DeleteVehicleButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioDelete5);
            this.groupBox3.Controls.Add(this.RadioDelete4);
            this.groupBox3.Controls.Add(this.RadioDelete3);
            this.groupBox3.Controls.Add(this.RadioDelete2);
            this.groupBox3.Controls.Add(this.RadioDelete1);
            this.groupBox3.Controls.Add(this.DeleteVehicleButton);
            this.groupBox3.Location = new System.Drawing.Point(2, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 122);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Укажите на какой полосе удалить транспортное средство:";
            // 
            // RadioDelete5
            // 
            this.RadioDelete5.AutoSize = true;
            this.RadioDelete5.Enabled = false;
            this.RadioDelete5.Location = new System.Drawing.Point(68, 67);
            this.RadioDelete5.Name = "RadioDelete5";
            this.RadioDelete5.Size = new System.Drawing.Size(42, 17);
            this.RadioDelete5.TabIndex = 22;
            this.RadioDelete5.Text = "№5";
            this.RadioDelete5.UseVisualStyleBackColor = true;
            // 
            // RadioDelete4
            // 
            this.RadioDelete4.AutoSize = true;
            this.RadioDelete4.Enabled = false;
            this.RadioDelete4.Location = new System.Drawing.Point(20, 67);
            this.RadioDelete4.Name = "RadioDelete4";
            this.RadioDelete4.Size = new System.Drawing.Size(42, 17);
            this.RadioDelete4.TabIndex = 21;
            this.RadioDelete4.Text = "№4";
            this.RadioDelete4.UseVisualStyleBackColor = true;
            // 
            // RadioDelete3
            // 
            this.RadioDelete3.AutoSize = true;
            this.RadioDelete3.Enabled = false;
            this.RadioDelete3.Location = new System.Drawing.Point(102, 52);
            this.RadioDelete3.Name = "RadioDelete3";
            this.RadioDelete3.Size = new System.Drawing.Size(42, 17);
            this.RadioDelete3.TabIndex = 20;
            this.RadioDelete3.Text = "№3";
            this.RadioDelete3.UseVisualStyleBackColor = true;
            // 
            // RadioDelete2
            // 
            this.RadioDelete2.AutoSize = true;
            this.RadioDelete2.Enabled = false;
            this.RadioDelete2.Location = new System.Drawing.Point(54, 52);
            this.RadioDelete2.Name = "RadioDelete2";
            this.RadioDelete2.Size = new System.Drawing.Size(42, 17);
            this.RadioDelete2.TabIndex = 20;
            this.RadioDelete2.Text = "№2";
            this.RadioDelete2.UseVisualStyleBackColor = true;
            // 
            // RadioDelete1
            // 
            this.RadioDelete1.AutoSize = true;
            this.RadioDelete1.Enabled = false;
            this.RadioDelete1.Location = new System.Drawing.Point(6, 52);
            this.RadioDelete1.Name = "RadioDelete1";
            this.RadioDelete1.Size = new System.Drawing.Size(42, 17);
            this.RadioDelete1.TabIndex = 19;
            this.RadioDelete1.Text = "№1";
            this.RadioDelete1.UseVisualStyleBackColor = true;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 291);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateVehicle1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddVehicleForm";
            this.Text = "Добавление ТС";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddVehicleForm_FormClosing);
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LaneNumberLabel;
        private System.Windows.Forms.Label FuelTypeLabel;
        private System.Windows.Forms.Label StartSpeedLabel;
        private System.Windows.Forms.Button CreateVehicle1Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteVehicleButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioDelete5;
        private System.Windows.Forms.RadioButton RadioDelete4;
        private System.Windows.Forms.RadioButton RadioDelete3;
        private System.Windows.Forms.RadioButton RadioDelete2;
        private System.Windows.Forms.RadioButton RadioDelete1;
        public System.Windows.Forms.TextBox StartSpeedTextBox;
        private System.Windows.Forms.Label MaxSpeedLabel;
        public System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.Label FuelRateLabel;
        public System.Windows.Forms.TextBox FuelRateTextBox;
        private System.Windows.Forms.Label FuelCapacityLabel;
        public System.Windows.Forms.TextBox FuelCapacityTextBox;
        public System.Windows.Forms.ComboBox TypeVehicleBox;
        public System.Windows.Forms.ComboBox LaneNumberBox;
        public System.Windows.Forms.ComboBox FuelTypeBox;
    }
}