#pragma checksum "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "489fe526ed6af7562c40eb8fbfb51ab2b1a31500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gerenciamento_Categorias), @"mvc.1.0.view", @"/Views/Gerenciamento/Categorias.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gerenciamento/Categorias.cshtml", typeof(AspNetCore.Views_Gerenciamento_Categorias))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489fe526ed6af7562c40eb8fbfb51ab2b1a31500", @"/Views/Gerenciamento/Categorias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07690756d6862f193687ba4416be4a186e4b9728", @"/Views/_ViewImports.cshtml")]
    public class Views_Gerenciamento_Categorias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Market.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("glyphicon glyphicon-trash fa-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
  
    ViewData["Title"] = "Categorias";
    Layout = "~/Views/Shared/_LayoutAdministrativa.cshtml";

#line default
#line hidden
            BeginContext(154, 600, true);
            WriteLiteral(@"
<script>
    function Mudarestado(el) {
        var display = document.getElementById(el).style.display;
        if (display == ""none"") {
            document.getElementById(el).style.display = 'block';
            document.getElementById('addBtn').style.display = 'block';
        } else {
            document.getElementById(el).style.display = 'none';
            document.getElementById('addBtn').style.display = 'none';
        }
    }
</script>

<div class=""box box-info"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Categorias</h3>
    </div>
    ");
            EndContext();
            BeginContext(754, 1103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "489fe526ed6af7562c40eb8fbfb51ab2b1a315006958", async() => {
                BeginContext(854, 46, true);
                WriteLiteral("\r\n        <div class=\"box-body\">\r\n            ");
                EndContext();
                BeginContext(900, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "489fe526ed6af7562c40eb8fbfb51ab2b1a315007388", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 27 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
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
                BeginContext(966, 884, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""col-sm-12"">
                    <div>
                        <a href=""#"" class=""btn btn-primary btn-block"" onclick=""Mudarestado('addCategoria')""><i class=""glyphicon glyphicon-plus""></i> Nova Categoria de Produtos</a>
                    </div>
                </div>
            </div>
            <div class=""form-group"" id=""addCategoria"" style=""display:none"">
                <div class=""col-sm-12"">
                    <label class=""control-label"">Nome da categoria</label>
                    <input name=""Descricao"" class=""form-control"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1857, 353, true);
            WriteLiteral(@"
</div>

<div class=""box"">
    <div class=""box-header"">
        <h3 class=""box-title"">Categorias de Produtos</h3>
    </div>
    <!-- /.box-header -->
    <div class=""box-body no-padding"">
        <table class=""table table-hover"">
            <tbody>
                <tr>
                    <th style=""width: 90%"">
                        ");
            EndContext();
            BeginContext(2211, 29, false);
#line 58 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                   Write(Html.DisplayName("Categoria"));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 117, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 5%; text-align: center\">\r\n                        ");
            EndContext();
            BeginContext(2358, 26, false);
#line 61 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                   Write(Html.DisplayName("Editar"));

#line default
#line hidden
            EndContext();
            BeginContext(2384, 117, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th style=\"width: 5%; text-align: center\">\r\n                        ");
            EndContext();
            BeginContext(2502, 20, false);
#line 64 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                   Write(Html.DisplayName(""));

#line default
#line hidden
            EndContext();
            BeginContext(2522, 52, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2639, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2712, 44, false);
#line 71 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2756, 108, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td style=\"text-align: center\">\r\n                        ");
            EndContext();
            BeginContext(2864, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "489fe526ed6af7562c40eb8fbfb51ab2b1a3150014274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                                                          WriteLiteral(item.IdCategoria);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2973, 361, true);
            WriteLiteral(@"
                        
                    </td>

                    <td style=""text-align: center"">
                        <a href=""#"" data-toggle=""modal"" data-target=""#modal-edit"" class=""glyphicon glyphicon-edit fa-lg editInsumo""
                           rel="""">
                        </a>
                    </td>

                </tr>
");
            EndContext();
#line 86 "C:\Users\Lucas\Desktop\estoque\Market\Views\Gerenciamento\Categorias.cshtml"
                }

#line default
#line hidden
            BeginContext(3353, 85, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <!-- /.box-body -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Market.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
