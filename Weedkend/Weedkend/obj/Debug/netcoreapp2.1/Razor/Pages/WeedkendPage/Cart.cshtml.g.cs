#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "086efae24ccb0ea3f034c4852de0daf802edbebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Cart), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/Cart.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Cart), @"/cart")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/cart")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"086efae24ccb0ea3f034c4852de0daf802edbebe", @"/Pages/WeedkendPage/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Xóa sản phẩm này"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-product_id", new global::Microsoft.AspNetCore.Html.HtmlString("1761"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-product_sku", new global::Microsoft.AspNetCore.Html.HtmlString("gatsby-moving-rubber-gatsby-xam"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button primary mt-0 pull-left small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Cập nhật giỏ hàng"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("woocommerce-cart-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    var cart = Model.cart;
    Layout = "~/Pages/Shared/_Weedkend.cshtml";
    var total = @Model.Total;

#line default
#line hidden
            BeginContext(209, 1126, true);
            WriteLiteral(@"
<main id=""main"" class="""">

    <div class=""checkout-page-title page-title"">
        <div class=""page-title-inner flex-row medium-flex-wrap container"">
            <div class=""flex-col flex-grow medium-text-center"">
                <nav class=""breadcrumbs heading-font checkout-breadcrumbs text-center h2 strong"">
                    <a href=""/cart"" class=""current"">Shopping Cart</a>
                    <span class=""divider hide-for-small""><i class=""icon-angle-right""></i></span>
                    <a href=""/checkout"" class=""hide-for-small"">Checkout details</a>
                    <span class=""divider hide-for-small""><i class=""icon-angle-right""></i></span>
                    <a href=""#"" class=""no-click hide-for-small"">Order Complete</a>
                </nav>
            </div><!-- .flex-left -->
        </div><!-- flex-row -->
    </div><!-- .page-title -->
    <div class=""cart-container container page-wrapper page-checkout"">
        <div class=""woocommerce"">
            <div class=""woocommer");
            WriteLiteral("ce-notices-wrapper\">\r\n                <div class=\"woocommerce-message message-wrapper\" role=\"alert\">\r\n");
            EndContext();
            BeginContext(1565, 168, true);
            WriteLiteral("                </div>\r\n            </div><div class=\"woocommerce row row-large row-divided\">\r\n                <div class=\"col large-7 pb-0 \">\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(1733, 7669, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb8b554449542d09a3795120ebfc3f7", async() => {
                BeginContext(1799, 201, true);
                WriteLiteral("\r\n                        <div class=\"cart-wrapper sm-touch-scroll\">\r\n                            <table class=\"shop_table shop_table_responsive cart woocommerce-cart-form__contents\" cellspacing=\"0\">\r\n");
                EndContext();
#line 40 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                 if (cart != null)
                                {

#line default
#line hidden
                BeginContext(2087, 532, true);
                WriteLiteral(@"                                    <thead>
                                        <tr>
                                            <th class=""product-name"" colspan=""3"">Sản phẩm</th>
                                            <th class=""product-price"">Giá</th>
                                            <th class=""product-quantity"">Số lượng</th>
                                            <th class=""product-subtotal"">Tổng</th>
                                        </tr>
                                    </thead>
");
                EndContext();
                BeginContext(2621, 47, true);
                WriteLiteral("                                    <tbody>\r\n\r\n");
                EndContext();
#line 53 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                         foreach (var item in Model.cart)
                                        {

#line default
#line hidden
                BeginContext(2786, 232, true);
                WriteLiteral("                                            <tr class=\"woocommerce-cart-form__cart-item cart_item\">\r\n\r\n                                                <td class=\"product-remove\">\r\n                                                    ");
                EndContext();
                BeginContext(3018, 203, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990e2ff04599428aa6d16db07daadb28", async() => {
                    BeginContext(3216, 1, true);
                    WriteLiteral("×");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 58 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                   WriteLiteral(item.Product.ProductId.ToString());

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3221, 507, true);
                WriteLiteral(@"
                                                </td>


                                                <td class=""product-thumbnail"">
                                                    <a href=""https://classic.vn/shop/gatsby-moving-rubber-gatsby-xam/"">
                                                        <picture width=""300"" height=""300"" class=""attachment-woocommerce_thumbnail size-woocommerce_thumbnail"">
                                                            <source type=""image/webp""");
                EndContext();
                BeginWriteAttribute("srcset", " srcset=\"", 3728, "\"", 3757, 1);
