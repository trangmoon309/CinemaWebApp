#pragma checksum "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f7b21c291b03b0787f5a0a1566b7e58ee36a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f7b21c291b03b0787f5a0a1566b7e58ee36a10", @"/Views/Home/Main.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CinemaBooking.ViewModels.Film.MovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/mainpage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:28%; float:left;clear:both"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilmDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Film", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
  
    ViewData["Title"] = "Main";
    Layout = "~/Pages/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03f7b21c291b03b0787f5a0a1566b7e58ee36a105355", async() => {
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
#nullable restore
#line 16 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
  
    var firstPath = "~/imgs/films/" + (@Model[0].Photo ?? "default.jpg");
    List<CinemaBooking.Models.Category> categories = ViewBag.Categories;
    string typeFilm;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-container\">\r\n    <div class=\"main-carousel\">\r\n");
#nullable restore
#line 24 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
          
            string flag = "a";
            for (int i = 0; i < 6; i++)
            {
                var photoPath = "~/imgs/films/" + (@Model[i].Photo ?? "default.jpg");

                if (i == 1) flag = "b";
                if (i == 2) flag = "c";
                if (i == 3) flag = "d";
                if (i == 4) flag = "e";
                if (i == 5) flag = "f";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 989, "\"", 1012, 2);
            WriteAttributeValue("", 997, "main-item", 997, 9, true);
