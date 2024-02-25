using DNSON.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSON.ApplicationCore.Interface.Repository
{
    public interface IProductCategoryRepository : IBaseRepository<ProductCategory>
    {
        Task<int> DeleteMultipleRecord(string listId);

    }
}