#line 65 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
WriteAttributeValue("", 3737, item.Product.ImgUrl, 3737, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3758, 67, true);
                WriteLiteral(">\r\n                                                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3825, "\"", 3851, 1);
#line 66 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
WriteAttributeValue("", 3831, item.Product.ImgUrl, 3831, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3852, 1311, true);
                WriteLiteral(@" alt="""" srcset=""https://classic.vn/wp-content/uploads/2017/02/sap-vuot-toc-gatsby-moving-rubber-grunge-mat-80g-ghi-5769-1825681-12a34eb1efacdded74d90e715c874f68-product-1-300x300.jpg 300w, https://classic.vn/wp-content/uploads/2017/02/sap-vuot-toc-gatsby-moving-rubber-grunge-mat-80g-ghi-5769-1825681-12a34eb1efacdded74d90e715c874f68-product-1-280x280.jpg 280w, https://classic.vn/wp-content/uploads/2017/02/sap-vuot-toc-gatsby-moving-rubber-grunge-mat-80g-ghi-5769-1825681-12a34eb1efacdded74d90e715c874f68-product-1-80x80.jpg 80w, https://classic.vn/wp-content/uploads/2017/02/sap-vuot-toc-gatsby-moving-rubber-grunge-mat-80g-ghi-5769-1825681-12a34eb1efacdded74d90e715c874f68-product-1-100x100.jpg 100w, https://classic.vn/wp-content/uploads/2017/02/sap-vuot-toc-gatsby-moving-rubber-grunge-mat-80g-ghi-5769-1825681-12a34eb1efacdded74d90e715c874f68-product-1.jpg 340w"" sizes=""(max-width: 300px) 100vw, 300px"">
                                                        </picture>
                                            ");
                WriteLiteral(@"        </a>
                                                </td>

                                                <td class=""product-name"" data-title=""Sản phẩm"">
                                                    <a href=""https://classic.vn/shop/gatsby-moving-rubber-gatsby-xam/"">");
                EndContext();
                BeginContext(5164, 20, false);
#line 72 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                                                  Write(item.Product.ProName);

#line default
#line hidden
                EndContext();
                BeginContext(5184, 320, true);
                WriteLiteral(@"</a>
                                                    <div class=""show-for-small mobile-product-price"">
                                                        <span class=""mobile-product-price__qty"">1 x </span>
                                                        <span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(5505, 36, false);
#line 75 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                                 Write(item.Product.Price.ToString("#,###"));

#line default
#line hidden
                EndContext();
                BeginContext(5541, 380, true);
                WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span>
                                                    </div>
                                                </td>

                                                <td class=""product-price"" data-title=""Giá"">
                                                    <span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(5922, 36, false);
#line 80 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                             Write(item.Product.Price.ToString("#,###"));

#line default
#line hidden
                EndContext();
                BeginContext(5958, 320, true);
                WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span>
                                                </td>

                                                <td class=""product-quantity"" data-title=""Số lượng"">
                                                    <div class=""quantity buttons_added"">
");
                EndContext();
                BeginContext(6516, 178, true);
                WriteLiteral("                                                        <input type=\"number\" id=\"quantity_5df0db8eed3e3\" class=\"input-text qty text\" step=\"1\" min=\"0\" max=\"9999\" name=\"quantities\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6694, "\"", 6716, 1);
#line 86 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
WriteAttributeValue("", 6702, item.Quantity, 6702, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6717, 43, true);
                WriteLiteral(" title=\"SL\" size=\"4\" inputmode=\"numeric\">\r\n");
                EndContext();
                BeginContext(6881, 312, true);
                WriteLiteral(@"                                                    </div>
                                                </td>

                                                <td class=""product-subtotal"" data-title=""Tổng"">
                                                    <span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(7195, 54, false);
#line 92 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                              Write((item.Quantity * item.Product.Price).ToString("#,###"));

#line default
#line hidden
                EndContext();
                BeginContext(7250, 179, true);
                WriteLiteral(" &nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span>\r\n                                                </td>\r\n                                            </tr>\r\n");
                EndContext();
#line 95 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                        }

#line default
#line hidden
                BeginContext(7472, 620, true);
                WriteLiteral(@"
                                        <tr>
                                            <td colspan=""6"" class=""actions clear"">


                                                <div class=""continue-shopping pull-left text-left"">
                                                    <a class=""button-continue-shopping button primary is-outline"" href=""/products"">
                                                        ←&nbsp;Tiếp tục xem sản phẩm
                                                    </a>
                                                </div>

                                                ");
                EndContext();
                BeginContext(8092, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3946833945941098071fac5a152e487", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8227, 358, true);
                WriteLiteral(@"

                                                <input type=""hidden"" id=""woocommerce-cart-nonce"" name=""woocommerce-cart-nonce"" value=""80c4360d54""><input type=""hidden"" name=""_wp_http_referer"" value=""/cart/"">
                                            </td>
                                        </tr>

                                    </tbody>
");
                EndContext();
#line 114 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(8693, 577, true);
                WriteLiteral(@"                                    <div class=""text-center pt pb"">
                                        <div class=""woocommerce-notices-wrapper""></div><p class=""cart-empty woocommerce-info"">Chưa có sản phẩm nào trong giỏ hàng.</p>		<p class=""return-to-shop"">
                                            <a class=""button primary wc-backward"" href=""/products"">
                                                Quay trở lại cửa hàng
                                            </a>
                                        </p>
                                    </div>
");
                EndContext();
#line 124 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                }

#line default
#line hidden
                BeginContext(9305, 90, true);
                WriteLiteral("                            </table>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9402, 28, true);
            WriteLiteral("\r\n                </div>\r\n\r\n");
            EndContext();
#line 130 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                 if (cart != null)
                {

#line default
#line hidden
            BeginContext(9485, 1054, true);
            WriteLiteral(@"                    <div class=""cart-collaterals large-5 col pb-0"">

                        <div class=""cart-sidebar col-inner "">
                            <div class=""cart_totals "">

                                <table cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th class=""product-name"" colspan=""2"" style=""border-width:3px;"">Cộng giỏ hàng</th>
                                        </tr>
                                    </thead>
                                </table>

                                <h2>Cộng giỏ hàng</h2>

                                <table cellspacing=""0"" class=""shop_table shop_table_responsive"">

                                    <tbody>
                                        <tr class=""cart-subtotal"">
                                            <th>Tạm tính</th>
                                            <td data-title=""Tạm tính""><span class=""woo");
            WriteLiteral("commerce-Price-amount amount\">");
            EndContext();
            BeginContext(10540, 23, false);
#line 152 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                                               Write(total.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(10563, 754, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></td>
                                        </tr>




                                        <tr class=""woocommerce-shipping-totals shipping "">
                                            <td class=""shipping__inner"" colspan=""2"">
                                                <table class=""shipping__table "">
                                                    <tbody>
                                                        <tr>
                                                            <th>Giao hàng</th>
                                                            <td data-title=""Giao hàng"">
                                                                Free
");
            EndContext();
            BeginContext(12500, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(49641, 597, true);
            WriteLiteral(@"
                                                            </td>
                                                        </tr>
                                                    </tbody>

                                                </table>
                                            </td>
                                        </tr>
                                        <tr class=""order-total"">
                                            <th>Tổng</th>
                                            <td data-title=""Tổng""><strong><span class=""woocommerce-Price-amount amount"">");
            EndContext();
            BeginContext(50239, 23, false);
#line 463 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                                                                                                                   Write(total.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(50262, 590, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></strong> </td>
                                        </tr>


                                    </tbody>
                                </table>

                                <div class=""wc-proceed-to-checkout"">

                                    <a href=""/checkout"" class=""checkout-button button alt wc-forward"">
                                        Tiến hành thanh toán
                                    </a>
                                </div>



                            </div>
");
            EndContext();
            BeginContext(51375, 139, true);
            WriteLiteral("                            <div class=\"cart-sidebar-content relative\"></div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 488 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Cart.cshtml"
                }

#line default
#line hidden
            BeginContext(51533, 146, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"cart-footer-content after-cart-content relative\"></div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.Pages.WeedkendPage.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.CartModel>)PageContext?.ViewData;
        public Weedkend.Pages.WeedkendPage.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
