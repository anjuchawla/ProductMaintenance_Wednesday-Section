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
    public partial class frmNewProduct : Form
	{
        private Product product = null;
		public frmNewProduct()
		{
			InitializeComponent();
		}

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        private void btnSave_Click(object sender, EventArgs e)
		{
            //checks that code, description and price have been provided
            //validates that price is a valid decimal number

            if(IsValidData())
            {
                product = new ProductMaintenance.Product(txtCode.Text,
                    txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }

			
		}

        private bool IsValidData()
        {
            return Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice) &&
                Validator.IsWithinRange(txtPrice, 0, 100);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
		{
            //close the current form
			this.Close();
		}

       
    }
}