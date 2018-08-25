using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms_Calculators
{
    public partial class Frm_CalcA : Form
    {
        public Frm_CalcA()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Cars.Text = null;
            txtBox_ClownsPerCar.Text = null;
            txtBox_TotalClowns.Text = null;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (ConvertTextToInt(txtBox_Cars.Text, out int numberOfCars) &&
                ConvertTextToInt(txtBox_ClownsPerCar.Text, out int numberOfClownsPerCar))
            {
                txtBox_TotalClowns.Text = (numberOfCars * numberOfClownsPerCar).ToString();
            }
            else
            {
                MessageBox.Show("The Number of Cars and Clowns per Car fields must contain integers.");
            }            
        }

        private bool ConvertTextToInt(string textBoxValueString, out int textBoxValueInt)
        {
            return int.TryParse(textBoxValueString, out textBoxValueInt);
        }
    }
}
