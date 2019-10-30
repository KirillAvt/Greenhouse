using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }



    private void label1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                MessageBox.Show("ТЕПЛИИИИИИИЧЕЧКА");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("                        Пздц \nНу ты и овощ, выбери уже какой-нибудь план");
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TemperatureUp_Click(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TemDeg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Degrees_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click_1(object sender, EventArgs e)
        {
            Form2 ShowGreenhouse = new WindowsFormsApplication2.Form2();
            ShowGreenhouse.Show();
        }

        private void TemHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Percent_Click(object sender, EventArgs e)
        {

        }

        private void PerHour_Click(object sender, EventArgs e)
        {

        }

        private void PerText1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HourPerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Degrees2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Percent1_Click(object sender, EventArgs e)
        {

        }
    }


    }
