#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c01e04c1910ba4106158d84104cc57542763638e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.Admin.Order.Pages_Admin_Order_ViewOrders), @"mvc.1.0.razor-page", @"/Pages/Admin/Order/ViewOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Order/ViewOrders.cshtml", typeof(Weedkend.Pages.Admin.Order.Pages_Admin_Order_ViewOrders), @"/viewOrder")]
namespace Weedkend.Pages.Admin.Order
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/viewOrder")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01e04c1910ba4106158d84104cc57542763638e", @"/Pages/Admin/Order/ViewOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Order_ViewOrders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "viewOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "~/Pages/Shared/_LayoutAdmin.cshtml";
    var Orders = Model.Orders;
    int count = 1;

#line default
#line hidden
            BeginContext(201, 315, true);
            WriteLiteral(@"
<h2>Danh sách đơn hàng</h2>

<table class=""table"">
    <thead>

        <tr>
            <th>STT</th>
            <th>Ngày đặt hàng</th>
            <th>Tên Khách Hàng</th>
            <th>Địa Chỉ</th>
            <th>Số điện thoại</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
         foreach (var item in Orders)
        {

#line default
#line hidden
            BeginContext(566, 63, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <p>");
            EndContext();
            BeginContext(631, 7, false);
#line 30 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
                   Write(count++);

#line default
#line hidden
            EndContext();
            BeginContext(639, 74, true);
            WriteLiteral("</p>\r\n                </td>\r\n                <td>\r\n                    <p>");
            EndContext();
            BeginContext(714, 13, false);
#line 33 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
                  Write(item.Datetime);

#line default
#line hidden
            EndContext();
            BeginContext(727, 71, true);
            WriteLiteral("</p>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(799, 52, false);
#line 36 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(851, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(919, 55, false);
#line 39 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(974, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1042, 51, false);
#line 42 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.PhoneNo));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1160, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0a91521f444438b7ff1b17c2b3b6c5", async() => {
                BeginContext(1219, 8, true);
                WriteLiteral("Chi tiết");
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
#line 45 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
                                                    WriteLiteral(item.OrderId);

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
            BeginContext(1231, 46, true);
            WriteLiteral(" |\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 48 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrders.cshtml"
        }

#line default
#line hidden
            BeginContext(1288, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.ViewOrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.ViewOrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.ViewOrdersModel>)PageContext?.ViewData;
        public Weedkend.ViewOrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
