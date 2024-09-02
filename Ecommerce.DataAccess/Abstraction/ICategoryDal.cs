using Ecommerce.Core.DataAccess;
using Ecommerce.Entities.Models;

namespace Ecommerce.DataAccess.Abstraction
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}