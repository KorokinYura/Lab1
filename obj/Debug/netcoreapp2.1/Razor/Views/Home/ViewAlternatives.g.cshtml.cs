#pragma checksum "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a165a75c69be94c95c87015cbba5dae1d23647c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewAlternatives), @"mvc.1.0.view", @"/Views/Home/ViewAlternatives.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewAlternatives.cshtml", typeof(AspNetCore.Views_Home_ViewAlternatives))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a165a75c69be94c95c87015cbba5dae1d23647c0", @"/Views/Home/ViewAlternatives.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59419ef1b1476a13ca8a84f44f57646c39f2efca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewAlternatives : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab1.Models.ViewModels.ViewAlternativesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alternative", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveAlternative", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
  
    ViewData["Title"] = "ViewAlternatives";

#line default
#line hidden
            BeginContext(111, 31, true);
            WriteLiteral("\r\n<h2>Альтернативы</h2>\r\n<hr>\r\n");
            EndContext();
            BeginContext(142, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "630c93bac2874fe8b28b0446e08defcb", async() => {
                BeginContext(218, 10, true);
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
            BeginContext(232, 16, true);
            WriteLiteral("<br /><br />\r\n\r\n");
            EndContext();
#line 11 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
 foreach (var alter in Model.Alternatives)
{

#line default
#line hidden
            BeginContext(295, 29, true);
            WriteLiteral("    <a data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 324, "\"", 344, 2);
            WriteAttributeValue("", 331, "#", 331, 1, true);
#line 13 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
WriteAttributeValue("", 332, alter.IdAlt, 332, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(345, 168, true);
            WriteLiteral(">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <b style=\"font-size: 150%; color: #3c3c3c\">\r\n                    ");
            EndContext();
            BeginContext(514, 11, false);
#line 17 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
               Write(alter.AName);

#line default
#line hidden
            EndContext();
            BeginContext(525, 78, true);
            WriteLiteral("\r\n                </b>\r\n            </div>\r\n        </div>\r\n    </a>\r\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 603, "\"", 620, 1);
#line 22 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
WriteAttributeValue("", 608, alter.IdAlt, 608, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(621, 43, true);
            WriteLiteral(" class=\"panel-collapse collapse\">\r\n        ");
            EndContext();
            BeginContext(664, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fca33a77988c44049f8aaab457d834a7", async() => {
                BeginContext(723, 4, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idAlt", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                                         WriteLiteral(alter.IdAlt);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idAlt"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idAlt", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idAlt"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(731, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(743, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3fc3aaa6d7e493dae23aa57d4f2d2d6", async() => {
                BeginContext(808, 6, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idAlt", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                                               WriteLiteral(alter.IdAlt);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idAlt"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idAlt", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idAlt"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(818, 195, true);
            WriteLiteral("<br />\r\n        <div class=\"panel panel-default\">\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1014, 60, false);
#line 30 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                       Write(Html.DisplayNameFor(model => model.Criterions.First().CName));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1166, 55, false);
#line 33 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                       Write(Html.DisplayNameFor(model => model.Marks.First().MName));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1313, 62, false);
#line 36 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                       Write(Html.DisplayNameFor(model => model.Criterions.First().EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 86, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n");
            EndContext();
#line 40 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                 foreach (var crit in Model.Criterions)
                {

#line default
#line hidden
            BeginContext(1537, 153, true);
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n                            <th style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(1691, 10, false);
#line 45 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                           Write(crit.CName);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 99, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"font-weight: normal\">\r\n");
            EndContext();
#line 48 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                                  
                                    var vects = Model.Vectors.Where(v => v.IdAlt == alter.IdAlt);
                                    var marks = Model.Marks.Where(m => m.IdCrit == crit.IdCrit);
                                    var mark = marks.FirstOrDefault(m => m.IdMark == vects.FirstOrDefault(v => v.IdMark == m.IdMark)?.IdMark);

                                    string print = mark == null ? "" : mark.MName;
                                

#line default
#line hidden
            BeginContext(2298, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2331, 5, false);
#line 55 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                           Write(print);

#line default
#line hidden
            EndContext();
            BeginContext(2336, 131, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"font-weight: normal\">\r\n                                ");
            EndContext();
            BeginContext(2468, 12, false);
#line 58 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                           Write(crit.EdIzmer);

#line default
#line hidden
            EndContext();
            BeginContext(2480, 98, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </tbody>\r\n");
            EndContext();
#line 62 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
                }

#line default
#line hidden
            BeginContext(2597, 50, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 66 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewAlternatives.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab1.Models.ViewModels.ViewAlternativesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
