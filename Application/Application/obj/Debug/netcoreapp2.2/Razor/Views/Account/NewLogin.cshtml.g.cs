#pragma checksum "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a6aaf4634367cac384edca67a19d9856d447794"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_NewLogin), @"mvc.1.0.view", @"/Views/Account/NewLogin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/NewLogin.cshtml", typeof(AspNetCore.Views_Account_NewLogin))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#line 1 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
using System.Linq;

#line default
#line hidden
#line 2 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
using MODELS.ViewModels;

#line default
#line hidden
#line 3 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
using MODELS.DB;

#line default
#line hidden
#line 4 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 5 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6aaf4634367cac384edca67a19d9856d447794", @"/Views/Account/NewLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d8edc1ed7b82dad2ddbfdedea183fcd8a36915", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_NewLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 9 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(285, 29, true);
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(314, 540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a6aaf4634367cac384edca67a19d9856d4477945224", async() => {
                BeginContext(320, 356, true);
                WriteLiteral(@"
    <title>Log in</title>

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta charset=""utf-8"">
    <script>
        addEventListener(""load"", function () {
            setTimeout(hideURLbar, 0);
        }, false);
        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>

    ");
                EndContext();
                BeginContext(676, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a6aaf4634367cac384edca67a19d9856d4477945968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(730, 117, true);
                WriteLiteral("\r\n\r\n    <link href=\"//fonts.googleapis.com/css?family=Poiret+One&amp;subset=cyrillic,latin-ext\" rel=\"stylesheet\">\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(854, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(858, 2234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a6aaf4634367cac384edca67a19d9856d4477948228", async() => {
                BeginContext(864, 140, true);
                WriteLiteral("\r\n    <div class=\"back_image\"></div>\r\n    <div class=\"w3ls-login box box--big\">\r\n        <h1 class=\"title-page\">Sign In </h1>\r\n        <form");
                EndContext();
                BeginWriteAttribute("asp-route-returnurl", " asp-route-returnurl=\"", 1004, "\"", 1048, 1);
#line 40 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
WriteAttributeValue("", 1026, ViewData["ReturnUrl"], 1026, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1049, 1393, true);
                WriteLiteral(@" method=""post"">
            <div class=""agile-field-txt"">
                <label asp-for=""Email""></label>
                <input asp-for=""Email"" class=""form-control"" id=""email"" placeholder=""Enter your login"" />
                <span asp-validation-for=""Email"" class=""agile-right""></span>
            </div>
            <div class=""agile-field-txt"">
                <label asp-for=""Password""></label>
                <input asp-for=""Password"" id=""pass"" class=""form-control"" placeholder=""Enter your password"" />
                <span asp-validation-for=""Password"" class=""text-danger""></span>
                <div asp-validation-summary=""All"" class=""agile_label"" style=""color : red""></div>
            </div>
            <div class=""agile-field-txt"">
                <div class=""agile_label"">
                    <input id=""check3"" name=""check3"" type=""checkbox"" value=""show password"" onclick=""ShowPassword()"">
                    <label class=""check"" for=""check3"">Show password</label>
                </div>
 ");
                WriteLiteral(@"               <div class=""agile-right"">
                    <a asp-action=""ForgotPassword"">Forgot your password?</a>
                </div>
            </div>
            <div class=""w3ls-bot"">
                <div class=""switch-agileits"">
                    <label class=""switch"">
                        <input asp-for=""RememberMe"">
                        ");
                EndContext();
                BeginContext(2443, 38, false);
#line 65 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
                   Write(Html.DisplayNameFor(m => m.RememberMe));

#line default
#line hidden
                EndContext();
                BeginContext(2481, 383, true);
                WriteLiteral(@"
                        <span class=""slider round""></span>
                    </label>
                </div>
            </div>
            <div class=""agile-field-txt"">
                <p>
                    <input type=""submit"" value=""SIGN IN"">
                </p>
            </div>
            <div class=""agile-right"">
                <a asp-action=""NewRegister""");
                EndContext();
                BeginWriteAttribute("asp-route-returnurl", " asp-route-returnurl=\"", 2864, "\"", 2908, 1);
#line 76 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
WriteAttributeValue("", 2886, ViewData["ReturnUrl"], 2886, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2909, 176, true);
                WriteLiteral(">REGISTRATION</a>\r\n            </div>\r\n        </form>\r\n    </div>\r\n\r\n    <div class=\"copy-wthree\">\r\n        <p>\r\n            © 2019 | SMS-service\r\n        </p>\r\n    </div>\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3092, 255, true);
            WriteLiteral("\r\n</html>\r\n\r\n<script>\r\n    function ShowPassword() {\r\n        var x = document.getElementById(\"pass\");\r\n        if (x.type === \"password\") {\r\n            x.type = \"text\";\r\n        } else {\r\n            x.type = \"password\";\r\n        }\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3365, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3372, 52, false);
#line 102 "D:\3 курс\Net\Application\ASP-.NET-CAR\Application\Application\Views\Account\NewLogin.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(3424, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
