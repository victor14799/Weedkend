#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9887f9c668c0f8bef8bd73ae2b36eb2ea54b555c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9887f9c668c0f8bef8bd73ae2b36eb2ea54b555c", @"/Pages/WeedkendPage/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woocommerce-form woocommerce-form-login login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout_coupon woocommerce-form-coupon has-border is-dashed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout woocommerce-checkout "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "checkOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

#line default
#line hidden
            BeginContext(228, 799, true);
            WriteLiteral(@"
<main id=""main"" class="""">
    <div id=""content"" class=""content-area page-wrapper"" role=""main"">
        <div class=""row row-main"">
            <div class=""large-12 col"">
                <div class=""col-inner"">
                    <div class=""woocommerce"">
                        <div class=""woocommerce-notices-wrapper""></div><div class=""woocommerce-form-login-toggle"">

                            <div class=""woocommerce-info message-wrapper"">
                                <div class=""message-container container medium-text-center"">
                                    Bạn đã có tài khoản? <a href=""#"" class=""showlogin"">Ấn vào đây để đăng nhập</a>
                                </div>
                            </div>
                        </div>
                        ");
            EndContext();
            BeginContext(1027, 2244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d30accfa734c8c9e4e23008cb55ca0", async() => {
                BeginContext(1123, 2141, true);
                WriteLiteral(@"


                            <p>If you have shopped with us before, please enter your details below. If you are a new customer, please proceed to the Billing section.</p>

                            <p class=""form-row form-row-first"">
                                <label for=""username"">Tên đăng nhập hoặc email&nbsp;<span class=""required"">*</span></label>
                                <input type=""text"" class=""input-text"" name=""username"" id=""username"" autocomplete=""username"">
                            </p>
                            <p class=""form-row form-row-last"">
                                <label for=""password"">Mật khẩu&nbsp;<span class=""required"">*</span></label>
                                <input class=""input-text"" type=""password"" name=""password"" id=""password"" autocomplete=""current-password"">
                            </p>
                            <div class=""clear""></div>


                            <p class=""form-row"">
                                <label cl");
                WriteLiteral(@"ass=""woocommerce-form__label woocommerce-form__label-for-checkbox woocommerce-form-login__rememberme"">
                                    <input class=""woocommerce-form__input woocommerce-form__input-checkbox"" name=""rememberme"" type=""checkbox"" id=""rememberme"" value=""forever""> <span>Ghi nhớ mật khẩu</span>
                                </label>
                                <input type=""hidden"" id=""woocommerce-login-nonce"" name=""woocommerce-login-nonce"" value=""6232fc208f""><input type=""hidden"" name=""_wp_http_referer"" value=""/checkout-2/"">		<input type=""hidden"" name=""redirect"" value=""https://classic.vn/checkout-2/"">
                                <button type=""submit"" class=""woocommerce-button button woocommerce-form-login__submit"" name=""login"" value=""Đăng nhập"">Đăng nhập</button>
                            </p>
                            <p class=""lost_password"">
                                <a href=""https://classic.vn/my-account-2/lost-password/"">Quên mật khẩu?</a>
                          ");
                WriteLiteral("  </p>\r\n\r\n                            <div class=\"clear\"></div>\r\n\r\n\r\n                        ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3271, 490, true);
            WriteLiteral(@"
                        <div class=""woocommerce-form-coupon-toggle"">

                            <div class=""woocommerce-info message-wrapper"">
                                <div class=""message-container container medium-text-center"">
                                    Bạn có mã ưu đãi? <a href=""#"" class=""showcoupon"">Ấn vào đây để nhập mã</a>
                                </div>
                            </div>
                        </div>

                        ");
            EndContext();
            BeginContext(3761, 969, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26106d93750b4ba6bff105c72c24a0cf", async() => {
                BeginContext(3871, 852, true);
                WriteLiteral(@"

                            <p>Nếu bạn có mã giảm giá, vui lòng điền vào phía bên dưới.</p>
                            <div class=""coupon"">
                                <div class=""flex-row medium-flex-wrap"">
                                    <div class=""flex-col flex-grow"">
                                        <input type=""text"" name=""coupon_code"" class=""input-text"" placeholder=""Mã ưu đãi"" id=""coupon_code"" value="""">
                                    </div>
                                    <div class=""flex-col"">
                                        <button type=""submit"" class=""button expand"" name=""apply_coupon"" value=""Áp dụng"">Áp dụng</button>
                                    </div>
                                </div><!-- row -->
                            </div><!-- coupon -->
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4730, 507, true);
            WriteLiteral(@"
                        <div class=""woocommerce-notices-wrapper"">
                            <div class=""woocommerce-message message-wrapper"" role=""alert"">
                                <div class=""message-container container success-color medium-text-center"">
                                    <i class=""icon-checkmark""></i>			Customer matched zone ""Hồ Chí Minh""
                                </div>
                            </div>
                        </div>
                        ");
            EndContext();
            BeginContext(5237, 49413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ce53b0129344c21aabae2d18a7c6dd0", async() => {
                BeginContext(5394, 4279, true);
                WriteLiteral(@"

                            <div class=""row pt-0 "">
                                <div class=""large-7 col  "">


                                    <div id=""customer_details"">
                                        <div class=""clear"">
                                            <div class=""woocommerce-billing-fields"">

                                                <h3>Thông tin thanh toán</h3>


                                                <div class=""get_address_byphone_wrap"">
                                                    <button class=""get_address_byphone"" type=""button"" data-mfp-src=""#get_address_content"">+ Lấy địa chỉ mua hàng trước</button>
                                                    <div id=""get_address_content"" class=""mfp-hide"">
                                                        <div class=""get_address_content_input"">
                                                            <input name=""sdt_get_address"" id=""sdt_get_address"" placeholder=""Nhập số điện thoại");
                WriteLiteral(@" mua lần trước"">
                                                        </div>
                                                        <div class=""get_address_content_mess""></div>
                                                        <div class=""get_address_content_button"">
                                                            <a href=""#"" class=""btn_get_address"">Tiếp tục</a>
                                                            <a href=""#"" class=""btn_cancel"">Hủy</a>
                                                        </div>
                                                        <div class=""get_address_content_footer""></div>
                                                    </div>
                                                </div>

                                                <div class=""woocommerce-billing-fields__field-wrapper"">
                                                    <p class=""form-row form-row-wide validate-required"" id=""billing_last_name_field"" data-pri");
                WriteLiteral(@"ority=""10"">
                                                        <label for=""billing_last_name"" class="""">
                                                            Họ và tên&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr>
                                                        </label><span class=""woocommerce-input-wrapper"">
                                                            <input required type=""text"" class=""input-text "" name=""FullName"" placeholder=""Họ tên của bạn"" value="""">
                                                        </span>
                                                    </p>
                                                    <p class=""form-row form-row-first validate-required validate-phone"" data-priority=""20"">
                                                        <label for=""billing_phone"" class="""">
                                                            Số điện thoại&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr>
                               ");
                WriteLiteral(@"                         </label>
                                                        <span class=""woocommerce-input-wrapper"">
                                                            <input required type=""tel"" class=""input-text "" name=""phone"" placeholder=""Số điện thoại của bạn"" value="""" autocomplete=""tel"">
                                                        </span>
                                                    </p>
                                                    <p class=""form-row form-row-last validate-required validate-email"" id=""billing_email_field"" data-priority=""21"">
                                                        <label for=""billing_email"" class="""">Địa chỉ email&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr></label>
                                                        <span class=""woocommerce-input-wrapper"">
                                                            <input required type=""email"" class=""input-text "" name=""email"" id=""billing_email"" placehold");
                WriteLiteral("er=\"Email của bạn\" value=\"\" autocomplete=\"email username\">\r\n                                                        </span>\r\n                                                    </p>\r\n");
                EndContext();
                BeginContext(23853, 1031, true);
                WriteLiteral(@"                                                    <p class=""form-row form-row-last validate-required"" id=""billing_address_1_field"" data-priority=""60"">
                                                        <label for=""billing_address_1"" class="""">
                                                            Địa chỉ&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr>
                                                        </label>
                                                        <span class=""woocommerce-input-wrapper"">
                                                            <input type=""text"" class=""input-text "" name=""address"" placeholder=""Ví dụ: Số 20, ngõ 90"" value="""" required>
                                                        </span>
                                                    </p>
                                                </div>

                                            </div>

                                            <div class=""woocommerce-account-field");
                WriteLiteral("s\">\r\n\r\n");
                EndContext();
                BeginContext(25523, 740, true);
                WriteLiteral(@"



                                                <div class=""create-account"" style=""display: none;"">
                                                    <p class=""form-row validate-required"" id=""account_password_field"" data-priority=""""><label for=""account_password"" class="""">Tạo mật khẩu của tài khoản&nbsp;<abbr class=""required"" title=""bắt buộc"">*</abbr></label><span class=""woocommerce-input-wrapper""><input type=""password"" class=""input-text "" name=""account_password"" id=""account_password"" placeholder=""Mật khẩu"" value=""""></span></p>								<div class=""clear""></div>
                                                </div>


                                            </div>
                                        </div>

");
                EndContext();
                BeginContext(44053, 541, true);
                WriteLiteral(@"                                    </div>



                                </div><!-- large-7 -->

                                <div class=""large-5 col"">

                                    <div class=""col-inner has-border"">
                                        <div class=""checkout-sidebar sm-touch-scroll"">
                                            <h3 id=""order_review_heading"">Đơn hàng của bạn</h3>
                                            <p style=""color:red"">
                                                ");
                EndContext();
                BeginContext(44595, 17, false);
#line 418 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                           Write(ViewData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(44612, 52, true);
                WriteLiteral("\r\n                                            </p>\r\n");
                EndContext();
#line 420 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                             if (cart != null)
                                            {

#line default
#line hidden
                BeginContext(44775, 771, true);
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
#line 432 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                             foreach (var item in cart)
                                                            {

#line default
#line hidden
                BeginContext(45698, 255, true);
                WriteLiteral("                                                                <tr class=\"cart_item\">\r\n                                                                    <td class=\"product-name\">\r\n                                                                        ");
                EndContext();
                BeginContext(45954, 20, false);
#line 436 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                   Write(item.Product.ProName);

#line default
#line hidden
                EndContext();
                BeginContext(45974, 48, true);
                WriteLiteral("&nbsp;\t\t\t\t\t\t <strong class=\"product-quantity\">× ");
                EndContext();
                BeginContext(46023, 13, false);
#line 436 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                                                                          Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(46036, 300, true);
                WriteLiteral(@"</strong>
                                                                    </td>
                                                                    <td class=""product-total"">
                                                                        <span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(46338, 54, false);
#line 439 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                                  Write((item.Product.Price * item.Quantity).ToString("#,###"));

#line default
#line hidden
                EndContext();
                BeginContext(46393, 218, true);
                WriteLiteral("&nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span>\r\n                                                                    </td>\r\n                                                                </tr>\r\n");
                EndContext();
#line 442 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(46674, 420, true);
                WriteLiteral(@"                                                        </tbody>

                                                        <tfoot>

                                                            <tr class=""cart-subtotal"">
                                                                <th>Tạm tính</th>
                                                                <td><span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(47095, 5, false);
#line 449 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                             Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(47100, 152, true);
                WriteLiteral("&nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span></td>\r\n                                                            </tr>\r\n\r\n\r\n\r\n\r\n");
                EndContext();
                BeginContext(49447, 299, true);
                WriteLiteral(@"





                                                            <tr class=""order-total"">
                                                                <th>Tổng</th>
                                                                <td><strong><span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(49747, 5, false);
#line 484 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                                                                                                     Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(49752, 397, true);
                WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></strong> </td>
                                                            </tr>


                                                        </tfoot>
                                                    </table>

                                                    <div id=""payment"" class=""woocommerce-checkout-payment"">
");
                EndContext();
                BeginContext(52849, 1426, true);
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
#line 534 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Checkout.cshtml"
                                            }

#line default
#line hidden
                BeginContext(54322, 321, true);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(54650, 173, true);
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
