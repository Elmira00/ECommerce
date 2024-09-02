using Ecommerce.Core.DataAccess.EntityFramework;
using Ecommerce.DataAccess.Abstraction;
using Ecommerce.Entities.Models;

namespace Ecommerce.DataAccess.Concrete.EFEntityFramework
{
    public class EFCategoryDal : EFEntityFrameworkRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public EFCategoryDal(NorthwindContext context)
         : base(context)
        {
        }
    }
}