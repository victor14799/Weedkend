#pragma checksum "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a0955f042859effd3df2111e7074ee4db6d6607"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_ProductPage), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/ProductPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/ProductPage.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_ProductPage), @"/products")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/products")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0955f042859effd3df2111e7074ee4db6d6607", @"/Pages/WeedkendPage/ProductPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_ProductPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://classic.vn/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
  
    ViewData["Title"] = "Product Page";
    Layout = "~/Pages/Shared/_Weedkend.cshtml";
    var Products = @Model.Products;

#line default
#line hidden
            BeginContext(187, 327, true);
            WriteLiteral(@"
<div class=""row category-page-row"">

    <div class=""col large-3 hide-for-medium "">
        <div id=""shop-sidebar"" class=""sidebar-inner col-inner"">
            <aside id=""search-5"" class=""widget widget_search"">
                <span class=""widget-title shop-sidebar"">TÌM KIẾM</span><div class=""is-divider small""></div>");
            EndContext();
            BeginContext(514, 972, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0110abb5d924e13a34b32b0373f9444", async() => {
                BeginContext(595, 884, true);
                WriteLiteral(@"
                    <div class=""flex-row relative"">
                        <div class=""flex-col flex-grow"">
                            <input type=""search"" class=""search-field mb-0"" name=""s"" value="""" id=""s"" placeholder=""Tìm kiếm…"" autocomplete=""off"">
                        </div><!-- .flex-col -->
                        <div class=""flex-col"">
                            <button type=""submit"" class=""ux-search-submit submit-button secondary button icon mb-0"">
                                <i class=""icon-search""></i>
                            </button>
                        </div><!-- .flex-col -->
                    </div><!-- .flex-row -->
                    <div class=""live-search-results text-left z-top""><div class=""autocomplete-suggestions"" style=""position: absolute; display: none; max-height: 300px; z-index: 9999;""></div></div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1486, 24, true);
            WriteLiteral("\r\n            </aside>\r\n");
            EndContext();
            BeginContext(16718, 144, true);
            WriteLiteral("        </div><!-- .sidebar-inner -->\r\n    </div><!-- #shop-sidebar -->\r\n\r\n    <div class=\"col large-9\">\r\n        <div class=\"shop-container\">\r\n");
            EndContext();
            BeginContext(17004, 65, true);
            WriteLiteral("\r\n\r\n            <div class=\"woocommerce-notices-wrapper\"></div>\r\n");
            EndContext();
#line 161 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
             if (Products != null)
            {

#line default
#line hidden
            BeginContext(17120, 103, true);
            WriteLiteral("                <div class=\"products row row-small large-columns-4 medium-columns-3 small-columns-2\">\r\n");
            EndContext();
#line 164 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
                     foreach (var item in Products)
                    {

#line default
#line hidden
            BeginContext(17299, 671, true);
            WriteLiteral(@"                        <div class=""product-small col has-hover product type-product post-1176 status-publish first instock product_cat-luoc-tao-kieu product_cat-phu-kien-toc has-post-thumbnail shipping-taxable purchasable product-type-simple"">
                            <div class=""col-inner"">

                                <div class=""badge-container absolute left top z-1"">
                                </div>
                                <div class=""product-small box "">
                                    <div class=""box-image"">
                                        <div class=""image-fade_in_back"">
                                            ");
            EndContext();
            BeginContext(17970, 871, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10264af1a175434a913962cf1ad9c8be", async() => {
                BeginContext(18022, 154, true);
                WriteLiteral("\r\n                                                <picture width=\"300\" height=\"300\" class=\"attachment-woocommerce_thumbnail size-woocommerce_thumbnail\">\r\n");
                EndContext();
                BeginContext(18543, 56, true);
                WriteLiteral("                                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 18599, "\"", 18617, 1);
#line 177 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
WriteAttributeValue("", 18605, item.ImgUrl, 18605, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(18618, 7, true);
                WriteLiteral(" alt=\"\"");
                EndContext();
                BeginWriteAttribute("srcset", " srcset=\"", 18625, "\"", 18689, 6);
#line 177 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
WriteAttributeValue("", 18634, item.ImgUrl, 18634, 12, false);

#line default
#line hidden
                WriteAttributeValue(" ", 18646, "300w,", 18647, 6, true);
#line 177 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
WriteAttributeValue(" ", 18652, item.ImgUrl, 18653, 12, false);

#line default
#line hidden
                WriteAttributeValue(" ", 18665, "100w,", 18666, 6, true);
#line 177 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
WriteAttributeValue(" ", 18671, item.ImgUrl, 18672, 12, false);

#line default
#line hidden
                WriteAttributeValue(" ", 18684, "280w", 18685, 5, true);
                EndWriteAttribute();
                BeginContext(18690, 147, true);
                WriteLiteral(" sizes=\"(max-width: 300px) 100vw, 300px\">\r\n                                                </picture>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 174 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
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
            BeginContext(18841, 150, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"image-tools is-small top right show-on-hover\">\r\n");
            EndContext();
            BeginContext(21892, 213, true);
            WriteLiteral("                                        </div>\r\n                                        <div class=\"image-tools is-small hide-for-small bottom left show-on-hover\">\r\n                                        </div>\r\n");
            EndContext();
            BeginContext(22444, 405, true);
            WriteLiteral(@"                                    </div><!-- box-image -->

                                    <div class=""box-text box-text-products text-center grid-style-2"">
                                        <div class=""title-wrapper"">
                                            <p class=""category uppercase is-smaller no-text-overflow product-cat op-7"">
                                                ");
            EndContext();
            BeginContext(22850, 36, false);
#line 231 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
                                           Write(item.CategoryNavigation.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(22886, 128, true);
            WriteLiteral("\r\n                                            </p>\r\n                                            <p class=\"name product-title\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 23014, "\"", 23048, 3);
            WriteAttributeValue("", 23021, "/products/{", 23021, 11, true);
#line 233 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
WriteAttributeValue("", 23032, item.ProductId, 23032, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 23047, "}", 23047, 1, true);
            EndWriteAttribute();
            BeginContext(23049, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(23052, 12, false);
#line 233 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
                                                                                                            Write(item.ProName);

#line default
#line hidden
            EndContext();
            BeginContext(23064, 203, true);
            WriteLiteral("&amp;Guy</a></p>\r\n                                        </div><div class=\"price-wrapper\">\r\n                                            <span class=\"price\"><span class=\"woocommerce-Price-amount amount\">");
            EndContext();
            BeginContext(23268, 28, false);
#line 235 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
                                                                                                         Write(item.Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(23296, 339, true);
            WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span></span>
                                        </div>
                                    </div><!-- box-text -->
                                </div><!-- box -->
                            </div><!-- .col-inner -->
                        </div><!-- col -->
");
            EndContext();
#line 245 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
                                    
                    }

#line default
#line hidden
            BeginContext(24662, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 248 "C:\Users\PC\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\ProductPage.cshtml"
            }

#line default
#line hidden
            BeginContext(24701, 73, true);
            WriteLiteral("\r\n            <!-- shop container -->\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.ProductPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.ProductPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.ProductPageModel>)PageContext?.ViewData;
        public Weedkend.ProductPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
