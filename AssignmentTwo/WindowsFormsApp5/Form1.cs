using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class coffeShop : Form
    {
        public coffeShop()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            {
                string item = comboBoxItem.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                double price = 0;


                if (item == "Math")
                {
                    price = 120 * quantity;
                }
                else if (item == "English")
                {
                    price = 100 * quantity;
                }
                else if (item == "Bangla")
                {
                    price = 80 * quantity;
                }
                else if (item == "Art")
                {
                    price = 90 * quantity;
                }


                else
                {
                    MessageBox.Show("Select an item");
                }

                richTextBoxShow.Text = "Name :" + textBoxName.Text + "\n" + "Contact No: " + textBoxContract.Text + "\n" +
                                       "Address :" + textBoxAddress.Text + "\n" + "Item : " + item + "\n" + "Price :" + price;




            }
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coffeShop_Load(object sender, EventArgs e)
        {

        }
    }
}
