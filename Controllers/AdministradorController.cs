using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class AdministradorController : Controller {

        public ActionResult Comentarios (IFormCollection form) {
            ComentarioRepositorioSerializado ComentarioRep = new ComentarioRepositorioSerializado ();
            ViewData["comentarios"] = ComentarioRep.Listar ();
            return View ();
        }

        [HttpGet]
        public IActionResult Aprovar (int id) {
            //Cria um objecto ComentarioRepositorioSerializado
            ComentarioRepositorioSerializado ComentarioRep = new ComentarioRepositorioSerializado ();

            //Busca o comentário no banco através do seu ID
            ComentarioModel comentario = ComentarioRep.BuscarPorId (id);

            //Verifica se o comentário existe
            if (comentario == null) {
                //Caso não exista defini uma mensagem e redireciona para a página de comentários
                TempData["Mensagem"] = "Coemtário não encontrado";
                //Redirecionamento
                return RedirectToAction ("Comentarios");
            }

            //Caso exista altera o status do comentário para true
            comentario.Aprovado = true;
            //Chama o metodo alterar do objecto criado acima
            ComentarioRep.Alterar (comentario);

            //Redireciona para a página de comentários
            return RedirectToAction ("Comentarios");

        }

        [HttpGet]
        public IActionResult Rejeitar (int id) {

            //Cria um objecto ComentarioRepositorioSerializado
            ComentarioRepositorioSerializado ComentarioRep = new ComentarioRepositorioSerializado ();

            //Busca o comentário no banco através do seu ID
            ComentarioModel comentario = ComentarioRep.BuscarPorId (id);

            //Verifica se o comentário existe
            if (comentario == null) {
                //Caso não exista defini uma mensagem e redireciona para a página de comentários
                TempData["Mensagem"] = "Coemtário não encontrado";
                //Redirecionamento
                return RedirectToAction ("Comentarios");
            }

            //Caso exista altera o status do comentário para true
            comentario.Aprovado = false;
            //Chama o metodo alterar do objecto criado acima
            ComentarioRep.Alterar (comentario);

            //Redireciona para a página de comentários
            return RedirectToAction ("Comentarios");

        }

    }
}