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
       String[] NameList = new string[20];
           string[] ContactNoList = new string[20];
           string[] AddressList = new string[20];
            string[] ItemList = new string[20];
          string[]  QuantityList = new string[20];
        

        int  ItemNo = 0;


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


                if (item == "Black")
                {
                    price = 120 * quantity;
                }
                else if (item == "Cold")
                {
                    price = 100 * quantity;
                }
                else if (item == "Hot")
                {
                    price = 80 * quantity;
                }
                else if (item == "Regular")
                {
                    price = 90 * quantity;
                }
               

                

                string output = "";
                for (int i = 0; i < ItemNo; i++)
                {
                    output += "Name :" + NameList[i] + "\n" + "Contact No: " + ContactNoList[i] + "\n" +
                                           "Address :" + AddressList[i] + "\n" + "Item : " + ItemList[i] + "\n"  + "\n\n\n";;
                }
       
               richTextBoxShow.Text = output;


            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string item = comboBoxItem.Text;
            NameList[ItemNo] = textBoxName.Text;
            ContactNoList[ItemNo] = textBoxContract.Text;
            AddressList[ItemNo] = textBoxAddress.Text;
            ItemList[ItemNo] = item;


            ItemNo = ItemNo + 1;
        }
    }
}
