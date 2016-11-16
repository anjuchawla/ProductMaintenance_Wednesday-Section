/*
 * Name: Anju Chawla
 * Date: November 2016
 * Purpose: This form displays the products in inventory and allows the user to add new products
 * and delete existing products
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmProductMain : Form
	{
        //to store the products in the inventory
        private List<Product> products = null;
		public frmProductMain()
		{
			InitializeComponent();
		}

	

		private void frmProductMain_Load(object sender, EventArgs e)
		{
            //populate the list with products 
            products = ProductDB.GetProducts();
            FillProductListBox();			
		}

        private void FillProductListBox()
        {
            //populates the list box with the products
            lstProducts.Items.Clear();
            foreach(Product p in products)
            {
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
		{
            //the form to add new product is displayed
            frmNewProduct newProductForm = new frmNewProduct();
            newProductForm.Show(); 
          /* Product product = newProductForm.GetNewProduct();

            if(product != null)
            {
                products.Add(product);
                ProductDB.SaveProducts(products);
                FillProductListBox();
            }
            */
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            //delete a product
            int i = lstProducts.SelectedIndex;

            if(i != -1) //user has selected item to delete
            {
                Product product = products[i];
                string message = "Are you sure you want to delete the product";

                DialogResult confirm = MessageBox.Show(message, "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if(confirm == DialogResult.Yes )
                {
                    products.Remove(product);
                    ProductDB.SaveProducts(products);
                    FillProductListBox();
                }



            }
            else
            {
                MessageBox.Show("Please select a product to delete", 
                    "Delete Unsuccessful", MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation);
            }

			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            //close the form
			this.Close();
		}
	}
}