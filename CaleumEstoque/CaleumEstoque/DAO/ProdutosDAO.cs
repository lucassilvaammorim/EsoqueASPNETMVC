using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaelumEstoque.DAO
{
    public class ProdutosDAO
    {
        private static IList<Produto> produtos = new List<Produto>();
        private static int AutoId = 0;
        
        
        public ProdutosDAO()
        {

        }
        public void Adiciona(Produto produto)
        {
            AutoId ++;
            produto.Id = AutoId;
            produtos.Add(produto);
        }

        public IList<Produto> Lista()
        {
            return produtos;
        }

        public Produto BuscaPorId(int id)
        {
            List<Produto> _produto = new List<Produto>(); 
            _produto = produtos.Where(p => p.Id == id).ToList();

            return _produto[0];

        }

        public void Atualiza(Produto produto)
        {
            produtos[produto.Id - 1] = produto;
        }
    }
}