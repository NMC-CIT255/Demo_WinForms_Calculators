using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms_Calculators_CrankRatios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateChainringComboBoxes();

            radBtn_Chainring1.Checked = true;

            //
            // hide chainring2 and chainring3 labels and combo boxes initially
            //
            lbl_Chainring2.Visible = false;
            cmbBox_Chainring2.Visible = false;
            lbl_Chainring3.Visible = false;
            cmbBox_Chainring3.Visible = false;
        }

        /// <summary>
        /// populate the three chainring combo boxes with sizes
        /// </summary>
        private void PopulateChainringComboBoxes()
        {
            const int MIN_CHAINRING_SIZE = 24;
            const int MAX_CHAINRING_SIZE = 54;

            IList<string> chainring1Sizes = new List<string>();
            IList<string> chainring2Sizes = new List<string>();
            IList<string> chainring3Sizes = new List<string>();

            for (int chainringSize = MIN_CHAINRING_SIZE; chainringSize <= MAX_CHAINRING_SIZE; chainringSize++)
            {
                chainring1Sizes.Add(chainringSize.ToString());
                chainring2Sizes.Add(chainringSize.ToString());
                chainring3Sizes.Add(chainringSize.ToString());
            }

            cmbBox_Chainring1.DataSource = chainring1Sizes;
            cmbBox_Chainring2.DataSource = chainring2Sizes;
            cmbBox_Chainring3.DataSource = chainring3Sizes;
        }

        private void radBtn_Chainring_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtn_Chainring3.Checked == true)
            {
                lbl_Chainring1.Visible = true;
                cmbBox_Chainring1.Visible = true;
                lbl_Chainring2.Visible = true;
                cmbBox_Chainring2.Visible = true;
                lbl_Chainring3.Visible = true;
                cmbBox_Chainring3.Visible = true;
            }
            else if (radBtn_Chainring2.Checked == true)
            {
                lbl_Chainring1.Visible = true;
                cmbBox_Chainring1.Visible = true;
                lbl_Chainring2.Visible = true;
                cmbBox_Chainring2.Visible = true;
                lbl_Chainring3.Visible = false;
                cmbBox_Chainring3.Visible = false;
            }
            else
            {
                lbl_Chainring1.Visible = true;
                cmbBox_Chainring1.Visible = true;
                lbl_Chainring2.Visible = false;
                cmbBox_Chainring2.Visible = false;
                lbl_Chainring3.Visible = false;
                cmbBox_Chainring3.Visible = false;
            }
        }
    }
}
