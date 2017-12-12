namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using AutoMapper;
    using PIM.Database.TO;
    using PIM.Web.ViewModels;
    using PIM.Service.Services;

    public class GruposUsuariosController : Controller
    {
        private UsuarioTO _usuarioTO;

        public ActionResult Index()
        {
            if (Session["MoradorTO"] != null)
            {
                return RedirectToActionPermanent("AccessDenied", "ErrorHandler");
            }

            if (Session["UsuarioTO"] == null)
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
            if (!_usuarioTO.Valido)
                return RedirectToActionPermanent("Login", "Home");

            ListaGrupoUsuarioTO listaGrupoUsuario = new ListaGrupoUsuarioTO();

            try
            {
                listaGrupoUsuario = GrupoUsuarioService.Listar();
                var listaGrupoUsuarioesVM = Mapper.Map<List<GrupoUsuarioTO>, List<GrupoUsuarioVM>>(listaGrupoUsuario.Lista);

                return View(listaGrupoUsuarioesVM);
            }
            catch (Exception ex)
            {
                listaGrupoUsuario.Mensagem = $"Erro ao obter GrupoUsuarioes. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            if (Session["MoradorTO"] != null)
            {
                return RedirectToActionPermanent("AccessDenied", "ErrorHandler");
            }

            if (Session["UsuarioTO"] == null)
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
            if (!_usuarioTO.Valido)
                return RedirectToActionPermanent("Login", "Home");

            GrupoUsuarioTO GrupoUsuarioTO = new GrupoUsuarioTO();

            try
            {
                GrupoUsuarioTO = GrupoUsuarioService.Obter(id);

                if (!GrupoUsuarioTO.Valido)
                {
                    Session["Mensagem"] = GrupoUsuarioTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var GrupoUsuarioVM = Mapper.Map<GrupoUsuarioTO, GrupoUsuarioVM>(GrupoUsuarioTO);

                return View(GrupoUsuarioVM);
            }
            catch (Exception ex)
            {
                GrupoUsuarioTO.Mensagem = $"Erro ao obter GrupoUsuario. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            if (Session["MoradorTO"] != null)
            {
                return RedirectToActionPermanent("AccessDenied", "ErrorHandler");
            }

            if (Session["UsuarioTO"] == null)
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
            if (!_usuarioTO.Valido)
                return RedirectToActionPermanent("Login", "Home");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GrupoUsuarioVM GrupoUsuario)
        {
            if (ModelState.IsValid)
            {
                var GrupoUsuarioTO = Mapper.Map<GrupoUsuarioVM, GrupoUsuarioTO>(GrupoUsuario);

                GrupoUsuarioService.Criar(GrupoUsuarioTO);

                Session["Mensagem"] = GrupoUsuarioTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(GrupoUsuario);
            }
        }

        public ActionResult Edit(int id)
        {
            if (Session["MoradorTO"] != null)
            {
                return RedirectToActionPermanent("AccessDenied", "ErrorHandler");
            }

            if (Session["UsuarioTO"] == null)
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
            if (!_usuarioTO.Valido)
                return RedirectToActionPermanent("Login", "Home");

            if (ModelState.IsValid)
            {
                var GrupoUsuarioTO = GrupoUsuarioService.Obter(id);

                if (!GrupoUsuarioTO.Valido)
                {
                    Session["Mensagem"] = GrupoUsuarioTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var GrupoUsuarioVM = Mapper.Map<GrupoUsuarioTO, GrupoUsuarioVM>(GrupoUsuarioTO);

                return View(GrupoUsuarioVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GrupoUsuarioVM GrupoUsuarioVM)
        {
            if (ModelState.IsValid)
            {
                var GrupoUsuarioTO = Mapper.Map<GrupoUsuarioVM, GrupoUsuarioTO>(GrupoUsuarioVM);

                GrupoUsuarioService.Atualizar(GrupoUsuarioTO);

                if (!GrupoUsuarioTO.Valido)
                {
                    Session["Mensagem"] = GrupoUsuarioTO.Valido;
                    return RedirectToAction("Index");
                }

                GrupoUsuarioVM = Mapper.Map<GrupoUsuarioTO, GrupoUsuarioVM>(GrupoUsuarioTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (Session["MoradorTO"] != null)
            {
                return RedirectToActionPermanent("AccessDenied", "ErrorHandler");
            }

            if (Session["UsuarioTO"] == null)
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
            if (!_usuarioTO.Valido)
                return RedirectToActionPermanent("Login", "Home");

            if (id > 0)
            {
                var GrupoUsuarioTO = GrupoUsuarioService.Obter(id);
                var GrupoUsuarioVM = Mapper.Map<GrupoUsuarioTO, GrupoUsuarioVM>(GrupoUsuarioTO);

                return View(GrupoUsuarioVM);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                if (id > 0)
                {
                    var retorno = GrupoUsuarioService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
