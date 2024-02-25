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
    public class SlideService : BaseService<Slide>, ISlideService
    {
        #region Constructor
        public SlideService(ISlideRepository slideRepository) : base(slideRepository)
        {

        }
        #endregion
    }
}
