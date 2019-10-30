namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TemperatureUp = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.TemDeg = new System.Windows.Forms.TextBox();
            this.Degrees = new System.Windows.Forms.TextBox();
            this.Degrees2 = new System.Windows.Forms.TextBox();
            this.TemHour = new System.Windows.Forms.TextBox();
            this.Percent = new System.Windows.Forms.Label();
            this.PerText1 = new System.Windows.Forms.TextBox();
            this.HourPerText = new System.Windows.Forms.TextBox();
            this.Percent1 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(600, 441);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(160, 80);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start \r\nGrowing";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartButton.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tomato",
            "Cucumber",
            "Add my plan"});
            this.comboBox1.Location = new System.Drawing.Point(305, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(58, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(674, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Select culture";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TemperatureUp
            // 
            this.TemperatureUp.AutoSize = true;
            this.TemperatureUp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TemperatureUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemperatureUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TemperatureUp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureUp.Location = new System.Drawing.Point(39, 151);
            this.TemperatureUp.Name = "TemperatureUp";
            this.TemperatureUp.Size = new System.Drawing.Size(160, 20);
            this.TemperatureUp.TabIndex = 3;
            this.TemperatureUp.Text = "Temperature Set\r\n";
            this.TemperatureUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Humidity
            // 
            this.Humidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Humidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Humidity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Humidity.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Humidity.Location = new System.Drawing.Point(594, 151);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(130, 20);
            this.Humidity.TabIndex = 9;
            this.Humidity.Text = "Humidity Set";
            this.Humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemDeg
            // 
            this.TemDeg.Location = new System.Drawing.Point(39, 213);
            this.TemDeg.Multiline = true;
            this.TemDeg.Name = "TemDeg";
            this.TemDeg.Size = new System.Drawing.Size(110, 22);
            this.TemDeg.TabIndex = 10;
            this.TemDeg.TextChanged += new System.EventHandler(this.TemDeg_TextChanged);
            // 
            // Degrees
            // 
            this.Degrees.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Degrees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Degrees.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degrees.Location = new System.Drawing.Point(155, 213);
            this.Degrees.Multiline = true;
            this.Degrees.Name = "Degrees";
            this.Degrees.Size = new System.Drawing.Size(86, 83);
            this.Degrees.TabIndex = 11;
            this.Degrees.Text = "Degrees\r\n\r\n\r\nHour(s)";
            this.Degrees.TextChanged += new System.EventHandler(this.Degrees_TextChanged);
            // 
            // Degrees2
            // 
            this.Degrees2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Degrees2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Degrees2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degrees2.Location = new System.Drawing.Point(39, 241);
            this.Degrees2.Name = "Degrees2";
            this.Degrees2.Size = new System.Drawing.Size(110, 16);
            this.Degrees2.TabIndex = 12;
            this.Degrees2.Text = "for";
            this.Degrees2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Degrees2.TextChanged += new System.EventHandler(this.Degrees2_TextChanged);
            // 
            // TemHour
            // 
            this.TemHour.Location = new System.Drawing.Point(39, 276);
            this.TemHour.Name = "TemHour";
            this.TemHour.Size = new System.Drawing.Size(110, 20);
            this.TemHour.TabIndex = 13;
            this.TemHour.TextChanged += new System.EventHandler(this.TemHour_TextChanged);
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Percent.Location = new System.Drawing.Point(488, 213);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(71, 119);
            this.Percent.TabIndex = 14;
            this.Percent.Text = "Percent\r\n\r\n\r\nHour(s)\r\n\r\n\r\n\r\n";
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // PerText1
            // 
            this.PerText1.Location = new System.Drawing.Point(585, 213);
            this.PerText1.Name = "PerText1";
            this.PerText1.Size = new System.Drawing.Size(100, 20);
            this.PerText1.TabIndex = 16;
            this.PerText1.TextChanged += new System.EventHandler(this.PerText1_TextChanged);
            // 
            // HourPerText
            // 
            this.HourPerText.Location = new System.Drawing.Point(585, 276);
            this.HourPerText.Name = "HourPerText";
            this.HourPerText.Size = new System.Drawing.Size(100, 20);
            this.HourPerText.TabIndex = 17;
            this.HourPerText.TextChanged += new System.EventHandler(this.HourPerText_TextChanged);
            // 
            // Percent1
            // 
            this.Percent1.AutoSize = true;
            this.Percent1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Percent1.Location = new System.Drawing.Point(594, 241);
            this.Percent1.Name = "Percent1";
            this.Percent1.Size = new System.Drawing.Size(35, 17);
            this.Percent1.TabIndex = 18;
            this.Percent1.Text = "for";
            this.Percent1.Click += new System.EventHandler(this.Percent1_Click);
            // 
            // Show
            // 
            this.Show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Show.AutoSize = true;
            this.Show.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show.Location = new System.Drawing.Point(332, 129);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(110, 38);
            this.Show.TabIndex = 6;
            this.Show.Text = "Show \r\nGreenhouse";
            this.Show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Show.Click += new System.EventHandler(this.Show_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Percent1);
            this.Controls.Add(this.HourPerText);
            this.Controls.Add(this.PerText1);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.TemHour);
            this.Controls.Add(this.Degrees2);
            this.Controls.Add(this.Degrees);
            this.Controls.Add(this.TemDeg);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.TemperatureUp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Greenhouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TemperatureUp;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.TextBox TemDeg;
        private System.Windows.Forms.TextBox Degrees;
        private System.Windows.Forms.TextBox Degrees2;
        private System.Windows.Forms.TextBox TemHour;
        private System.Windows.Forms.Label Percent;
        private System.Windows.Forms.TextBox PerText1;
        private System.Windows.Forms.TextBox HourPerText;
        private System.Windows.Forms.Label Percent1;
        private System.Windows.Forms.Label Show;
    }
}

