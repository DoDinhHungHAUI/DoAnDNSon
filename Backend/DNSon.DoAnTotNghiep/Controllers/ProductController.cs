using DNSON.ApplicationCore.Common;
using DNSON.ApplicationCore.Interface.Service;
using DNSON.ApplicationCore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNSON.DoAnTotNghiep.Controllers
{
    public class ProductController : Controller
    {
        #region Declare

        private readonly IProductService _productService;

        #endregion

        #region Constructor

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        #endregion

        public IActionResult Detail(Guid? ProductId, int page = 1)
        {

            int pageSize = ConfigHelper.pageSize;

            ProductDetailViewModel productDetailViewModel = new ProductDetailViewModel();


            var product = _productService.GetEntities().Result;

            var productDetail = product.Where(x => x.ProductId == ProductId).FirstOrDefault();

            productDetailViewModel.Product = productDetail;

            var productRelates = product.Where(x => x.CategoryID == productDetail.CategoryID).ToList();

            int totalPage = (int)Math.Ceiling((double)productRelates.Count / pageSize);

            productDetailViewModel.ProductRelates = productRelates.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            productDetailViewModel.MaxPage = ConfigHelper.MaxPage;
            productDetailViewModel.Page = page;

            productDetailViewModel.TotalPages = totalPage;

            productDetailViewModel.TotalCount = productRelates.Count;

            return View(productDetailViewModel);
        }
    }
}
