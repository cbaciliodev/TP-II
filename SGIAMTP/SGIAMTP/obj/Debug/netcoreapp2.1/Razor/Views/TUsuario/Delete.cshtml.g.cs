#pragma checksum "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19eb242890881f21e2f5439b4d66c3fd1628bab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuario_Delete), @"mvc.1.0.view", @"/Views/TUsuario/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuario/Delete.cshtml", typeof(AspNetCore.Views_TUsuario_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb242890881f21e2f5439b4d66c3fd1628bab9", @"/Views/TUsuario/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c849864aa56c7471393875712d69497bce88c7", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuario_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SGIAMTP.Models.TUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(76, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>TUsuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 44, false);
#line 15 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(290, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(334, 40, false);
#line 18 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuNombre));

#line default
#line hidden
            EndContext();
            BeginContext(374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(418, 46, false);
#line 21 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(464, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(508, 42, false);
#line 24 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuApaterno));

#line default
#line hidden
            EndContext();
            BeginContext(550, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(594, 46, false);
#line 27 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(640, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(684, 42, false);
#line 30 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuAmaterno));

#line default
#line hidden
            EndContext();
            BeginContext(726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(770, 53, false);
#line 33 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(867, 49, false);
#line 36 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DuFechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(916, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(960, 48, false);
#line 39 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1052, 44, false);
#line 42 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuContraseña));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1140, 42, false);
#line 45 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1226, 38, false);
#line 48 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuSexo));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1308, 47, false);
#line 51 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNacademia));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1399, 43, false);
#line 54 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuNacademia));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1486, 42, false);
#line 57 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VuFoto));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1572, 38, false);
#line 60 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VuFoto));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1654, 62, false);
#line 63 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FkItuTipoUsuarioNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1760, 75, false);
#line 66 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkItuTipoUsuarioNavigation.PkItuTipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1879, 62, false);
#line 69 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuCodCategoriaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1985, 69, false);
#line 72 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FkIuCodCategoriaNavigation.PkIcCodCat));

#line default
#line hidden
            EndContext();
            BeginContext(2054, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2092, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d0327798bb45f2b290a76850a02a39", async() => {
                BeginContext(2118, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2128, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5c1ef7b8d51f4e8a80427fbeae2ce18c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "D:\universidad\taller de proyectos\SGIAMTP\SGIAMTP\Views\TUsuario\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PkIuDni);

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
                BeginContext(2169, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2253, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e395c66e7ee142ddb0627d50e0f482f6", async() => {
                    BeginContext(2275, 12, true);
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
                BeginContext(2291, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2304, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SGIAMTP.Models.TUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
