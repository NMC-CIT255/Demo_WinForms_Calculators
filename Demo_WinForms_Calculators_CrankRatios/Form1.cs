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
            //
            // populate combo box items
            //
            PopulateChainringComboBoxes();
            PopulateNumberOfSprocketsComboBox();
            PopulateSprocketComboBoxes();

            radBtn_Chainring1.Checked = true;

            //
            // hide chainring2 and chainring3 labels and combo boxes initially
            //
            lbl_Chainring2.Visible = false;
            cmbBox_Chainring2.Visible = false;
            lbl_Chainring3.Visible = false;
            cmbBox_Chainring3.Visible = false;

            //
            // hide sprockets 2-12 labels and combo boxes initially
            //
            for (int i = 2; i <= 12; i++)
            {
                Control[] comboBoxes = Controls.Find("cmbBox_Sprocket" + i, true);
                comboBoxes[0].Visible = false;

                Control[] labels = Controls.Find("lbl_Sprocket" + i, true);
                labels[0].Visible = false;
            }
        }

        /// <summary>
        /// add items to the Number of Sprockets combo box
        /// </summary>
        private void PopulateNumberOfSprocketsComboBox()
        {
            const int MIN_NUMBER_OF_SPROCKETS = 1;
            const int MAX_NUMBER_OF_SPROCKETS = 12;

            IList<string> numberOfSprokects = new List<string>();

            for (int sprocket = MIN_NUMBER_OF_SPROCKETS; sprocket <= MAX_NUMBER_OF_SPROCKETS; sprocket++)
            {
                numberOfSprokects.Add(sprocket.ToString());
            }

            cmbBox_NumberOfSprockets.DataSource = numberOfSprokects;
        }

        /// <summary>
        /// add items to the three chainring combo boxes
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


        /// <summary>
        /// add items to the sprocket combo boxes
        /// </summary>
        private void PopulateSprocketComboBoxes()
        {
            const int MIN_SPROCKET_SIZE = 11;
            const int MAX_SPROCKET_SIZE = 38;
            const int MAX_NUMBER_OF_SPROCKETS = 12;

            for (int i = 1; i < MAX_NUMBER_OF_SPROCKETS; i++)
            {
                Control[] comboBoxes = Controls.Find("cmbBox_Sprocket" + i, true);
                ComboBox comboBox = comboBoxes[0] as ComboBox;

                for (int sprocketSize = MIN_SPROCKET_SIZE; sprocketSize < MAX_SPROCKET_SIZE; sprocketSize++)
                {
                    comboBox.Items.Add(sprocketSize.ToString());
                }
            }

        }

        /// <summary>
        /// show the correct number of chainring combo boxes based on radio button selected
        /// </summary>
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

        /// <summary>
        /// show the correct number of sprocket size combo boxes
        /// </summary>
        private void cmbBox_NumberOfSprockets_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberOfSprockets = int.Parse(cmbBox_NumberOfSprockets.Text);

            //
            // hide sprockets 2-12 labels and combo boxes initially
            //
            for (int i = 2; i <= 12; i++)
            {
                Control[] comboBoxes = Controls.Find("cmbBox_Sprocket" + i, true);
                comboBoxes[0].Visible = false;

                Control[] labels = Controls.Find("lbl_Sprocket" + i, true);
                labels[0].Visible = false;
            }

            //
            // show sprocket size combo box for each sprocket
            //
            for (int i = 2; i <= numberOfSprockets; i++)
            {
                Control[] comboBoxes = Controls.Find("cmbBox_Sprocket" + i, true);
                comboBoxes[0].Visible = true;

                Control[] labels = Controls.Find("lbl_Sprocket" + i, true);
                labels[0].Visible = true;
            }
        }
    }
}
