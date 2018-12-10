using System;

namespace Senai.Sprint4.Carfel.Models {
    [Serializable]
    public class UsuarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Administrador { get; set; }
        public DateTime DataCriacao { get; set; }

        //cadastro
        public UsuarioModel (string nome, string email, string senha, DateTime dataCriacao, bool administrador) {

            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataCriacao = DataCriacao;
            this.Administrador = administrador;
        }

        //login
        public UsuarioModel (int id, string nome, string email, string senha, DateTime dataCriacao, bool administrador) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataCriacao = DataCriacao;
            this.Administrador = administrador;
        }

        //Comentario
        public UsuarioModel () {

        }
        public UsuarioModel(int id, string nome, string email, string senha, DateTime dataCriacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataCriacao = dataCriacao;
        }
    }
}