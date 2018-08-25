using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using CaleumEstoque.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaleumEstoque.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(String nome, String senha)
        {
            UsuariosDAO daoUser = new UsuariosDAO();
            Usuario usuario = daoUser.Busca(nome, senha);

            if(usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}