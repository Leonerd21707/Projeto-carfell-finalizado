using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Sprint4.Carfel.Models;
using Senai.Sprint4.Carfel.Repositorio;

namespace Senai.Sprint4.Carfel.Controllers {
    public class AdministradorController : Controller {

        public ActionResult Comentarios (IFormCollection form) {
            ComentarioRepositorioSerializado ComentarioRep = new ComentarioRepositorioSerializado(); 
            ViewData["comentarios"] = ComentarioRep.Listar();
            return View();
        }

    }
}