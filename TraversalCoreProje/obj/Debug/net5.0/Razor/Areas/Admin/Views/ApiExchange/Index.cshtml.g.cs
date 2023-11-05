#pragma checksum "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a2e2acb52b2e6c327b4fd87844431e7f3383e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiExchange_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a2e2acb52b2e6c327b4fd87844431e7f3383e4", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf8530f335610412f21c49f2d5f1be63c4a9662e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ApiExchange_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingExchangeViewModel2.Exchange_Rates>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking Api Kur Bilgileri</h1>\r\n<br />\r\n<table class=\"table table-striped\">\r\n    >\r\n    <tr>\r\n        <th>Kur Adı</th>\r\n        <th>Kur Oranı</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 18 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
           Write(item.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
           Write(item.exchange_rate_buy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\User\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingExchangeViewModel2.Exchange_Rates>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
