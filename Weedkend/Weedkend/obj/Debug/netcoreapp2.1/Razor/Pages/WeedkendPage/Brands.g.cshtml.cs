#pragma checksum "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96471bfc71f21c72a93cc2218a1130a7530be644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Brands), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/Brands.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/Brands.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Brands), @"/brands")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/brands")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96471bfc71f21c72a93cc2218a1130a7530be644", @"/Pages/WeedkendPage/Brands.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_Brands : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml"
  
    ViewData["Title"] = "Brands";
    Layout = "~/Pages/Shared/_Weedkend.cshtml";

#line default
#line hidden
            BeginContext(156, 1533, true);
            WriteLiteral(@"

<div class=""shop-page-title category-page-title page-title "">

    <div class=""page-title-inner flex-row  medium-flex-wrap container"">
        <div class=""flex-col flex-grow medium-text-center"">
            <div class=""is-large"">
                <nav class=""woocommerce-breadcrumb breadcrumbs"">
                    <a href=""/"">Trang chủ</a>
                    <span class=""divider"">/</span>
                    <a href=""/products"">Shop</a>
                    <span class=""divider"">/</span>
                    Thương Hiệu
                </nav>
            </div>
            <div class=""category-filtering category-filter-row show-for-medium"">
                <a href=""#"" data-open=""#shop-sidebar"" data-visible-after=""true"" data-pos=""left"" class=""filter-button uppercase plain"">
                    <i class=""icon-menu""></i>
                    <strong>Lọc</strong>
                </a>
                <div class=""inline-block"">
                </div>
            </div>
        </div><!-- .flex");
            WriteLiteral(@"-left -->


    </div><!-- flex-row -->
</div><!-- .page-title -->

<div class=""row category-page-row"">

    <div class=""col large-3 hide-for-medium "">
        <div id=""shop-sidebar"" class=""sidebar-inner col-inner"">
            <aside id=""woocommerce_product_categories-3"" class=""widget woocommerce widget_product_categories"">
                <span class=""widget-title shop-sidebar"">DANH MỤC ThƯƠNG HIỆU</span><div class=""is-divider small""></div>
                <ul class=""product-categories"">
");
            EndContext();
#line 43 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml"
                     foreach (var item in Model.Brands)
                    {
                        var ClassId = "cat-item " + item.BrandId + " cat-parent has-child";

#line default
#line hidden
            BeginContext(1862, 27, true);
            WriteLiteral("                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=", 1889, "", 1904, 1);
#line 46 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml"
WriteAttributeValue("", 1896, ClassId, 1896, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1904, 53, true);
            WriteLiteral(" aria-expanded=\"false\">\r\n                            ");
            EndContext();
            BeginContext(1957, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9caa4fdb3b92462d81791d7061ca924a", async() => {
                BeginContext(2005, 14, false);
#line 47 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml"
                                                                      Write(item.BrandName);

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
#line 47 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml"
                                                 WriteLiteral(item.BrandId);

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
            BeginContext(2023, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 49 "D:\Study\C#\Projects\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brands.cshtml"
                    }

#line default
#line hidden
            BeginContext(2079, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3832, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14641, 174, true);
            WriteLiteral("                    <li class=\"cat-item cat-item-66\"><a href=\"https://classic.vn/cua-hang/hot-combo/\">Combo Khuyến Mãi</a></li>\r\n                </ul>\r\n            </aside>\r\n");
            EndContext();
            BeginContext(16511, 85, true);
            WriteLiteral("        </div><!-- .sidebar-inner -->\r\n    </div><!-- #shop-sidebar -->\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.Pages.WeedkendPage.BrandsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.BrandsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.BrandsModel>)PageContext?.ViewData;
        public Weedkend.Pages.WeedkendPage.BrandsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