#nullable restore
#line 36 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
WriteAttributeValue(" ", 1006, flag, 1007, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-transform:uppercase\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03f7b21c291b03b0787f5a0a1566b7e58ee36a108197", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                  WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 39 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<div class=""prev btn btn-danger""><i class=""fa fa-arrow-left""></i></div>
<div class=""next btn btn-danger""><i class=""fa fa-arrow-right""></i></div>



<div class=""tile"" id=""tile-1"">

    <!-- Nav tabs -->
    <ul class=""nav nav-tabs nav-justified"" role=""tablist"">
        <div class=""slider""></div>
        <li class=""nav-item"">
            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true""><i class=""fa fa-film""></i> Phim đang chiếu</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false""><i class=""fa fa-camera""></i> Phim sắp chiếu</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#type"" role=""tab"" aria-controls=""profile"" aria-selected=""false""><i class=""fa fa-ellipsis-h ""></i> Thể loại</a>
        </li>");
            WriteLiteral("\n    </ul>\r\n\r\n    <!-- Tab panes -->\r\n    <div class=\"tab-content\" style=\"background-color: rgba(36,32,32,0.9)\">\r\n        <div class=\"tab-pane fade show active\" id=\"home\" role=\"tabpanel\" aria-labelledby=\"home-tab\">\r\n            <div class=\"movie-list\">\r\n");
#nullable restore
#line 69 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                  
                    for (int i = 0; i < Model.Count; i++)
                    {
                        var photoPath = "~/imgs/films/" + (@Model[i].Photo ?? "default.jpg");

                        //if (DateTime.Now >= Model[i].fromDate && DateTime.Now <= Model[i].toDate)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"movie-item row\" style=\"margin-bottom:20px;\">\r\n                                <div class=\"item-info col-md-9\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03f7b21c291b03b0787f5a0a1566b7e58ee36a1012677", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                  WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 78 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <div class=\"movie-description\" style=\"float:left;width:65%\">\r\n                                        <h5 style=\"text-transform:uppercase\">");
#nullable restore
#line 80 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                        Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <span>");
#nullable restore
#line 81 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                         Write(Model[i].Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hours | ");
#nullable restore
#line 81 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                Write(Model[i].Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n                                        <p style=\"font-size:14px;\">\r\n                                            <strong>Directed by</strong> ");
#nullable restore
#line 83 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                    Write(Model[i].Director);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                            <strong>Stars</strong> ");
#nullable restore
#line 84 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                              Write(Model[i].Star);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                            ");
#nullable restore
#line 85 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                       Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"item-timestamp col-md-3\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f7b21c291b03b0787f5a0a1566b7e58ee36a1017422", async() => {
                WriteLiteral("MUA VÉ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filmId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                                           WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filmId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f7b21c291b03b0787f5a0a1566b7e58ee36a1019992", async() => {
                WriteLiteral("XEM CHI TIẾT");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-filmId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                                           WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-filmId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["filmId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 94 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n        </div>\r\n        <div class=\"tab-pane fade\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n");
#nullable restore
#line 102 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
              
                for (int i = 0; i < Model.Count; i++)
                {
                    var photoPath = "~/imgs/films/" + (@Model[i].Photo ?? "default.jpg");

                    if (DateTime.Now < Model[i].fromDate)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"movie-item row\" style=\"margin-bottom:20px;\">\r\n                            <div class=\"item-info col-md-9\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03f7b21c291b03b0787f5a0a1566b7e58ee36a1023716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                              WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 111 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"movie-description\" style=\"float:left;width:65%\">\r\n                                    <h5 style=\"text-transform:uppercase\">");
#nullable restore
#line 113 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                    Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <span>");
#nullable restore
#line 114 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                     Write(Model[i].Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hours | ");
#nullable restore
#line 114 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                            Write(Model[i].Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n                                    <p style=\"font-size:14px;\">\r\n                                        <strong>Directed by</strong> ");
#nullable restore
#line 116 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                Write(Model[i].Director);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                        <strong>Stars</strong> ");
#nullable restore
#line 117 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                          Write(Model[i].Star);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                        ");
#nullable restore
#line 118 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                   Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                </div>
                            </div>
                            <div class=""item-timestamp col-md-3"">

                            </div>
                        </div>
");
#nullable restore
#line 126 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>

        <div class=""tab-pane fade"" id=""type"" role=""tabpanel"" aria-labelledby=""profile-tab"">

            <div class=""dropdown"">
                <a href=""javascript:void(0)"" class=""dropdown-toggle btn btn-primary"" data-toggle=""dropdown"" aria-expanded=""false""  style=""width:100%;background-color:#A12914;border:none"">
                    Thể loại
                </a>
                <ul class=""dropdown-menu animated fadeInUp "" style=""width:100%"">
");
#nullable restore
#line 138 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                      
                        for (int i = 0; i < categories.Count ;i++)
                        {
                            string cateid = "cate" + i.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a class=\"hvr-bounce-to-right\"");
            BeginWriteAttribute("id", " id=\"", 6648, "\"", 6660, 1);
#nullable restore
#line 143 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
WriteAttributeValue("", 6653, cateid, 6653, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 6661, "\"", 6696, 3);
            WriteAttributeValue("", 6671, "showMovieItem(\'#", 6671, 16, true);
#nullable restore
#line 143 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
WriteAttributeValue("", 6687, cateid, 6687, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6694, "\')", 6694, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 143 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                                                                                                           Write(categories[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 145 "D:\Self-learning\(3).C#\6.ASP.NET Core\CinemaBooking\CinemaWebApp\CinemaBooking\Views\Home\Main.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
            </div>
            <div class=""movie-result"">
                <div class=""result-content""></div>
            </div>
        </div>
    </div>
    <script type=""text/javascript"">

        var flag = true;
        //var newDiv = document.createElement(""div"")
        //newDiv.className = ""result-content""; 
        function showMovieItem(idItem) {
            $.ajax({
                type: 'GET',
                url: 'https://localhost:44307/api/Home/GetMovieByCate/' + $(idItem).text(),
                contentType: 'json',
                success: function (result) {
                    if (flag == false) {
                        $("".result-content"").empty();
                    }
                    $.each(result, function (index, val) {
                        var photoPath = ""/imgs/films/"" + val.photoPath;
                        var title = val.title;
                        var hour = val.hour;
                        var director = val.director;
 ");
            WriteLiteral(@"                       var star = val.star;
                        var description = val.description;

                        var content = $(
                            ' <div class=""movie-item row"" style=""margin-top:20px;"" > ' +
                            ' <div class=""item-info col-md-9""> ' +
                            '  <img src=""' + photoPath + '"" asp-append-version=""true"" style=""width:28%; float: left; clear: both"" /> ' +
                            '   <div class=""movie-description"" style=""float:left;width:65%""> ' +
                            '      <h5 style=""text-transform:uppercase"">' + title + '</h5>' +
                            '      <span>' + hour + 'hours | ' + $(idItem).text() + '</span> <br /> ' +
                            '     <p style=""font-size:14px;""> ' +
                            '        <strong>Directed by</strong> ' + director + ' <br /> ' +
                            '       <strong>Stars</strong> ' + star + '<br /> ' + description +
                      ");
            WriteLiteral(@"      '    </p> ' +
                            '   </div> ' +
                            '  </div > ' +
                            '  </div > ' +
                            ' <div class=""item-timestamp col-md-3""> ' +
                            '  </div > ');

                        $('.result-content').append(content);
                    });
                    $("".movie-result"").html($('.result-content'));
                    flag = false;
                }
            })
        };

    </script>

</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        var carousel = $("".main-carousel""),
            currdeg = 0;

        function swapImages() {
            currdeg = currdeg - 60;
            carousel.css({
                ""-webkit-transform"": ""rotateY("" + currdeg + ""deg)"",
                ""-moz-transform"": ""rotateY("" + currdeg + ""deg)"",
                ""-o-transform"": ""rotateY("" + currdeg + ""deg)"",
                ""transform"": ""rotateY("" + currdeg + ""deg)""
            });
        }

        function swapImages2() {
            currdeg = currdeg + 60;
            carousel.css({
                ""-webkit-transform"": ""rotateY("" + currdeg + ""deg)"",
                ""-moz-transform"": ""rotateY("" + currdeg + ""deg)"",
                ""-o-transform"": ""rotateY("" + currdeg + ""deg)"",
                ""transform"": ""rotateY("" + currdeg + ""deg)""
            });
        }

        setInterval(swapImages, 2500);

        $("".next"").on(""click"", swapImages);

        $("".prev"").on(""click"", swapImages2);

        $(""#tile-1 .n");
                WriteLiteral(@"av-tabs a"").click(function () {
            var position = $(this).parent().position();
            var width = $(this).parent().width();
            $(""#tile-1 .slider"").css({ ""left"": + position.left, ""width"": width });
        });
        var actWidth = $(""#tile-1 .nav-tabs"").find("".active"").parent(""li"").width();
        var actPosition = $(""#tile-1 .nav-tabs .active"").position();
        $(""#tile-1 .slider"").css({ ""left"": + actPosition.left, ""width"": actWidth });



    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CinemaBooking.ViewModels.Film.MovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
