#pragma checksum "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93752d30eb752530bb48c13ffbf46e59b9e98544"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93752d30eb752530bb48c13ffbf46e59b9e98544", @"/Views/Home/ViewMarks.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e3dc0b020af46bc92bae6864270a1e0", async() => {
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
            BeginContext(317, 207, true);
            WriteLiteral(">\r\n        <div  class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <div style=\"color: #3c3c3c\">\r\n                    <b style=\"font-size: 150%\">\r\n                        ");
            EndContext();
            BeginContext(525, 10, false);
#line 18 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                   Write(crit.CName);

#line default
#line hidden
            EndContext();
            BeginContext(535, 112, true);
            WriteLiteral("\r\n                    </b><br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </a>\r\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 647, "\"", 664, 1);
#line 24 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
WriteAttributeValue("", 652, crit.IdCrit, 652, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(665, 179, true);
            WriteLiteral(" class=\"panel panel-default panel-collapse collapse\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(845, 46, false);
#line 29 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mark.MName));

#line default
#line hidden
            EndContext();
            BeginContext(891, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(971, 62, false);
#line 32 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                   Write(Html.DisplayNameFor(model => model.Criterions.First().EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 37 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                 foreach (var mark in Model.Marks)
                {
                    

#line default
#line hidden
#line 39 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                     if (mark.IdCrit == crit.IdCrit)
                    {

#line default
#line hidden
            BeginContext(1276, 124, true);
            WriteLiteral("                        <tr>\r\n                            <td style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(1401, 10, false);
#line 43 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                           Write(mark.MName);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 131, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(1543, 12, false);
#line 46 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                           Write(crit.EdIzmer);

#line default
#line hidden
            EndContext();
            BeginContext(1555, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1658, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1613a83346c34a33b4f7665a4445beb5", async() => {
                BeginContext(1711, 4, true);
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
            BeginContext(1719, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1826, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1858, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693e591d5c064ebea5a3afd910b9e195", async() => {
                BeginContext(1917, 6, true);
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
#line 51 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
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
            BeginContext(1927, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                    }

#line default
#line hidden
#line 54 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2037, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 59 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewMarks.cshtml"
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
