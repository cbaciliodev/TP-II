#pragma checksum "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ce67638d65469a98e9706636c97be0fa0c8614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TConcursoes_Details), @"mvc.1.0.view", @"/Views/TConcursoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TConcursoes/Details.cshtml", typeof(AspNetCore.Views_TConcursoes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ce67638d65469a98e9706636c97be0fa0c8614", @"/Views/TConcursoes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_TConcursoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGIAMTP.Models.TConcurso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 498, true);
            WriteLiteral(@"
<h2>Detalles del Concurso</h2>

<div class=""col-lg-6"">
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            <div>
                <h4 class=""panel-title"">Registro de Concurso</h4>
            </div>
        </div>
        <div class=""panel panel-body form-group"">
            <hr />
            <dl class=""dl-horizontal"">
                <dt>
                    Nombre del Concurso:
                </dt>
                <dd>
                    ");
            EndContext();
            BeginContext(577, 43, false);
#line 23 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
               Write(Html.DisplayFor(model => model.VcNombreCon));

#line default
#line hidden
            EndContext();
            BeginContext(620, 153, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    Lugar del Concurso:\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(774, 42, false);
#line 29 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
               Write(Html.DisplayFor(model => model.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(816, 153, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    Fecha del Concurso:\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(970, 47, false);
#line 35 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
               Write(Html.DisplayFor(model => model.DcFechaConcurso));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 151, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    Cantidad Seriado:\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1169, 46, false);
#line 41 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
               Write(Html.DisplayFor(model => model.IcCantidadSeri));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 149, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    Cantidad Novel:\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1365, 46, false);
#line 47 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
               Write(Html.DisplayFor(model => model.IcCantidadNove));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 153, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    Estado de Concurso:\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1565, 68, false);
#line 53 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
               Write(Html.DisplayFor(model => model.FkIecIdEstadoNavigation.VeNombreEsta));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 79, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1712, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c247d064dc440a9e95cc923c1d75fe", async() => {
                BeginContext(1794, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Details.cshtml"
                                                               WriteLiteral(Model.PkIcIdConcurso);

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
            BeginContext(1804, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1822, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a3c8a6f46147c6b89c1fcb392f8894", async() => {
                BeginContext(1867, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1879, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGIAMTP.Models.TConcurso> Html { get; private set; }
    }
}
#pragma warning restore 1591
