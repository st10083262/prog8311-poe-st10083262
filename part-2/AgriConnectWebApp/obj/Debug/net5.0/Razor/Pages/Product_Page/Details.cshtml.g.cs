#pragma checksum "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0875067ce74179c654fdc3650f45c58f7fb2346d1e69cd0d8ec13f42519cfca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgriConnectWebApp.Pages.Product_Page.Pages_Product_Page_Details), @"mvc.1.0.razor-page", @"/Pages/Product_Page/Details.cshtml")]
namespace AgriConnectWebApp.Pages.Product_Page
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\_ViewImports.cshtml"
using AgriConnectWebApp

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\_ViewImports.cshtml"
using AgriConnectWebApp.Data

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e0875067ce74179c654fdc3650f45c58f7fb2346d1e69cd0d8ec13f42519cfca", @"/Pages/Product_Page/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a81e8b2fca31cdbe29a158c8ddc773ff60a59d211d3d9565e704c762e5be3c37", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Product_Page_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 15 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayNameFor(model => model.Product.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 18 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayFor(model => model.Product.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 21 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayNameFor(model => model.Product.Category)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 24 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayFor(model => model.Product.Category)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 27 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayNameFor(model => model.Product.ProductionDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 30 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayFor(model => model.Product.ProductionDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 33 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayNameFor(model => model.Product.Farmer)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 36 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
             Html.DisplayFor(model => model.Product.Farmer.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0875067ce74179c654fdc3650f45c58f7fb2346d1e69cd0d8ec13f42519cfca7811", async() => {
                WriteLiteral("Edit");
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
            WriteLiteral(
#nullable restore
#line 41 "C:\Users\yashi\3D Objects\Visual Studio\PROG7311\Kaitlyn Naidoo\AgriConnectWebApp\Pages\Product_Page\Details.cshtml"
                                        Model.Product.ProductId

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0875067ce74179c654fdc3650f45c58f7fb2346d1e69cd0d8ec13f42519cfca10067", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgriConnectWebApp.Pages.Product_Page.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgriConnectWebApp.Pages.Product_Page.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgriConnectWebApp.Pages.Product_Page.DetailsModel>)PageContext?.ViewData;
        public AgriConnectWebApp.Pages.Product_Page.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
