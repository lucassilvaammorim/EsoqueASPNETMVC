using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class CategoriasDAO
    {
        IList<CategoriaDoProduto> categorias;

        public CategoriasDAO()
        {
            categorias = new List<CategoriaDoProduto>();

            categorias.Add(new CategoriaDoProduto() { Nome = "Alimentos", Id = 1 });
            categorias.Add(new CategoriaDoProduto() { Nome = "Bebidas", Id = 2 });
            categorias.Add(new CategoriaDoProduto() { Nome = "Eletronicos", Id = 3 });
        }
        //public void Adiciona(CategoriaDoProduto categoria)
        //{
        //    using (var context = new EstoqueContext())
        //    {
        //        context.Categorias.Add(categoria);
        //        context.SaveChanges();
        //    }
        //}

        public IList<CategoriaDoProduto> Lista()
        {
            return categorias;
        }

        //public CategoriaDoProduto BuscaPorId(int id)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        return contexto.Categorias.Find(id);
        //    }
        //}

        //public void Atualiza(CategoriaDoProduto categoria)
        //{
        //    using (var contexto = new EstoqueContext())
        //    {
        //        contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}
    }
}