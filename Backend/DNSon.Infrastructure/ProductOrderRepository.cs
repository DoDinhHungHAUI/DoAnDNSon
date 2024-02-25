using DNSON.ApplicationCore.Entity;
using DNSON.ApplicationCore.Interface.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSON.Infrastructure
{
    public class ProductOrderRepository : BaseRepository<ProductOrder>, IProductOrderRepository
    {
        #region Constructor
        public ProductOrderRepository(IConfiguration configuration) : base(configuration)
        {

        }
        #endregion
    }
}
