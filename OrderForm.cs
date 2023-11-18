using My_website.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_website
{
    public partial class OrderForm : Form
    {
        Dictionary<string, int> prices = new Dictionary<string, int>()
        {
            {"Desktop",35},
            {"Tower",30},
            {"Gaming",110},
            {"Intel",550},
            {"AMD",440},
            {"4 Gigabyte",4},
            {"8 Gigabyte",8},
            {"16 Gigabyte",16},
            {"1 Terabyte",33},
            {"2 Terabyte",45},
            {"4 Terabyte",75},
            {"256 Gigabyte",35},
            {"512 Gigabyte",60},
            {"400 Watts",40},
            {"600 Watts",55},
            {"850 Watts",80}
        };
        static public int finalPrice = 0;
        Dictionary<string, string> groupBoxCurrentSelection = new Dictionary<string, string>()
        {
            {"caseGroupBox","" },
            {"processorGroupBox","" },
            {"ramGroupBox","" },
            {"hddGroupBox","" },
            {"ssdGroupBox","" },
            {"psuGroupBox","" }
        };

        public OrderForm()
        {
            InitializeComponent();
        }

        private void desktopRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Desktop", desktopRadioButton);
            casePictureBox.Image = Resources.Desktop;
            casePriceLabel.Text = "£" + prices["Desktop"];
        }

        private void towerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Tower", towerRadioButton);
            casePictureBox.Image = Resources.Tower;
            casePriceLabel.Text = "£" + prices["Tower"];
        }

        private void gamingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Gaming", gamingRadioButton);
            casePictureBox.Image = Resources.Gaming;
            casePriceLabel.Text = "£" + prices["Gaming"];
        }

        private void intelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("Intel", intelRadioButton);
            processorPictureBox.Image = Resources.Intel;
            processorPriceLabel.Text = "£" + prices["Intel"];
        }

        private void amdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("AMD", amdRadioButton);
            processorPictureBox.Image = Resources.AMD;
            processorPriceLabel.Text = "£" + prices["AMD"];
        }

        private void _4GBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("4 Gigabyte", _4GBRadioButton);
            ramPictureBox.Image = Resources._4GB;
            ramPriceLabel.Text = "£" + prices["4 Gigabyte"];
        }

        private void _8GBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("8 Gigabyte", _8GBRadioButton);
            ramPictureBox.Image = Resources._8GB;
            ramPriceLabel.Text = "£" + prices["8 Gigabyte"];
        }

        private void _16GBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("16 Gigabyte", _16GBRadioButton);
            ramPictureBox.Image = Resources._16GB;
            ramPriceLabel.Text = "£" + prices["16 Gigabyte"];
        }

        private void _1TBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("1 Terabyte", _1TBRadioButton);
            hddPictureBox.Image = Resources._1TB;
            hddPriceLabel.Text = "£" + prices["1 Terabyte"];
        }

        private void _2TBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("2 Terabyte", _2TBRadioButton);
            hddPictureBox.Image = Resources._2TB;
            hddPriceLabel.Text = "£" + prices["2 Terabyte"];
        }

        private void _4TBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("4 Terabyte", _4TBRadioButton);
            hddPictureBox.Image = Resources._4TB;
            hddPriceLabel.Text = "£" + prices["4 Terabyte"];
        }


        private void _512GBRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("512 Gigabyte", _512GBRadioButton);
            ssdPictureBox.Image = Resources._512GB;
            ssdPriceLabel.Text = "£" + prices["512 Gigabyte"];
        }

        private void _400WRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("400 Watts", _400WRadioButton);
            psuPictureBox.Image = Resources._400W;
            psuPriceLabel.Text = "£" + prices["400 Watts"];
        }

        private void _600WRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("600 Watts", _600WRadioButton);
            psuPictureBox.Image = Resources._600W;
            psuPriceLabel.Text = "£" + prices["600 Watts"];
        }

        private void _850WRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice("850 Watts", _850WRadioButton);
            psuPictureBox.Image = Resources._850W;
            psuPriceLabel.Text = "£" + prices["850 Watts"];
        }
        void updatePrice(string name, RadioButton button)
        {
            GroupBox groupBox = button.Parent as GroupBox;
            string groupName = groupBox.Name;
            string currentSelection = groupBoxCurrentSelection[groupName];

            if (button.Checked)
            {
                if (currentSelection != name)
                {
                    finalPrice += prices[$"{name}"];
                }
                groupBoxCurrentSelection[groupName] = name;
            }
            else
            {
                if (currentSelection == name)
                {
                    finalPrice -= prices[$"{name}"];
                }
                groupBoxCurrentSelection[groupName] = "";
            }

            totalPriceLabel.Text = "Final Price: £" + finalPrice.ToString();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void _256GBRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            updatePrice("256 Gigabyte", _256GBRadioButton);
            ssdPictureBox.Image = Resources._256GB;
            ssdPriceLabel.Text = "£" + prices["256 Gigabyte"];
        
    }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void ssdPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }   
}
