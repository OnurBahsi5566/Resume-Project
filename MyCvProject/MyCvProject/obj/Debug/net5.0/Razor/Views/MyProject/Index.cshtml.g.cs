#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb0602f27813f0edeed70ce79678945c2ae32d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyProject_Index), @"mvc.1.0.view", @"/Views/MyProject/Index.cshtml")]
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
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb0602f27813f0edeed70ce79678945c2ae32d1", @"/Views/MyProject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MyProject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyProject>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MyCvLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ol class=""breadcrumb"">
    <li class=""breadcrumb-item"">
        <a href=""/MyProject/Index"">Home</a>
    </li>
    <li class=""breadcrumb-item active"">Projects</li>
</ol>

<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Project Informations</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 23 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 825, 2);
            WriteAttributeValue("", 789, "/MyProject/GetMyProjectById/", 789, 28, true);
#nullable restore
#line 26 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
WriteAttributeValue("", 817, item.Id, 817, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 865, "\"", 882, 1);
#nullable restore
#line 27 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
WriteAttributeValue("", 871, item.Image, 871, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 914, "\"", 920, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                 style=""object-fit:fill;
                                        width:400px;
                                        height:200px;
                                        border: solid 1px #CCC"">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1389, "\"", 1432, 2);
            WriteAttributeValue("", 1396, "/MyProject/GetMyProjectById/", 1396, 28, true);
#nullable restore
#line 36 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
WriteAttributeValue("", 1424, item.Id, 1424, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 37 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                                                                           Write(item.CreatedDate.ToString().Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n                                    <li class=\"mx-2\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1748, "\"", 1791, 2);
            WriteAttributeValue("", 1755, "/MyProject/GetMyProjectById/", 1755, 28, true);
#nullable restore
#line 41 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
WriteAttributeValue("", 1783, item.Id, 1783, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 42 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                                       Write(await Component.InvokeAsync("CommentCountByMyProjectId", new { myProjectId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2102, "\"", 2145, 2);
            WriteAttributeValue("", 2109, "/MyProject/GetMyProjectById/", 2109, 28, true);
#nullable restore
#line 46 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
WriteAttributeValue("", 2137, item.Id, 2137, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 47 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                                                                  Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a href=\"single.html\">");
#nullable restore
#line 53 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                                                     Write(item.Name.Substring(0,item.Name.Substring(0,25).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 55 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                                                     Write(item.Description.Substring(0,item.Description.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2782, "\"", 2825, 2);
            WriteAttributeValue("", 2789, "/MyProject/GetMyProjectById/", 2789, 28, true);
#nullable restore
#line 56 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
WriteAttributeValue("", 2817, item.Id, 2817, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 59 "C:\projelerim\MyCvProject\MyCvProject\Views\MyProject\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyProject>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
