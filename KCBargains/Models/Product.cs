using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KCBargains.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Quantity { get; set; }
        public double Cost { get; set; }
        public string Picture { get; set; }
        public int CategoryId { get; set; }
        public int RetailerId { get; set; }
        public int UserId { get; set; }
        public Retailer ProductRetailer { get; set; }
        public ProductCategory Category { get; set; }

        public Product(){}

        public Product(string name, string description, string quantity, double cost) 
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Cost = cost;
        }


    }
}
