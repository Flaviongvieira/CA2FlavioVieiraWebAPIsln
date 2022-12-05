using CA2FlavioVieiraWebAPI.Model;

namespace CA2FlavioVieiraWebAPI.Repository
{
    public interface IRepository
    {
        // Return a list of products for a specified category and a specified rating
        List<Product> GetProductbyCategoryRating(string category, int rating);

        // Return a list of products for a specified price range (i.e. allow the user to specify a min and max price) 
        List<Product> GetProductbyPriceRange(double min, double max);

        // All Products
        List<Product> GetAllProducts();
    }
}
