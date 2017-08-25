using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV2_CalculoDeDano
{
    
    public partial class Form1 : Form
    {
        int valorATK;
        int valorDEF;
        float MultiplierATK;
        float MultiplierDEF;
        float totalDMG;
        string elementoATK;
        string elementoDEF;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            elementoATK = comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(elementoATK == "Fire" && elementoDEF == "Ice")
            {
                MultiplierATK = 2f; MultiplierDEF = 1f;
            }

            if (elementoATK == "Ice" && elementoDEF == "Fire")
            {
                MultiplierDEF = 2f; MultiplierATK = 1f;
            }

            if (elementoATK == "Fire" && elementoDEF == "Electricity")
            {
                MultiplierDEF = 2f; MultiplierATK = 1f;
            }

            if (elementoATK == "Electricity" && elementoDEF == "Fire")
            {
                MultiplierATK = 2f; MultiplierDEF = 1f;
            }

            if (elementoATK == "Ice" && elementoDEF == "Electricity")
            {
                MultiplierATK = 2f; MultiplierDEF = 1f;
            }

            if (elementoATK == "Electricity" && elementoDEF == "Ice")
            {
                MultiplierDEF = 2f; MultiplierATK = 1f;
            }

            if (elementoATK == elementoDEF)
            {
                MultiplierATK = 1f; MultiplierDEF = 1f;
            }

            totalDMG =  (valorATK * MultiplierATK) - (valorDEF * MultiplierDEF);

            if(totalDMG > 0)
            {
                label1.Text = totalDMG.ToString();
            }
            else if (totalDMG < 0)
            {
                label1.Text = "0";
            }
              
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            valorDEF = (int)numericUpDown2.Value;

            if(numericUpDown2.Value > 100)
            {
                numericUpDown2.Value = 100;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            valorATK = (int)numericUpDown1.Value;

            if (numericUpDown1.Value > 100)
            {
                numericUpDown1.Value = 100;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            elementoDEF = comboBox1.Text;
        }
    }
}
