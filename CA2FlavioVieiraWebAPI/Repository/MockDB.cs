using CA2FlavioVieiraWebAPI.Model;

namespace CA2FlavioVieiraWebAPI.Repository
{
    public class MockDB : IRepository
    {
        // Static private List
        private static List<Product> Products = new List<Product>()
        {
            new Product{ProductID = 1, ProductName="T-Shirt", ProductCategory="Football", ProductPrice = 79.90, ProductSize = "L", ProductRating = 4 },
            new Product{ProductID = 2, ProductName="T-Shirt", ProductCategory="Hurling", ProductPrice = 59.90, ProductSize = "S", ProductRating = 5 },
            new Product{ProductID = 3, ProductName="Jacket", ProductCategory="Hurling", ProductPrice = 89.90, ProductSize = "XL", ProductRating = 3 },
            new Product{ProductID = 4, ProductName="Jacket", ProductCategory="Football", ProductPrice = 89.90, ProductSize = "M", ProductRating = 1 },
            new Product{ProductID = 5, ProductName="Shorts", ProductCategory="Football", ProductPrice = 29.90, ProductSize = "M", ProductRating = 2 },
            new Product{ProductID = 6, ProductName="Shorts", ProductCategory="Clothes", ProductPrice = 29.90, ProductSize = "L", ProductRating = 4 }

        };

        public List<Product> GetProductbyCategoryRating(string category, int rating)
        {
            var found = Products.Where(x=>x.ProductCategory == category).Where(x=>x.ProductRating == rating).ToList();
            return found;
        }

        public List<Product> GetProductbyPriceRange(double min, double max)
        {
            var found = Products.Where(x => x.ProductPrice >= min).Where(x => x.ProductPrice <= max).ToList();
            return found;
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }
    }
}
