#pragma checksum "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb052375eac133284045dde52b746a1dc2ad18e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb052375eac133284045dde52b746a1dc2ad18e7", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bfa5d04f1c8847147a239f41e39d6087dc8064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DNSON.ApplicationCore.ViewModel.PaginationSet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
  
    var keyword = (string)ViewBag.Keyword;
    ViewBag.MetaKeyword = "Kết quả tìm kiếm cho từ khóa " + keyword;
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/CustomCss/ProductCategorySection.css"" />

<section class=""ftco-section product-category-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-10"">
                <p>Kết quả tìm kiếm ");
#nullable restore
#line 16 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                               Write(ViewBag.keyword);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 16 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                  Write(Model.Item.TotalProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Sản phẩm  </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 21 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
              

                foreach (var item in Model.Item.products)
                {
                    var urlImage = "";

                    if (item.TypeProduct == 1)
                    {
                        // Điện thoại
                        urlImage = "/images/ImageProduct/DienThoai/" + item.Image;
                    }
                    else if (item.TypeProduct == 2)
                    {
                        // Laptop
                        urlImage = "/images/ImageProduct/Laptop/" + item.Image;
                    }
                    else if (item.TypeProduct == 3)
                    {
                        // Máy tính bảng
                        urlImage = "/images/ImageProduct/MayTinhBang/" + item.Image;
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                        <div class=\"product\">\r\n                            <a href=\"#\" class=\"img-prod\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 1631, "", 1645, 1);
#nullable restore
#line 46 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue("", 1636, urlImage, 1636, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"">
                                <span class=""status"">30%</span>
                                <div class=""overlay""></div>
                            </a>
                            <div class=""text py-3 pb-4 px-3 text-center"">
                                <h3>
                                    <a href=""#""");
            BeginWriteAttribute("title", " title=\"", 1992, "\"", 2017, 1);
#nullable restore
#line 52 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue("", 2000, item.ProductName, 2000, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"product-name-text\">");
#nullable restore
#line 53 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                                  Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                    </a>
                                </h3>
                                <div class=""d-flex"">
                                    <div class=""pricing"">
                                        <p class=""price"">
");
#nullable restore
#line 59 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                             if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"mr-2 price-dc\">");
#nullable restore
#line 61 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                                        Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 61 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                                                                                                                                                                                   Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 62 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"mr-2 price-sale\">");
#nullable restore
#line 65 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                                          Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 66 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </p>
                                    </div>
                                </div>
                                <div class=""bottom-area d-flex px-3"">
                                    <div class=""m-auto d-flex"">
                                        <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                            <span>
                                                <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                                        <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
                                            <span>
                                                <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                            </span>
                                        </a>");
            WriteLiteral(@"
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
#line 92 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"row mt-5\">\r\n            <div class=\"col text-center\">\r\n                <div class=\"block-27\">\r\n                    <ul>\r\n");
#nullable restore
#line 100 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                         if (Model.TotalPages > 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5160, "\"", 5188, 2);
            WriteAttributeValue("", 5167, "?page=", 5167, 6, true);
#nullable restore
#line 103 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue("", 5173, Model.Page-1, 5173, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    &lt;\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 107 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"

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
            BeginWriteAttribute("href", " href=\"", 5867, "\"", 5882, 2);
            WriteAttributeValue("", 5874, "?page=", 5874, 6, true);
#nullable restore
#line 117 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue("", 5880, i, 5880, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 5883, "\"", 5899, 2);
            WriteAttributeValue("", 5891, "trang", 5891, 5, true);
#nullable restore
#line 117 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue(" ", 5896, i, 5897, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 117 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </span>\r\n                                    </li>\r\n");
#nullable restore
#line 120 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6193, "\"", 6208, 2);
            WriteAttributeValue("", 6200, "?page=", 6200, 6, true);
#nullable restore
#line 124 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue("", 6206, i, 6206, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 6209, "\"", 6225, 2);
            WriteAttributeValue("", 6217, "Trang", 6217, 5, true);
#nullable restore
#line 124 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue(" ", 6222, i, 6223, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 124 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 126 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
                                }
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 6414, "\"", 6442, 2);
            WriteAttributeValue("", 6421, "?page=", 6421, 6, true);
#nullable restore
#line 130 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"
WriteAttributeValue("", 6427, Model.Page+1, 6427, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    &gt;\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 134 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Search.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      \r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNSON.ApplicationCore.ViewModel.PaginationSet> Html { get; private set; }
    }
}
#pragma warning restore 1591