#pragma checksum "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44c7844aa4b13d115a74b49f9d79aecb5197c569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Comentarios), @"mvc.1.0.view", @"/Views/Administrador/Comentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Comentarios.cshtml", typeof(AspNetCore.Views_Administrador_Comentarios))]
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
#line 1 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
using Senai.Sprint4.Carfel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44c7844aa4b13d115a74b49f9d79aecb5197c569", @"/Views/Administrador/Comentarios.cshtml")]
    public class Views_Administrador_Comentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
  
    ViewBag.Title = "Aprove ou Rejeite um comenttario";
    Layout = "MasterPageLogado";

#line default
#line hidden
            BeginContext(131, 82, true);
            WriteLiteral("\n<h1>Seleção de comentarios</h1>\n\n<style>\ntextarea{\n    resize: none;\n}\n</style>\n\n");
            EndContext();
            BeginContext(214, 16, false);
#line 16 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(230, 245, true);
            WriteLiteral("\n\n<table>\n    <thead>\n        <tr>\n            <th>Id</th>\n            <th>Nome</th>\n            <th>Comentario</th>\n            <th>Data Criação</th>\n            <th>Status</th>\n            <th>ações</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 30 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
         foreach (var item in ViewData["comentarios"] as List<ComentarioModel>)
        {

#line default
#line hidden
            BeginContext(565, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(624, 7, false);
#line 34 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(631, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(696, 17, false);
#line 37 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
               Write(item.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(713, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(778, 15, false);
#line 40 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
               Write(item.Comentario);

#line default
#line hidden
            EndContext();
            BeginContext(793, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(858, 36, false);
#line 43 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
               Write(item.DataCriacao.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(894, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(959, 13, false);
#line 46 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
               Write(item.Aprovado);

#line default
#line hidden
            EndContext();
            BeginContext(972, 65, true);
            WriteLiteral("\n               </td>\n                <td>\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1037, "\"", 1078, 2);
            WriteAttributeValue("", 1044, "/Administrador/Alterar?id=", 1044, 26, true);
#line 49 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
WriteAttributeValue("", 1070, item.Id, 1070, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1079, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 50 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
                     if(item.Aprovado){

#line default
#line hidden
            BeginContext(1121, 39, true);
            WriteLiteral("                       <p>Rejeitar</p>\n");
            EndContext();
#line 52 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
                    } else {

#line default
#line hidden
            BeginContext(1189, 38, true);
            WriteLiteral("                       <p>Aprovar</p>\n");
            EndContext();
#line 54 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
                    }

#line default
#line hidden
            BeginContext(1249, 86, true);
            WriteLiteral("                    </a>\n                    \n                </td>\n            </tr>\n");
            EndContext();
#line 59 "C:\Users\FIC\Documents\Projetos_SENAI\projetos\Carfell_Area_de_Comentarios-master\Views\Administrador\Comentarios.cshtml"
        }

#line default
#line hidden
            BeginContext(1345, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
