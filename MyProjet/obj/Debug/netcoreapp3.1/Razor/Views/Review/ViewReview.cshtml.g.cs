#pragma checksum "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a019bc5038ed77fded3f6389ae887b1a711c126a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_ViewReview), @"mvc.1.0.view", @"/Views/Review/ViewReview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a019bc5038ed77fded3f6389ae887b1a711c126a", @"/Views/Review/ViewReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Review_ViewReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Review>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
  
    ViewData["Title"] = "ViewReview";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewReview</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ReviewID</th>\r\n        <th>Comment</th>\r\n        <th>ProductID</th>\r\n        <th>Reviewer</th>\r\n        <th>Rating</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
       Write(Model.ReviewID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
       Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
       Write(Model.Reviewer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
       Write(Model.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n<div style=\"display: block\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 543, 2);
            WriteAttributeValue("", 507, "/Review/UpdateReview/", 507, 21, true);
#nullable restore
#line 26 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Review\ViewReview.cshtml"
WriteAttributeValue("", 528, Model.ReviewID, 528, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update this Review</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Review> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
