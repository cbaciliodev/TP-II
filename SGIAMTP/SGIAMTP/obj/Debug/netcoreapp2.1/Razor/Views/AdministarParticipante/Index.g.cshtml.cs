#pragma checksum "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694aaaae4b7c6c62849f667be409211ed5d4014a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministarParticipante_Index), @"mvc.1.0.view", @"/Views/AdministarParticipante/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdministarParticipante/Index.cshtml", typeof(AspNetCore.Views_AdministarParticipante_Index))]
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
#line 1 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\_ViewImports.cshtml"
using SGIAMTP;

#line default
#line hidden
#line 2 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\_ViewImports.cshtml"
using SGIAMTP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694aaaae4b7c6c62849f667be409211ed5d4014a", @"/Views/AdministarParticipante/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministarParticipante_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGIAMTP.Models.TUsuarioModalidad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3480e9d585cd4897840ae62f3971e8d1", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(256, 43, false);
#line 16 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(299, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(355, 47, false);
#line 19 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 50, false);
#line 22 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VmUmArchivoDni));

#line default
#line hidden
            EndContext();
            BeginContext(508, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(564, 48, false);
#line 25 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VmUmArchivoB));

#line default
#line hidden
            EndContext();
            BeginContext(612, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(668, 60, false);
#line 28 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkIcIdConcursoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(728, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(784, 61, false);
#line 31 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkImIdModalidadNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(845, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(901, 53, false);
#line 34 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkIuDniNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(954, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1010, 59, false);
#line 37 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkIuDniParejaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1187, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1236, 42, false);
#line 46 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1334, 46, false);
#line 49 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1436, 49, false);
#line 52 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VmUmArchivoDni));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1541, 47, false);
#line 55 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VmUmArchivoB));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1644, 70, false);
#line 58 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIcIdConcursoNavigation.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(1714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1770, 76, false);
#line 61 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkImIdModalidadNavigation.PkImIdModalidad));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1902, 60, false);
#line 64 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIuDniNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2018, 66, false);
#line 67 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIuDniParejaNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2139, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5547bddcbc584acc9091bc6f9a51e375", async() => {
                BeginContext(2192, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                                       WriteLiteral(item.PkIumCodUm);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2200, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2220, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac2610d6d7e842dfb812ea6db6b75434", async() => {
                BeginContext(2276, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                                          WriteLiteral(item.PkIumCodUm);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2287, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2307, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab9557864d304dfc9a338443ddec3d73", async() => {
                BeginContext(2362, 6, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                                         WriteLiteral(item.PkIumCodUm);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2372, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2411, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGIAMTP.Models.TUsuarioModalidad>> Html { get; private set; }
    }
}
#pragma warning restore 1591
