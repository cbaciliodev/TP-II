#pragma checksum "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79198b98d29c5a17eb3aec3f16a499577e004d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuario_Index), @"mvc.1.0.view", @"/Views/TUsuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuario/Index.cshtml", typeof(AspNetCore.Views_TUsuario_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79198b98d29c5a17eb3aec3f16a499577e004d0e", @"/Views/TUsuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGIAMTP.Models.TUsuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Usuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/UsuarioModalidad.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 173, true);
            WriteLiteral("\r\n<div class=\"container-fluid col-xs-12 col-md-12 col-lg-12\" style=\"font-size:16px; font-family:\'Century Gothic\'\">\r\n\r\n    <div class=\"form-group \" style=\"margin-top:10px\">\r\n");
            EndContext();
            BeginContext(384, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(392, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd7dabb4ca714b2fbfe89efbe456d59b", async() => {
                BeginContext(459, 14, true);
                WriteLiteral("Volver al Menú");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(477, 1010, true);
            WriteLiteral(@"
    </div>
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            <div>
                <h4 class=""panel-title"">Lista de Usuarios</h4>
            </div>
        </div>

        <div class=""panel panel-body form-group"">
            <div class=""table-responsive"">
                <table class=""table table-condensed table-hover table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th class=""text-center"">
                                Nombre
                            </th>
                            <th class=""text-center"">
                                Apellido Paterno
                            </th>
                            <th class=""text-center"">
                                Apellido Materno
                            </th>
                            <th class=""text-center"">
                                Fecha de Nacimiento
                            </th>
");
            EndContext();
            BeginContext(1632, 831, true);
            WriteLiteral(@"                            <th class=""text-center"">
                                Genero
                            </th>
                            <th class=""text-center"">
                                Academia
                            </th>
                            <th class=""text-center"">
                                Foto
                            </th>
                            <th class=""text-center"">
                                Tipo de Usuario
                            </th>
                            <th class=""text-center"">
                                Categoria
                            </th>
                            <th class=""text-center"" colspan=""2"">Acci&oacute;n</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 59 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2544, 140, true);
            WriteLiteral("                            <tr >\r\n                                <td style=\"vertical-align:middle;\">\r\n                                    ");
            EndContext();
            BeginContext(2685, 43, false);
#line 63 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(2728, 147, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\"> \r\n                                    ");
            EndContext();
            BeginContext(2876, 45, false);
#line 66 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(2921, 146, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\">\r\n                                    ");
            EndContext();
            BeginContext(3068, 45, false);
#line 69 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(3280, 52, false);
#line 72 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(3332, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
            BeginContext(3568, 125, true);
            WriteLiteral("                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(3694, 41, false);
#line 78 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(3735, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(3902, 46, false);
#line 81 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.VuNacademia));

#line default
#line hidden
            EndContext();
            BeginContext(3948, 170, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4118, "\"", 4166, 1);
#line 84 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
WriteAttributeValue("", 4124, Html.DisplayFor(modelItem => item.VuFoto), 4124, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4167, 210, true);
            WriteLiteral(" alt=\"Alternate Text\" style=\"height:60px\" />\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(4378, 82, false);
#line 87 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkItuTipoUsuarioNavigation.VtuNombreTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(4460, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(4627, 76, false);
#line 90 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuCodCategoriaNavigation.VcNomCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(4703, 166, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(4869, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2efdc75e395d41e1942cdefda26e6ebf", async() => {
                BeginContext(4943, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                                                                   WriteLiteral(item.PkIuDni);

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
            BeginContext(4953, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
            BeginContext(5226, 125, true);
            WriteLiteral("                                <td style=\"vertical-align:middle;\" class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(5351, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54b034b06c604ccbb681c5e54ccba6ae", async() => {
                BeginContext(5426, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                                                                    WriteLiteral(item.PkIuDni);

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
            BeginContext(5438, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 102 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5541, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5673, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(5681, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fce4df950ed64dda9d5fb85f84960b7b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5717, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5723, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be7f0e1ee1f34f95bd4e31ad5f5aad11", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5762, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5768, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edbe6f6bc10c4152aecce3d6c895af23", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5816, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 115 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(5889, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SGIAMTP.Models.TUsuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
