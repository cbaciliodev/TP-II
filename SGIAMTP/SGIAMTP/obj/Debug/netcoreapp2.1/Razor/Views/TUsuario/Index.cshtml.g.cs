#pragma checksum "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22a70b8941833ab50be91240e858e7e81e00cc75"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a70b8941833ab50be91240e858e7e81e00cc75", @"/Views/TUsuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGIAMTP.Models.TUsuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdministarParticipante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 193, true);
            WriteLiteral("\r\n    <div class=\"container-fluid col-xs-12 col-md-12 col-lg-12\" style=\"font-size:16px; font-family:\'Century Gothic\'\">\r\n\r\n        <div class=\"form-group \" style=\"margin-top:10px\">\r\n            ");
            EndContext();
            BeginContext(281, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d613487396ff49edbb5d2c39e170b047", async() => {
                BeginContext(368, 21, true);
                WriteLiteral("Registar Participante");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(393, 2158, true);
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
              ");
            WriteLiteral(@"                      Fecha de Nacimiento
                                </th>
                                <th class=""text-center"">
                                    Contraseña
                                </th>
                                <th class=""text-center"">
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
                                <th class=""text-center"" colspan=""3"">Acci&oacute;");
            WriteLiteral("n</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 58 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2640, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2761, 43, false);
#line 62 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(2804, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2932, 45, false);
#line 65 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3105, 45, false);
#line 68 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3150, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(3298, 52, false);
#line 71 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(3350, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(3498, 47, false);
#line 74 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(3545, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(3693, 41, false);
#line 77 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(3734, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(3882, 46, false);
#line 80 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.VuNacademia));

#line default
#line hidden
            EndContext();
            BeginContext(3928, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(4076, 51, false);
#line 83 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FkIuCodCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(4127, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(4275, 82, false);
#line 86 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FkItuTipoUsuarioNavigation.VtuNombreTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(4357, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(4505, 76, false);
#line 89 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.FkIuCodCategoriaNavigation.VcNomCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(4581, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(4728, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f0af16dccb04bf882b7ee0966d1bdc1", async() => {
                BeginContext(4802, 6, true);
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
#line 92 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
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
            BeginContext(4812, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4854, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b267b533d0194a959b1d757432e2ca72", async() => {
                BeginContext(4928, 7, true);
                WriteLiteral("Detalle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
            BeginContext(4939, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4981, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ab1ee1d19b44b328e54975012cbe897", async() => {
                BeginContext(5056, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
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
            BeginContext(5068, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 97 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(5183, 146, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
