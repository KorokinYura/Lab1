#pragma checksum "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c4459ef0dd05962685b1b50dd83c908748d2f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewMarks), @"mvc.1.0.view", @"/Views/Home/ViewMarks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewMarks.cshtml", typeof(AspNetCore.Views_Home_ViewMarks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22c4459ef0dd05962685b1b50dd83c908748d2f0", @"/Views/Home/ViewMarks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59419ef1b1476a13ca8a84f44f57646c39f2efca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMarks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab1.Models.ViewModels.ViewMarksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Mark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
  
    ViewData["Title"] = "ViewMarks";

#line default
#line hidden
            BeginContext(97, 27, true);
            WriteLiteral("\r\n<h2>Оценки</h2>\r\n<hr />\r\n");
            EndContext();
            BeginContext(124, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be0b0c4181c54ab999b591c8800c9beb", async() => {
                BeginContext(193, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(207, 16, true);
            WriteLiteral("<br /><br />\r\n\r\n");
            EndContext();
#line 11 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
 foreach (var crit in Model.Criterions)
{

#line default
#line hidden
            BeginContext(267, 29, true);
            WriteLiteral("    <a data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 296, "\"", 316, 2);
            WriteAttributeValue("", 303, "#", 303, 1, true);
#line 13 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
WriteAttributeValue("", 304, crit.IdCrit, 304, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(317, 175, true);
            WriteLiteral(" class=\"panel panel-default\">\r\n        <div class=\"panel-heading\">\r\n            <div style=\"color: #3c3c3c\">\r\n                <b style=\"font-size: 150%\">\r\n                    ");
            EndContext();
            BeginContext(493, 10, false);
#line 17 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
               Write(crit.CName);

#line default
#line hidden
            EndContext();
            BeginContext(503, 84, true);
            WriteLiteral("\r\n                </b><br />\r\n            </div>\r\n        </div>\r\n    </a>\r\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 587, "\"", 604, 1);
#line 22 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
WriteAttributeValue("", 592, crit.IdCrit, 592, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(605, 179, true);
            WriteLiteral(" class=\"panel panel-default panel-collapse collapse\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(785, 46, false);
#line 27 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mark.MName));

#line default
#line hidden
            EndContext();
            BeginContext(831, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(911, 62, false);
#line 30 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                   Write(Html.DisplayNameFor(model => model.Criterions.First().EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(973, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 35 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                 foreach (var mark in Model.Marks)
                {
                    

#line default
#line hidden
#line 37 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                     if (mark.IdCrit == crit.IdCrit)
                    {

#line default
#line hidden
            BeginContext(1216, 124, true);
            WriteLiteral("                        <tr>\r\n                            <td style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(1341, 10, false);
#line 41 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                           Write(mark.MName);

#line default
#line hidden
            EndContext();
            BeginContext(1351, 131, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(1483, 12, false);
#line 44 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                           Write(crit.EdIzmer);

#line default
#line hidden
            EndContext();
            BeginContext(1495, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1598, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57668f3491cb468f90b8b7f1f9738d87", async() => {
                BeginContext(1651, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idMark", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                                                           WriteLiteral(mark.IdMark);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMark"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idMark", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMark"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1659, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1766, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1798, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f9903f430064c7e847f626a10c9ba7c", async() => {
                BeginContext(1857, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idMark", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                                                                 WriteLiteral(mark.IdMark);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMark"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idMark", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMark"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1867, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 52 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                    }

#line default
#line hidden
#line 52 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1977, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 57 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab1.Models.ViewModels.ViewMarksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
