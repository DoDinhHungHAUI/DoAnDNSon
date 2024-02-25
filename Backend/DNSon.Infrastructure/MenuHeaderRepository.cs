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
    public class MenuHeaderRepository : BaseRepository<MenuHeader>, IMenuHeaderRepository
    {
        #region Constructor
        public MenuHeaderRepository(IConfiguration configuration) : base(configuration)
        {


        }
        #endregion
    }
}
