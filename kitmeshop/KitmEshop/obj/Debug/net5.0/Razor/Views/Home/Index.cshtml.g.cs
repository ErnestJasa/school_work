#pragma checksum "D:\visual studio\kitmshop20221215\KitmEshop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe925c1500aeb21791ecda955fea29496aba8fe5"
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
#line 1 "D:\visual studio\kitmshop20221215\KitmEshop\Views\_ViewImports.cshtml"
using KitmEshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\visual studio\kitmshop20221215\KitmEshop\Views\_ViewImports.cshtml"
using KitmEshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\visual studio\kitmshop20221215\KitmEshop\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe925c1500aeb21791ecda955fea29496aba8fe5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5eba788afa02589c33ea7865f9898733b612772", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\visual studio\kitmshop20221215\KitmEshop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\visual studio\kitmshop20221215\KitmEshop\Views\Home\Index.cshtml"
 if (ViewBag.reviewAdded != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"alert alert-success\">Review addded</span>\r\n");
#nullable restore
#line 8 "D:\visual studio\kitmshop20221215\KitmEshop\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""text-center"">
    <h1 class=""display-4"">Eshop</h1>
</div>
<div class=""res card""></div>
<script>
    (function () {
        $.get(""api/products"", function (data) {
            const result = JSON.parse(JSON.stringify(data)).$values

            for (var i = 0; i < result.length; i++) {

                $("".res"").append('<ul><li><img src=""' + result[i].image + '""/></li><li>' + result[i].name + '</li><li>' + result[i].price + '</li></ul> <a href=""Review/add/' + result[i].id + '"">Write a review</a><ul id=""' + result[i].id + '""></ul>');

                for (var y = 0; y < result[i].reviews.$values.length; y++) {

                    $(""#"" + result[i].id).append('<li>' + result[i].reviews.$values[y].reviewText + '</li>');
                }
            }
        });
    })();

    //$("".result"").html(data);
    //for (var i = 0; i < data.length; i++) {
    //    $("".result"").add(""<p>"" + data[i].Name.value + ""</p>"");
    //}
    //console.log(result);
</script>");
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
