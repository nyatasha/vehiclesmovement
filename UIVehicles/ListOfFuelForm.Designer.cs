namespace UIVehicles
{
    partial class ListOfFuelForm
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
            this.fuelListAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список видов топлива:";
            // 
            // fuelListAll
            // 
            this.fuelListAll.AutoSize = true;
            this.fuelListAll.Location = new System.Drawing.Point(40, 38);
            this.fuelListAll.Name = "fuelListAll";
            this.fuelListAll.Size = new System.Drawing.Size(35, 13);
            this.fuelListAll.TabIndex = 2;
            this.fuelListAll.Text = "label3";
            // 
            // ListOfFuelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 200);
            this.Controls.Add(this.fuelListAll);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ListOfFuelForm";
            this.Text = "Список видов топлива";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListOfFuelForm_FormClosing);
            this.Load += new System.EventHandler(this.ListOfFuelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fuelListAll;
    }
}