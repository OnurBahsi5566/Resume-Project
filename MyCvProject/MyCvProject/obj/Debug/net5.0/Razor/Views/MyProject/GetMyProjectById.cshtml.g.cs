#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b0b39b946d8ca7c615260281859708207b834e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyProject_GetMyProjectById), @"mvc.1.0.view", @"/Views/MyProject/GetMyProjectById.cshtml")]
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
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\_ViewImports.cshtml"
using MyCvProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projelerim\MyCvProject\MyCvProject\Views\_ViewImports.cshtml"
using MyCvProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b0b39b946d8ca7c615260281859708207b834e", @"/Views/MyProject/GetMyProjectById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MyProject_GetMyProjectById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyProject>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
  
    ViewData["Title"] = "GetMyProjectById";
    Layout = "~/Views/Shared/_MyCvLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--\r\n    Author: W3layouts\r\n    Author URL: http://w3layouts.com\r\n    License: Creative Commons Attribution 3.0 Unported\r\n    License URL: http://creativecommons.org/licenses/by/3.0/\r\n-->\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b0b39b946d8ca7c615260281859708207b834e3887", async() => {
                WriteLiteral(@"
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
                    <div class=""blog-grid-top"">
                        <div class=""b-grid-top"">
                            <div class=""blog_info_left_grid"">
                                <a href=""single.html"">
                                    <img");
                BeginWriteAttribute("src", " src=\"", 889, "\"", 907, 1);
#nullable restore
#line 31 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
WriteAttributeValue("", 895, Model.Image, 895, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 926, "\"", 932, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 38 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                                                                           Write(Model.CreatedDate.ToString().Substring(0,10));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            ");
#nullable restore
#line 48 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                                       Write(await Component.InvokeAsync("CommentCountByMyProjectId", new { myProjectId = @Model.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </a>
                                    </li>

                                </ul>
                            </div>
                        </div>

                        <h3>
                            <a href=""single.html"">");
#nullable restore
#line 57 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 57 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                                                          Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(")  </a>\r\n                        </h3>\r\n                        <p>\r\n                            ");
#nullable restore
#line 60 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        <a href=\"/MyProject/Index\" class=\"btn btn-primary read-m\">Back Projects</a>\r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 65 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
               Write(await Component.InvokeAsync("CommentListByMyProjectId", new { myProjectId = ViewBag.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 67 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
               Write(await Html.PartialAsync("/Views/Comment/AddCommentPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>

                <!--//left-->
                <!--right-->
                <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                    <div class=""right-blog-info text-left"">

                        ");
#nullable restore
#line 75 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsletterPerson/AddNewsletterPerson.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 77 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 79 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                   Write(await Component.InvokeAsync("MostLikedProjectList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 81 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                   Write(await Component.InvokeAsync("OurProgressTheme"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 83 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\GetMyProjectById.cshtml"
                   Write(await Component.InvokeAsync("RecentProject"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                </aside>\r\n                <!--//right-->\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!--//main-->\r\n    <!---->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProject> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
