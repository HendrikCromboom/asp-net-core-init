#pragma checksum "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "742a9a93cf15338852a3aa4a5ba5e19dfd5c0224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(asp_net_core_init.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace asp_net_core_init.Pages
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
#line 1 "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\_ViewImports.cshtml"
using asp_net_core_init;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742a9a93cf15338852a3aa4a5ba5e19dfd5c0224", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afef81c02e6ba854e23607e1b6a847ad30594e16", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\Index.cshtml"
  
    ViewData["Title"] = "Some random shop";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Some random shop</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\"card-columns\">\r\n");
#nullable restore
#line 13 "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\Index.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 422, "\"", 470, 4);
            WriteAttributeValue("", 430, "background-image:", 430, 17, true);
            WriteAttributeValue(" ", 447, "url(\'", 448, 6, true);
#nullable restore
#line 16 "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\Index.cshtml"
WriteAttributeValue("", 453, product.Image, 453, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 467, "\');", 467, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>  \r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Hendrik Cromboom\source\repos\asp-net-core-init\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
