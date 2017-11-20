using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class PostagemController : Controller
    {
        Model1 modelo = new Model1();
        // GET: CadastroPost
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public void CriarPostagem(POSTAGEM post)
        {
            post.ID_USUARIO_CRIADOR = (long)Session["IdUsuario"];
            post.DATA_CRIACAO = DateTime.Now;

            // Solicitar um redirecionamento para o provedor de logon externo
            modelo.POSTAGEM.Add(post);
            modelo.SaveChanges();
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult ListAll()
        {
            var lista = modelo.POSTAGEM.ToList();
            return  Json(lista,JsonRequestBehavior.AllowGet );
        }
        
    }
}