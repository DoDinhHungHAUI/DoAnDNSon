#pragma checksum "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1948b1885db9967d289bbd7201d499c0bf0b167b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1948b1885db9967d289bbd7201d499c0bf0b167b", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bfa5d04f1c8847147a239f41e39d6087dc8064", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmPayment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Slide -->\r\n\r\n");
#nullable restore
#line 9 "E:\DoAnTotNghiep\DoAnDNSon\Backend\DNSon.DoAnTotNghiep\Views\ShoppingCart\Index.cshtml"
Write(await Component.InvokeAsync("SliderOption"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

<link rel=""stylesheet"" href=""/css/CustomCss/ShoppingCart.css"" />


<section class=""ftco-section ftco-cart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 ftco-animate"">
                <div class=""cart-list"">
                    <table class=""table"">
                        <thead class=""thead-primary"">
                            <tr class=""text-center"">
                                <th>&nbsp;</th>
                                <th>Hình ảnh</th>
                                <th>Tên Sản Phẩm</th>
                                <th>Giá</th>
                                <th>Số Lượng</th>
                                <th>Tổng</th>
                            </tr>
                        </thead>
                        <tbody id=""cartBody"">
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""row row-margin-top"">
            <div class=""col");
            WriteLiteral(@"-md-12 ftco-animate"">
                <button class=""btn btn-danger button-shopping-cart"" id=""btnDeleteAll"">
                    <i class=""fa fa-trash"" aria-hidden=""true""></i>
                    <span>
                        Xóa tất cả
                    </span>
                </button>
                <button class=""btn btn-warning button-shopping-cart btn-confirm"" id=""btnCheckout"">
                    <i class=""fa fa-truck"" aria-hidden=""true""></i>
                    <span>Đặt hàng</span>
                </button>
            </div>
        </div>

        <div class=""row row-margin-top"">
            <div class=""col-md-12"">
                <div id=""divCheckout"" style=""display:none;"">
                    <div class=""reservation_top"">
                        <div class=""contact_right"">
                            <h4>Vui lòng nhập thông tin</h4>
                            <div class=""contact-form"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1948b1885db9967d289bbd7201d499c0bf0b167b6514", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <input type=""text"" class=""textbox form-control"" id=""txtName"" name=""name"" placeholder=""Họ tên"">
                                    </div>

                                    <div class=""form-group"">
                                        <input type=""text"" class=""textbox form-control"" id=""txtAddress"" name=""address"" placeholder=""Địa chỉ"">
                                    </div>

                                    <div class=""form-group"">
                                        <input type=""text"" class=""textbox form-control"" id=""txtEmail"" name=""email"" placeholder=""Email"">
                                    </div>
                                    <div class=""form-group"">
                                        <input type=""text"" class=""textbox form-control"" id=""txtPhone"" name=""phone"" placeholder=""Điện thoại"">
                                    </div>

                                  ");
                WriteLiteral("  <div class=\"form-group\">\r\n                                        <textarea");
                BeginWriteAttribute("value", " value=\"", 3682, "\"", 3690, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""user-message"" id=""txtMessage form-control"" style=""font-size : 15px;"" placeholder=""Ghi chú""></textarea>
                                    </div>
                                    <div class=""form-group"">
                                        <button type=""button"" class=""btn btn-warning btn-confirm"" id=""btnCreateOrder"">
                                            <i class=""fa fa-check-circle"" aria-hidden=""true""></i> 
                                            <span>Xác nhận</span>
                                        </button>
");
                WriteLiteral("                                    </div>\r\n\r\n                                    <div class=\"clearfix\"> </div>\r\n                                ");
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
            WriteLiteral(@"

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

       

    </div>
</section>


<script id=""tplCart"" type=""x-tmpl-mustache"">

   <tr class=""text-center"">
        <td class=""product-remove"">
            <a class = ""btnDeleteItem"" data-id=""{{ProductId}}"">
                <span>
                    <i class=""fa fa-times"" aria-hidden=""true""></i>
                </span>
            </a>
        </td>

        <td class=""image-prod""><div class=""img"" style=""background-image:url(/images/ImageProduct/{{Image}});""></div></td>

        <td class=""product-name"">
            <h3>{{ProductName}}</h3>
        </td>

        <td class=""price"">{{Price}}</td>

        <td class=""quantity"">
            <div class=""input-group mb-3"">
                <input type=""text"" name=""quantity"" data-id=""{{ProductId}}"" class=""txtQuantity quantity form-control input-number"" value=""{{Quantity}}"" min=""1""");
            WriteLiteral(" max=\"100\">\r\n            </div>\r\n        </td>\r\n\r\n        <td class=\"total\" id=\"amount_{{ProductId}}\">{{Amount}}</td>\r\n    </tr>\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
