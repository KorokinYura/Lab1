#pragma checksum "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72aaabebd63f1d4b804723f12c4977bfd523b2a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCriterions), @"mvc.1.0.view", @"/Views/Home/ViewCriterions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewCriterions.cshtml", typeof(AspNetCore.Views_Home_ViewCriterions))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72aaabebd63f1d4b804723f12c4977bfd523b2a1", @"/Views/Home/ViewCriterions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59419ef1b1476a13ca8a84f44f57646c39f2efca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCriterions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab1.Models.Criterion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criterion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 1%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCriterion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
  
    ViewData["Title"] = "ViewCriterions";

#line default
#line hidden
            BeginContext(95, 27, true);
            WriteLiteral("\r\n<h2>Критерии</h2>\r\n<hr>\r\n");
            EndContext();
            BeginContext(122, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ababe906245940ca8f5293c7614a1615", async() => {
                BeginContext(196, 10, true);
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
            BeginContext(210, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 41, false);
#line 15 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
           Write(Html.DisplayNameFor(model => model.CName));

#line default
#line hidden
            EndContext();
            BeginContext(340, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(562, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(597, 41, false);
#line 24 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
           Write(Html.DisplayNameFor(model => model.CType));

#line default
#line hidden
            EndContext();
            BeginContext(638, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(694, 45, false);
#line 27 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
           Write(Html.DisplayNameFor(model => model.OptimType));

#line default
#line hidden
            EndContext();
            BeginContext(739, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(795, 43, false);
#line 30 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
           Write(Html.DisplayNameFor(model => model.EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(838, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(894, 45, false);
#line 33 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
           Write(Html.DisplayNameFor(model => model.ScaleType));

#line default
#line hidden
            EndContext();
            BeginContext(939, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1074, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1135, 40, false);
#line 43 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
               Write(Html.DisplayFor(modelItem => item.CName));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1423, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1466, 40, false);
#line 52 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
               Write(Html.DisplayFor(modelItem => item.CType));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1574, 44, false);
#line 55 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
               Write(Html.DisplayFor(modelItem => item.OptimType));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1686, 42, false);
#line 58 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
               Write(Html.DisplayFor(modelItem => item.EdIzmer));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1796, 44, false);
#line 61 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
               Write(Html.DisplayFor(modelItem => item.ScaleType));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1907, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bc87fd1875d4ab4a8603125589a8826", async() => {
                BeginContext(1965, 4, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idCrit", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
                                                    WriteLiteral(item.IdCrit);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCrit"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idCrit", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCrit"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1973, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(2068, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2088, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7aeab9b78474ddc8918cd524bf1243b", async() => {
                BeginContext(2152, 6, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idCrit", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
                                                          WriteLiteral(item.IdCrit);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCrit"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idCrit", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCrit"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2162, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 69 "D:\NURE\3 курс\1 семестр\МоТи\Lab1\Lab1\Views\Home\ViewCriterions.cshtml"
        }

#line default
#line hidden
            BeginContext(2217, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab1.Models.Criterion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
