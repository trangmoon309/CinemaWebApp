#pragma checksum "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\ConfirmInfo\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999ee7137eda8017182074e8691dbdead7c99574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConfirmInfo_Error), @"mvc.1.0.view", @"/Views/ConfirmInfo/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999ee7137eda8017182074e8691dbdead7c99574", @"/Views/ConfirmInfo/Error.cshtml")]
    public class Views_ConfirmInfo_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\ConfirmInfo\Error.cshtml"
  
    ViewData["Title"] = "Error";
    Layout = "~/Pages/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lỗi: ");
#nullable restore
#line 7 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\ConfirmInfo\Error.cshtml"
    Write(ViewBag.MessageError);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
