#pragma checksum "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58e3e334900e09713c75e4b8954fec5c504188e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewProduct), @"mvc.1.0.view", @"/Views/Product/ViewProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58e3e334900e09713c75e4b8954fec5c504188e0", @"/Views/Product/ViewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf3769524b1f3f1408335fc6162de5f8bb9c9f00", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_ViewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 3 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Information</h3>

<div style=""display: block"">
    <a href=""/Product/InsertProduct/"">Create a New Product</a>
</div>

<table class=""table"">
    <tr>
        <th>Product ID</th>
        <th>Name</th>
        <th>Price</th>
        <th>Category ID</th>
        <th>On Sale</th>
        <th>StockLevel</th>
    </tr>
    <tr>
        <td>");
#nullable restore
#line 19 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
       Write(Model.OnSale);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
       Write(Model.StockLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n   \r\n</table>\r\n <div style=\"display: block\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 640, "\"", 686, 2);
            WriteAttributeValue("", 647, "/Product/UpdateProduct/", 647, 23, true);
#nullable restore
#line 29 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
WriteAttributeValue("", 670, Model.ProductID, 670, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update this Product</a>\r\n </div>\r\n<div style=\"display: block\">\r\n");
#nullable restore
#line 32 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
     using (Html.BeginForm("DeleteProduct", "Product", "Post"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58e3e334900e09713c75e4b8954fec5c504188e06492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 34 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
                                            WriteLiteral(Model.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <input type=\"submit\" onclick=\"return confirm(\'Are you sure?\')\" value=\"Delete this product\" />\r\n");
#nullable restore
#line 36 "C:\Users\Ahmed\OneDrive\Desktop\C#-WORK\MyProject-CS\MyProjet\Views\Product\ViewProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591