using System.ComponentModel.DataAnnotations;

namespace CA2FlavioVieiraWebAPI.Model
{
    public class Product
    {
        /*public enum category
        {
            Football, Hurling, Clothes
        }*/

        // ProductID
        [Key]
        public int ProductID { get; set; }

        // Product Name (required and must contain at least 2 characters) 
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string ProductName { get; set; }

        // Product Price (required) 
        public double ProductPrice { get; set; }

        // Product Rating (an integer value for 1 to 5 representing the customer rating of the product) 
        [Range(1,5)]

        public int ProductRating { get; set; }

        // Product category (Allowed values are ‘Football’, ‘Hurling’ and ‘Clothes’)
        /*public category ProductCategory { get; set; }*/
        [RegularExpression("Football|LHurling|Clothes", ErrorMessage = "Allowed values are ‘Football’, ‘Hurling’ and ‘Clothes’")]
        public string ProductCategory { get; set; }


        // Product Size (Allowed values are ‘XL, ‘L’ , ‘M’, and ‘S’)
        [RegularExpression("XL|L|M|S", ErrorMessage = "Allowed values are ‘XL, ‘L’ , ‘M’, and ‘S’")]
        public string ProductSize { get; set; }

    }
}
