using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planer_Przyjec
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                                          fancyDecorations.Checked,
                                          healthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDecorations.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyOption.Checked;
            DisplayDinnerPartyCost();
        }

        /// <summary>
        /// Wyświetlamy całkowity koszt
        /// </summary>
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            totalCost.Text = Cost.ToString("c"); // ToString("c") powoduje wyświetlanie kwoty w walucie kraju w którym jesteśmy
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
    }
}
