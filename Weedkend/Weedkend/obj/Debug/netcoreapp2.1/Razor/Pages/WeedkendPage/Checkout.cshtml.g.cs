#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d223c6ac51c717f1a87f599b4b86b2ffc9fba9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Checkout), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/Checkout.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Checkout), @"/checkout")]
namespace Weedkend.Pages.WeedkendPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\_ViewImports.cshtml"
using Weedkend;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/checkout")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d223c6ac51c717f1a87f599b4b86b2ffc9fba9", @"/Pages/WeedkendPage/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout woocommerce-checkout "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "checkOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
  
    ViewData["Title"] = "Check Out";
    Layout = "~/Pages/Shared/_Weedkend.cshtml";
    var cart = @Model.cart;
    var total = ViewData["Total"];
    var err = Model.Err;

#line default
#line hidden
            BeginContext(254, 381, true);
            WriteLiteral(@"
<main id=""main"" class="""">
    <div id=""content"" class=""content-area page-wrapper"" role=""main"">
        <div class=""row row-main"">
            <div class=""large-12 col"">
                <div class=""col-inner"">
                    <div class=""woocommerce"">
                        <div class=""woocommerce-notices-wrapper""></div><div class=""woocommerce-form-login-toggle"">

");
            EndContext();
            BeginContext(1001, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
            BeginContext(3773, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5245, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5269, 50797, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3feedb0b3e0a4cff950333965fce0ac8", async() => {
                BeginContext(5426, 419, true);
                WriteLiteral(@"

                            <div class=""row pt-0 "">
                                <div class=""large-7 col  "">


                                    <div id=""customer_details"">
                                        <div class=""clear"">
                                            <div class=""woocommerce-billing-fields"">

                                                <h3>Thông tin thanh toán</h3>


");
                EndContext();
                BeginContext(7230, 756, true);
                WriteLiteral(@"
                                                <div class=""woocommerce-billing-fields__field-wrapper"">
                                                    <p class=""form-row form-row-wide validate-required"" id=""billing_last_name_field"" data-priority=""10"">
                                                        <label for=""billing_last_name"" class="""">
                                                            Họ và tên&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr>
                                                        </label><span class=""woocommerce-input-wrapper"">

                                                            <input required type=""text"" class=""input-text "" name=""FullName"" placeholder=""Họ tên của bạn"" value="""">
");
                EndContext();
#line 121 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                             if (!string.IsNullOrEmpty(err.FullNameErr))
                                                            {

#line default
#line hidden
                BeginContext(8155, 88, true);
                WriteLiteral("                                                                <span style=\"color:red\">");
                EndContext();
                BeginContext(8244, 15, false);
#line 123 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                   Write(err.FullNameErr);

#line default
#line hidden
                EndContext();
                BeginContext(8259, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 124 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(8331, 841, true);
                WriteLiteral(@"                                                        </span>
                                                    </p>

                                                    <p class=""form-row form-row-first validate-required validate-phone"" data-priority=""20"">
                                                        <label for=""billing_phone"" class="""">
                                                            Số điện thoại&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr>
                                                        </label>
                                                        <span class=""woocommerce-input-wrapper"">

                                                            <input required type=""tel"" class=""input-text "" name=""phone"" placeholder=""Số điện thoại của bạn"" value="""" autocomplete=""tel"">
");
                EndContext();
#line 135 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                             if (!string.IsNullOrEmpty(err.PhoneNoErr))
                                                            {

#line default
#line hidden
                BeginContext(9340, 88, true);
                WriteLiteral("                                                                <span style=\"color:red\">");
                EndContext();
                BeginContext(9429, 14, false);
#line 137 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                   Write(err.PhoneNoErr);

#line default
#line hidden
                EndContext();
                BeginContext(9443, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 138 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(9515, 767, true);
                WriteLiteral(@"                                                        </span>
                                                    </p>
                                                    <p class=""form-row form-row-last validate-required validate-email"" id=""billing_email_field"" data-priority=""21"">
                                                        <label for=""billing_email"" class="""">Địa chỉ email&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr></label>
                                                        <span class=""woocommerce-input-wrapper"">

                                                            <input required type=""email"" class=""input-text "" name=""email"" id=""billing_email"" placeholder=""Email của bạn"" value="""" autocomplete=""email username"">
");
                EndContext();
#line 146 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                             if (!string.IsNullOrEmpty(err.EmailErr))
                                                            {

#line default
#line hidden
                BeginContext(10448, 88, true);
                WriteLiteral("                                                                <span style=\"color:red\">");
                EndContext();
                BeginContext(10537, 12, false);
#line 148 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                   Write(err.EmailErr);

#line default
#line hidden
                EndContext();
                BeginContext(10549, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 149 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(10621, 123, true);
                WriteLiteral("                                                        </span>\r\n                                                    </p>\r\n");
                EndContext();
                BeginContext(24924, 710, true);
                WriteLiteral(@"                                                    <p class=""form-row form-row-last validate-required"" id=""billing_address_1_field"" data-priority=""60"">
                                                        <label for=""billing_address_1"" class="""">
                                                            Địa chỉ&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr>
                                                        </label>
                                                        <span class=""woocommerce-input-wrapper"">

                                                            <input type=""text"" class=""input-text "" name=""address"" placeholder=""Ví dụ: Số 20, ngõ 90"" value="""" required>
");
                EndContext();
#line 265 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                             if (!string.IsNullOrEmpty(err.AddressErr))
                                                            {

#line default
#line hidden
                BeginContext(25802, 88, true);
                WriteLiteral("                                                                <span style=\"color:red\">");
                EndContext();
                BeginContext(25891, 14, false);
#line 267 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                   Write(err.AddressErr);

#line default
#line hidden
                EndContext();
                BeginContext(25905, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 268 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(25977, 323, true);
                WriteLiteral(@"                                                        </span>
                                                    </p>
                                                </div>

                                            </div>

                                            <div class=""woocommerce-account-fields"">

");
                EndContext();
                BeginContext(26939, 740, true);
                WriteLiteral(@"



                                                <div class=""create-account"" style=""display: none;"">
                                                    <p class=""form-row validate-required"" id=""account_password_field"" data-priority=""""><label for=""account_password"" class="""">Tạo mật khẩu của tài khoản&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr></label><span class=""woocommerce-input-wrapper""><input type=""password"" class=""input-text "" name=""account_password"" id=""account_password"" placeholder=""Mật khẩu"" value=""""></span></p>								<div class=""clear""></div>
                                                </div>


                                            </div>
                                        </div>

");
                EndContext();
                BeginContext(45469, 541, true);
                WriteLiteral(@"                                    </div>



                                </div><!-- large-7 -->

                                <div class=""large-5 col"">

                                    <div class=""col-inner has-border"">
                                        <div class=""checkout-sidebar sm-touch-scroll"">
                                            <h3 id=""order_review_heading"">Đơn hàng của bạn</h3>
                                            <p style=""color:red"">
                                                ");
                EndContext();
                BeginContext(46011, 17, false);
#line 440 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                           Write(ViewData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(46028, 52, true);
                WriteLiteral("\r\n                                            </p>\r\n");
                EndContext();
#line 442 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                             if (cart != null)
                                            {

#line default
#line hidden
                BeginContext(46191, 771, true);
                WriteLiteral(@"                                                <div id=""order_review"" class=""woocommerce-checkout-review-order"">
                                                    <table class=""shop_table woocommerce-checkout-review-order-table"">
                                                        <thead>
                                                            <tr>
                                                                <th class=""product-name"">Sản phẩm</th>
                                                                <th class=""product-total"">Tổng</th>
                                                            </tr>
                                                        </thead>

                                                        <tbody>
");
                EndContext();
#line 454 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                             foreach (var item in cart)
                                                            {

#line default
#line hidden
                BeginContext(47114, 255, true);
                WriteLiteral("                                                                <tr class=\"cart_item\">\r\n                                                                    <td class=\"product-name\">\r\n                                                                        ");
                EndContext();
                BeginContext(47370, 20, false);
#line 458 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                   Write(item.Product.ProName);

#line default
#line hidden
                EndContext();
                BeginContext(47390, 48, true);
                WriteLiteral("&nbsp;\t\t\t\t\t\t <strong class=\"product-quantity\">× ");
                EndContext();
                BeginContext(47439, 13, false);
#line 458 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                                                                          Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(47452, 300, true);
                WriteLiteral(@"</strong>
                                                                    </td>
                                                                    <td class=""product-total"">
                                                                        <span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(47754, 54, false);
#line 461 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                                  Write((item.Product.Price * item.Quantity).ToString("#,###"));

#line default
#line hidden
                EndContext();
                BeginContext(47809, 218, true);
                WriteLiteral("&nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span>\r\n                                                                    </td>\r\n                                                                </tr>\r\n");
                EndContext();
#line 464 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(48090, 420, true);
                WriteLiteral(@"                                                        </tbody>

                                                        <tfoot>

                                                            <tr class=""cart-subtotal"">
                                                                <th>Tạm tính</th>
                                                                <td><span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(48511, 5, false);
#line 471 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                             Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(48516, 152, true);
                WriteLiteral("&nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span></td>\r\n                                                            </tr>\r\n\r\n\r\n\r\n\r\n");
                EndContext();
                BeginContext(50863, 299, true);
                WriteLiteral(@"





                                                            <tr class=""order-total"">
                                                                <th>Tổng</th>
                                                                <td><strong><span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(51163, 5, false);
#line 506 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                                     Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(51168, 397, true);
                WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></strong> </td>
                                                            </tr>


                                                        </tfoot>
                                                    </table>

                                                    <div id=""payment"" class=""woocommerce-checkout-payment"">
");
                EndContext();
                BeginContext(54265, 1426, true);
                WriteLiteral(@"                                                        <div class=""form-row place-order"">
                                                            <noscript>
                                                                Trình duyệt của bạn không hỗ trợ JavaScript, hoặc nó bị vô hiệu hóa, hãy đảm bảo bạn nhấp vào <em>Cập nhật giỏ hàng</em> trước khi bạn thanh toán. Bạn có thể phải trả nhiều hơn số tiền đã nói ở trên, nếu bạn không làm như vậy.			<br /><button type=""submit"" class=""button alt"" name=""woocommerce_checkout_update_totals"" value=""Cập nhật tổng"">Cập nhật tổng</button>
                                                            </noscript>

                                                            <div class=""woocommerce-terms-and-conditions-wrapper"">

                                                            </div>

                                                            <button type=""submit"" class=""button alt"">Đặt hàng</button>

                                               ");
                WriteLiteral(@"             <input type=""hidden"" id=""woocommerce-process-checkout-nonce"" name=""woocommerce-process-checkout-nonce"" value=""2c9143dbed""><input type=""hidden"" name=""_wp_http_referer"" value=""/?wc-ajax=update_order_review"">
                                                        </div>
                                                    </div>

                                                </div>
");
                EndContext();
#line 556 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                            }

#line default
#line hidden
                BeginContext(55738, 321, true);
                WriteLiteral(@"                                            <div class=""woocommerce-privacy-policy-text""></div>
                                        </div>
                                    </div>

                                </div><!-- large-5 -->

                            </div><!-- row -->
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(56066, 173, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n\r\n\r\n                </div><!-- .col-inner -->\r\n            </div><!-- .large-12 -->\r\n        </div><!-- .row -->\r\n    </div>\r\n\r\n\r\n</main>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.Pages.WeedkendPage.CheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.CheckoutModel>)PageContext?.ViewData;
        public Weedkend.Pages.WeedkendPage.CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
