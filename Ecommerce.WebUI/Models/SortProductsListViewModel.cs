using Ecommerce.Entities.Models;

namespace Ecommerce.WebUI.Models
{
    public class SortProductsListViewModel
    {
        public List<Product> Products { get; set; }
        public int Page { get; set; }
        public int Category { get; set; }
        public int Sorting { get; set; }
        public int Count { get; set; }
        public int Size { get; set; }
    }
}