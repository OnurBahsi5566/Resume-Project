#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afa7f30a98fdc738ff90615cf5812f13cbe38521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectCategories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectCategories/Default.cshtml")]
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
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa7f30a98fdc738ff90615cf5812f13cbe38521", @"/Views/Shared/Components/ProjectCategories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectCategories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyProject>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n\r\n    <h4>Project Categories</h4>\r\n\r\n");
#nullable restore
#line 8 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 270, "\"", 313, 2);
            WriteAttributeValue("", 277, "/MyProject/GetMyProjectById/", 277, 28, true);
#nullable restore
#line 12 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
WriteAttributeValue("", 305, item.Id, 305, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 358, 1);
#nullable restore
#line 13 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
WriteAttributeValue("", 347, item.Image, 347, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 377, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                     style=""object-fit:fill;
                                        width:150px;
                                        height:100px;
                                        border: solid 1px #CCC"">
                </a>
            </div>
            <div class=""col-md-7 blog-grid-right"">
                <div class=""sub-meta"">
                    <span>
                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 23 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
                                              Write(item.ProjectCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <br />\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 969, "\"", 1012, 2);
            WriteAttributeValue("", 976, "/MyProject/GetMyProjectById/", 976, 28, true);
#nullable restore
#line 28 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
WriteAttributeValue("", 1004, item.Id, 1004, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 32 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
                                                Write(item.CreatedDate.ToString().Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\ProjectCategories\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
