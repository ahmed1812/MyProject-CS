#pragma checksum "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a83c6844e8d6d3594a76b4b1fdf62164b3b9a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sale_Index), @"mvc.1.0.view", @"/Views/Sale/Index.cshtml")]
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
#line 1 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\_ViewImports.cshtml"
using MyProjet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\_ViewImports.cshtml"
using MyProjet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a83c6844e8d6d3594a76b4b1fdf62164b3b9a6", @"/Views/Sale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Sale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyProjet.Models.Sale>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div style=\"display: block\">\r\n    <a href=\"/Sale/InsertSale/\">Create a New Sale</a>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SalesID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PricePerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                \r\n                <a");
            BeginWriteAttribute("href", " href=", 1015, "", 1049, 2);
            WriteAttributeValue("", 1021, "/Sale/ViewSale/", 1021, 15, true);
#nullable restore
#line 41 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
WriteAttributeValue("", 1036, item.SalesID, 1036, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
                                                Write(item.SalesID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PricePerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 60 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 61 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Sale\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyProjet.Models.Sale>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
