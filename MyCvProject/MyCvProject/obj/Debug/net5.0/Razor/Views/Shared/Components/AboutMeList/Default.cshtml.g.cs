#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\AboutMeList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b861825d9695ac189ab73e64b41719f3861b195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutMeList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutMeList/Default.cshtml")]
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
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\AboutMeList\Default.cshtml"
using MyCvProjectEntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b861825d9695ac189ab73e64b41719f3861b195", @"/Views/Shared/Components/AboutMeList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutMeList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutMe>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\AboutMeList\Default.cshtml"
  
    string details = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 footer-grid-agileits-w3ls text-left\">\r\n    <h3>About ME</h3>\r\n");
#nullable restore
#line 9 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\AboutMeList\Default.cshtml"
     if (Model.Details.Length >= 180)
    {
        details = @Model.Details.Substring(0, Model.Details.Substring(0, 180).LastIndexOf(" ")) + "...";
    }
    else
    {
        details = @Model.Details;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 17 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\AboutMeList\Default.cshtml"
  Write(details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"read\">\r\n        <a href=\"/AboutMe/Index/\" class=\"btn btn-primary read-m\">Read More</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutMe> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
