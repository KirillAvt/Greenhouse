namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sensorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humidifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fertilizerDispenserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesToolStripMenuItem,
            this.sensorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sensorsToolStripMenuItem
            // 
            this.sensorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temToolStripMenuItem,
            this.humidityToolStripMenuItem,
            this.acidityToolStripMenuItem});
            this.sensorsToolStripMenuItem.Name = "sensorsToolStripMenuItem";
            this.sensorsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sensorsToolStripMenuItem.Text = "Sensors";
            // 
            // temToolStripMenuItem
            // 
            this.temToolStripMenuItem.Name = "temToolStripMenuItem";
            this.temToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temToolStripMenuItem.Text = "Temperature";
            this.temToolStripMenuItem.Click += new System.EventHandler(this.temToolStripMenuItem_Click);
            // 
            // humidityToolStripMenuItem
            // 
            this.humidityToolStripMenuItem.Name = "humidityToolStripMenuItem";
            this.humidityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.humidityToolStripMenuItem.Text = "Humidity";
            // 
            // acidityToolStripMenuItem
            // 
            this.acidityToolStripMenuItem.Name = "acidityToolStripMenuItem";
            this.acidityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acidityToolStripMenuItem.Text = "Acidity(pH)";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humidifierToolStripMenuItem,
            this.fertilizerDispenserToolStripMenuItem,
            this.lightingToolStripMenuItem,
            this.temperatureToolStripMenuItem});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.devicesToolStripMenuItem.Text = "Devices";
            // 
            // humidifierToolStripMenuItem
            // 
            this.humidifierToolStripMenuItem.Name = "humidifierToolStripMenuItem";
            this.humidifierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.humidifierToolStripMenuItem.Text = "Humidifier";
            // 
            // fertilizerDispenserToolStripMenuItem
            // 
            this.fertilizerDispenserToolStripMenuItem.Name = "fertilizerDispenserToolStripMenuItem";
            this.fertilizerDispenserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fertilizerDispenserToolStripMenuItem.Text = "Fertilizer dispenser";
            // 
            // lightingToolStripMenuItem
            // 
            this.lightingToolStripMenuItem.Name = "lightingToolStripMenuItem";
            this.lightingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightingToolStripMenuItem.Text = "Lighting";
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heaterToolStripMenuItem,
            this.conditionToolStripMenuItem});
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // heaterToolStripMenuItem
            // 
            this.heaterToolStripMenuItem.Name = "heaterToolStripMenuItem";
            this.heaterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.heaterToolStripMenuItem.Text = "Heater";
            // 
            // conditionToolStripMenuItem
            // 
            this.conditionToolStripMenuItem.Name = "conditionToolStripMenuItem";
            this.conditionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conditionToolStripMenuItem.Text = "Condition";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 451);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "ShowGreenhouse";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sensorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humidityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acidityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humidifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fertilizerDispenserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionToolStripMenuItem;
    }
}