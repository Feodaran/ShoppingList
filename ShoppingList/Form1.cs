using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class FormShoppingList : Form
    {
        string itemName;
        double itemPrice;
        int quantity;
        double totalPrice;

        public FormShoppingList()
        {
            InitializeComponent();

         //   txtPrice.Text(Convert.ToDouble());
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            txtItem.Focus();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {


            // Add contents of the textboxes and total price to shopping list
            txtShoppingList.AppendText(txtItem.Text + txtPrice.Text + txtQuantity + lblTotalPrice.Text);

            //Clear textboxes and move cursor back to Item textbox.
            txtItem.Clear();
            txtItem.Focus();
            txtPrice.Clear();
            txtQuantity.Clear();
            lblTotalPrice.Text = "[total price]";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear items and total price label
            txtShoppingList.Clear();
            txtItem.Clear();
            txtItem.Focus();
            txtPrice.Clear();
            txtQuantity.Clear();
            lblTotalPrice.Text = "[total price]";

            
        }

        public void _totalPrice()
        {
           // lblTotalPrice.Text = txtPrice + txtQuantity;
        }




        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Numerical values and decimals only, no text
        }

        private void txtShoppingList_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // This closes the application when Done is pressed.
            Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Numerical values only. No text or decimals

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
        }
    }
}
