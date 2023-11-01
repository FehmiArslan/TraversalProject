#pragma checksum "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb921f272b78925dc527556218e33e5e2399150f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb921f272b78925dc527556218e33e5e2399150f", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ec19881daa9c406a3e822741c8d3bb751aacdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcı Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad Soyad</th>
        <th>Kullanıcı Adı</th>
        <th>Mail</th>
        <th>Sil</th>
        <th>Düzenle</th>
        <th>Yorumlar</th>
        <th>Tur Geçmişi</th>
    </tr>

");
#nullable restore
#line 24 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 27 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
              sayac = sayac + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 28 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
           Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 30 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 723, "\"", 761, 2);
            WriteAttributeValue("", 730, "/Admin/User/DeleteUser/", 730, 23, true);
#nullable restore
#line 33 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 753, item.Id, 753, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 826, "\"", 862, 2);
            WriteAttributeValue("", 833, "/Admin/User/EditUser/", 833, 21, true);
#nullable restore
#line 34 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 854, item.Id, 854, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 971, 2);
            WriteAttributeValue("", 939, "/Admin/User/CommentUser/", 939, 24, true);
#nullable restore
#line 35 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 963, item.Id, 963, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Yorumlar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1039, "\"", 1082, 2);
            WriteAttributeValue("", 1046, "/Admin/User/ReservationUser/", 1046, 28, true);
#nullable restore
#line 36 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1074, item.Id, 1074, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\">Tur Geçmişi</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Login/SignUp/\" class=\"btn btn-outline-primary\">Yeni Kullanıcı Kaydı</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
