#pragma checksum "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89f541a742d5099588cb69062859d5b8a4a680d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89f541a742d5099588cb69062859d5b8a4a680d", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ec19881daa9c406a3e822741c8d3bb751aacdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    img{border-radius:50%;}

</style>

<h1>Rehber Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Görsel</th>
        <th>Ad Soyad</th>
        <th>Açıklama</th>
        <th>Durum</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 24 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
     foreach(var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 570, "\"", 587, 1);
#nullable restore
#line 29 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 576, item.Image, 576, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
              
                if (item.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 844, 2);
            WriteAttributeValue("", 805, "/Admin/Guide/ChangeToFalse/", 805, 27, true);
#nullable restore
#line 35 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 832, item.GuidID, 832, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 36 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 985, "\"", 1030, 2);
            WriteAttributeValue("", 992, "/Admin/Guide/ChangeToTrue/", 992, 26, true);
#nullable restore
#line 39 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1018, item.GuidID, 1018, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap</a></td>\r\n");
#nullable restore
#line 40 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a href=\"/Admin/Guide/EditGuide/\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/Guide/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Girişi</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591