#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ed68385b2203782e8129cd72a02a08da66b1aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Brand), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/Brand.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/Brand.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Brand), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ed68385b2203782e8129cd72a02a08da66b1aee", @"/Pages/WeedkendPage/Brand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_Brand : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
  
    ViewData["Title"] = "Brand";
    Layout = "~/Pages/Shared/_Weedkend.cshtml";

#line default
#line hidden
            BeginContext(144, 608, true);
            WriteLiteral(@"<div class=""shop-page-title category-page-title page-title "">

    <div class=""page-title-inner flex-row  medium-flex-wrap container"">
        <div class=""flex-col flex-grow medium-text-center"">
            <div class=""is-large"">
                <nav class=""woocommerce-breadcrumb breadcrumbs"">
                    <a href=""/"">Trang chủ</a>
                    <span class=""divider"">/</span>
                    <a href=""/products"">Shop</a>
                    <span class=""divider"">/</span>
                    <a href=""/Brands"">Thương Hiệu </a>
                    <span class=""divider"">/</span>");
            EndContext();
            BeginContext(753, 46, false);
#line 18 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                                             Write(Model.Products[0].ProBrandNavigation.BrandName);

#line default
#line hidden
            EndContext();
            BeginContext(799, 498, true);
            WriteLiteral(@"
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
        </div><!-- .flex-left -->
");
            EndContext();
            BeginContext(2225, 569, true);
            WriteLiteral(@"<!-- .flex-right -->

    </div><!-- flex-row -->
</div><!-- .page-title -->

<main id=""main"" class="""">
    <div class=""row category-page-row"">

        <div class=""col large-3 hide-for-medium "">
            <div id=""shop-sidebar"" class=""sidebar-inner col-inner"">
                <aside id=""woocommerce_product_categories-3"" class=""widget woocommerce widget_product_categories"">
                    <span class=""widget-title shop-sidebar"">DANH MỤC ThƯƠNG HIỆU</span><div class=""is-divider small""></div>
                    <ul class=""product-categories"">
");
            EndContext();
#line 57 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                         foreach (var item in Model.Brands)
                        {
                            var ClassId = "cat-item " + item.BrandId + " cat-parent has-child";

#line default
#line hidden
            BeginContext(2979, 31, true);
            WriteLiteral("                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=", 3010, "", 3025, 1);
#line 60 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
WriteAttributeValue("", 3017, ClassId, 3017, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3025, 57, true);
            WriteLiteral(" aria-expanded=\"false\">\r\n                                ");
            EndContext();
            BeginContext(3082, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9f28da9fe244f88ab7fe7c63badaea5", async() => {
                BeginContext(3130, 14, false);
#line 61 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
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
#line 61 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
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
            BeginContext(3148, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 63 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                        }

#line default
#line hidden
            BeginContext(3212, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5025, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(16315, 175, true);
            WriteLiteral("                    </ul>\r\n                </aside>\r\n            </div><!-- .sidebar-inner -->\r\n        </div><!-- #shop-sidebar -->\r\n\r\n\r\n\r\n        <div class=\"col large-9\">\r\n");
            EndContext();
#line 174 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
             if (Model.Products != null)
            {

#line default
#line hidden
            BeginContext(16547, 224, true);
            WriteLiteral("                <div class=\"shop-container\">\r\n                    <div class=\"woocommerce-notices-wrapper\"></div>\r\n                    <div class=\"products row row-small large-columns-4 medium-columns-3 small-columns-2\">\r\n\r\n");
            EndContext();
#line 180 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                         foreach (var item in Model.Products)
                        {
                            var productClass = "product-small col has-hover product type-product " + item.ProductId + " has-post-thumbnail shipping-taxable purchasable product-type-simple";
                            var imgURL = "/img/product/" + item.ImgUrl;
                            

#line default
#line hidden
            BeginContext(17181, 32, true);
            WriteLiteral("                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 17213, "\"", 17234, 1);
#line 185 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
WriteAttributeValue("", 17221, productClass, 17221, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(17235, 408, true);
            WriteLiteral(@">
                                <div class=""col-inner"">

                                    <div class=""badge-container absolute left top z-1"">
                                    </div>
                                    <div class=""product-small box "">
                                        <div class=""box-image"">
                                            <div class=""image-fade_in_back"">
");
            EndContext();
            BeginContext(17703, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(17751, 1178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1ef7583c4fb47149b03806509b02764", async() => {
                BeginContext(17801, 158, true);
                WriteLiteral("\r\n                                                    <picture width=\"300\" height=\"300\" class=\"attachment-woocommerce_thumbnail size-woocommerce_thumbnail\">\r\n");
                EndContext();
                BeginContext(18689, 60, true);
                WriteLiteral("                                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 18749, "\"", 18762, 1);
#line 198 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
WriteAttributeValue("", 18755, imgURL, 18755, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(18763, 162, true);
                WriteLiteral(" alt=\"\" sizes=\"(max-width: 300px) 100vw, 300px\">\r\n                                                    </picture>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 194 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                                                                      WriteLiteral(item.ProductId);

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
            BeginContext(18929, 56, true);
            WriteLiteral("\r\n                                            </div>\r\n\r\n");
            EndContext();
            BeginContext(22383, 934, true);
            WriteLiteral(@"                                            <div class=""image-tools is-small hide-for-small bottom left show-on-hover"">
                                            </div>
                                            <div class=""image-tools grid-tools text-center hide-for-small bottom hover-slide-in show-on-hover"">
                                                <a class=""quick-view quick-view-added"" data-prod=""2313"" href=""#quick-view"">Quick View</a>
                                            </div>
                                        </div><!-- box-image -->

                                        <div class=""box-text box-text-products text-center grid-style-2"">
                                            <div class=""title-wrapper"">
                                                <p class=""category uppercase is-smaller no-text-overflow product-cat op-7"">
                                                    ");
            EndContext();
            BeginContext(23318, 49, false);
#line 254 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                                               Write(Model.Products[0].CategoryNavigation.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(23367, 56, true);
            WriteLiteral("\r\n                                                </p>\r\n");
            EndContext();
            BeginContext(23483, 134, true);
            WriteLiteral("                                                <p class=\"name product-title\"><a href=\"https://classic.vn/shop/dau-goi-hanz-de-fuko/\">");
            EndContext();
            BeginContext(23618, 12, false);
#line 257 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                                                                                                                                 Write(item.ProName);

#line default
#line hidden
            EndContext();
            BeginContext(23630, 203, true);
            WriteLiteral("</a></p>\r\n                                            </div><div class=\"price-wrapper\">\r\n                                                <span class=\"price\"><span class=\"woocommerce-Price-amount amount\">");
            EndContext();
            BeginContext(23834, 10, false);
#line 259 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                                                                                                             Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(23844, 359, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></span>
                                            </div>
                                        </div><!-- box-text -->
                                    </div><!-- box -->
                                </div><!-- .col-inner -->
                            </div><!-- col -->
");
            EndContext();
#line 265 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
                        }

#line default
#line hidden
            BeginContext(24230, 75, true);
            WriteLiteral("                    </div>\r\n                </div><!-- shop container -->\r\n");
            EndContext();
#line 268 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(24353, 50, true);
            WriteLiteral("                <p> No Product in this brand</p>\r\n");
            EndContext();
#line 272 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Brand.cshtml"
            }

#line default
#line hidden
            BeginContext(24418, 55, true);
            WriteLiteral("        </div>\r\n\r\n\r\n    </div>\r\n\r\n</main><!-- #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.Pages.WeedkendPage.BrandModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.BrandModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.Pages.WeedkendPage.BrandModel>)PageContext?.ViewData;
        public Weedkend.Pages.WeedkendPage.BrandModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
