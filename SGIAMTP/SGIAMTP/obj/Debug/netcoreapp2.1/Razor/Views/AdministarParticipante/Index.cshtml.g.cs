#pragma checksum "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f466705fd51895ef0d300328c4331e3a71a0fb9"
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
#line 1 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\_ViewImports.cshtml"
using SGIAMTP;

#line default
#line hidden
#line 2 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\_ViewImports.cshtml"
using SGIAMTP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f466705fd51895ef0d300328c4331e3a71a0fb9", @"/Views/AdministarParticipante/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_AdministarParticipante_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SGIAMTP.Models.TUsuarioModalidad>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 239, true);
            WriteLiteral("<style>\r\n    #contenedor {\r\n        margin-top: 20px;\r\n    }\r\n\r\n    #temporal {\r\n        margin-top: 10px;\r\n    }\r\n</style>\r\n<br />\r\n<div id=\"contenedor\" class=\"container-fluid\" style=\"font-size:16px; font-family:\'Century Gothic\'\">\r\n\r\n    ");
            EndContext();
<<<<<<< HEAD
            BeginContext(126, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91440539c4574bfc8f44e65af6800ed9", async() => {
                BeginContext(149, 10, true);
                WriteLiteral("Create New");
=======
            BeginContext(336, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a2a2297d8b54237b9e765437c7ba1c4", async() => {
                BeginContext(383, 22, true);
                WriteLiteral("Registrar Participante");
>>>>>>> 4b1659bb7826f0d28a8b56487166837f689f3ac3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(409, 1680, true);
            WriteLiteral(@"
    <br /><br />
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
            <div>
                <h4 class=""panel-title"">Lista de Participantes</h4>
            </div>
        </div>

        <div class=""panel panel-body form-group"">
            <div class=""table-responsive"">
                <table class=""table table-condensed table-hover table-striped table-bordered"">
                    <thead>
                        <tr>
                            <th>
                                Fase
                            </th>
                            <th class=""text-center"">
                                Fecha Inscripci&oacute;n
                            </th>
                            <th class=""text-center"">
                                Dni
                            </th>
                            <th class=""text-center"">
                                Pago
                            </th>
                            <th class=""text-c");
            WriteLiteral(@"enter"">
                                Concurso
                            </th>
                            <th class=""text-center"">
                                Modalidad
                            </th>
                            <th class=""text-center"">
                                PArticipante
                            </th>
                            <th class=""text-center"">
                                Pareja
                            </th>
                            <th class=""text-center"" colspan=""3"">Acci&oacute;n</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 60 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2170, 128, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(2299, 42, false);
#line 64 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.IumFase));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 135, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(2477, 46, false);
#line 67 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DumFechaIns));

#line default
#line hidden
            EndContext();
            BeginContext(2523, 142, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2665, "\"", 2723, 1);
#line 70 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
WriteAttributeValue("", 2673, Html.DisplayFor(modelItem => item.VmUmArchivoDni), 2673, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2724, 233, true);
            WriteLiteral(" class=\"btn btn-success openBtn\" id=\"verModal\" onclick=\"openModal(this.value)\">Ver</button>\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2957, "\"", 3013, 1);
#line 73 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
WriteAttributeValue("", 2965, Html.DisplayFor(modelItem => item.VmUmArchivoB), 2965, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3014, 226, true);
            WriteLiteral(" class=\"btn btn-success openBtn\" id=\"verModal\" onclick=\"openModal(this.value)\">Ver</button>\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(3241, 71, false);
#line 76 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIcIdConcursoNavigation.VcNombreCon));

#line default
#line hidden
            EndContext();
            BeginContext(3312, 135, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
            BeginContext(3448, 72, false);
#line 79 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkImIdModalidadNavigation.VmNombreMod));

#line default
#line hidden
            EndContext();
            BeginContext(3520, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(3657, 61, false);
#line 82 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuDniNavigation.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(3718, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3757, 63, false);
#line 83 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuDniNavigation.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3820, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3859, 63, false);
#line 84 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuDniNavigation.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(3922, 136, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-justify\">\r\n                                    ");
            EndContext();
            BeginContext(4059, 67, false);
#line 87 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuDniParejaNavigation.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(4126, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4165, 69, false);
#line 88 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuDniParejaNavigation.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(4234, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4273, 69, false);
#line 89 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FkIuDniParejaNavigation.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(4342, 135, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2018, 66, false);
#line 67 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIuDniParejaNavigation.PkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2139, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0d592a7ede4f8687333c6731d1766e", async() => {
                BeginContext(2192, 4, true);
                WriteLiteral("Edit");
=======
            BeginContext(4477, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17cca79dcf5c4daba859e55153947ac9", async() => {
                BeginContext(4554, 6, true);
                WriteLiteral("Editar");
>>>>>>> 4b1659bb7826f0d28a8b56487166837f689f3ac3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
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
            BeginContext(4564, 137, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2220, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dddc5bde09746a0a465115eeb40e607", async() => {
                BeginContext(2276, 7, true);
                WriteLiteral("Details");
=======
            BeginContext(4701, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "759fd620c1d641d78d9c1753617fbcd6", async() => {
                BeginContext(4778, 8, true);
                WriteLiteral("Detalles");
>>>>>>> 4b1659bb7826f0d28a8b56487166837f689f3ac3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
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
            BeginContext(4790, 137, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td class=\"text-center\">\r\n                                    ");
            EndContext();
<<<<<<< HEAD
            BeginContext(2307, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f5903c7ae724a198ebddcdad96190bd", async() => {
                BeginContext(2362, 6, true);
                WriteLiteral("Delete");
=======
            BeginContext(4927, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3361ce6097f423bae8bb624744ab372", async() => {
                BeginContext(5005, 8, true);
                WriteLiteral("Eliminar");
>>>>>>> 4b1659bb7826f0d28a8b56487166837f689f3ac3
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
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
            BeginContext(5017, 78, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 104 "C:\Proyectos\TPII\TP-II\SGIAMTP\SGIAMTP\Views\AdministarParticipante\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5122, 1047, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
                <h4 class=""modal-title"">Archivo Adjunto</h4>
            </div>
            <div class=""modal-body"">
                <embed id=""mostarPdf"" width=""580"" height=""375""
                       type=""application/pdf"" src="""">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cerrar</button>
            </div>
        </div>
    </div>
</div>

<script>

    function openModal(value) {


        $(""#mostarPdf"").attr(""src"", value);

        $('#myModal').modal({ show: true, backdrop: 'static', keyboard: false })");
            WriteLiteral(";\r\n\r\n    }\r\n\r\n</script>");
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
