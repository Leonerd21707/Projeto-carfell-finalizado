#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf1a416fdd6fcfef856f02231e7fe758927c945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf1a416fdd6fcfef856f02231e7fe758927c945", @"/Views/Usuario/Cadastrar.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("styles", async() => {
                BeginContext(16, 83, true);
                WriteLiteral("\n    <link href=\"/css/Cadastrousuario.css\" rel=\"stylesheet\" type=\"text/css\" />\n    ");
                EndContext();
            }
            );
#line 4 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Usuario\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastrar Usuário";
    Layout = "MasterPageDeslogado";

#line default
#line hidden
            BeginContext(183, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(186, 16, false);
#line 10 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Usuario\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(202, 448, true);
            WriteLiteral(@"
<div class=""cadastro"">
    <h1> Cadastro de Usuarios</h1>


<form class=""info""  action=""/Usuario/Cadastrar"" method=""POST"">
    <label>
        Nome
        <input type=""text""  name=""nome"">
    </label>

    <label>
        Email
        <input type=""email"" name=""email"">
    </label>

    <label>
        Senha
        <input type=""password"" name=""senha"">
    </label>
    

    <input class=""enviar"" type=""submit"" value=""Enviar"">

</form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
