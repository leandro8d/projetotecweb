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

        [HttpPost]
        [AllowAnonymous]
        public  void CriarUsuario(Usuario usuario)
        {

            // Solicitar um redirecionamento para o provedor de logon externo
            modelo.USUARIO.Add(new USUARIO {NOME= usuario.Nome,EMAIL=usuario.Email,SENHA = usuario.Senha,ID_PERFIL = usuario.IdPerfil });
            modelo.SaveChanges();
        }

    }
}