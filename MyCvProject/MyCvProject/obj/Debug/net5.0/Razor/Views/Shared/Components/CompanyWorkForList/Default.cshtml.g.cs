#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238478366cbe491cf725f9e1d349d8e775515927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CompanyWorkForList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CompanyWorkForList/Default.cshtml")]
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
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
using MyCvProjectEntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238478366cbe491cf725f9e1d349d8e775515927", @"/Views/Shared/Components/CompanyWorkForList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CompanyWorkForList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CompanyWorkFor>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
  
    string endDate = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6 card mt-3\">\r\n        <h3 class=\"card-title\">Experiences </h3>\r\n");
#nullable restore
#line 11 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 302, "\"", 319, 1);
#nullable restore
#line 13 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
WriteAttributeValue("", 308, item.Image, 308, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card-image\"\r\n             style=\"object-fit:fill;\r\n                    width:400px;\r\n                    height:100px;\r\n                    border: solid 1px #CCC\">\r\n");
            WriteLiteral("            <div class=\"card-body\">\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
                                                Write(item.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("  -\r\n");
#nullable restore
#line 23 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
                         if (item.EndDate != null)
                        {
                            endDate = @item.EndDate.ToString().Substring(0, 10);
                        }
                        else
                        {
                            endDate = "Devam Ediyor";
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"far fa-clock\"></i>   ");
#nullable restore
#line 31 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
                                                  Write(endDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <p class=\"card-text mb-3\">");
#nullable restore
#line 34 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
                                     Write(item.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 37 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\CompanyWorkForList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CompanyWorkFor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591