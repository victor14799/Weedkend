#pragma checksum "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d5d13bbdf549fecbac48ebfd47a3045abc40fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_OrderSuccess), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/OrderSuccess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/OrderSuccess.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_OrderSuccess), @"/orderSuccess")]
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
#line 1 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\_ViewImports.cshtml"
using Weedkend;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/orderSuccess")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d5d13bbdf549fecbac48ebfd47a3045abc40fa7", @"/Pages/WeedkendPage/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_OrderSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
  
    ViewData["Title"] = "OrderSuccess";
    Layout = "~/Pages/Shared/_Weedkend.cshtml";
    var cart = Model.cart;

#line default
#line hidden
            BeginContext(183, 1137, true);
            WriteLiteral(@"
<div id=""content"" class=""content-area page-wrapper"" role=""main"">
    <div class=""row row-main"">
        <div class=""large-12 col"">
            <div class=""col-inner"">
                <div class=""woocommerce"">
                    <div class=""row"">
                        <div class=""large-7 col"">

                            <p>Trả tiền mặt khi giao hàng</p>
                            <section class=""woocommerce-order-details"">

                                <h2 class=""woocommerce-order-details__title"">Chi tiết đơn hàng</h2>

                                <table class=""woocommerce-table woocommerce-table--order-details shop_table order_details"">

                                    <thead>
                                        <tr>
                                            <th class=""woocommerce-table__product-name product-name"">Sản phẩm</th>
                                            <th class=""woocommerce-table__product-table product-total"">Tổng</th>
                           ");
            WriteLiteral("             </tr>\r\n                                    </thead>\r\n\r\n                                    <tbody>\r\n");
            EndContext();
#line 32 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                         if (cart != null)
                                        {
                                            foreach (var item in cart)
                                            {

#line default
#line hidden
            BeginContext(1542, 271, true);
            WriteLiteral(@"                                                <tr class=""woocommerce-table__line-item order_item"">

                                                    <td class=""woocommerce-table__product-name product-name"">
                                                        ");
            EndContext();
            BeginContext(1813, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6f386cc83a4d10857f59e80c852dcc", async() => {
                BeginContext(1874, 20, false);
#line 39 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                                                               Write(item.Product.ProName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                               WriteLiteral(item.Product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1898, 36, true);
            WriteLiteral(" <strong class=\"product-quantity\">× ");
            EndContext();
            BeginContext(1935, 13, false);
#line 39 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                                                                                                                            Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 287, true);
            WriteLiteral(@"</strong>
                                                    </td>

                                                    <td class=""woocommerce-table__product-total product-total"">
                                                        <span class=""woocommerce-Price-amount amount"">");
            EndContext();
            BeginContext(2237, 54, false);
#line 43 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                                                  Write((item.Product.Price * item.Quantity).ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(2292, 188, true);
            WriteLiteral("&nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span>\r\n                                                    </td>\r\n\r\n                                                </tr>\r\n");
            EndContext();
#line 47 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(2570, 312, true);
            WriteLiteral(@"                                    </tbody>

                                    <tfoot>
                                        <tr>
                                            <th scope=""row"">Tổng số phụ:</th>
                                            <td><span class=""woocommerce-Price-amount amount"">");
            EndContext();
            BeginContext(2883, 17, false);
#line 54 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                                         Write(ViewData["Total"]);

#line default
#line hidden
            EndContext();
            BeginContext(2900, 1027, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></td>
                                        </tr>
                                        <tr>
                                            <th scope=""row"">Giao nhận hàng:</th>
                                            <td><span class=""woocommerce-Price-amount amount"">0&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ (Free)</span></span>&nbsp;<small class=""shipped_via"">qua Giao hàng Toàn quốc</small></td>
                                        </tr>
                                        <tr>
                                            <th scope=""row"">Phương thức thanh toán:</th>
                                            <td>Trả tiền mặt khi nhận hàng COD</td>
                                        </tr>
                                        <tr>
                                            <th scope=""row"">Tổng cộng:</th>
                                            <td><span class=""woocommerce-Price-amount amoun");
            WriteLiteral("t\">");
            EndContext();
            BeginContext(3928, 17, false);
#line 66 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                                         Write(ViewData["Total"]);

#line default
#line hidden
            EndContext();
            BeginContext(3945, 905, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></td>
                                        </tr>
                                    </tfoot>
                                </table>

                            </section>


                        </div>

                        <div class=""large-5 col"">
                            <div class=""is-well col-inner entry-content"">
                                <p class=""success-color woocommerce-notice woocommerce-notice--success woocommerce-thankyou-order-received""><strong>Cảm ơn bạn. Đơn hàng của bạn đã được nhận.</strong></p>

                                <ul class=""woocommerce-order-overview woocommerce-thankyou-order-details order_details"">

                                    <li class=""woocommerce-order-overview__order order"">
                                        Mã đơn hàng:						<strong>");
            EndContext();
            BeginContext(4851, 19, false);
#line 83 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                               Write(Model.Order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(4870, 204, true);
            WriteLiteral("</strong>\r\n                                    </li>\r\n\r\n                                    <li class=\"woocommerce-order-overview__date date\">\r\n                                        Ngày:\t\t\t\t\t\t\t<strong>");
            EndContext();
            BeginContext(5075, 43, false);
#line 87 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                            Write(Model.Order.Datetime.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5118, 258, true);
            WriteLiteral(@"</strong>
                                    </li>


                                    <li class=""woocommerce-order-overview__total total"">
                                        Tổng cộng:						<strong><span class=""woocommerce-Price-amount amount"">");
            EndContext();
            BeginContext(5377, 17, false);
#line 92 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\OrderSuccess.cshtml"
                                                                                                                           Write(ViewData["Total"]);

#line default
#line hidden
            EndContext();
            BeginContext(5394, 726, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></strong>
                                    </li>

                                    <li class=""woocommerce-order-overview__payment-method method"">
                                        Phương thức thanh toán:							<strong>Trả tiền mặt khi nhận hàng COD</strong>
                                    </li>

                                </ul>

                                <div class=""clear""></div>
                            </div>
                        </div>



                    </div>
                </div>


            </div><!-- .col-inner -->
        </div><!-- .large-12 -->
    </div><!-- .row -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.OrderSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.OrderSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.OrderSuccessModel>)PageContext?.ViewData;
        public Weedkend.OrderSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
