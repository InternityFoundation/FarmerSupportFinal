#pragma checksum "E:\hackthonproject\FarmerSupport2\Views\FarmerModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0d4b3c8dfb8f37c2b13b84b8776cebb7b71981b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FarmerModels_Index), @"mvc.1.0.view", @"/Views/FarmerModels/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FarmerModels/Index.cshtml", typeof(AspNetCore.Views_FarmerModels_Index))]
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
#line 1 "E:\hackthonproject\FarmerSupport2\Views\_ViewImports.cshtml"
using FarmerSupport2;

#line default
#line hidden
#line 2 "E:\hackthonproject\FarmerSupport2\Views\_ViewImports.cshtml"
using FarmerSupport2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d4b3c8dfb8f37c2b13b84b8776cebb7b71981b", @"/Views/FarmerModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9251406b34186a6cc41cfca2c6da4cafae078a7c", @"/Views/_ViewImports.cshtml")]
    public class Views_FarmerModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FarmerSupport2.Models.FarmerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("FarmerModels/setCropInformation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\hackthonproject\FarmerSupport2\Views\FarmerModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 20, true);
            WriteLiteral("\r\n\r\n    <html>\r\n    ");
            EndContext();
            BeginContext(118, 2307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0d4b3c8dfb8f37c2b13b84b8776cebb7b71981b4580", async() => {
                BeginContext(124, 2294, true);
                WriteLiteral(@"
        <title>Login page</title>
        <style type=""text/css"">
            * {
                box-sizing: border-box;
            }

                *:focus {
                    outline: none;
                }

            body {
                font-family: Arial;
                background-color: #3498DB;
                padding: 50px;
            }

            .information {
                margin: 20px auto;
                width: 500px;
            }

            .information-screen {
                background-color: #FFF;
                padding: 20px;
                border-radius: 5px
            }

            .app-title {
                text-align: center;
                color: #777;
            }

            .information-form {
                text-align: center;
            }

            .control-group {
                margin-bottom: 10px;
            }

            input {
                text-align: center;
                background-color");
                WriteLiteral(@": #ECF0F1;
                border: 2px solid transparent;
                border-radius: 3px;
                font-size: 16px;
                font-weight: 200;
                padding: 10px 0;
                width: 450px;
                transition: border .5s;
            }

                input:focus {
                    border: 2px solid #3498DB;
                    box-shadow: none;
                }

            .btn {
                border: 2px solid transparent;
                background: #3498DB;
                color: #ffffff;
                font-size: 16px;
                line-height: 25px;
                padding: 10px 0;
                text-decoration: none;
                text-shadow: none;
                border-radius: 3px;
                box-shadow: none;
                transition: 0.25s;
                display: block;
                width: 250px;
                margin: 0 auto;
            }

                .btn:hover {
                    backg");
                WriteLiteral("round-color: #2980B9;\r\n                }\r\n\r\n            .information-link {\r\n                font-size: 12px;\r\n                color: #444;\r\n                display: block;\r\n                margin-top: 12px;\r\n            }\r\n        </style>\r\n    ");
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
            BeginContext(2425, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2431, 1643, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0d4b3c8dfb8f37c2b13b84b8776cebb7b71981b8155", async() => {
                BeginContext(2437, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2447, 1614, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0d4b3c8dfb8f37c2b13b84b8776cebb7b71981b8549", async() => {
                    BeginContext(2508, 1546, true);
                    WriteLiteral(@"
            <div class=""information"">
                <div class=""information-screen"">
                    <div class=""app-title"">
                        <h1>Information</h1>
                    </div>
                    <div class=""information-form"">
                        <div class=""control-group"">
                            <input type=""number"" class=""information-field"" value="""" placeholder=""Sunlight"" name=""sunlight"">
                        </div>

                        <div class=""control-group"">
                            <input type=""number"" class=""information-field"" value="""" placeholder=""temperature"" name=""temperature"">
                        </div>

                        <div class=""control-group"">
                            <input type=""number"" class=""information-field"" value="""" placeholder=""Humidity"" name=""humidity"">
                        </div>

                        <div class=""control-group"">
                            <input type=""number"" class=""information");
                    WriteLiteral(@"-field"" value="""" placeholder=""Eletrical Conductivity"" name=""elecricalconductivity"">
                        </div>

                        <div class=""control-group"">
                            <input type=""number"" class=""information-field"" value="""" placeholder=""Rainfall"" name=""rainfall"">
                        </div>

                        <input type=""submit"" value=""Calculate"" class=""btn btn-primary btn-large btn-block"">

                    </div>
                </div>
            </div>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4061, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(4074, 15, true);
            WriteLiteral("\r\n    </html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FarmerSupport2.Models.FarmerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
