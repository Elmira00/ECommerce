using Ecommerce.Entities.Models;

namespace Ecommerce.WebUI.Models
{
    public class CategoryListViewModel
    {
        public bool IsAdmin { get; set; }
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}