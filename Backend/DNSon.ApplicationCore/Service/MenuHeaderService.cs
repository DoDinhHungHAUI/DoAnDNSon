using DNSON.ApplicationCore.Entity;
using DNSON.ApplicationCore.Interface.Repository;
using DNSON.ApplicationCore.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSON.ApplicationCore.Service
{
    public class MenuHeaderService : BaseService<MenuHeader>,IMenuHeaderService
    {
        #region Constructor
        public MenuHeaderService(IMenuHeaderRepository menuRepository) : base(menuRepository)
        {

        }
        #endregion
    }
}
