#pragma checksum "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92e95b99ac9629a7c1f5a291fc2f4caefc96424c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Index.cshtml", typeof(AspNetCore.Views_Clientes_Index))]
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
#line 1 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\_ViewImports.cshtml"
using GestaoDeClientes;

#line default
#line hidden
#line 2 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\_ViewImports.cshtml"
using GestaoDeClientes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92e95b99ac9629a7c1f5a291fc2f4caefc96424c", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348f2d182f9127620b9ac5a5a988aafa88ad9e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestaoDeClientes.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/index/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bootstrap-stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-lighten-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:burlywood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:lightcoral"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Excluir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92e95b99ac9629a7c1f5a291fc2f4caefc96424c7515", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(215, 172, true);
            WriteLiteral("\r\n\r\n<!-- Begin page -->\r\n<div id=\"wrapper\">\r\n\r\n    <div class=\"container-fluid\">\r\n\r\n        <div class=\"tab-content profile-tab-content\">\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(387, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92e95b99ac9629a7c1f5a291fc2f4caefc96424c9128", async() => {
                BeginContext(458, 12, true);
                WriteLiteral("Novo Cliente");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
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
            BeginContext(474, 576, true);
            WriteLiteral(@"
            </p>
            <!-- Personal-Information -->
            <div class=""card card-default card-fill"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Catálogo de Clientes</h3>
                </div>
                <div class=""card-body"">
                    <!---->
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <!--th>
                                ");
            EndContext();
            BeginContext(1051, 49, false);
#line 30 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClientePerfil));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 383, true);
            WriteLiteral(@"
                            </th-->
                                    <th>

                                        Nome
                                    </th>
                                    <th>
                                        Empresa
                                    </th>
                                    <!--th>
                                ");
            EndContext();
            BeginContext(1484, 55, false);
#line 40 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteNomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 251, true);
            WriteLiteral("\r\n                            </th-->\r\n                                    <th>\r\n                                        CPF/CNPJ\r\n                                    </th>\r\n                                    <!--th>\r\n                                ");
            EndContext();
            BeginContext(1791, 51, false);
#line 46 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteTelefone));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 382, true);
            WriteLiteral(@"
                            </th-->
                                    <th>
                                        Celular
                                    </th>
                                    <th>
                                        Email
                                    </th>
                                    <!--th>
                                ");
            EndContext();
            BeginContext(2225, 46, false);
#line 55 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteRua));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2375, 49, false);
#line 58 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteNumero));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2528, 46, false);
#line 61 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteCep));

#line default
#line hidden
            EndContext();
            BeginContext(2574, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2678, 49, false);
#line 64 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteCidade));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2831, 49, false);
#line 67 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteEstado));

#line default
#line hidden
            EndContext();
            BeginContext(2880, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2984, 53, false);
#line 70 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClienteEndComplem));

#line default
#line hidden
            EndContext();
            BeginContext(3037, 200, true);
            WriteLiteral("\r\n                            </th-->\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 76 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                 foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3310, 115, true);
            WriteLiteral("                                <tr>\r\n                                    <!--td>\r\n                                ");
            EndContext();
            BeginContext(3426, 48, false);
#line 80 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClientePerfil));

#line default
#line hidden
            EndContext();
            BeginContext(3474, 123, true);
            WriteLiteral("\r\n                            </td-->\r\n                                    <td>\r\n\r\n                                        ");
            EndContext();
            BeginContext(3598, 46, false);
#line 84 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ClienteNome));

#line default
#line hidden
            EndContext();
            BeginContext(3644, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3772, 49, false);
#line 87 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ClienteEmpresa));

#line default
#line hidden
            EndContext();
            BeginContext(3821, 122, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <!--td>\r\n                                ");
            EndContext();
            BeginContext(3944, 54, false);
#line 90 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteNomeFantasia));

#line default
#line hidden
            EndContext();
            BeginContext(3998, 121, true);
            WriteLiteral("\r\n                            </td-->\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4120, 49, false);
#line 93 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ClienteCpfCnpj));

#line default
#line hidden
            EndContext();
            BeginContext(4169, 122, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <!--td>\r\n                                ");
            EndContext();
            BeginContext(4292, 50, false);
#line 96 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteTelefone));

#line default
#line hidden
            EndContext();
            BeginContext(4342, 121, true);
            WriteLiteral("\r\n                            </td-->\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4464, 49, false);
#line 99 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ClienteCelular));

#line default
#line hidden
            EndContext();
            BeginContext(4513, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4641, 47, false);
#line 102 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ClienteEmail));

#line default
#line hidden
            EndContext();
            BeginContext(4688, 122, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <!--td>\r\n                                ");
            EndContext();
            BeginContext(4811, 45, false);
#line 105 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteRua));

#line default
#line hidden
            EndContext();
            BeginContext(4856, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4960, 48, false);
#line 108 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteNumero));

#line default
#line hidden
            EndContext();
            BeginContext(5008, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5112, 45, false);
#line 111 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteCep));

#line default
#line hidden
            EndContext();
            BeginContext(5157, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5261, 48, false);
#line 114 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteCidade));

#line default
#line hidden
            EndContext();
            BeginContext(5309, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5413, 48, false);
#line 117 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteEstado));

#line default
#line hidden
            EndContext();
            BeginContext(5461, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(5565, 52, false);
#line 120 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ClienteEndComplem));

#line default
#line hidden
            EndContext();
            BeginContext(5617, 121, true);
            WriteLiteral("\r\n                            </td-->\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5738, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92e95b99ac9629a7c1f5a291fc2f4caefc96424c24494", async() => {
                BeginContext(5826, 34, true);
                WriteLiteral("<i class=\"material-icons\">edit</i>");
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
#line 123 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                                                                                   WriteLiteral(item.ClienteId);

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
            BeginContext(5864, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5906, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92e95b99ac9629a7c1f5a291fc2f4caefc96424c27071", async() => {
                BeginContext(6007, 35, true);
                WriteLiteral("<i class=\"material-icons\">clear</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
                                                                                                  WriteLiteral(item.ClienteId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6046, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 127 "C:\Users\juliano.silva\Desktop\Projeto_v3\GestaoDeClientes\GestaoDeClientes\Views\Clientes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(6141, 462, true);
            WriteLiteral(@"                            </tbody>
                        </table>

                    </div>

                </div>
            </div>
            <!-- Personal-Information -->

        </div>

        <!-- end container-fluid -->

    </div>


    <!-- ============================================================== -->
    <!-- End Page content -->
    <!-- ============================================================== -->

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestaoDeClientes.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
