#pragma checksum "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931d48d8e76fd23f69e73876f1130f0864ec8c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\_ViewImports.cshtml"
using BakerProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\_ViewImports.cshtml"
using BakerProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931d48d8e76fd23f69e73876f1130f0864ec8c7f", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73601a3035110e8fab0070cb4cf801a6133aa50e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/shop/shop-img-10-604x684.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/shop/shop-img-3-604x684.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/shop/shop-img-6-604x684.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ShopLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<main>
    <div class=""header-img""
         style=""padding-top: 10%; padding-bottom: 10%; background-image: url(/../assets/images/shop/shop-title-area.jpg);"">
        <div class=""text-sm-center"">
            <h2 style=""font-size: 50px; color: white;"">SHOP</h2>
            <p style=""font-size: 16px; color: white;"">Experienced and Friendly</p>
        </div>
    </div>
    <section id=""products"" class=""pb-5"">
        <div class=""container "">
            <div class=""row "" style=""padding-right: 25%;"">
");
#nullable restore
#line 19 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                 if (Model != null && Model.Products.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                     for (var i = 0; i < Model.Products.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-4 cardimg\" data-ci-target=\"");
#nullable restore
#line 23 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                                 Write(Model.Products[i].CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-id=\"");
#nullable restore
#line 23 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                                                                         Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" style="" z-index: 1;"">
                            <div class=""card text-center ""
                         style="" width: 18rem; border: none; line-height: 30px; cursor: pointer;"">
                                <div class=""position-relative"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "931d48d8e76fd23f69e73876f1130f0864ec8c7f9453", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1209, "~/assets/images/shop/", 1209, 21, true);
#nullable restore
#line 27 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 1230, Model.Products[i].Image, 1230, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931d48d8e76fd23f69e73876f1130f0864ec8c7f11156", async() => {
                WriteLiteral("\r\n                                    <button type=\"submit\" data-target=\"");
#nullable restore
#line 29 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" class=""position-absolute h-0 addcart""
                                 style=""transition: 0.3s ease; border:none; left: 21.5%; cursor: pointer; bottom: 1px; background-color: #181818;  padding: 0px 35px; font-size: 14px;"">
                                        <span class=""text-light"" style=""transition: 0.3s ease;"">ADD TO CART</span>
                                    </button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                                                                         WriteLiteral(Model.Products[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n\r\n                                <div class=\"card-body\">\r\n                                    <small style=\"font-size: 14px;\">");
#nullable restore
#line 37 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                               Write(Model.Products[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                    <h5 class=\"card-title text-dark\">");
#nullable restore
#line 38 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                                Write(Model.Products[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text text-dark\">$");
#nullable restore
#line 39 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                               Write(Model.Products[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 43 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""cat "" style=""position: absolute; padding-left: 65%; padding-top: 5%;"">
                    <ul>
                        <li>
                            <h4 class=""text-dark"" style=""letter-spacing: 2px; font-size: 20px; "">CATEGORIES</h4>
                        </li>
                        <li class=""sidebtn btnall"">All</li>
");
#nullable restore
#line 52 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                         if (Model != null && Model.Categories.Count > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                             foreach (var item in Model.Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-id=\"");
#nullable restore
#line 56 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"sidebtn catbtns\">");
#nullable restore
#line 56 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 57 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\asger\Desktop\BakerProject\BakerProject\Views\Shop\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"pt-5\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "931d48d8e76fd23f69e73876f1130f0864ec8c7f18587", async() => {
                WriteLiteral("\r\n                                <div class=\"d-flex search-product\">\r\n                                    <input type=\"text\" placeholder=\"Search Products...\"");
                BeginWriteAttribute("name", " name=\"", 3457, "\"", 3464, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3465, "\"", 3470, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button class=\"text-uppercase\"><i class=\"las la-search\"></i></button>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                        <li class=""pt-5 pb-3"">
                            <h4 class=""text-dark"" style=""letter-spacing: 2px; font-size: 20px; "">
                                FILTER BY PRICE
                            </h4>
                            <input type=""range"">
                        </li>
                        <li>Price: $40 — $190</li>
                        <li class=""pt-3"">
                            <a class=""filter""");
            BeginWriteAttribute("href", " href=\"", 4141, "\"", 4148, 0);
            EndWriteAttribute();
            WriteLiteral(@">FILTER</a>
                        </li>
                        <li class=""mt-5"">
                            <h4 class=""text-dark"" style=""letter-spacing: 2px; font-size: 20px; "">
                                BEST
                                PRODUCTS
                            </h4>
                        </li>
                        <li class=""mt-4"">
                            <ul>
                                <li>
                                    <div class=""d-flex"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "931d48d8e76fd23f69e73876f1130f0864ec8c7f21709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"d-flex flex-column\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4891, "\"", 4898, 0);
            EndWriteAttribute();
            WriteLiteral(@">Spanish Bread</a>
                                            <div class=""star-rating"" role=""img"" aria-label=""Rated 3.00 out of 5"">
                                                <span style=""width:100%""></span>
                                            </div>
                                            <p class=""price"">$150.00 <br> $115.00</p>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class=""d-flex"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "931d48d8e76fd23f69e73876f1130f0864ec8c7f23807", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"d-flex flex-column\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5718, "\"", 5725, 0);
            EndWriteAttribute();
            WriteLiteral(@">Spanish Bread</a>
                                            <div class=""star-rating"" role=""img"" aria-label=""Rated 3.00 out of 5"">
                                                <span style=""width:100%""></span>
                                            </div>
                                            <p class=""price"">$150.00 <br> $115.00</p>
                                        </div>
                                    </div>
                                </li>
                                <li>
                                    <div class=""d-flex"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "931d48d8e76fd23f69e73876f1130f0864ec8c7f25905", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <div class=\"d-flex flex-column\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 6545, "\"", 6552, 0);
            EndWriteAttribute();
            WriteLiteral(@">Spanish Bread</a>
                                            <div class=""star-rating"" role=""img"" aria-label=""Rated 3.00 out of 5"">
                                                <span style=""width:100%""></span>
                                            </div>
                                            <p class=""price"">$150.00 <br> $115.00</p>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
