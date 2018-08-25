using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class UsuariosDAO
    {
        private static List<Usuario> usuarios = new List<Usuario>();
        public UsuariosDAO()
        {
            

        }
        


        //public void Adiciona(Usuario usuario)
        //{
        //    using (var context = new EstoqueContext())
        //    {
        //        context.Usuarios.Add(usuario);
        //        context.SaveChanges();
        //    }
        //}

        //public IList<Usuario> Lista()
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        return contexto.Usuarios.ToList();
        //    }
        //}

        //public Usuario BuscaPorId(int id)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        return contexto.Usuarios.Find(id);
        //    }
        //}

        //public void Atualiza(Usuario usuario)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        contexto.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}

        public Usuario Busca(string login, string senha)
        {
            usuarios.Add(new Usuario() { Nome = "Lucas", Senha = "1234" }
            );
            Predicate<Usuario> Valida = x => x.Nome == login && x.Senha == senha;
            Usuario usuario = usuarios.Find(Valida);
            return usuario;

            //return new Usuario() { Nome = "Lucas", Senha = "123" };

        }
    }
}