#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b067df4dd822f09996e4dff9b88b8fae8de28111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.Admin.Order.Pages_Admin_Order_ViewOrderDetail), @"mvc.1.0.razor-page", @"/Pages/Admin/Order/ViewOrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Order/ViewOrderDetail.cshtml", typeof(Weedkend.Pages.Admin.Order.Pages_Admin_Order_ViewOrderDetail), @"/viewOrderDetail")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/viewOrderDetail")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b067df4dd822f09996e4dff9b88b8fae8de28111", @"/Pages/Admin/Order/ViewOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Order_ViewOrderDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "viewOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrderDetail.cshtml"
  
    ViewData["Title"] = "Order Detail";
    Layout = "~/Pages/Shared/_LayoutAdmin.cshtml";
    var products = Model.Products;

#line default
#line hidden
            BeginContext(202, 111, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Chi tiết đơn hàng</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(314, 62, false);
#line 15 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.OrdersDetail.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(376, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(420, 58, false);
#line 18 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.OrdersDetail.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(478, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            <p>Tổng đơn</p>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(580, 29, false);
#line 24 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrderDetail.cshtml"
       Write(Model.Total.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(609, 105, true);
            WriteLiteral(" VNĐ\r\n        </dd>\r\n        <dt>\r\n            <p>Sản phẩm</p>\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(715, 17, false);
#line 30 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Order\ViewOrderDetail.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(732, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(899, 45, true);
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(944, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a53cb1b6de724cd09f48c4b3ba1c48ae", async() => {
                BeginContext(969, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(985, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.ViewOrderDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.ViewOrderDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.ViewOrderDetailModel>)PageContext?.ViewData;
        public Weedkend.ViewOrderDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
