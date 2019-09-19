using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWithList
{
    public partial class CoffeeShop : Form
    {
        List<string> customerName = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<string> quantity = new List<string>();
        List<string> coffeCost = new List<string>();

        string cName = "";
        string cNo = "";
        string add = "";
        string ordr = "";
        string qty = "";
        double cost;
        int length;

        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            cName = customerNameTextBox.Text;
            cNo = contactNoTextBox.Text;
            add = addressTextBox.Text;
            ordr = orderComboBox.Text;
            qty = quantityTextBox.Text;
            length = cNo.Length;

            if (cName == "")
            {
                MessageBox.Show("Customer Field Required Customer Name.Please Fill this field.");
                customerNameTextBox.Clear();
            }
            else if (cNo == "")
            {
                MessageBox.Show("Contact Field Required Contact Number.Please Fill this field.");
                contactNoTextBox.Clear();
            }
            else if (add == "")
            {
                MessageBox.Show("Address Field Required Address.Please Fill this field.");
                addressTextBox.Clear();
            }
            else if (orderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, Select Order Item");
                orderComboBox.Text = "";
            }
            else if (qty == "")
            {
                MessageBox.Show("Quantity Field Required Quantity.Please Fill this field.");
                quantityTextBox.Clear();
            }
            else if (!CheckIfNumeric(qty))
            {
                MessageBox.Show("Quantity Field Required Numeric value.");
            }
            else
            {
                if (length == 11)
                {
                    if (customerName.Count > 0)
                    {
                        for (int i = 0; i < customerName.Count; i++)
                        {
                            if (cNo == contactNo[i])
                            {
                                MessageBox.Show("Already Used this Contact.Please Enter New Contact Number");
                                contactNoTextBox.Clear();
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("'11' Digits Mobile Number is Required.");
                    contactNoTextBox.Clear();
                    return;
                }
                

                AddToList();


                if (ordr == "Black-120")
                {
                    cost = Convert.ToInt32(qty) * 120;
                    Cost();
                }
                else if (ordr == "Cold-100")
                {
                    cost = Convert.ToInt32(qty) * 100;
                    Cost();
                }
                else if (ordr == "Hot-90")
                {
                    cost = Convert.ToInt32(qty) * 90;
                    Cost();
                }
                else if (ordr == "Regular-80")
                {
                    cost = Convert.ToInt32(qty) * 80;
                    Cost();
                }

                MessageBox.Show("Information Saved Successfully..");
                Clear();
            }
        }
        private void AddToList()
        {
            customerName.Add(cName);
            contactNo.Add(cNo);
            address.Add(add);
            order.Add(ordr);
            quantity.Add(qty);
        }

        private void Cost()
        {
            coffeCost.Add(cost.ToString());
        }

        private bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }
        private void Clear()
        {
            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = "";
            quantityTextBox.Clear();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            Show();
        }
        private new void Show()
        {
            string result = "";
            for (int i = 0; i < customerName.Count; i++)
            {
                result += "Custome Name:   " + customerName[i] + "\nContact Number:   " + contactNo[i]
                          + "\nAddress:   " + address[i] + "\nOrder:   " + order[i] + "\nQuantity:   "
                          + quantity[i] + "\nUnit Price:   " + Convert.ToInt32(coffeCost[i]) / Convert.ToInt32(qty) + "" +
                          "\nTotal Price:   " + coffeCost[i] + "\n\n";
            }
            showRichTextBox.Text = result;
        }
    }
    public static class StringExtensions
    {
        public static bool IsNumeric(this string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
    }
}
