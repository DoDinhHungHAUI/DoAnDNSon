#pragma checksum "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eecbf93a7cf4378e0a5ae3a5a9fed683becb60ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eecbf93a7cf4378e0a5ae3a5a9fed683becb60ef", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bfa5d04f1c8847147a239f41e39d6087dc8064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DNSON.ApplicationCore.ViewModel.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CustomCss/ProductSection.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eecbf93a7cf4378e0a5ae3a5a9fed683becb60ef4142", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!--Slide -->\r\n<section id=\"home-section\" class=\"hero\">\r\n\r\n    ");
#nullable restore
#line 14 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n</section>\r\n\r\n");
#nullable restore
#line 18 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
 if (Model.PhoneLatests.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""ftco-section product-section"">
        <div class=""container"">
            <div class=""row justify-content-center mb-3 pb-3"">
                <div class=""col-md-12 heading-section text-center ftco-animate"">

                    <span class=""subheading"">Điện Thoại Mới Nhất</span>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">

");
#nullable restore
#line 32 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                  

                    foreach (var item in Model.PhoneLatests)
                    {
                        var urlImage = "";

                        // Điện thoại
                        urlImage = "/images/ImageProduct/DienThoai/" + item.Image;

                        var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                            <div class=\"product\">\r\n                                <a href=\"#\" class=\"img-prod\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 1399, "", 1413, 1);
#nullable restore
#line 46 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 1404, urlImage, 1404, 9, false);

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
            BeginWriteAttribute("title", " title=\"", 1784, "\"", 1809, 1);
#nullable restore
#line 52 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 1792, item.ProductName, 1792, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-name-text\">");
#nullable restore
#line 53 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
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
#line 59 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                 if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-dc\">");
#nullable restore
#line 61 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                            Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 61 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                                                                       Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 62 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-sale\">");
#nullable restore
#line 65 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                              Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 66 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </p>
                                        </div>
                                    </div>
                                    <div class=""bottom-area d-flex px-3"">
                                        <div class=""m-auto d-flex"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 3429, "\"", 3453, 1);
#nullable restore
#line 72 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 3436, urlProductDetail, 3436, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                                <span>
                                                    <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a class=""buy-now d-flex justify-content-center align-items-center mx-1 btnAddToCart"" data-id=""");
#nullable restore
#line 77 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
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
#line 92 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 99 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 103 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
 if (Model.LaptopLatests.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"ftco-section product-section\">\r\n        <div class=\"container\">\r\n            <div class=\"row justify-content-center mb-3 pb-3\">\r\n                <div class=\"col-md-12 heading-section text-center ftco-animate\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                    <span class=\"subheading\">Laptop Mới Nhất</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 121 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                  

                    foreach (var item in Model.LaptopLatests)
                    {
                        var urlImage = "";

                        // Điện thoại
                        urlImage = "/images/ImageProduct/Laptop/" + item.Image;

                        var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                            <div class=\"product\">\r\n                                <a href=\"#\" class=\"img-prod\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 6337, "", 6351, 1);
#nullable restore
#line 135 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 6342, urlImage, 6342, 9, false);

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
#line 140 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <div class=\"d-flex\">\r\n                                        <div class=\"pricing\">\r\n                                            <p class=\"price\">\r\n");
#nullable restore
#line 144 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                 if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-dc\">");
#nullable restore
#line 146 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                            Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 146 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                                                                       Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 147 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-sale\">");
#nullable restore
#line 150 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                              Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 151 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </p>
                                        </div>
                                    </div>
                                    <div class=""bottom-area d-flex px-3"">
                                        <div class=""m-auto d-flex"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 8136, "\"", 8160, 1);
#nullable restore
#line 157 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 8143, urlProductDetail, 8143, 17, false);

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
#line 162 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
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
#line 177 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 184 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 187 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
 if (Model.TabletLatests.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""ftco-section product-section"">
        <div class=""container"">
            <div class=""row justify-content-center mb-3 pb-3"">
                <div class=""col-md-12 heading-section text-center ftco-animate"">
                    <span class=""subheading"">Máy Tính Bảng Mới Nhất</span>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">

");
#nullable restore
#line 200 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                  

                    foreach (var item in Model.TabletLatests)
                    {
                        var urlImage = "";

                        // Điện thoại
                        urlImage = "/images/ImageProduct/MayTinhBang/" + item.Image;

                        var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                            <div class=\"product\">\r\n                                <a href=\"#\" class=\"img-prod\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 10741, "", 10755, 1);
#nullable restore
#line 214 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 10746, urlImage, 10746, 9, false);

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
#line 219 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <div class=\"d-flex\">\r\n                                        <div class=\"pricing\">\r\n                                            <p class=\"price\">\r\n");
#nullable restore
#line 223 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                 if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-dc\">");
#nullable restore
#line 225 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                            Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 225 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                                                                       Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 226 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-sale\">");
#nullable restore
#line 229 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                              Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 230 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </p>
                                        </div>
                                    </div>
                                    <div class=""bottom-area d-flex px-3"">
                                        <div class=""m-auto d-flex"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 12540, "\"", 12564, 1);
#nullable restore
#line 236 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 12547, urlProductDetail, 12547, 17, false);

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
#line 241 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
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
#line 256 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 263 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNSON.ApplicationCore.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
