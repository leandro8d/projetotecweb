using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Blog.Models;
using Repositorio;
using System.Web.Helpers;

namespace Blog.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        Model1 modelo = new Model1();

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public  void CriarUsuario(Usuario usuario)
        {

            // Solicitar um redirecionamento para o provedor de logon externo
            modelo.USUARIO.Add(new USUARIO {NOME= usuario.Nome,EMAIL=usuario.Email,SENHA = usuario.Senha,ID_PERFIL = usuario.IdPerfil });
            modelo.SaveChanges();
        }


        [HttpPost]
        [AllowAnonymous]
        public JsonResult Logar(Usuario usuario)
        {
            var user = modelo.USUARIO.Where(b => b.EMAIL.Equals(usuario.Email) && b.SENHA.Equals(usuario.Password)).FirstOrDefault();

            if (user == null)
                return new JsonResult { Data="email ou senha invalida" };
            else
            {
                Session["IdUsuario"] = user.ID_USUARIO;
                Session["IdPerfil"] = user.ID_PERFIL;
                return new JsonResult { Data = "Logado com Sucesso" };
            }
        }


        [HttpPost]
        [AllowAnonymous]
        public JsonResult Logout(Usuario usuario)
        {
            Session["IdUsuario"] = null;
            Session["IdPerfil"] = null;
            return new JsonResult { Data = "Logado com Sucesso" };
        }

    }
}