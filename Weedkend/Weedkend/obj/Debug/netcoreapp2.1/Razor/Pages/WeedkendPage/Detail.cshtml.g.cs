#pragma checksum "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c284bdbf9bfca7a89874c2fec37ced0877d89ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Detail), @"mvc.1.0.razor-page", @"/Pages/WeedkendPage/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WeedkendPage/Detail.cshtml", typeof(Weedkend.Pages.WeedkendPage.Pages_WeedkendPage_Detail), null)]
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
#line 1 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\_ViewImports.cshtml"
using Weedkend;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c284bdbf9bfca7a89874c2fec37ced0877d89ad", @"/Pages/WeedkendPage/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4956a47c66449323d868915f74efeec0536aff58", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WeedkendPage_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://classic.vn/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "buynow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Pages/Shared/_Weedkend.cshtml";
    var product = @Model.product;

#line default
#line hidden
            BeginContext(162, 538, true);
            WriteLiteral(@"
<div class=""page-title shop-page-title product-page-title"">
    <div class=""page-title-inner flex-row medium-flex-wrap container"">
        <div class=""flex-col flex-grow medium-text-center"">
            <div class=""is-large"">
                <nav class=""woocommerce-breadcrumb breadcrumbs""><a href=""https://classic.vn"">Trang chủ</a> <span class=""divider"">/</span> <a href=""https://classic.vn/shop/"">Shop</a> <span class=""divider""></span><span class=""divider"">/</span> <a href=""https://classic.vn/cua-hang/thuong-hieu/hanz-de-fuko/"">");
            EndContext();
            BeginContext(701, 15, false);
#line 13 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                                                                                                                                                                                                                             Write(product.ProName);

#line default
#line hidden
            EndContext();
            BeginContext(716, 67, true);
            WriteLiteral("</a></nav>\r\n            </div>\r\n        </div><!-- .flex-left -->\r\n");
            EndContext();
            BeginContext(3728, 850, true);
            WriteLiteral(@"    </div><!-- flex-row -->
</div>

<main id=""main"" class="""">

    <div class=""shop-container"">

        <div class=""container"">
            <div class=""woocommerce-notices-wrapper""></div>
        </div><!-- /.container -->
        <div class=""product type-product post-2313 status-publish first instock product_cat-dau-goi-dau-xa product_cat-hanz-de-fuko has-post-thumbnail shipping-taxable purchasable product-type-simple"">
            <div class=""product-main"">
                <div class=""row content-row row-divided row-large"">

                    <div id=""product-sidebar"" class=""col large-3 hide-for-medium shop-sidebar "">
                        <aside id=""search-4"" class=""widget widget_search"">
                            <span class=""widget-title shop-sidebar"">TÌM KIẾM SẢN PHẨM</span><div class=""is-divider small""></div>");
            EndContext();
            BeginContext(4578, 1116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6498fe42b0ff4d15927ee433c61c6266", async() => {
                BeginContext(4659, 1028, true);
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
                WriteLiteral("    ");
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
            BeginContext(5694, 36, true);
            WriteLiteral("\r\n                        </aside>\r\n");
            EndContext();
            BeginContext(20554, 683, true);
            WriteLiteral(@"                    </div><!-- col large-3 -->

                    <div class=""col large-9"">
                        <div class=""row"">
                            <div class=""large-6 col"">

                                <div class=""product-images relative mb-half has-hover woocommerce-product-gallery woocommerce-product-gallery--with-images woocommerce-product-gallery--columns-4 images"" data-columns=""4"" style=""opacity: 1;"">

                                    <div class=""badge-container is-larger absolute left top z-1"">
                                    </div>
                                    <div class=""image-tools absolute top show-on-hover right z-3"">
");
            EndContext();
            BeginContext(24155, 1331, true);
            WriteLiteral(@"                                    </div>

                                    <figure class=""woocommerce-product-gallery__wrapper product-gallery-slider slider slider-nav-small mb-half flickity-enabled"" data-flickity-options=""{
                &quot;cellAlign&quot;: &quot;center&quot;,
                &quot;wrapAround&quot;: true,
                &quot;autoPlay&quot;: false,
                &quot;prevNextButtons&quot;:true,
                &quot;adaptiveHeight&quot;: true,
                &quot;imagesLoaded&quot;: true,
                &quot;lazyLoad&quot;: 1,
                &quot;dragThreshold&quot; : 15,
                &quot;pageDots&quot;: false,
                &quot;rightToLeft&quot;: false       }"" tabindex=""0"">
                                        <div class=""flickity-viewport"" style=""height: 370.75px; touch-action: pan-y;"">
                                            <div class=""flickity-slider"" style=""left: 0px; transform: translateX(0%);"">
                                      ");
            WriteLiteral(@"          <div data-thumb=""https://classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-100x100.jpg"" class=""woocommerce-product-gallery__image slide first is-selected"" aria-selected=""true"" style=""position: absolute; left: 0%;"">
                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 25486, "\"", 25508, 1);
#line 241 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 25493, product.ImgUrl, 25493, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(25509, 206, true);
            WriteLiteral(">\r\n                                                        <picture width=\"460\" height=\"460\" class=\"wp-post-image skip-lazy\" title=\"hanz-de-fuko.natural-shampoo.1500x1500\" data-caption=\"\" data-large_image=\"");
            EndContext();
            BeginContext(25716, 14, false);
#line 242 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                                                                                                                      Write(product.ImgUrl);

#line default
#line hidden
            EndContext();
            BeginContext(25730, 148, true);
            WriteLiteral("\" data-large_image_width=\"460\" data-large_image_height=\"460\">\r\n                                                            <source type=\"image/webp\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 25878, "\"", 25996, 10);
#line 243 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 25887, product.ImgUrl, 25887, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 25902, ".webp,", 25903, 7, true);
#line 243 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue(" ", 25909, product.ImgUrl, 25910, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 25925, "300w,", 25926, 6, true);
#line 243 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue(" ", 25931, product.ImgUrl, 25932, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 25947, "100w,", 25948, 6, true);
#line 243 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue(" ", 25953, product.ImgUrl, 25954, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 25969, "280w,", 25970, 6, true);
#line 243 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue(" ", 25975, product.ImgUrl, 25976, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 25991, "400w", 25992, 5, true);
            EndWriteAttribute();
            BeginContext(25997, 107, true);
            WriteLiteral(" sizes=\"(max-width: 460px) 100vw, 460px\">\r\n                                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 26104, "\"", 26125, 1);
#line 244 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 26110, product.ImgUrl, 26110, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(26126, 34, true);
            WriteLiteral(" alt=\"\" data-caption=\"\" data-src=\"");
            EndContext();
            BeginContext(26161, 14, false);
#line 244 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                                   Write(product.ImgUrl);

#line default
#line hidden
            EndContext();
            BeginContext(26175, 20, true);
            WriteLiteral("\" data-large_image=\"");
            EndContext();
            BeginContext(26196, 14, false);
#line 244 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                                                                      Write(product.ImgUrl);

#line default
#line hidden
            EndContext();
            BeginContext(26210, 60, true);
            WriteLiteral("\" data-large_image_width=\"460\" data-large_image_height=\"460\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 26270, "\"", 26630, 10);
#line 244 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 26279, product.ImgUrl, 26279, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 26294, "460w,", 26295, 6, true);
#line 244 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue(" ", 26300, product.ImgUrl, 26301, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 26316, "300w,", 26317, 6, true);
            WriteAttributeValue(" ", 26322, "https://classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-100x100.jpg", 26323, 97, true);
            WriteAttributeValue(" ", 26419, "100w,", 26420, 6, true);
            WriteAttributeValue(" ", 26425, "https://classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-280x280.jpg", 26426, 97, true);
            WriteAttributeValue(" ", 26522, "280w,", 26523, 6, true);
            WriteAttributeValue(" ", 26528, "https://classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-400x400.jpg", 26529, 97, true);
            WriteAttributeValue(" ", 26625, "400w", 26626, 5, true);
            EndWriteAttribute();
            BeginContext(26631, 947, true);
            WriteLiteral(@" sizes=""(max-width: 460px) 100vw, 460px"">
                                                        </picture>
                                                    </a>
                                                </div>
                                            </div>
                                        </div><button class=""flickity-button flickity-prev-next-button previous"" type=""button"" disabled="""" aria-label=""Previous""><svg class=""flickity-button-icon"" viewBox=""0 0 100 100""><path d=""M 10,50 L 60,100 L 70,90 L 30,50  L 70,10 L 60,0 Z"" class=""arrow""></path></svg></button><button class=""flickity-button flickity-prev-next-button next"" type=""button"" disabled="""" aria-label=""Next""><svg class=""flickity-button-icon"" viewBox=""0 0 100 100""><path d=""M 10,50 L 60,100 L 70,90 L 30,50  L 70,10 L 60,0 Z"" class=""arrow"" transform=""translate(100, 100) rotate(180) ""></path></svg></button>
                                    </figure>

");
            EndContext();
            BeginContext(28002, 312, true);
            WriteLiteral(@"                                </div>


                            </div>


                            <div class=""product-info summary entry-summary col col-fit product-summary"">
                                <h1 class=""product-title product_title entry-title"">
                                    ");
            EndContext();
            BeginContext(28315, 15, false);
#line 265 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                               Write(product.ProName);

#line default
#line hidden
            EndContext();
            BeginContext(28330, 265, true);
            WriteLiteral(@"
                                </h1>

                                <div class=""price-wrapper"">
                                    <p class=""price product-page-price "">
                                        <span class=""woocommerce-Price-amount amount"">");
            EndContext();
            BeginContext(28596, 31, false);
#line 270 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                 Write(product.Price.ToString("#,###"));

#line default
#line hidden
            EndContext();
            BeginContext(28627, 190, true);
            WriteLiteral("&nbsp;<span class=\"woocommerce-Price-currencySymbol\">VNĐ</span></span>\r\n                                    </p>\r\n                                </div>\r\n\r\n\r\n                                ");
            EndContext();
            BeginContext(28817, 2306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b951865838d4bf6b246cf9e7f0db8a6", async() => {
                BeginContext(28956, 408, true);
                WriteLiteral(@"
                                    <div class=""sticky-add-to-cart-wrapper"">
                                        <div class=""sticky-add-to-cart"">
                                            <div class=""sticky-add-to-cart__product"">
                                                <picture class=""sticky-add-to-cart-img"">
                                                    <source type=""image/webp""");
                EndContext();
                BeginWriteAttribute("srcset", " srcset=\"", 29364, "\"", 29388, 1);
#line 280 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 29373, product.ImgUrl, 29373, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(29389, 59, true);
                WriteLiteral(">\r\n                                                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 29448, "\"", 29469, 1);
#line 281 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 29454, product.ImgUrl, 29454, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(29470, 167, true);
                WriteLiteral(">\r\n                                                </picture>\r\n                                                <div class=\"product-title-small hide-for-small\"><strong>");
                EndContext();
                BeginContext(29638, 15, false);
#line 283 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                   Write(product.ProName);

#line default
#line hidden
                EndContext();
                BeginContext(29653, 237, true);
                WriteLiteral("</strong></div><div class=\"price-wrapper\">\r\n                                                    <p class=\"price product-page-price \">\r\n                                                        <span class=\"woocommerce-Price-amount amount\">");
                EndContext();
                BeginContext(29891, 13, false);
#line 285 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                 Write(product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(29904, 320, true);
                WriteLiteral(@"&nbsp;<span class=""woocommerce-Price-currencySymbol"">VNĐ</span></span>
                                                    </p>
                                                </div>
                                            </div>
                                            <div class=""quantity buttons_added"">
");
                EndContext();
                BeginContext(30440, 221, true);
                WriteLiteral("                                                <input type=\"number\" id=\"quantity_5df2095668c07\" class=\"input-text qty text\" step=\"1\" min=\"1\" max=\"9999\" name=\"quantity\" value=\"1\" title=\"SL\" size=\"4\" inputmode=\"numeric\">\r\n");
                EndContext();
                BeginContext(30774, 342, true);
                WriteLiteral(@"                                            </div>

                                            <button type=""submit"" name=""add-to-cart"" value=""2313"" class=""single_add_to_cart_button button alt"">Mua hàng</button>

                                        </div>
                                    </div>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 275 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                     WriteLiteral(product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(31123, 267, true);
            WriteLiteral(@"



                            </div><!-- .summary -->


                        </div><!-- .row -->
                        <div class=""product-footer"">

                            <div class=""woocommerce-tabs wc-tabs-wrapper container tabbed-content"">
");
            EndContext();
            BeginContext(32115, 333, true);
            WriteLiteral(@"                                <div class=""tab-panels"">
                                    <div class=""woocommerce-Tabs-panel woocommerce-Tabs-panel--description panel entry-content active"" id=""tab-description"" role=""tabpanel"" aria-labelledby=""tab-title-description"">


                                        <h2>Thông tin về ");
            EndContext();
            BeginContext(32449, 15, false);
#line 322 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                    Write(product.ProName);

#line default
#line hidden
            EndContext();
            BeginContext(32464, 97, true);
            WriteLiteral(":</h2>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(32562, 19, false);
#line 324 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                       Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(32581, 137, true);
            WriteLiteral("\r\n                                        </p>\r\n                                        <p><img class=\"alignnone size-full wp-image-3185\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 32718, "\"", 32739, 1);
#line 326 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 32724, product.ImgUrl, 32724, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(32740, 32, true);
            WriteLiteral(" alt=\"\" width=\"460\" height=\"460\"");
            EndContext();
            BeginWriteAttribute("srcset", " srcset=\"", 32772, "\"", 32802, 2);
#line 326 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
WriteAttributeValue("", 32781, product.ImgUrl, 32781, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 32796, "l460w", 32797, 6, true);
            EndWriteAttribute();
            BeginContext(32803, 3, true);
            WriteLiteral(" , ");
            EndContext();
            BeginContext(32807, 14, false);
#line 326 "C:\Users\dungh\Desktop\Weedkend\Weedkend\Weedkend\Pages\WeedkendPage\Detail.cshtml"
                                                                                                                                                                            Write(product.ImgUrl);

#line default
#line hidden
            EndContext();
            BeginContext(32821, 519, true);
            WriteLiteral(@" 300w, https: //classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-100x100.jpg 100w, https: //classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-280x280.jpg 280w, https: //classic.vn/wp-content/uploads/2017/04/hanz-de-fuko.natural-shampoo.1500x1500-400x400.jpg 400w"" sizes=""(max-width: 460px) 100vw, 460px""></p>
                                        <p>&nbsp;</p>
                                        <p>&nbsp;</p>
                                    </div>
");
            EndContext();
            BeginContext(38371, 120, true);
            WriteLiteral("                                </div><!-- .tab-panels -->\r\n                            </div><!-- .tabbed-content -->\r\n");
            EndContext();
            BeginContext(118610, 237, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div><!-- col large-9 -->\r\n\r\n                </div><!-- .row -->\r\n            </div><!-- .product-main -->\r\n        </div>\r\n\r\n\r\n    </div><!-- shop container -->\r\n\r\n</main>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Weedkend.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Weedkend.DetailModel>)PageContext?.ViewData;
        public Weedkend.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
