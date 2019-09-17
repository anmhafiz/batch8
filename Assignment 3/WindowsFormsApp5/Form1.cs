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
    //public class User
    //{
    //    public string Name { get; set; }
    //    public string ContactNo { get; set; }
    //    public string Address { get; set; }
    //}
    public partial class coffeShop : Form
    {
        private int ItemNo { get; set; }
        private string[] NameList { get; set; }
        private string[] ContactNoList { get; set; }
        private string[] AddressList { get; set; }
        private string[] ItemList { get; set; }
        private int[] QuantityList { get; set; }
        private double[] PriceList { get; set; }

        public coffeShop()
        {
            InitializeComponent();
            NameList = new string[20];
            ContactNoList = new string[20];
            AddressList = new string[20];
            ItemList = new string[20];
            QuantityList = new int[20];
            PriceList = new double[20];
            ItemNo = 0;
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
               

                NameList[ItemNo] = textBoxName.Text;
                ContactNoList[ItemNo] = textBoxContract.Text;
                AddressList[ItemNo] = textBoxAddress.Text;
                ItemList[ItemNo] = item;
                PriceList[ItemNo] = price;

                ItemNo = ItemNo + 1;

                string output = "";
                for (int i = 0; i < ItemNo; i++)
                {
                    output += "Name :" + NameList[i] + "\n" + "Contact No: " + ContactNoList[i] + "\n" +
                                           "Address :" + AddressList[i] + "\n" + "Item : " + ItemList[i] + "\n" + "Price :" + PriceList[i] + "\n\n\n";;
                }
       
               richTextBoxShow.Text = output;


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
