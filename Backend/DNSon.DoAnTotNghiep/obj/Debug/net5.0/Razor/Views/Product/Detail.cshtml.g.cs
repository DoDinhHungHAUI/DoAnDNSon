#pragma checksum "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46fa96578ac1454b3f3a1ae65f197d4b233d8ca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\_ViewImports.cshtml"
using DNSON.DoAnTotNghiep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\_ViewImports.cshtml"
using DNSON.DoAnTotNghiep.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46fa96578ac1454b3f3a1ae65f197d4b233d8ca1", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bfa5d04f1c8847147a239f41e39d6087dc8064", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DNSON.ApplicationCore.ViewModel.ProductDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    .session-product-detail {
        padding: 0px !important;
        margin-top: 20px !important;
    }

    .list-product-detail {
        margin-bottom: 20px !important;
    }

    .btn-cart-product-detail {
        border: 1px solid rgba(0, 0, 0, 0.05) !important;
        border-radius: 9px !important;
        height: 56px !important;
        background: #71b232 !important;
    }

    .name-product-detail {
        font-size: 17px;
    }

    .price-product-detail {
        font-size: 17px;
    }

    .price-line-through {
        text-decoration: line-through;
        color: #b3b3b3;
        font-size:15px;
    }

    .price-line {
        color: #82ae46;
    }

    .name-detail {
        color: #82ae46;
        font-size: 18px;
        margin-bottom: 5px;
        font-weight: 400;
        text-transform: uppercase;
        letter-spacing: 1px;
        font-family: ""Poppins"", Arial, sans-serif;
    }

    .quantiry-detail {
        color: #82ae46");
            WriteLiteral(@";
    }

    .warranty-product {
        font-size: 17px;
    }

    .warranty-detail {
        color: #82ae46;
    }

    .icon-footer-info-contact span {
        margin-right: 10px !important;
    }

    .list-product-detail .block-27{
        margin-block:35px !important;
    }

    .price .price-sale {
        font-size:14px !important;
    }

    .ftco-footer ftco-section{
        margin-top:35px !important;
    }



</style>

<section class=""ftco-section session-product-detail"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-5 mb-5 ftco-animate"">

");
#nullable restore
#line 92 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                  
                    var urlImage = "/images/ImageProduct/";
                    if (Model.Product.TypeProduct == 1)
                    {
                        // Điện thoại
                        urlImage += "DienThoai/" + Model.Product.Image;
                    }

                    if (Model.Product.TypeProduct == 2)
                    {
                        // Laptop
                        urlImage += "Laptop/" + Model.Product.Image;
                    }

                    if (Model.Product.TypeProduct == 3)
                    {
                        // Máy tính bảng
                        urlImage += "MayTinhBang/" + Model.Product.Image;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2536, "\"", 2552, 1);
#nullable restore
#line 113 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2543, urlImage, 2543, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image-popup\"><img");
            BeginWriteAttribute("src", " src=\"", 2578, "\"", 2593, 1);
#nullable restore
#line 113 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 2584, urlImage, 2584, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Colorlib Template\"></a>\r\n            </div>\r\n            <div class=\"col-lg-7 product-details pl-md-5 ftco-animate\">\r\n                <p class=\"name-product-detail\"><span>Tên sản phẩm : </span> <span class=\"name-detail\">");
#nullable restore
#line 116 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                                                 Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                <p class=\"price-product-detail\">\r\n                    <span>Giá : </span>\r\n\r\n");
#nullable restore
#line 120 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                      
                        if (Model.Product.PromotionPrice > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"mr-2 price-dc price-line-through\">\r\n                                ");
#nullable restore
#line 124 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                            Write((Math.Round((decimal)Model.Product.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ\r\n                            </span>\r\n                            <span class=\"price-sale price-line\">\r\n                                ");
#nullable restore
#line 127 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                            Write((Math.Round((decimal)Model.Product.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ\r\n                            </span>\r\n");
#nullable restore
#line 129 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"mr-2 price-dc\">\r\n                                ");
#nullable restore
#line 133 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                            Write((Math.Round((decimal)Model.Product.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ\r\n                            </span>\r\n");
#nullable restore
#line 135 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p class=\"price-product-detail\"><span>Số lượng : </span><span class=\"quantiry-detail\">");
#nullable restore
#line 139 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                                                 Write(Model.Product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                <p class=\"warranty-product\"><span>Bảo hành : </span><span class=\"warranty-detail\">");
#nullable restore
#line 140 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                                             Write(Model.Product.Warranty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Tháng</span></p>

                <div class=""row mt-4"">

                    <div class=""w-100""></div>
                    <div class=""input-group col-md-6 d-flex mb-3"">
                        <span class=""input-group-btn mr-2"">
                            <button type=""button"" class=""quantity-left-minus btn"" data-type=""minus"" data-field="""">
                                <i class=""fa fa-minus"" aria-hidden=""true""></i>
                            </button>
                        </span>
                        <input type=""text"" id=""quantityDetail"" name=""quantity"" class=""form-control input-number"" value=""1"" min=""1"" max=""100"">
                        <span class=""input-group-btn ml-2"">
                            <button type=""button"" class=""quantity-right-plus btn"" data-type=""plus"" data-field="""">
                                <i class=""fa fa-plus"" aria-hidden=""true""></i>
                            </button>
                        </span>
                    </div>
                   ");
            WriteLiteral(" <div class=\"w-100\"></div>\r\n                </div>\r\n                <p>\r\n                    <a href=\"cart.html\" class=\"btn btn-black py-3 px-5 btn-cart-product-detail\" id=\"btnAddToCartDetail\" data-id=\"");
#nullable restore
#line 161 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                                                                            Write(Model.Product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                        <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                        <span>Thêm vào giỏ hàng</span>
                    </a>
                </p>
            </div>
        </div>

        <div class=""row"">
            <h4>Mô tả sản phẩm</h4>
            <div>
                ");
#nullable restore
#line 172 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
           Write(Html.Raw(Model.Product.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>

    </div>
</section>

<section class=""ftco-section session-product-detail list-product-detail"">
    <div class=""container"">
        <div class=""row justify-content-center mb-3 pb-3"">
            <div class=""col-md-12 heading-section text-center ftco-animate"">
");
            WriteLiteral("                <span class=\"subheading\">Sản phẩm liên quan</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 191 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
              

                foreach (var item in Model.ProductRelates)
                {
                    var imageUrl = "/images/ImageProduct/";
                    if (Model.Product.TypeProduct == 1)
                    {
                        // Điện thoại
                        imageUrl += "DienThoai/" + item.Image;
                    }

                    if (Model.Product.TypeProduct == 2)
                    {
                        // Laptop
                        imageUrl += "Laptop/" + item.Image;
                    }

                    if (Model.Product.TypeProduct == 3)
                    {
                        // Máy tính bảng
                        imageUrl += "MayTinhBang/" + item.Image;
                    }

                    var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                        <div class=\"product\">\r\n                            <a href=\"#\" class=\"img-prod\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 7535, "", 7549, 1);
#nullable restore
#line 219 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 7540, imageUrl, 7540, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"">
                                <span class=""status"">30%</span>
                                <div class=""overlay""></div>
                            </a>
                            <div class=""text py-3 pb-4 px-3 text-center"">
                                <h3><a href=""#"">");
#nullable restore
#line 224 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <div class=\"d-flex\">\r\n                                    <div class=\"pricing\">\r\n                                        <p class=\"price\">\r\n");
#nullable restore
#line 228 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                             if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"mr-2 price-dc\">");
#nullable restore
#line 230 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                        Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 230 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                                                                                                                                                                   Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 231 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"mr-2 price-sale\">");
#nullable restore
#line 234 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                          Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 235 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </p>
                                    </div>
                                </div>
                                <div class=""bottom-area d-flex px-3"">
                                    <div class=""m-auto d-flex"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 9246, "\"", 9270, 1);
#nullable restore
#line 241 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 9253, urlProductDetail, 9253, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                            <span>
                                                <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                                        <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1 btnAddToCart"" data-id=""");
#nullable restore
#line 246 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                                                                                           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                            <span>
                                                <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                                        <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
                                            <span>
                                                <i class=""fa fa-heart"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 261 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"row mt-5\">\r\n            <div class=\"col text-center\">\r\n                <div class=\"block-27\">\r\n                    <ul>\r\n");
#nullable restore
#line 271 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                         if (Model.TotalPages > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 10908, "\"", 10936, 2);
            WriteAttributeValue("", 10915, "?page=", 10915, 6, true);
#nullable restore
#line 274 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 10921, Model.Page-1, 10921, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    &lt;\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 278 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"

                            var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                            var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);

                            for (int i = startPageIndex; i <= endPageIndex; i++)
                            {
                                if (Model.Page == i)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"active\">\r\n                                        <span>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 11615, "\"", 11630, 2);
            WriteAttributeValue("", 11622, "?page=", 11622, 6, true);
#nullable restore
#line 288 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 11628, i, 11628, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 11631, "\"", 11647, 2);
            WriteAttributeValue("", 11639, "trang", 11639, 5, true);
#nullable restore
#line 288 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue(" ", 11644, i, 11645, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 288 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </span>\r\n                                    </li>\r\n");
#nullable restore
#line 291 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 11941, "\"", 11956, 2);
            WriteAttributeValue("", 11948, "?page=", 11948, 6, true);
#nullable restore
#line 295 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 11954, i, 11954, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 11957, "\"", 11973, 2);
            WriteAttributeValue("", 11965, "Trang", 11965, 5, true);
#nullable restore
#line 295 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue(" ", 11970, i, 11971, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 295 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 297 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
                                }
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12162, "\"", 12190, 2);
            WriteAttributeValue("", 12169, "?page=", 12169, 6, true);
#nullable restore
#line 301 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"
WriteAttributeValue("", 12175, Model.Page+1, 12175, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    &gt;\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 305 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Product\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</section>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNSON.ApplicationCore.ViewModel.ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
