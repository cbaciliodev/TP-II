#pragma checksum "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7439df24a528cb18de866e99d0bb598336c8d275"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministarParticipante_Details), @"mvc.1.0.view", @"/Views/AdministarParticipante/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdministarParticipante/Details.cshtml", typeof(AspNetCore.Views_AdministarParticipante_Details))]
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
#line 1 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\_ViewImports.cshtml"
using SGIAMTP;

#line default
#line hidden
#line 2 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\_ViewImports.cshtml"
using SGIAMTP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7439df24a528cb18de866e99d0bb598336c8d275", @"/Views/AdministarParticipante/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministarParticipante_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGIAMTP.Models.TUsuarioModalidad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 131, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>TUsuarioModalidad</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(218, 43, false);
#line 14 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 39, false);
#line 17 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(344, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(388, 47, false);
#line 20 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(479, 43, false);
#line 23 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(522, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(566, 50, false);
#line 26 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmUmArchivoDni));

#line default
#line hidden
            EndContext();
            BeginContext(616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(660, 46, false);
#line 29 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmUmArchivoDni));

#line default
#line hidden
            EndContext();
            BeginContext(706, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(750, 48, false);
#line 32 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmUmArchivoB));

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(842, 44, false);
#line 35 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmUmArchivoB));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(930, 60, false);
#line 38 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIcIdConcursoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(990, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1034, 67, false);
#line 41 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIcIdConcursoNavigation.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1145, 61, false);
#line 44 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkImIdModalidadNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1250, 73, false);
#line 47 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkImIdModalidadNavigation.PkImIdModalidad));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1367, 53, false);
#line 50 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuDniNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1464, 57, false);
#line 53 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuDniNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1565, 59, false);
#line 56 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuDniParejaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1668, 63, false);
#line 59 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuDniParejaNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1778, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2451318d29a841f4b29e9619426e2496", async() => {
                BeginContext(1832, 4, true);
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Details.cshtml"
                           WriteLiteral(Model.PkIumCodUm);

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
            BeginContext(1840, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1848, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5f40f80b9b450083b00af4fe28556a", async() => {
                BeginContext(1870, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1886, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGIAMTP.Models.TUsuarioModalidad> Html { get; private set; }
    }
}
#pragma warning restore 1591
