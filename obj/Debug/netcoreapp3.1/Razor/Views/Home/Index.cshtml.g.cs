#pragma checksum "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b151688e193bae306efcfa84dd65f9a2dc52559b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\_ViewImports.cshtml"
using AS_ChefDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\_ViewImports.cshtml"
using AS_ChefDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b151688e193bae306efcfa84dd65f9a2dc52559b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bd907dcdbd650ad84dc0c04060f82c0ae46144", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <a href=""dishes"" class=""btn btn-outline-success"">Dishes</a><br>
    <a href=""new"" class=""btn btn-outline-primary"">New Chef</a>

    <h2>Our Chef Team</h2>
    <table class=""table table-bordered"">
        <tr>
            <th>FirstName</th>
            <th>LastName</th>
            <th>DoB</th>
        </tr>

");
#nullable restore
#line 19 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml"
          
            foreach (Chef c in ViewBag.AllChefs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml"
                   Write(c.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml"
                   Write(c.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml"
                   Write(c.DoB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\ddkim\Desktop\Coding_Dojo\C#\CSharpORM\AS_ChefDishes\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>        \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591
