#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0c90f00b5933d0b142dc350c2a13829f8bdc43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.Admin.Product.Pages_Admin_Product_Details), @"mvc.1.0.razor-page", @"/Pages/Admin/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Product/Details.cshtml", typeof(Weedkend.Pages.Admin.Product.Pages_Admin_Product_Details), null)]
namespace Weedkend.Pages.Admin.Product
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0c90f00b5933d0b142dc350c2a13829f8bdc43", @"/Pages/Admin/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Product_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(270, 51, false);
#line 16 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.ProName));

#line default
#line hidden
            EndContext();
            BeginContext(321, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(383, 47, false);
#line 19 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.ProName));

#line default
#line hidden
            EndContext();
            BeginContext(430, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(491, 49, false);
#line 22 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(540, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(602, 45, false);
#line 25 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(647, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
#line 27 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
          
            var imgUrl = "/images/" + Model.Product.ImgUrl;
        

#line default
#line hidden
            BeginContext(748, 43, true);
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(792, 50, false);
#line 31 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(842, 65, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 907, "\"", 920, 1);
#line 34 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
WriteAttributeValue("", 913, imgUrl, 913, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(921, 87, true);
            WriteLiteral(" height=\"300\" width=\"500\"/>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1009, 55, false);
#line 37 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1126, 51, false);
#line 40 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1238, 50, false);
#line 43 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1350, 46, false);
#line 46 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1457, 62, false);
#line 49 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.CategoryNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1581, 69, false);
#line 52 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.CategoryNavigation.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1711, 62, false);
#line 55 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.ProBrandNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1835, 66, false);
#line 58 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.ProBrandNavigation.BrandId));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1948, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ca54a3909444c38a679c9d6a789f7e", async() => {
                BeginContext(2009, 4, true);
                WriteLiteral("Edit");
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
#line 63 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\Admin\Product\Details.cshtml"
                           WriteLiteral(Model.Product.ProductId);

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
            BeginContext(2017, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2025, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ee517b4fac4f75ac74753d79a6283e", async() => {
                BeginContext(2047, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2063, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.Pages.Admin.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.Admin.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.Admin.DetailsModel>)PageContext?.ViewData;
        public Weedkend.Pages.Admin.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
