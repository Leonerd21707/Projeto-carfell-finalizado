using System;

namespace Senai.Sprint4.Carfel.Models {
    [Serializable]
    public class ComentarioModel {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Aprovado { get; set; }

        public UsuarioModel Usuario { get; set; }

        public ComentarioModel (string comentario, DateTime dataCriacao, UsuarioModel usuario, bool aprovado) {
            this.Comentario = comentario;
            this.DataCriacao = dataCriacao;
            this.Aprovado = aprovado;
            this.Usuario = usuario;
        }
        public ComentarioModel (int id, string comentario, UsuarioModel usuario, DateTime dataCriacao, bool aprovado) {
            this.Id = id;
            this.Comentario = comentario;
            this.Usuario = usuario;
            this.DataCriacao = DataCriacao;
            this.Aprovado = aprovado;
        }

    }
}