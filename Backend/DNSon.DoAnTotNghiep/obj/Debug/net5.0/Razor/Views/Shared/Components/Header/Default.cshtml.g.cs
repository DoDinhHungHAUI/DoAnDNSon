#pragma checksum "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1960d4fd77ab3bc910977e9d1d54ce056d0d857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1960d4fd77ab3bc910977e9d1d54ce056d0d857", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bfa5d04f1c8847147a239f41e39d6087dc8064", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DNSON.ApplicationCore.ViewModel.MenuHeaderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tim-kiem.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
   
    var userLogin = ViewBag.userLogin as DNSON.ApplicationCore.Entity.User;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<link rel=""stylesheet"" href=""/css/CustomCss/HeaderSection.css"" />



<div class=""container"">
    <a class=""navbar-brand"" href=""/"">DNSonShop</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#ftco-nav"" aria-controls=""ftco-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""oi oi-menu""></span> Menu
    </button>

    <div class=""collapse navbar-collapse"" id=""ftco-nav"">
        <ul class=""navbar-nav ml-auto"">

");
#nullable restore
#line 25 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
              
                var lstMenus = Model.ListMenuHeader;


                foreach (var menu in lstMenus)
                {
                    // có dropdown
                    if (menu.IsDropDown == 1)
                    {
                        var lstDropdowns = Model.ListProductCategory.Where(x => x.MenuHeaderId == menu.MenuHeaderId).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\"");
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1168, 2);
            WriteAttributeValue("", 1153, "/", 1153, 1, true);
#nullable restore
#line 37 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1154, menu.MenuLink, 1154, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"dropdown04\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">");
#nullable restore
#line 37 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                                    Write(menu.MenuHeaderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"dropdown04\">\r\n\r\n");
#nullable restore
#line 40 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                 foreach (var dropDown in lstDropdowns)
                                {
                                    var urlCategory = "danh-muc-" + dropDown.ProductCategoryLink + "/" + dropDown.ProductCategoryId;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1668, "\"", 1688, 2);
            WriteAttributeValue("", 1675, "/", 1675, 1, true);
#nullable restore
#line 43 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1676, urlCategory, 1676, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                                                             Write(dropDown.ProductCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 44 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 48 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1980, "\"", 2002, 2);
            WriteAttributeValue("", 1987, "/", 1987, 1, true);
#nullable restore
#line 53 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1988, menu.MenuLink, 1988, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                                ");
#nullable restore
#line 54 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                           Write(menu.MenuHeaderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 57 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 61 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
             if (ViewBag.isLogin)
            {
                // Đã đăng nhập

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a class=\"nav-link\">\r\n                        <span>Xin chào :</span><span class=\"user-name-login\">");
#nullable restore
#line 66 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                                                        Write(userLogin.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                </li>\r\n");
            WriteLiteral(@"                <li class=""nav-item"">
                    <a class=""nav-link menu-logout"" id=""btnLogout"">
                        <span>
                            <i class=""fa fa-user"" aria-hidden=""true""></i>
                        </span>
                        <span>Đăng xuất</span>
                    </a>
                </li>
");
#nullable restore
#line 78 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""dang-nhap.html"" class=""nav-link"">
                        <span>
                            <i class=""fa fa-sign-in"" aria-hidden=""true""></i>
                        </span>
                        <span>Đăng nhập</span>
                    </a>
                </li>
");
            WriteLiteral(@"                <li class=""nav-item"">
                    <a href=""dang-ky.html"" class=""nav-link"">
                        <span>
                            <i class=""fa fa-user"" aria-hidden=""true""></i>
                        </span>
                        <span>Đăng ký</span>
                    </a>
                </li>
");
#nullable restore
#line 99 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <li class=""nav-item cta cta-colored"">
                <a href=""/gio-hang.html"" class=""nav-link"">
                    <span>
                        <!-- class=""icon-shopping_cart""-->
                        <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                    </span>
                    <span id=""CountcartItem"">[");
#nullable restore
#line 107 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                         Write(Model.CountCart);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</span>\r\n                </a>\r\n            </li>\r\n\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"search-bar\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1960d4fd77ab3bc910977e9d1d54ce056d0d85713022", async() => {
                WriteLiteral("\r\n        <input id=\"txtSearch\" type=\"text\" name=\"keyword\" placeholder=\"Tìm kiếm...\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DNSON.ApplicationCore.ViewModel.MenuHeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
