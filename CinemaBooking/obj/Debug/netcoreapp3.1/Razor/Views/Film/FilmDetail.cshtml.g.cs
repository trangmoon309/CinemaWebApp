#pragma checksum "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67c7bf33457852227b776cd52a52abe0c0da165"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_FilmDetail), @"mvc.1.0.view", @"/Views/Film/FilmDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67c7bf33457852227b776cd52a52abe0c0da165", @"/Views/Film/FilmDetail.cshtml")]
    public class Views_Film_FilmDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaBooking.ViewModels.Film.MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/filmdetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger my-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookingTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
  
    ViewData["Title"] = "FilmDetail";
    Layout = "~/Pages/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f67c7bf33457852227b776cd52a52abe0c0da1655823", async() => {
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
            WriteLiteral("\r\n<div id=\"ContainerHL\">\r\n    <div id=\"MainPoster\" class=\"col-md-3\">\r\n");
#nullable restore
#line 16 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
           
            var photoPath = "/imgs/films/" + (@Model.Photo ?? "default.jpg");
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 511, "\"", 527, 1);
#nullable restore
#line 19 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
WriteAttributeValue("", 517, photoPath, 517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" />\r\n        <div id=\"Ratings\">\r\n            <table>\r\n                <tr>\r\n                    <td><b><span style=\"color:rgb(200,170,30);\">Thời lượng:</span></b></td>\r\n                    <td><b>");
#nullable restore
#line 24 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                      Write(Model.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><b><span style=\"color:rgb(200,170,30);\">Đạo diễn:</span></b></td>\r\n                    <td><b>");
#nullable restore
#line 28 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                      Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><b><span style=\"color:rgb(200,170,30);\">Diễn viên:</span></b></td>\r\n                    <td><b>");
#nullable restore
#line 32 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                      Write(Model.Star);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                </tr>\r\n                <tr>\r\n                    <td><b><span style=\"color:rgb(200,170,30);\">Thể loại:</span></b></td>\r\n                    <td><b>");
#nullable restore
#line 36 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                      Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                </tr>\r\n\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div id=\"TitleHL\" class=\"col-md-9\" style=\"padding-left:0\"><b>");
#nullable restore
#line 44 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></div>

</div>
    <div id=""SelMovie"">
        <div id=""MovieInfoMain"">
            <div id=""Title""><b> </b></div>
            <div id=""UserRating""></div>
            <div id=""DetailsTop""></div>
            <div id=""DetailsTopCover""></div>
            <div id=""DetailsBottom""></div>
            <div id=""DetailsBottomCover""></div>
            <div id=""Details"">
                <p>");
#nullable restore
#line 56 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                 if (Model.Schedule.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-danger\">Hiện không có khung giờ nào trong hôm nay cho bộ phim này!</p>\r\n");
#nullable restore
#line 60 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Các khung giờ đang được công chiêu trong hôm nay:</p>\r\n");
#nullable restore
#line 64 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                    for (int i = 0; i < Model.Schedule.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67c7bf33457852227b776cd52a52abe0c0da16511952", async() => {
                WriteLiteral("\r\n                             ");
#nullable restore
#line 70 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                        Write(Model.Schedule[i].fromTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-TimeID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                                   WriteLiteral(Model.Schedule[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TimeID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TimeID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TimeID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MovieID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MovieID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MovieID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Film\FilmDetail.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n<div id=BTN_Back>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f67c7bf33457852227b776cd52a52abe0c0da16515866", async() => {
                WriteLiteral("BACK");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaBooking.ViewModels.Film.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
