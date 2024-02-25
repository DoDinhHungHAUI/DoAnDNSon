using DNSON.ApplicationCore.Entity;
using DNSON.ApplicationCore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNSON.ApplicationCore.Interface.Service
{
    public interface IFooterProductService : IBaseService<FooterProduct>
    {
        public Task<FooterViewModel> GetFooterProducts();
    }
}
