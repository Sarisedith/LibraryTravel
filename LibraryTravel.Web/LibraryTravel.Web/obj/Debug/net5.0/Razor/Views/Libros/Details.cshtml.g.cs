#pragma checksum "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fffff398b316898caf7e902accfd0e986126378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libros_Details), @"mvc.1.0.view", @"/Views/Libros/Details.cshtml")]
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
#line 1 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\_ViewImports.cshtml"
using LibraryTravel.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\_ViewImports.cshtml"
using LibraryTravel.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fffff398b316898caf7e902accfd0e986126378", @"/Views/Libros/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece46cb7d7866700b668d308e8173aaec69f0161", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Libros_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryTravel.Domain.Models.Libros>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Books</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 14 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 18 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
       Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 22 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sinopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 26 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sinopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 30 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.N_Paginas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 34 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
       Write(Html.DisplayFor(model => model.N_Paginas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n</div>\n<p>\n    ");
#nullable restore
#line 40 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ISBN }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
#nullable restore
#line 41 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Libros\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryTravel.Domain.Models.Libros> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
