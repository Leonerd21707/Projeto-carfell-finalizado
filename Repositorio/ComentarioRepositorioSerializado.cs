using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Repositorio {
    public class ComentarioRepositorioSerializado : IComentario {


        private const string caminho = "comentarios.dat";
        private List<ComentarioModel> lsComentario ;


        public ComentarioRepositorioSerializado(){
            if(File.Exists(caminho)){
                lsComentario = Listar();
            }else{
                lsComentario = new List<ComentarioModel>();
            }
        }
        public ComentarioModel Alterar (ComentarioModel comentario) {
            
            //Caso o usuario buscado tennha sido encontrado...
            foreach (var item in lsComentario)
            {
                if(item.Id == comentario.Id){
                    item.Aprovado = comentario.Aprovado;

                    //Temos que atualizar o arquivo com a lista sem o objeto
                    MemoryStream memoria = new MemoryStream();
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(memoria,lsComentario);
                    File.WriteAllBytes(caminho, memoria.ToArray());

                    return item;    
                }
            }              

            return null;
        }

        public ComentarioModel BuscarPorId (int id) {
            //Percorre todos os comentarios buscando pelo id...
            foreach (ComentarioModel comentario in lsComentario) {
                if (id == comentario.Id) {
                    return comentario;
                }
            }

            //Caso não encontre o comentario pelo id
            return null;

        }

        public ComentarioModel Comentar (ComentarioModel comentario) {
            if(lsComentario.Count > 0){
                comentario.Id = lsComentario.Count + 1;
            } else {
                comentario.Id = 1;
            }

            //salva o comentario na lista
            lsComentario.Add(comentario);

            MemoryStream memoria = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(memoria,lsComentario);
            File.WriteAllBytes(caminho, memoria.ToArray());
            lsComentario =  Listar();

            return comentario;

        }

        public List<ComentarioModel> Listar () {
            {
                //lê os bytes do arquivo
                byte[] bytesSerializados = File.ReadAllBytes (caminho);

                //cria o fluxo de memoria com os bytes do arquivo serializado
                MemoryStream memoria = new MemoryStream (bytesSerializados);

                BinaryFormatter serializador = new BinaryFormatter ();

                return (List<ComentarioModel>) serializador.Deserialize (memoria);

            }
        }
    }
}