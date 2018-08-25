using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using CaleumEstoque.Filter;


//A camada de controller é reponsável por processar as requisições feitas, solicitar os dados de modelo e retornar para a view
namespace CaelumEstoque.Controllers
{
    [AutorizarFilter]
    public class ProdutoController : Controller
    {
        
        // GET: Produto
        [Route("produtos", Name = "ListarProdutos")]
        public ActionResult Index()
        {
            //Instanciar classe DAO de produtos e construir a informação necessária para construir a view solicitada
            ProdutosDAO bdproduto = new ProdutosDAO();
            IList<Produto> produtos = bdproduto.Lista();

            return View(produtos);
        }

        //Responsável por chamar a view do formadd
        public ActionResult FormAdd()
        {
            CategoriasDAO categoriasDAO = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = categoriasDAO.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }

        
        [Route("produtos/{id}", Name = "BuscaPorId")]
        public ActionResult Visualizar(int id)
        {
            ProdutosDAO bdproduto = new ProdutosDAO();
            Produto produtos = bdproduto.BuscaPorId(id);
            ViewBag.Produto = produtos;
            return View();
        }

        //Adiciona os dados inputados no formadd, que chama essa action passando os paramentros via html form
        [HttpPost]
        [ValidateAntiForgeryToken]//verifica token de segurança
        public ActionResult Adiciona(Produto produto)
        {
            if(ModelState.IsValid)
            {
                ProdutosDAO produtosDAO = new ProdutosDAO();
                produtosDAO.Adiciona(produto);
            }
            else
            {
                return RedirectToAction("FormAdd", "Produto");
            }
            

            return RedirectToAction("Index","Produto");
        }

    
      
        public ActionResult DecrementaQtd(int id)
        {
            ProdutosDAO bdproduto = new ProdutosDAO();
            Produto produtos = bdproduto.BuscaPorId(id);

            produtos.Quantidade--;

            bdproduto.Atualiza(produtos);

            return Json(produtos);
        }
    }
}