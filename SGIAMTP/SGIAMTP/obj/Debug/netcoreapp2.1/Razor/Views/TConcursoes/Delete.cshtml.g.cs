#pragma checksum "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "716234224d0fdf2985a6a815bcaa0724bf1638fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TConcursoes_Delete), @"mvc.1.0.view", @"/Views/TConcursoes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TConcursoes/Delete.cshtml", typeof(AspNetCore.Views_TConcursoes_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716234224d0fdf2985a6a815bcaa0724bf1638fd", @"/Views/TConcursoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_TConcursoes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGIAMTP.Models.TConcurso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 201, true);
            WriteLiteral("\r\n\r\n<h3>Esta seguro, que desea eliminar este registro?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Nombre del Concurso:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(279, 43, false);
#line 16 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VcNombreCon));

#line default
#line hidden
            EndContext();
            BeginContext(322, 105, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Lugar del Concurso:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(428, 42, false);
#line 22 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VcLugarCon));

#line default
#line hidden
            EndContext();
            BeginContext(470, 105, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Fecha del Concurso:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(576, 47, false);
#line 28 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DcFechaConcurso));

#line default
#line hidden
            EndContext();
            BeginContext(623, 103, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cantidad Seriado:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(727, 46, false);
#line 34 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IcCantidadSeri));

#line default
#line hidden
            EndContext();
            BeginContext(773, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Cantidad Novel:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(875, 46, false);
#line 40 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IcCantidadNove));

#line default
#line hidden
            EndContext();
            BeginContext(921, 105, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Estado de Concurso:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1027, 68, false);
#line 46 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkIecIdEstadoNavigation.VeNombreEsta));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1133, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c4c957bc5414cea849aa5621234f98f", async() => {
                BeginContext(1159, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1169, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0299c1cd8304057a05ad72ab0b563c6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 51 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TConcursoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PkIcIdConcurso);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1217, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> \r\n        ");
                EndContext();
                BeginContext(1301, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3346a9e92a5b4a41a646d2880c926d67", async() => {
                    BeginContext(1347, 8, true);
                    WriteLiteral("Regresar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1359, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGIAMTP.Models.TConcurso> Html { get; private set; }
    }
}
#pragma warning restore 1591
