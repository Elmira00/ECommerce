using Ecommerce.Core.DataAccess.EntityFramework;
using Ecommerce.DataAccess.Abstraction;
using Ecommerce.Entities.Models;

namespace Ecommerce.DataAccess.Concrete.EFEntityFramework
{
    public class EFProductDal : EFEntityFrameworkRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public EFProductDal(NorthwindContext context)
         : base(context)
        {
        }
    }
}