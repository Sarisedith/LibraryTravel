#pragma checksum "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b49f76e468b29e284a51b34aa7f7a254d2587f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editoriales_Delete), @"mvc.1.0.view", @"/Views/Editoriales/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b49f76e468b29e284a51b34aa7f7a254d2587f", @"/Views/Editoriales/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece46cb7d7866700b668d308e8173aaec69f0161", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Editoriales_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LibraryTravel.Domain.Models.Editoriales>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
   ViewBag.Title = "Delete"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Editorials</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 13 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 17 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 21 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sede));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 25 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sede));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n\n");
#nullable restore
#line 29 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-actions no-color\">\n                    <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n                    ");
#nullable restore
#line 35 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
               Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>");
#nullable restore
#line 36 "C:\Users\Sara\Source\Repos\LibraryTravel\LibraryTravel.Web\LibraryTravel.Web\Views\Editoriales\Delete.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibraryTravel.Domain.Models.Editoriales> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
