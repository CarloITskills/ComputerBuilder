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
    public partial class InvoiceForm : Form
    {

        double total;
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            total = OrderForm.finalPrice;

            double priceWithVat =OrderForm.finalPrice * 1.2; //Calculates price with VAT
            totalLabel.Text = "£" + priceWithVat;
            objectPriceLabel.Text = "£" + OrderForm.finalPrice;
            vatLabel.Text = "£" + (OrderForm.finalPrice * 0.2);
            depositLabel.Text = "£" + (priceWithVat * 0.1);
            totalUnitsPriceLabel.Text = "£" + OrderForm.finalPrice;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double quantity, quantityWithPrice, vat;


            if (!double.TryParse(unitsTextBox.Text, out quantity))
            {
                MessageBox.Show("Please only enter numbers");
            }
            quantityWithPrice = OrderForm.finalPrice * quantity;
            vat = quantityWithPrice * 0.2;
            vatLabel.Text = "£" + vat;
            total = vat + quantityWithPrice;
            totalUnitsPriceLabel.Text = "£" + quantityWithPrice;
            totalLabel.Text = "£" + total;
            depositLabel.Text = "£" + (total * 0.1);
            lefttopay.Text="£"+(total-total*0.1);
        }

        private void BackToOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form OrderForm = new OrderForm();
            OrderForm.Show();
        }

        private void lefttopay_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
