#pragma checksum "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7345ea63388d6d3b567e7687246567c895ccbdd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PSE_Index), @"mvc.1.0.view", @"/Views/PSE/Index.cshtml")]
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
#line 1 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\_ViewImports.cshtml"
using MyProjet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\_ViewImports.cshtml"
using MyProjet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7345ea63388d6d3b567e7687246567c895ccbdd3", @"/Views/PSE/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PSE_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
 foreach (var parent in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 5 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
   Write(parent.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <ul>\r\n");
#nullable restore
#line 7 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
         foreach (var child in parent.Sales)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 9 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
           Write(child.PricePerUnit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <ul>\r\n");
#nullable restore
#line 11 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
                 foreach (var grandChild in child.Employees)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 13 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
                   Write(grandChild.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 16 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 18 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\PSE\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
