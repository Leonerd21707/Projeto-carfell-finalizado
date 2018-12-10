using System.Collections.Generic;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Interfaces {
    public interface IUsuario {

        UsuarioModel BuscarPorId(int id);

        UsuarioModel Cadastrar (UsuarioModel usuario);

        UsuarioModel Login (string email, string senha);

         List<UsuarioModel> Listar();

    }
}