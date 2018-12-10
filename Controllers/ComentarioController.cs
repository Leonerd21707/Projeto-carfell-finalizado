using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class ComentarioController : Controller {

        private IComentario ComentarioRepositorio { get; set; }

        private IUsuario UsuarioRepositorio { get; set; }

        public ComentarioController () {
            ComentarioRepositorio = new ComentarioRepositorioSerializado ();
            UsuarioRepositorio = new UsuarioRepositorio ();
        }

        //responsavel pelos comentarios
        [HttpGet]
        public ActionResult Comentar () {

            return View ();
        }

        [HttpPost]
        public ActionResult Comentar (IFormCollection form) {
            int idUsuario = int.Parse (HttpContext.Session.GetString ("idUsuario"));
            UsuarioModel usuario = UsuarioRepositorio.BuscarPorId (idUsuario);
            ComentarioModel comentario = new ComentarioModel (
                comentario: form["comentario"],
                dataCriacao: DateTime.Now,
                usuario: usuario,
                aprovado: false);
            Console.WriteLine($"\n{comentario.Comentario}\n");
            ComentarioRepositorio.Comentar (comentario);

            return View ();
        }

        [HttpGet]
        public ActionResult Alterar (int id) {

            if (id == 0) {
                TempData["Mensagem"] = "Informe um Comentario para Alterar";
                return RedirectToAction ("Listar");
            }

            ComentarioRepositorioSerializado comentarioRepositorioSerializado = new ComentarioRepositorioSerializado ();
            ComentarioModel comentario = ComentarioRepositorio.BuscarPorId (id);

            if (comentario != null) {
                ViewBag.Comentario = comentario;
            } else {
                TempData["Mensagem"] = "Comentario não encontrado";
                return RedirectToAction ("Listar");
            }

            return RedirectToAction ("Comentar");
        }

    }
}