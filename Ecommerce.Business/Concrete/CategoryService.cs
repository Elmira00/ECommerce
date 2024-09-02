using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstraction;
using Ecommerce.Entities.Models;

namespace Ecommerce.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _categoryDal.GetList();
        }
    }
}