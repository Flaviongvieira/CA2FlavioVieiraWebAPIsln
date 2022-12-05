using CA2FlavioVieiraWebAPI.Model;
using CA2FlavioVieiraWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CA2FlavioVieiraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IRepository _repo;
        public ProductsController(IRepository repo) { _repo = repo; }

        // GET: api/<ProductsController>            https://localhost:7001/Products/AllProducts
        [HttpGet("AllProducts")]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(_repo.GetAllProducts().ToList());
        }

        // GET api/<ProductsController>/5           https://localhost:7001/Products/Products/Hurling/5
        [HttpGet("Products/{category}/{rating}")] 
        public ActionResult<IEnumerable<Product>> GetAllProductsbyCategoryRating(string category, int rating)
        {
            var found = _repo.GetProductbyCategoryRating(category, rating);
            if (found == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(found);
            }
        }

        // GET api/<ProductsController>/5           https://localhost:7001/Products/Products/39.80/59.90
        [HttpGet("Products/Price/{min}/{max}")]
        public ActionResult<IEnumerable<Product>> GetAllProductsbyCPrice(double min, double max)
        {
            var found = _repo.GetProductbyPriceRange(min, max);
            if (found == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(found);
            }
        }

    }
}
