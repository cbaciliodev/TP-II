#pragma checksum "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ebd23876936bc712d355c91abb8f480b63ab438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuarioModalidad_Details), @"mvc.1.0.view", @"/Views/TUsuarioModalidad/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuarioModalidad/Details.cshtml", typeof(AspNetCore.Views_TUsuarioModalidad_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebd23876936bc712d355c91abb8f480b63ab438", @"/Views/TUsuarioModalidad/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuarioModalidad_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGIAMTP.Models.TUsuarioModalidad>
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
#line 3 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 578, true);
            WriteLiteral(@"
<h2>Details</h2>

<div id=""contenedor"" class=""container-fluid"" style=""font-size:16px; font-family:'Century Gothic'"">


    <div class=""row col-xs-12 col-md-12 col-lg-12"">
        <div class=""col-lg-2""></div>

        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                <div>
                    <h4 class=""panel-title"">Registro de Participantes</h4>
                </div>
            </div>
        </div>
    </div>

    <h4>TUsuarioModalidad</h4>
    <hr />
    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(665, 43, false);
#line 28 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(708, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(752, 39, false);
#line 31 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(791, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(835, 47, false);
#line 34 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(926, 43, false);
#line 37 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(969, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1013, 50, false);
#line 40 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmUmArchivoDni));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1107, 46, false);
#line 43 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmUmArchivoDni));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1197, 48, false);
#line 46 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmUmArchivoB));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1289, 44, false);
#line 49 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmUmArchivoB));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1377, 60, false);
#line 52 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIcIdConcursoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1481, 71, false);
#line 55 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIcIdConcursoNavigation.PkIcIdConcurso));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1596, 61, false);
#line 58 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkImIdModalidadNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1701, 73, false);
#line 61 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkImIdModalidadNavigation.PkImIdModalidad));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1818, 53, false);
#line 64 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuDniNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1871, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1915, 57, false);
#line 67 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuDniNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2016, 59, false);
#line 70 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuDniParejaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2119, 63, false);
#line 73 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuDniParejaNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2229, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cad12ac5dc546c7832ea52e0fa4d7b2", async() => {
                BeginContext(2283, 4, true);
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
#line 78 "C:\Users\alumno.LABORATORIOS\Downloads\git\TP-II\SGIAMTP\SGIAMTP\Views\TUsuarioModalidad\Details.cshtml"
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
            BeginContext(2291, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2299, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5286fb3ef65c4e54b019ed40d7d78df6", async() => {
                BeginContext(2321, 12, true);
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
            BeginContext(2337, 10, true);
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
