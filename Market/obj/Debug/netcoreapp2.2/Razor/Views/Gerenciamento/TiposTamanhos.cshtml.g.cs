#pragma checksum "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6ccfc9f4b1291bea7dbf3cadf752139728faa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gerenciamento_TiposTamanhos), @"mvc.1.0.view", @"/Views/Gerenciamento/TiposTamanhos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gerenciamento/TiposTamanhos.cshtml", typeof(AspNetCore.Views_Gerenciamento_TiposTamanhos))]
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
#line 1 "C:\Users\Lucas\Desktop\estoque\Market\Views\_ViewImports.cshtml"
using Market;

#line default
#line hidden
#line 2 "C:\Users\Lucas\Desktop\estoque\Market\Views\_ViewImports.cshtml"
using Market.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff6ccfc9f4b1291bea7dbf3cadf752139728faa4", @"/Views/Gerenciamento/TiposTamanhos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07690756d6862f193687ba4416be4a186e4b9728", @"/Views/_ViewImports.cshtml")]
    public class Views_Gerenciamento_TiposTamanhos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Market.Models.Medida>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "CategoriaId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TiposTamanhos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveTiposTamanhos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("glyphicon glyphicon-trash fa-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
  
    ViewData["Title"] = "TiposTamanhos";
    Layout = "~/Views/Shared/_LayoutAdministrativa.cshtml";


#line default
#line hidden
            BeginContext(156, 689, true);
            WriteLiteral(@"

<script>
    function Mudarestado(el) {
        var display = document.getElementById(el).style.display;
        if (display == ""none"") {
            document.getElementById(el).style.display = 'block';
            document.getElementById('addBtn').style.display = 'block';
            //document.getElementById('categoria').className += 'select2';

        } else {
            document.getElementById(el).style.display = 'none';
            document.getElementById('addBtn').style.display = 'none';           
        }
    }
</script>


<div class=""box box-info"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Medida</h3>
    </div>
    ");
            EndContext();
            BeginContext(845, 1778, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6ccfc9f4b1291bea7dbf3cadf752139728faa47698", async() => {
                BeginContext(902, 46, true);
                WriteLiteral("\r\n        <div class=\"box-body\">\r\n            ");
                EndContext();
                BeginContext(948, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6ccfc9f4b1291bea7dbf3cadf752139728faa48128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 32 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1014, 1020, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""col-sm-12"">
                    <div>
                        <a href=""#"" class=""btn btn-primary btn-block"" onclick=""Mudarestado('addMedida')""><i class=""glyphicon glyphicon-plus""></i> Nova Medida de Produtos</a>
                    </div>
                </div>
            </div>
            <div id=""addMedida"" style=""display:none"">
                <div class=""form-group"">
                    <div class=""col-sm-4"">
                        <label class=""control-label"">Nome</label>
                        <input class=""form-control text-danger"" name=""Nome"" />
                    </div>
                    <div class=""col-sm-3"">
                        <label class=""control-label"">Sigla</label>
                        <input class=""form-control"" name=""Sigla"" />
                    </div>
                    <div class=""col-lg-5"">
                        <label class=""control-label"">Categoria</label>
                        ");
                EndContext();
                BeginContext(2034, 290, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6ccfc9f4b1291bea7dbf3cadf752139728faa410971", async() => {
                    BeginContext(2223, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(2253, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6ccfc9f4b1291bea7dbf3cadf752139728faa411406", async() => {
                        BeginContext(2261, 19, true);
                        WriteLiteral("Selecione categoria");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2289, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 53 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.categorias, "IdCategoria", "Descricao"));

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2324, 292, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""box-footer"" id=""addBtn"" style=""display:none"">
                <button type=""submit"" value=""Create"" class=""btn btn-info pull-right"">Adicionar</button>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2623, 340, true);
            WriteLiteral(@"
</div>


<div class=""box"">
    <div class=""box-header"">
        <h3 class=""box-title"">Medidas</h3>
    </div>
    <!-- /.box-header -->
    <div class=""box-body no-padding"">
        <table class=""table table-hover"">
            <tbody>
                <tr>
                    <th style=""width: 60%"">
                        ");
            EndContext();
            BeginContext(2964, 24, false);
#line 78 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                   Write(Html.DisplayName("Nome"));

#line default
#line hidden
            EndContext();
            BeginContext(2988, 99, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 20%;\">\r\n                        ");
            EndContext();
            BeginContext(3088, 29, false);
#line 81 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                   Write(Html.DisplayName("Categoria"));

#line default
#line hidden
            EndContext();
            BeginContext(3117, 98, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 5%;\">\r\n                        ");
            EndContext();
            BeginContext(3216, 25, false);
#line 84 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                   Write(Html.DisplayName("Sigla"));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 118, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 15%; text-align: center\">\r\n                        ");
            EndContext();
            BeginContext(3360, 20, false);
#line 87 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                   Write(Html.DisplayName(""));

#line default
#line hidden
            EndContext();
            BeginContext(3380, 54, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n\r\n");
            EndContext();
#line 91 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3499, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3584, 39, false);
#line 95 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3623, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3717, 54, false);
#line 99 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Categoria.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3865, 40, false);
#line 103 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Sigla));

#line default
#line hidden
            EndContext();
            BeginContext(3905, 120, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td style=\"text-align: center\">\r\n                            ");
            EndContext();
            BeginContext(4025, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff6ccfc9f4b1291bea7dbf3cadf752139728faa420108", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                                                                  WriteLiteral(item.IdMedida);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4135, 277, true);
            WriteLiteral(@"


                            <a href=""#"" data-toggle=""modal"" data-target=""#modal-edit"" class=""glyphicon glyphicon-edit fa-lg editInsumo""
                               rel="""">
                            </a>
                        </td>

                    </tr>
");
            EndContext();
#line 116 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\TiposTamanhos.cshtml"
                }

#line default
#line hidden
            BeginContext(4431, 84, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <!-- /.box-body -->\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Market.Models.Medida>> Html { get; private set; }
    }
}
#pragma warning restore 1591
