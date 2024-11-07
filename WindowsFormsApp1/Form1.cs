//Learning Activity 1: Temperature Converter
//SODV2101 Rapid Application Development 24SEPMNFS1
//Submitted By: Nestle Juco
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_Input.Text = "0";
            lbl_Output.Text = "0";
            lbl_Output2.Text = "0";
            comboBox1.Items.AddRange(new string[] { "Select Convertion Type", "Celsius to Fahrenheit", "Fahrenheit to Celsius", "Celsius to Kelvin", "Kelvin to Celsius", "Fahrenheit to Kelvin", "Kelvin to Fahrenheit" });
            comboBox1.SelectedIndex = 0;
        }

        //Display Reset Button
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            lbl_Input.Text = "0";
            lbl_Output.Text = "0";
            lbl_Output2.Text = "0";
        }

        //Backspace Button
        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (lbl_Input.Text.Length > 1)
            {
                lbl_Input.Text = lbl_Input.Text.Substring(0, lbl_Input.Text.Length - 1);
            }
            else
            {
                lbl_Input.Text = "0";
            }
        }

        // Change the sign of the number
        private void btn_PlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lbl_Input.Text, out double currentValue))
            {
                currentValue *= -1;
                lbl_Input.Text = currentValue.ToString();
            }
        }

        //Number and Decimal Input
        private void btn_Numbers(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;

            if (lbl_Input.Text == "0" && tempButton.Text != ".") lbl_Input.Text = "";

            if (tempButton.Text != "." || !lbl_Input.Text.Contains("."))
            {
                lbl_Input.Text += tempButton.Text;
            }
        }

        //Temperature Conversion Selection
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertTemperature();
        }

        //Temperature Convertion Method
        private void ConvertTemperature()
        {
            if (double.TryParse(lbl_Input.Text, out double inputTemp))
            {
                double result = 0;
                double result2 = 0;
                string conversionType = comboBox1.SelectedItem.ToString();

                switch (conversionType)
                {
                    case "Select Convertion Type":
                        result = 0;
                        lbl_Output.Text = result.ToString();
                        break;
                    case "Celsius to Fahrenheit":
                        result = (inputTemp * 9 / 5) + 32;
                        lbl_Output.Text = result.ToString("F2") + " °F";
                        result2 = inputTemp + 273.15;
                        lbl_Output2.Text = result2.ToString("F2") + " K";
                        break;
                    case "Fahrenheit to Celsius":
                        result = (inputTemp - 32) * 5 / 9;
                        lbl_Output.Text = result.ToString("F2") + " °C";
                        result2 = (inputTemp - 32) * 5 / 9 + 273.15;
                        lbl_Output2.Text = result2.ToString("F2") + " K";
                        break;
                    case "Celsius to Kelvin":
                        result = inputTemp + 273.15;
                        lbl_Output.Text = result.ToString("F2") + " K";
                        result2 = (inputTemp * 9 / 5) + 32;
                        lbl_Output2.Text = result2.ToString("F2") + " °F";
                        break;
                    case "Kelvin to Celsius":
                        result = inputTemp - 273.15;
                        lbl_Output.Text = result.ToString("F2") + " °C";
                        result2 = (inputTemp - 273.15) * 9 / 5 + 32;
                        lbl_Output2.Text = result2.ToString("F2") + " °F";
                        break;
                    case "Fahrenheit to Kelvin":
                        result = (inputTemp - 32) * 5 / 9 + 273.15;
                        lbl_Output.Text = result.ToString("F2") + " K";
                        result2 = (inputTemp - 32) * 5 / 9;
                        lbl_Output2.Text = result2.ToString("F2") + " °C";
                        break;
                    case "Kelvin to Fahrenheit":
                        result = (inputTemp - 273.15) * 9 / 5 + 32;
                        lbl_Output.Text = result.ToString("F2") + " °F";
                        result2 = inputTemp - 273.15;
                        lbl_Output2.Text = result2.ToString("F2") + " °C";
                        break;
                }

            }
            else
            {
                lbl_Output.Text = "Invalid input";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Output_Click(object sender, EventArgs e)
        {

        }
    }
}
