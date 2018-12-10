using System.Collections.Generic;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Interfaces {
    public interface IComentario {
        ComentarioModel Comentar (ComentarioModel comentario);
        ComentarioModel Alterar (ComentarioModel comentario);
        List<ComentarioModel> Listar ();
        ComentarioModel BuscarPorId (int id);

    }
}