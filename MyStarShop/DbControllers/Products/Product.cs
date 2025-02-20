using System.ComponentModel;

namespace MyStarShop.DbControllers.Products
{
    public class Product
    {
        [DisplayName("productID")]
        public int ProductID { get; set; }

        [DisplayName("categoryName")]
        public string CategoryName { get; set; }

        [DisplayName("description")]
        public string Description { get; set; }
        
        [DisplayName("unitPrice")]
        public float UnitPrice { get; set; }

        [DisplayName("stock")]
        public int Stock { get; set; }



    }
}