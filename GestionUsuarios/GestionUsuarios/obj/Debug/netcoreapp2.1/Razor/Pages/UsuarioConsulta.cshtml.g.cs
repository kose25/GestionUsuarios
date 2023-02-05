#pragma checksum "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8e74d4cdbaa1a58ed1e46b7b9bf6d94edc16a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GestionUsuarios.Pages.Pages_UsuarioConsulta), @"mvc.1.0.razor-page", @"/Pages/UsuarioConsulta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UsuarioConsulta.cshtml", typeof(GestionUsuarios.Pages.Pages_UsuarioConsulta), null)]
namespace GestionUsuarios.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\_ViewImports.cshtml"
using GestionUsuarios;

#line default
#line hidden
#line 8 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 9 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
using UsuariosCore.Entidades;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8e74d4cdbaa1a58ed1e46b7b9bf6d94edc16a6", @"/Pages/UsuarioConsulta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6aa78d135543f1995ca303fc25a237ffeb25d03", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UsuarioConsulta : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Usuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
  
    ViewData["Title"] = "Usuario Consulta";
    Layout = "~/Pages/Shared/_DevExtremeLayout.cshtml";

#line default
#line hidden
            BeginContext(168, 23, false);
#line 7 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(191, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(254, 199, true);
            WriteLiteral("\r\n<div class=\"mt-4 mx-5\">\r\n    <h1>Usuario Consulta</h1>\r\n    <hr>\r\n    <p>Grid de consulta de usuarios registrados</p>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">       \r\n\r\n            ");
            EndContext();
            BeginContext(455, 1584, false);
#line 18 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
        Write(Html.DevExtreme().DataGrid<Usuarios>()
            .ID("TablaUsuarios")
            .ShowRowLines(true)
            .RemoteOperations(d=>d.Paging(true))
            .RowAlternationEnabled(true)
            .ShowBorders(true)
            .ShowColumnLines(true)
            .ShowRowLines(true)
            .FilterRow(q=>q.Visible(true))
            .AllowColumnReordering(true)
            .AllowColumnResizing(true)
            .ColumnAutoWidth(true)
            .RemoteOperations(c => c.Paging(true).Filtering(true))
            .Paging(paging => paging.PageSize(10))
            .Pager(pager =>
            {
                pager.ShowPageSizeSelector(true);
                pager.ShowNavigationButtons(true);
                pager.Visible(true);
                pager.AllowedPageSizes(new List<int>
                { 5, 10, 20 });
                pager.ShowInfo(true);
            })
            .OnRowClick("SeleccionarRegistro")
            .SearchPanel(d=>d.Visible(true))
            .DataSource(s=>s.RemoteController().LoadUrl(Url.Page("UsuarioConsulta", "ListaUsuarios")))
            .Columns(s=>{
                s.AddFor(q=>q.Nombre);
                s.AddFor(q=>q.Sexo);
                s.AddFor(q=>q.FechaNacimiento);
                s.Add().Visible(true).Caption("Acciones").Type(GridCommandColumnType.Buttons).Buttons(b=>{
                    b.Add().Icon("edit").Hint("editar").OnClick("EditarUsuarioFromGrid");
                    b.Add().Icon("remove").Hint("Eliminar").OnClick("EliminarUsuario");
                });
            }));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 79, true);
            WriteLiteral("\r\n\r\n            <div id=\"divformulario\" style=\"display:none\">\r\n                ");
            EndContext();
            BeginContext(2121, 114, false);
#line 55 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
            Write(Html.DevExtreme().Button().OnClick("esconderFormulario").Text("Volver").Icon("arrowleft").Type(ButtonType.Default));

#line default
#line hidden
            EndContext();
            BeginContext(2236, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2256, 1968, false);
#line 56 "C:\Users\Jose\Documents\vaino usuarios prueba\GestionUsuarios\GestionUsuarios\Pages\UsuarioConsulta.cshtml"
            Write(Html.DevExtreme().Form<Usuarios>()
                .ID("FormUsuarioEdit")
                .ColCount(12)
                .Items(items=>{

                    items.AddSimpleFor(m=>m.Nombre)
                    .ValidationRules(v=>v.AddRequired().Message("El nombre es requerido"))
                    .ValidationRules(q=>q.AddStringLength().Min(1).Max(100).Message("maximo 100")).IsRequired(true)
                    .Label(f=>f.Location(FormLabelLocation.Top)
                    .Text("Nombre"))
                    .ColSpan(6)
                    .Editor(d=>d.TextBox().MaxLength(100).Placeholder("ingrese el nombre"));

                    items.AddSimpleFor(g=>g.Sexo).ColSpan(6)
                    .ValidationRules(r=>r.AddRequired().Message("este campo es requerido")).IsRequired(true)
                    .Label(d=>d.Location(FormLabelLocation.Top).Text("Sexo"))
                    .Editor(f=>f.SelectBox().Placeholder("seleccione el sexo").DataSource(ds=>ds.Array().Data(new List<string>() {
                        "M","F"
                        })));                

                    items.AddSimpleFor(f=>f.FechaNacimiento).ColSpan(6)
                    .ValidationRules(r=>r.AddRequired().Message("la fecha es obligatoria")).IsRequired(true)
                    .Label(d=>d.Location(FormLabelLocation.Top).Text("Fecha de naciemiento"))
                    .Editor(f=>f.DateBox().Max(DateTime.Now).DateSerializationFormat("yyyy-MM-dd").DisplayFormat("dd/MM/yyy").Placeholder("Ingrese fecha"));

                    items.AddEmpty().ColSpan(6);
                    items.AddButton()
                    .ButtonOptions(s=>s.Icon("save").ID("btnsalvar")
                    .OnClick("Editar")
                    .Type(ButtonType.Default).Text("Guardar")).ColSpan(3)
                    .HorizontalAlignment(HorizontalAlignment.Left)
                    .VerticalAlignment(VerticalAlignment.Bottom);

                }));

#line default
#line hidden
            EndContext();
            BeginContext(4225, 68, true);
            WriteLiteral("\r\n    \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(4293, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f8e74d4cdbaa1a58ed1e46b7b9bf6d94edc16a69687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GestionUsuarios.Pages.UsuarioConsultaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GestionUsuarios.Pages.UsuarioConsultaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GestionUsuarios.Pages.UsuarioConsultaModel>)PageContext?.ViewData;
        public GestionUsuarios.Pages.UsuarioConsultaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
