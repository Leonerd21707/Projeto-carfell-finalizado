using System;
using System.Collections.Generic;
using System.IO;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Repositorio {
    public class UsuarioRepositorio : IUsuario {

        public UsuarioModel BuscarPorId (int id) {
            //Percorre todos os usuários buscando pelo id...
            foreach (UsuarioModel usuario in Listar ()) {
                if (id == usuario.Id) {
                    return usuario;
                }
            }

            //Caso não encontre o usuário pelo id
            return null;

        }

        public UsuarioModel Cadastrar (UsuarioModel usuario) {
            //verifica se existe o arquivo 
            if (File.Exists ("usuarios.csv")) {
                //se o arquivo existir pega o numero de linhas e incrementa + 1
                usuario.Id = File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuario.Id = 1;
            }
            //grava as informações no arquivo
            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                usuario.DataCriacao = DateTime.Now;
                sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao};{usuario.Administrador}");
            }
            return usuario;
        }

        public UsuarioModel Login (string email, string senha) {
            //percorre o arquivo atras de um usuario cadastrado
            using (StreamReader sr = new StreamReader ("usuarios.csv")) {
                while (!sr.EndOfStream) {
                    var linha = sr.ReadLine ();

                    if (string.IsNullOrEmpty (linha)) {
                        continue;
                    }

                    string[] dados = linha.Split (";");

                    if (dados[2] == email && dados[3] == senha) {
                        UsuarioModel usuario = new UsuarioModel (
                            id: int.Parse (dados[0]),
                            nome: dados[1],
                            email: dados[2],
                            senha: dados[3],
                            dataCriacao: DateTime.Parse (dados[4]),
                            administrador: bool.Parse (dados[5])
                        );

                        return usuario;
                    }
                }
            }

            return null;
        }

        public List<UsuarioModel> Listar () {
            
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel> ();

            string[] linhas = System.IO.File.ReadAllLines ("usuarios.csv");

            UsuarioModel usuario;

            foreach (var item in linhas) {

                //Verifica se a linha é vazia
                if (string.IsNullOrEmpty (item)) {
                    //Retorna para o foreach
                    continue;
                }

                string[] linha = item.Split (';');

                usuario = new UsuarioModel (
                    id: int.Parse (linha[0]),
                    nome: linha[1],
                    email: linha[2],
                    senha: linha[3],
                    dataCriacao: DateTime.Parse (linha[4])
                );

                lsUsuarios.Add (usuario);
            }

            return lsUsuarios;
        }
    }
}