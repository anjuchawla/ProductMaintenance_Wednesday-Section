/*
 * Name:  Anju Chawla
 * Date: Nov, 2016
 * Purpose: To defin the Product entity that will be used in the maintenance
 * of products in the inventory
 * */
using System;

namespace ProductMaintenance
{
    public class Product
    {
        //fields - instance variables
        private string code;
        //private string description;
        private decimal price;

        //constructors
        public Product()
        {

        }

        public Product(string code, string description, decimal price)
        {
            this.Code = code;  //using the set
            this.Description = description;
            this.Price = price;


        }
        //properties of fields - getters and setters

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value.Length != 4)
                {
                    throw new ArgumentException("Length of product code should be 4 characters");
                }
                this.code = value;
            }
        }
        //property defined thus will automatically create a private description instance variable
        //Expression bodied property
        public string Description { get; set;}
      /*
        public string Description
        {
            get
            {
                return description ;
            }
            set
            {
                description = value;
            }

        }*/

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price of product cannot be less than 0");
                }
                price = value;
            }
        }


        //return the product information
        public string GetDisplayText()
        {
            // string c = Code; //using the get
            return Code + ", " + Description + ", " + Price.ToString("c");
        }

        //overloaded method - coded as expression bodied method using the lambda operator
        public string GetDisplayText(string sep) => Code + sep + Description + sep + Price.ToString("c");







    }
}
