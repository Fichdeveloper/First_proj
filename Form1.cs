using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win_Calc
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((rezult.Text == "0") ||( operation_pressed))
            {
                rezult.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            rezult.Text = rezult.Text + b.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rezult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(rezult.Text);
            operation_pressed = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    rezult.Text = (value + Double.Parse(rezult.Text)).ToString();
                    break;
                case "-":
                    rezult.Text = (value - Double.Parse(rezult.Text)).ToString();
                    break;
                case "*":
                    rezult.Text = (value * Double.Parse(rezult.Text)).ToString();
                    break;
                case "/":
                    rezult.Text = (value / Double.Parse(rezult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rezult.Clear();
            value = 0;
        }
    }
}
