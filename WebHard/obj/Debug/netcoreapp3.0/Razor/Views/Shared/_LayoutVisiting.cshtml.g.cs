#pragma checksum "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033b98a274df9539fc64b042e82e9047f6ce35f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutVisiting), @"mvc.1.0.view", @"/Views/Shared/_LayoutVisiting.cshtml")]
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
#line 1 "D:\reports\WebHard\WebHard\WebHard\Views\_ViewImports.cshtml"
using WebHard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\reports\WebHard\WebHard\WebHard\Views\_ViewImports.cshtml"
using WebHard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033b98a274df9539fc64b042e82e9047f6ce35f7", @"/Views/Shared/_LayoutVisiting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c52fc88d005ff4e5d0325835c9fc4547145d8cd9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutVisiting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
  
    ViewData["Title"] = "_LayoutEmpty";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033b98a274df9539fc64b042e82e9047f6ce35f73431", async() => {
                WriteLiteral("\r\n    <title>Phase Shift by TEMPLATED</title>\r\n    <meta http-equiv=\"content-type\" content=\"text/html; charset=utf-8\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 231, "\"", 241, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 272, "\"", 282, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 299, "\"", 348, 1);
#nullable restore
#line 13 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 306, Url.Content("~/css/VisitingCss/skel.css"), 306, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 396, "\"", 446, 1);
#nullable restore
#line 14 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 403, Url.Content("~/css/VisitingCss/style.css"), 403, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                BeginWriteAttribute("href", " href=\"", 494, "\"", 549, 1);
#nullable restore
#line 15 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 501, Url.Content("~/css/VisitingCss/style-wide.css"), 501, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 603, "\"", 654, 1);
#nullable restore
#line 18 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 609, Url.Content("~/js/VisitingJs/jquery.min.js"), 609, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 701, "\"", 762, 1);
#nullable restore
#line 19 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 707, Url.Content("~/js/VisitingJs/jquery.dropotron.min.js"), 707, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 809, "\"", 858, 1);
#nullable restore
#line 20 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 815, Url.Content("~/js/VisitingJs/skel.min.js"), 815, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 905, "\"", 961, 1);
#nullable restore
#line 21 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 911, Url.Content("~/js/VisitingJs/skel-layers.min.js"), 911, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 1008, "\"", 1053, 1);
#nullable restore
#line 22 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
WriteAttributeValue("", 1014, Url.Content("~/js/VisitingJs/init.js"), 1014, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 28 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
     if (IsSectionDefined("AddToHead"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
   Write(RenderSection("AddToHead", required: false));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
                                                    
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "033b98a274df9539fc64b042e82e9047f6ce35f79194", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 40 "D:\reports\WebHard\WebHard\WebHard\Views\Shared\_LayoutVisiting.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
