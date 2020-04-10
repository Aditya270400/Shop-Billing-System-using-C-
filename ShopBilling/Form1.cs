using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBilling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb.SelectedItem.ToString()=="Grocery Item 1")
            {
                pricebox.Text = "100";
            }
            else if (cb.SelectedItem.ToString() == "Grocery Item 2")
            {
                pricebox.Text = "200";
            }
            else if (cb.SelectedItem.ToString() == "Grocery Item 3")
            {
                pricebox.Text = "300";
            }
            else if (cb.SelectedItem.ToString() == "Utensil Item 1")
            {
                pricebox.Text = "100";
            }
            else if (cb.SelectedItem.ToString() == "Utensil Item 2")
            {
                pricebox.Text = "200";
            }
            else if (cb.SelectedItem.ToString() == "Utensil Item 3")
            {
                pricebox.Text = "300";
            }
            else if (cb.SelectedItem.ToString() == "Snack Item 1")
            {
                pricebox.Text = "100";
            }
            else if (cb.SelectedItem.ToString() == "Snack Item 2")
            {
                pricebox.Text = "200";
            }
            else if (cb.SelectedItem.ToString() == "Snack Item 3")
            {
                pricebox.Text = "300";
            }
            else
            {
                pricebox.Text = "";
            }

            totalBox.Text = "";
            quantityBox.Text = "";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.ForeColor = Color.Green;
            RadioButton2.ForeColor = Color.Red;
            RadioButton3.ForeColor = Color.Red;

            cb.Items.Clear();
            cb.Items.Add("Grocery Item 1");
            cb.Items.Add("Grocery Item 2");
            cb.Items.Add("Grocery Item 3");

           
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.ForeColor = Color.Red;
            RadioButton2.ForeColor = Color.Green;
            RadioButton3.ForeColor = Color.Red;
            cb.Items.Clear();
            cb.Items.Add("Utensil Item 1");
            cb.Items.Add("Utensil Item 2");
            cb.Items.Add("Utensil Item 3");
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton1.ForeColor = Color.Red;
            RadioButton2.ForeColor = Color.Red;
            RadioButton3.ForeColor = Color.Green;
            cb.Items.Clear();
            cb.Items.Add("Snack Item 1");
            cb.Items.Add("Snack Item 2");
            cb.Items.Add("Snack Item 3");
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (quantityBox.Text.Length > 0)
            {
                totalBox.Text = (Convert.ToInt16(pricebox.Text) * Convert.ToInt16(quantityBox.Text)).ToString();
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Item_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cb.SelectedItem.ToString();
            arr[1]= pricebox.Text;
            arr[2]= quantityBox.Text;
            arr[3] = totalBox.Text;
            ListViewItem lv = new ListViewItem(arr);
            list_View.Items.Add(lv);
            subTotal.Text = (Convert.ToInt16(subTotal.Text) + Convert.ToInt16(totalBox.Text)).ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (list_View.SelectedItems.Count > 0)
            {
                for (int i = 0; i < list_View.Items.Count; i++)
                {
                    if (list_View.Items[i].Selected)
                    { 
                        subTotal.Text = (Convert.ToInt16(subTotal.Text) - Convert.ToInt16(list_View.Items[i].SubItems[3].Text)).ToString();
                        list_View.Items[i].Remove();
                    }
                }
            }
        }

        private void List_View_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (discountBox.Text.Length > 0)
            {
                netBalance.Text = (Convert.ToInt16(subTotal.Text) - Convert.ToInt16(discountBox.Text)).ToString();
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (discountBox.Text.Length > 0)
            {
                remainBalance.Text = (Convert.ToInt16(netBalance.Text) - Convert.ToInt16(paidBox.Text)).ToString();
            }

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            cb.Items.Clear();
            pricebox.Clear();
            quantityBox.Clear();
            totalBox.Clear();
            subTotal.Text = "0";
            discountBox.Clear();
            netBalance.Clear();
            paidBox.Clear();
            remainBalance.Clear();
            list_View.Clear();
        }
    }
}
