#pragma checksum "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5694f303c430f967b6f09f05c0be9a2db7d36c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPassword), @"mvc.1.0.view", @"/Views/Account/ResetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ResetPassword.cshtml", typeof(AspNetCore.Views_Account_ResetPassword))]
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
#line 1 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#line 2 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\ResetPassword.cshtml"
using MODELS.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5694f303c430f967b6f09f05c0be9a2db7d36c9", @"/Views/Account/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d8edc1ed7b82dad2ddbfdedea183fcd8a36915", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResetPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\ResetPassword.cshtml"
  
    ViewData["Title"] = "Reset password";

#line default
#line hidden
            BeginContext(107, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(114, 17, false);
#line 7 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\ResetPassword.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(131, 1148, true);
            WriteLiteral(@"</h2>
<h4>Reset your password.</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""All"" class=""text-danger""></div>
            <input asp-for=""Code"" type=""hidden"" />
            <div class=""form-group"">
                <label asp-for=""Email""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Password""></label>
                <input asp-for=""Password"" class=""form-control"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ConfirmPassword""></label>
                <input asp-for=""ConfirmPassword"" class=""form-control"" />
                <span asp-validation-for=""ConfirmPassword"" class=""text-danger""></span>
         ");
            WriteLiteral("   </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Reset</button>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1297, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1304, 52, false);
#line 36 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\ResetPassword.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1356, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResetPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
