#pragma checksum "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "052b5e3fe22953b1827d771af3f8e25759c1f433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Elimination), @"mvc.1.0.view", @"/Views/Home/Elimination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Elimination.cshtml", typeof(AspNetCore.Views_Home_Elimination))]
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
#line 1 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1;

#line default
#line hidden
#line 2 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"052b5e3fe22953b1827d771af3f8e25759c1f433", @"/Views/Home/Elimination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59419ef1b1476a13ca8a84f44f57646c39f2efca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Elimination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab1.Models.ViewModels.EliminationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Elimination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RestartElimination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
  
    ViewData["Title"] = "Elimination";

#line default
#line hidden
            BeginContext(101, 148, true);
            WriteLiteral("\r\n<h2>Выбор</h2>\r\n<hr />\r\n\r\n<div class=\"col-md-6\">\r\n    <p style=\"font-size: 150%; color: #3c3c3c; text-align: center; font-weight: bold\">\r\n        ");
            EndContext();
            BeginContext(250, 24, false);
#line 12 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
   Write(Model.Alternative1.AName);

#line default
#line hidden
            EndContext();
            BeginContext(274, 175, true);
            WriteLiteral("\r\n    </p>\r\n    <div class=\"panel panel-default\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(450, 51, false);
#line 19 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                   Write(Html.DisplayNameFor(model => model.Criterion.CName));

#line default
#line hidden
            EndContext();
            BeginContext(501, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(581, 46, false);
#line 22 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mark.MName));

#line default
#line hidden
            EndContext();
            BeginContext(627, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(707, 53, false);
#line 25 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                   Write(Html.DisplayNameFor(model => model.Criterion.EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(760, 74, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n");
            EndContext();
#line 29 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
             foreach (var v in Model.Vectors1)
            {

#line default
#line hidden
            BeginContext(897, 137, true);
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <th style=\"font-weight: normal\">\r\n                            ");
            EndContext();
            BeginContext(1035, 22, false);
#line 34 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                       Write(v.Mark.Criterion.CName);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 119, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th style=\"font-weight: normal\">\r\n                            ");
            EndContext();
            BeginContext(1177, 12, false);
#line 37 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                       Write(v.Mark.MName);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 119, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th style=\"font-weight: normal\">\r\n                            ");
            EndContext();
            BeginContext(1309, 24, false);
#line 40 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                       Write(v.Mark.Criterion.EdIzmer);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 86, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </tbody>\r\n");
            EndContext();
#line 44 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
            }

#line default
#line hidden
            BeginContext(1434, 34, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1468, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5fdf01be55244808586cfc8b60a2b32", async() => {
                BeginContext(1499, 29, true);
                WriteLiteral("\r\n        <input name=\"idAlt\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1528, "\"", 1561, 1);
#line 48 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
WriteAttributeValue("", 1536, Model.Alternative2.IdAlt, 1536, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1562, 253, true);
                WriteLiteral(" type=\"hidden\" />\r\n        <div class=\"form-group\" style=\"text-align:center;\">\r\n            <input type=\"submit\" value=\"Выбрать\" class=\"btn btn-default center-block\" style=\"background-color: dodgerblue; color: white; width: 50%\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1822, 132, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"col-md-6\">\r\n    <p style=\"font-size: 150%; color: #3c3c3c; text-align: center; font-weight: bold\">\r\n        ");
            EndContext();
            BeginContext(1955, 24, false);
#line 57 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
   Write(Model.Alternative2.AName);

#line default
#line hidden
            EndContext();
            BeginContext(1979, 210, true);
            WriteLiteral("\r\n    </p>\r\n    <div>\r\n        <div class=\"panel panel-default\">\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2190, 51, false);
#line 65 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                       Write(Html.DisplayNameFor(model => model.Criterion.CName));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2333, 46, false);
#line 68 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                       Write(Html.DisplayNameFor(model => model.Mark.MName));

#line default
#line hidden
            EndContext();
            BeginContext(2379, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(2471, 53, false);
#line 71 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                       Write(Html.DisplayNameFor(model => model.Criterion.EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(2524, 86, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n");
            EndContext();
#line 75 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                 foreach (var v in Model.Vectors2)
                {

#line default
#line hidden
            BeginContext(2681, 153, true);
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(2835, 22, false);
#line 80 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                           Write(v.Mark.Criterion.CName);

#line default
#line hidden
            EndContext();
            BeginContext(2857, 131, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(2989, 12, false);
#line 83 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                           Write(v.Mark.MName);

#line default
#line hidden
            EndContext();
            BeginContext(3001, 131, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(3133, 24, false);
#line 86 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                           Write(v.Mark.Criterion.EdIzmer);

#line default
#line hidden
            EndContext();
            BeginContext(3157, 98, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </tbody>\r\n");
            EndContext();
#line 90 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
                }

#line default
#line hidden
            BeginContext(3274, 54, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(3328, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4e5d24c5174a59af20b6d62909028c", async() => {
                BeginContext(3359, 29, true);
                WriteLiteral("\r\n        <input name=\"idAlt\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3388, "\"", 3421, 1);
#line 95 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\Elimination.cshtml"
WriteAttributeValue("", 3396, Model.Alternative1.IdAlt, 3396, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3422, 253, true);
                WriteLiteral(" type=\"hidden\" />\r\n        <div class=\"form-group\" style=\"text-align:center;\">\r\n            <input type=\"submit\" value=\"Выбрать\" class=\"btn btn-default center-block\" style=\"background-color: dodgerblue; color: white; width: 50%\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3682, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(3694, 272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8227a30a0a2a4cbf94da8b9e11f6822c", async() => {
                BeginContext(3732, 227, true);
                WriteLiteral("\r\n    <div class=\"form-group\" style=\"text-align:center;\">\r\n        <input type=\"submit\" value=\"Начать заново\" class=\"btn btn-default center-block\" style=\"background-color: forestgreen; color: white; width: 40%\" />\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab1.Models.ViewModels.EliminationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
