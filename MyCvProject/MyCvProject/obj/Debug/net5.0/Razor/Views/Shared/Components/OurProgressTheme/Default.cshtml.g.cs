#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6654ba1a16fe24f76f2214d311eeddb1c6a82834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OurProgressTheme_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OurProgressTheme/Default.cshtml")]
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
#line 1 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
using MyCvProjectEntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6654ba1a16fe24f76f2214d311eeddb1c6a82834", @"/Views/Shared/Components/OurProgressTheme/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_OurProgressTheme_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ability>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
  
    int counter = 1;
    string className = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"single-gd my-5 tech-btm\">\r\n    <h4>My Progress</h4>\r\n");
#nullable restore
#line 11 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
     foreach (var item in Model)
    {
        if (counter % 5 == 1)
        {
            className = "progress-bar progress-bar-striped";
        }
        else if (counter % 5 == 2)
        {
            className = "progress-bar progress-bar-striped bg-success";
        }
        else if (counter % 5 == 3)
        {
            className = "progress-bar progress-bar-striped bg-info";
        }
        else if (counter % 5 == 4)
        {
            className = "progress-bar progress-bar-striped bg-warning";
        }
        else if (counter % 5 == 0)
        {
            className = "progress-bar progress-bar-striped bg-danger";
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 34 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"progress\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 942, "\"", 960, 1);
#nullable restore
#line 36 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
WriteAttributeValue("", 950, className, 950, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 980, "\"", 1007, 3);
            WriteAttributeValue("", 988, "width:", 988, 6, true);
#nullable restore
#line 36 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
WriteAttributeValue(" ", 994, item.Level, 995, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1006, "%", 1006, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1008, "\"", 1035, 1);
#nullable restore
#line 36 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"
WriteAttributeValue("", 1024, item.Level, 1024, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\"\r\n             aria-valuemax=\"100\"></div>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\Components\OurProgressTheme\Default.cshtml"

        counter++;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ability>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591