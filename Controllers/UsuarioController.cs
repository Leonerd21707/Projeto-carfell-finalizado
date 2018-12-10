using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class UsuarioController : Controller {
        //Responsavel pelo cadastramento do Usuario
        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (nome: form["nome"], email: form["email"], senha: form["senha"], dataCriacao: DateTime.Now, administrador: false);

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            usuarioRepositorio.Cadastrar (usuario);

            ViewBag.Mensagem = "Usuário Cadastrado";

            return RedirectToAction ("Login");
        }

        //responsavel pelo login do usuario
        [HttpGet]
        public ActionResult Login () {
            return View ();
        }

        [HttpPost]
        public ActionResult Login (IFormCollection form) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            UsuarioModel usuario = usuarioRepositorio.Login (form["email"], form["senha"]);

            if (usuario != null) {
                HttpContext.Session.SetString ("idUsuario", usuario.Id.ToString ());
                HttpContext.Session.SetString ("nomeUsuario", usuario.Nome.ToString ());
                HttpContext.Session.SetString ("emailUsuario", usuario.Email.ToString ());

                return RedirectToAction ("Comentar", "Comentario");
            }

            ViewBag.Mensagem = "Usuário inválido";
            return View ();

        }

    }
}