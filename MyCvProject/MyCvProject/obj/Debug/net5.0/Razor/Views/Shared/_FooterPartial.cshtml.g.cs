#pragma checksum "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2297ace38afb369c829e560152be7bea7333b336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2297ace38afb369c829e560152be7bea7333b336", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd05c955600468869b5c2211f6d7a6c88bb8fc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/NewsletterPerson/AddNewsletterPerson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer>\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t");
#nullable restore
#line 4 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\_FooterPartial.cshtml"
       Write(await Component.InvokeAsync("AboutMeList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\r\n\t\t\t");
#nullable restore
#line 6 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\_FooterPartial.cshtml"
       Write(await Component.InvokeAsync("GetLast3Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t<!-- subscribe -->\r\n\t\t\t\r\n\t\t\t<div class=\"col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left\">\r\n\t\t\t\t<h2>Signup to my newsletter</h2>\r\n\t\t\t\t<div class=\"subscribe-main text-left\">\r\n\t\t\t\t\t<div class=\"subscribe-form\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2297ace38afb369c829e560152be7bea7333b3365159", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input class=\"form-control\" name=\"Email\" type=\"email\" placeholder=\"Enter your email...\"");
                BeginWriteAttribute("required", " required=\"", 580, "\"", 591, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary submit\">Submit</button>\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						<div class=""clearfix""> </div>
					</div>
					<p>We respect your privacy.No spam ever!</p>
				</div>
				<!-- //subscribe -->
			</div>
		</div>
		<!-- footer -->
		<div class=""footer-cpy text-center"">
			<div class=""footer-social"">
				<div class=""copyrighttop"">
					<ul>
						<li class=""mx-3"">
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-facebook-f""></i>
								<span>Facebook</span>
							</a>
						</li>
						<li>
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-twitter""></i>
								<span>Twitter</span>
							</a>
						</li>
						<li class=""mx-3"">
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-google-plus-g""></i>
								<span>Google+</span>
							</a>
						</li>
						<li>
							<a class=""facebook"" href=""#"">
								<i class=""fab fa-pinterest-p""></i>
								<span>Pinterest</span>
							</a>
						</li>
					</ul>

				</div>
			</div>
			<div class=""w3layouts-agile-copyrightbottom"">
				<p>
					©");
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\projelerim\MyCvProject\MyCvProject\Views\Shared\_FooterPartial.cshtml"
                 Write(DateTime.Today.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Resume. All Rights Reserved | Design by\r\n\t\t\t\t\t<a href=\"http://w3layouts.com/\">W3layouts</a>\r\n\t\t\t\t</p>\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<!-- //footer -->\r\n\r\n\t</div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591