#pragma checksum "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925d37660ef4410a8f21c57ec1b2963cf9d83164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VisitorApi_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
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
#line 3 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncomentDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925d37660ef4410a8f21c57ec1b2963cf9d83164", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf8530f335610412f21c49f2d5f1be63c4a9662e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_VisitorApi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VisitorViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Api Ziyaretçi Listesi</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad</th>
        <th>Soyad</th>
        <th>Şehir</th>
        <th>Ülke</th>
        <th>Mail</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.VisitorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
           Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 690, "\"", 744, 2);
            WriteAttributeValue("", 697, "/Admin/VisitorApi/DeleteVisitor/", 697, 32, true);
#nullable restore
#line 29 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 729, item.VisitorID, 729, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 809, "\"", 863, 2);
            WriteAttributeValue("", 816, "/Admin/VisitorApi/UpdateVisitor/", 816, 32, true);
#nullable restore
#line 30 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 848, item.VisitorID, 848, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/VisitorApi/AddVisitor/\" class=\"btn btn-outline-primary\">Yeni Ziyaretçi Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VisitorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
