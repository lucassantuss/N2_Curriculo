#pragma checksum "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\_ExperienciaProfissional.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e6fe9699f076bd06c683ec736ba173a554c158c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curriculo__ExperienciaProfissional), @"mvc.1.0.view", @"/Views/Curriculo/_ExperienciaProfissional.cshtml")]
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
#nullable restore
#line 1 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\_ViewImports.cshtml"
using N2_Curriculo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\_ViewImports.cshtml"
using N2_Curriculo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e6fe9699f076bd06c683ec736ba173a554c158c", @"/Views/Curriculo/_ExperienciaProfissional.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee761c2a725536a28f0d2343fca5630af5c2ec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Curriculo__ExperienciaProfissional : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExperienciaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("SalvarExperiencia"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e6fe9699f076bd06c683ec736ba173a554c158c4349", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Operacao\"");
                BeginWriteAttribute("value", " value=\"", 137, "\"", 162, 1);
#nullable restore
#line 4 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\_ExperienciaProfissional.cshtml"
WriteAttributeValue("", 145, ViewBag.Operacao, 145, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <label for=\"empresa\" class=\"control-label\">Empresa</label>\r\n    <input type=\"text\" Name=\"empresa\"");
                BeginWriteAttribute("value", " value=\"", 271, "\"", 293, 1);
#nullable restore
#line 7 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\_ExperienciaProfissional.cshtml"
WriteAttributeValue("", 279, Model.empresa, 279, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"/>\r\n    <br />\r\n    <label for=\"cargo\" class=\"control-label\">Cargo</label>\r\n    <input type=\"text\" Name=\"cargo\"");
                BeginWriteAttribute("value", " value=\"", 426, "\"", 446, 1);
#nullable restore
#line 10 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\_ExperienciaProfissional.cshtml"
WriteAttributeValue("", 434, Model.cargo, 434, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"/>\r\n    <br />\r\n    <label for=\"data_inicio\" class=\"control-label\">Data de Inicio</label>\r\n    <input type=\"date\" Name=\"data_inicio\"");
                BeginWriteAttribute("value", " value=\"", 600, "\"", 649, 1);
#nullable restore
#line 13 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\_ExperienciaProfissional.cshtml"
WriteAttributeValue("", 608, Model.data_inicio.ToString("yyyy-MM-dd"), 608, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"/>\r\n    <br />\r\n    <label for=\"data_fim\" class=\"control-label\">Data Final</label>\r\n    <input type=\"date\" Name=\"data_fim\"");
                BeginWriteAttribute("value", " value=\"", 793, "\"", 839, 1);
#nullable restore
#line 16 "E:\GITHUB\N2_Curriculo\N2_B1 - Curriculo\N2_Curriculo\Views\Curriculo\_ExperienciaProfissional.cshtml"
WriteAttributeValue("", 801, Model.data_fim.ToString("yyyy-MM-dd"), 801, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"/>\r\n    <br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Salvar\" class=\"btn btn-success\" />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExperienciaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591