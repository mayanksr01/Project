#pragma checksum "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd89953b420b408fd7b7c4d72a160556a8f697a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login__login), @"mvc.1.0.view", @"/Views/Login/_login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd89953b420b408fd7b7c4d72a160556a8f697a7", @"/Views/Login/_login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e81cc18ea151e6190006a63df9fe80ecf0f9aa99", @"/Views/_ViewImports.cshtml")]
    public class Views_Login__login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PriceCalculator.DTO.LoginDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
     using (Html.BeginForm("ValidateUser", "Login", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-horizontal\">\r\n           \r\n            ");
#nullable restore
#line 11 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 13 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
           Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 15 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
               Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
               Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 20 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
           Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 22 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
               Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", type = "password" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
               Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Submit"" class=""btn btn-primary"" />
                </div>
            </div>
");
#nullable restore
#line 32 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
             if (ViewBag.LoginError != null)
            {
                //your code
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
           Write(ViewBag.LoginError);

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
                                   
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 38 "E:\Mayank-Project\PriceCalculator\PriceCalculator\Views\Login\_login.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PriceCalculator.DTO.LoginDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
