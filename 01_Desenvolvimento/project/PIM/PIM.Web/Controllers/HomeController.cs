namespace PIM.Web.Controllers
{
    using PIM.Database.TO;
    using PIM.Service.Services;
    using PIM.Web.ViewModels;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        MoradorTO _moradorTO;
        UsuarioTO _usuarioTO;

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {

                string erro = string.Empty;

                if(!string.IsNullOrEmpty(loginVM.Login) && !string.IsNullOrEmpty(loginVM.Senha))
                {
                    var usuarioTO = UsuarioService.RealizarLogin(loginVM.Login, loginVM.Senha);

                    if (!usuarioTO.Valido)
                    {
                        ViewBag.Mensagem = usuarioTO.Mensagem;
                        return View();
                    }

                    Session["UsuarioTO"] = usuarioTO;

                    return RedirectToAction("Index");
                }
                else
                {
                    if (!string.IsNullOrEmpty(loginVM.CPF))
                    {
                        erro = string.Empty;

                        var moradorTO = MoradorService.LoginMorador(loginVM.CPF);

                        if (!moradorTO.Valido)
                        {
                            ViewBag.Mensagem = moradorTO.Mensagem;
                            return View();
                        }

                        Session["MoradorTO"] = moradorTO;

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        erro += "- Necessário informar o CPF";
                        ViewBag.Mensagem = erro;
                        return View();
                    }

                    if (string.IsNullOrEmpty(loginVM.Login))
                    {
                        erro += "- Necessário informar o Login";
                        ViewBag.Mensagem = erro;
                        return View();
                    }
                    if (string.IsNullOrEmpty(loginVM.Senha))
                    {
                        erro += "- Necessário informar a Senha";
                        ViewBag.Mensagem = erro;
                        return View();
                    }
                }
                
            }

            return View();
        }

        public ActionResult Index()
        {
            _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
            _moradorTO = (MoradorTO)Session["MoradorTO"];

            if (_usuarioTO != null)
            {
                _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
                if (!_usuarioTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }
            else if (_moradorTO != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (_moradorTO != null)
                {
                    _moradorTO = (MoradorTO)Session["MoradorTO"];
                    if (!_moradorTO.Valido)
                        return RedirectToActionPermanent("Login", "Home");
                }
            }
            else
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            return View();
        }

        public ActionResult Logoff()
        {
            Session.Remove("UsuarioTO");
            Session.Remove("MoradorTO");

            return RedirectToActionPermanent("Login");
        }
    }
}