#pragma checksum "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32416b26f67b368663782f94e43ab253170f380c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_AddInsumo), @"mvc.1.0.view", @"/Views/Produto/AddInsumo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/AddInsumo.cshtml", typeof(AspNetCore.Views_Produto_AddInsumo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32416b26f67b368663782f94e43ab253170f380c", @"/Views/Produto/AddInsumo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07690756d6862f193687ba4416be4a186e4b9728", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_AddInsumo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Market.Models.Insumo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2 chosen-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("multiple", new global::Microsoft.AspNetCore.Html.HtmlString("multiple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Selecione a categoria"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Categorias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddInsumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveInsumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("glyphicon glyphicon-trash fa-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditInsumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
  
    ViewData["Title"] = "AddInsumo";
    Layout = "~/Views/Shared/_LayoutAdministrativa.cshtml";

#line default
#line hidden
            BeginContext(150, 144, true);
            WriteLiteral("\r\n<div class=\"box box-info\">\r\n    <div class=\"box-header with-border\">\r\n        <h3 class=\"box-title\">Cadastro de produto</h3>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(294, 1880, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32416b26f67b368663782f94e43ab253170f380c7973", async() => {
                BeginContext(347, 46, true);
                WriteLiteral("\r\n        <div class=\"box-body\">\r\n            ");
                EndContext();
                BeginContext(393, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32416b26f67b368663782f94e43ab253170f380c8403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
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
                BeginContext(459, 1227, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""col-sm-4"">
                    <label class=""control-label"">Nome</label>
                    <input type=""text"" class=""form-control"" placeholder=""Nome do produto"" name=""Nome"">
                </div>

                <div class=""col-sm-4"">
                    <label class=""control-label"">Quantidade</label>
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control"" placeholder=""Quantidade em Kg"" name=""Quantidade"">
                        <span class=""input-group-addon"">Kg</span>
                    </div>
                </div>
                <div class=""col-sm-4"">
                    <label class=""control-label"">Valor</label>
                    <div class=""input-group"">
                        <span class=""input-group-addon"">R$</span>
                        <input type=""text"" class=""form-control"" placeholder=""Valor do Kg"" name=""Valor"">
                    </div>
          ");
                WriteLiteral("      </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <div class=\"col-sm-12\">\r\n                    <label class=\"control-label\">Categoria</label>\r\n                    ");
                EndContext();
                BeginContext(1686, 250, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32416b26f67b368663782f94e43ab253170f380c11503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 42 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.categorias;

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
                BeginContext(1936, 231, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"box-footer\">\r\n                <button type=\"submit\" value=\"Create\" class=\"btn btn-info pull-right\">Adicionar</button>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2174, 340, true);
            WriteLiteral(@"
</div>


<div class=""box"">
    <div class=""box-header"">
        <h3 class=""box-title"">Insumos</h3>
    </div>
    <!-- /.box-header -->
    <div class=""box-body no-padding"">
        <table class=""table table-hover"">
            <tbody>
                <tr>
                    <th style=""width: 35%"">
                        ");
            EndContext();
            BeginContext(2515, 24, false);
#line 64 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                   Write(Html.DisplayName("Nome"));

#line default
#line hidden
            EndContext();
            BeginContext(2539, 98, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 15%\">\r\n                        ");
            EndContext();
            BeginContext(2638, 31, false);
#line 67 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                   Write(Html.DisplayName("Preço em R$"));

#line default
#line hidden
            EndContext();
            BeginContext(2669, 98, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 15%\">\r\n                        ");
            EndContext();
            BeginContext(2768, 36, false);
#line 70 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                   Write(Html.DisplayName("Quantidade em Kg"));

#line default
#line hidden
            EndContext();
            BeginContext(2804, 118, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 25%; text-align: center\">\r\n                        ");
            EndContext();
            BeginContext(2923, 27, false);
#line 73 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                   Write(Html.DisplayName("Estoque"));

#line default
#line hidden
            EndContext();
            BeginContext(2950, 120, true);
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th style=\"width: 10%; text-align: center\">\r\n                        ");
            EndContext();
            BeginContext(3071, 26, false);
#line 77 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                   Write(Html.DisplayName("Editar"));

#line default
#line hidden
            EndContext();
            BeginContext(3097, 52, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3214, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3299, 39, false);
#line 84 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3338, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3430, 46, false);
#line 87 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PrecoInsumo));

#line default
#line hidden
            EndContext();
            BeginContext(3476, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3568, 45, false);
#line 90 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(3613, 65, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n");
            EndContext();
#line 94 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                              
                                double porcentagem = Math.Round((item.Quantidade / item.EstoqueMax) * 100, 1);

                                var color = "";
                                var bg = "";
                                string porc = porcentagem.ToString().Replace(",", ".");

                                if (porcentagem < 25)
                                {
                                    color = "progress-bar progress-bar-danger";
                                    bg = "badge bg-red";

                                }
                                if (porcentagem >= 25 && porcentagem < 50)
                                {
                                    color = "progress-bar progress-bar-yellow";
                                    bg = "badge bg-yellow";
                                }
                                if (porcentagem >= 50 && porcentagem <= 100)
                                {
                                    color = "progress-bar progress-bar-success";
                                    bg = "badge bg-green";
                                }

#line default
#line hidden
            BeginContext(4854, 266, true);
            WriteLiteral(@"                                <div class=""form-group"">
                                    <div class=""col-lg-9"">
                                        <div class=""progress progress-xs progress-striped active"">
                                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5120, "\"", 5134, 1);
#line 120 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue("", 5128, color, 5128, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 5135, "\"", 5156, 3);
            WriteAttributeValue("", 5143, "width:", 5143, 6, true);
#line 120 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue(" ", 5149, porc, 5150, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 5155, "%", 5155, 1, true);
            EndWriteAttribute();
            BeginContext(5157, 206, true);
            WriteLiteral("></div>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"col-lg-3\">\r\n                                        <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5363, "\"", 5374, 1);
#line 124 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue("", 5371, bg, 5371, 3, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5375, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5377, 11, false);
#line 124 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                                                     Write(porcentagem);

#line default
#line hidden
            EndContext();
            BeginContext(5388, 94, true);
            WriteLiteral("%</span>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
            BeginContext(5513, 118, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"text-align: center\">\r\n                            ");
            EndContext();
            BeginContext(5631, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32416b26f67b368663782f94e43ab253170f380c23246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                                                           WriteLiteral(item.IdInsumo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5734, 180, true);
            WriteLiteral("\r\n                            <a>&emsp;</a>\r\n                            <a href=\"#\" data-toggle=\"modal\" data-target=\"#modal-edit\" class=\"glyphicon glyphicon-edit fa-lg editInsumo\"");
            EndContext();
            BeginWriteAttribute("rel", "\r\n                               rel=\"", 5914, "\"", 6005, 7);
#line 134 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue("", 5952, item.Nome, 5952, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 5962, "|", 5962, 1, true);
#line 134 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue("", 5963, item.Quantidade, 5963, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5979, "|", 5979, 1, true);
#line 134 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue("", 5980, item.IdInsumo, 5980, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 5994, "|", 5994, 1, true);
#line 134 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
WriteAttributeValue("", 5995, item.Nome, 5995, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6006, 97, true);
            WriteLiteral(">\r\n                            </a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 139 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
                }

#line default
#line hidden
            BeginContext(6122, 540, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <!-- /.box-body -->
</div>


<!-- /.modal EDIT-->
<div class=""modal fade"" id=""modal-edit"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Editar Insumo</h4>

            </div>
            ");
            EndContext();
            BeginContext(6662, 2376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32416b26f67b368663782f94e43ab253170f380c27788", async() => {
                BeginContext(6692, 64, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    ");
                EndContext();
                BeginContext(6756, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32416b26f67b368663782f94e43ab253170f380c28239", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 161 "C:\Users\Lucas\Desktop\estoque\Market\Views\Produto\AddInsumo.cshtml"
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
                BeginContext(6822, 2209, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Nome</label>
                        <input id=""EditNome"" class=""form-control"" name=""EditNome"" />
                    </div>
                    <div class=""form-group"">
                        <label>Quantidade Atual</label>
                        <input id=""EditQuantidade"" class=""form-control"" name=""EditQuantidade"" disabled />
                    </div>

                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-lg-8"">
                                <label>Quantidade Modificada</label>
                                <input id=""EditQuantidade"" class=""form-control"" name=""EditQuantidade"" />
                            </div>
                            <div class=""col-lg-4"">
                                <label>Selecione opção</label>
                                <div class=""btn-group"" data-toggle=""buttons"">
                             ");
                WriteLiteral(@"       <label class=""btn btn-success"">
                                        <input type=""radio"" name=""option"" value=""adicionar"" autocomplete=""off"">Adicionar
                                    </label>
                                    <label class=""btn btn-danger"">
                                        <input type=""radio"" name=""option"" value=""remover"" autocomplete=""off"">Remover
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <select class=""form-control select2 "" multiple=""multiple"" id=""insumo"" style=""width: 100%;"" name=""insumo"">
                     
                    </select>
                   

                    <div class=""form-group row "">

                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""mod");
                WriteLiteral("al\">Fechar</button>\r\n                    <button class=\"btn btn-primary salvar\" name=\"EditId\" id=\"EditId\">Salvar</button>\r\n\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9038, 125, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <!-- /.modal-content -->\r\n    </div>\r\n    <!-- /.modal-dialog -->\r\n</div>\r\n<!-- /.modal EDIT-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Market.Models.Insumo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
