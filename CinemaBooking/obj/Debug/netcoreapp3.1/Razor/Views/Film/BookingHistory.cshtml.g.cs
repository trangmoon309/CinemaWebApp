#pragma checksum "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01359784c58937bf1f41fcf7123b05419f22d79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_BookingHistory), @"mvc.1.0.view", @"/Views/Film/BookingHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01359784c58937bf1f41fcf7123b05419f22d79", @"/Views/Film/BookingHistory.cshtml")]
    public class Views_Film_BookingHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CinemaBooking.ViewModels.Film.BookingHistoryViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bookinghistory.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListFilm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
  
    ViewData["Title"] = "BookingHistory";
    Layout = "~/Pages/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b01359784c58937bf1f41fcf7123b05419f22d794870", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 15 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
     if (Model.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""rwd-table"" style=""text-align:center;"">
            <tbody>
                <tr>
                    <th>Mã vé</th>
                    <th>Ngày đặt</th>
                    <th>Họ tên</th>
                    <th>Số điện thoại</th>
                    <th>Tên phim</th>
                    <th>Thời gian</th>
                    <th>Số lượng</th>
                    <th>Tổng tiền</th>
                </tr>
");
#nullable restore
#line 29 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                 for (int i = 0; i < Model.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td data-th=\"Supplier Code\">\r\n                        ");
#nullable restore
#line 33 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].IDTicket);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Supplier Name\">\r\n                        ");
#nullable restore
#line 36 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].BookingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Invoice Number\">\r\n                        ");
#nullable restore
#line 39 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Invoice Date\">\r\n                        ");
#nullable restore
#line 42 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Due Date\">\r\n                        ");
#nullable restore
#line 45 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Net Amount\">\r\n                        ");
#nullable restore
#line 48 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].FromTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Due Date\">\r\n                        ");
#nullable restore
#line 51 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td data-th=\"Net Amount\">\r\n                        ");
#nullable restore
#line 54 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                   Write(Model[i].Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <h3 style=\"margin-top: 20px;\" class=\"text-flicker-out-glow\"><i class=\" fa fa-heart\" style=\"color: #BD2F16;\"></i> Cảm ơn đã tin tưởng chúng tôi  <i class=\" fa fa-heart\" style=\"color: #BD2F16;\"></i></h3>\r\n");
#nullable restore
#line 61 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Bạn chưa đặt vé nào</h5>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01359784c58937bf1f41fcf7123b05419f22d7911074", async() => {
                WriteLiteral(" Đặt vé ngay ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\BookingHistory.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CinemaBooking.ViewModels.Film.BookingHistoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
