#pragma checksum "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c70da4fe0ef9ea1c58ebd781bd66ef0dd44fe1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tables_EmployeeBestSale), @"mvc.1.0.view", @"/Views/Tables/EmployeeBestSale.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c70da4fe0ef9ea1c58ebd781bd66ef0dd44fe1d", @"/Views/Tables/EmployeeBestSale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tables_EmployeeBestSale : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeSale>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>8- Retrieve the name and title of the employees who have made sales for each department in the current year (2018), sorted by department name and then by employee name:</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Product Name</th>
            <th>Average Rating</th>
            <th>Product Name</th>
            <th>Average Rating</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml"
               Write(x.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml"
               Write(x.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml"
               Write(x.LName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml"
               Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Ahmed\OneDrive\Desktop\MyProject-CS\MyProjet\Views\Tables\EmployeeBestSale.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeSale>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
