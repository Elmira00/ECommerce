using Ecommerce.Entities.Models;

namespace Ecommerce.Business.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
    }
}