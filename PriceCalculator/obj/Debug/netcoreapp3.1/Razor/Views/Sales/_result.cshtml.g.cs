#pragma checksum "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Sales\_result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48808cb76f0016393d07984ffd601af3068f6d81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales__result), @"mvc.1.0.view", @"/Views/Sales/_result.cshtml")]
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
#line 1 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\_ViewImports.cshtml"
using PriceCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\_ViewImports.cshtml"
using PriceCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48808cb76f0016393d07984ffd601af3068f6d81", @"/Views/Sales/_result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e81cc18ea151e6190006a63df9fe80ecf0f9aa99", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales__result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Sales\_result.cshtml"
     if (@ViewBag.FileResult == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2> Calculated Total Price is added in Result file. </h2>\r\n");
#nullable restore
#line 7 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Sales\_result.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 9 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Sales\_result.cshtml"
   Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
