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
            lstProducts.Items.Clear();
            foreach(Product p in products)
            {
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
		{
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            //close the form
			this.Close();
		}
	}
}