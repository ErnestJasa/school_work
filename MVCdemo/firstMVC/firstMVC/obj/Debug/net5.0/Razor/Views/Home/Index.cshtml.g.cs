#pragma checksum "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4ccdce4f72e1f7abcc3135d80bd37e812ae7ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 6 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
using firstMVC.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
using firstMVC.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4ccdce4f72e1f7abcc3135d80bd37e812ae7ab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99fd8a71f559ae29e892f5dadd566d7ef972c566", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<firstMVC.Models.InputViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Rytas</h1>\r\n<h2>");
#nullable restore
#line 15 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
Write(ViewBag.manoString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h3>");
#nullable restore
#line 17 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
Write(ViewData["foo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h4>");
#nullable restore
#line 19 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
Write(TempData["bar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<h1 class=\"text-primary\">");
#nullable restore
#line 21 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
                    Write(Model.Skaicius);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h1 class=\"text-primary\">");
#nullable restore
#line 23 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
                    Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1 class=\"text-primary\">");
#nullable restore
#line 24 "C:\Users\moksleivis\Desktop\EJ\firstMVC\firstMVC\Views\Home\Index.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<firstMVC.Models.InputViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591