using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OrdSYS.Models.Product
{
    public class ProductModel
    {
        // Fields
        private int _id;
        private string _name;
        private string _description;
        private decimal _price;
        private int _stock;
        private char _status;

        // Properties - Validations
        [DisplayName("Product ID")]
        [Required(ErrorMessage = "Product ID is required")]
        public int Id { get => _id; set => _id = value; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product Name is required")]
        public string Name { get => _name; set => _name = value; }
        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Product Description is required")]
        public string Description { get => _description; set => _description = value; }
        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product Price is required")]
        public decimal Price { get => _price; set => _price = value; }
        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        public int Stock { get => _stock; set => _stock = value; }
        [DisplayName("Product Status")]
        [Required(ErrorMessage = "Product Status is required")]
        public char Status { get => _status; set => _status = value; }
    }
}
