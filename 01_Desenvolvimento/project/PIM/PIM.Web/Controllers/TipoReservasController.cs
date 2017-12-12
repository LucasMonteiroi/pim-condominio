namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using AutoMapper;
    using PIM.Database.TO;
    using PIM.Web.ViewModels;
    using PIM.Service.Services;

    public class TipoReservasController : Controller
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

            ListaTipoReservaTO listaTipoReserva = new ListaTipoReservaTO();

            try
            {
                listaTipoReserva = TipoReservaService.Listar();
                var listaTipoReservaesVM = Mapper.Map<List<TipoReservaTO>, List<TipoReservaVM>>(listaTipoReserva.Lista);

                return View(listaTipoReservaesVM);
            }
            catch (Exception ex)
            {
                listaTipoReserva.Mensagem = $"Erro ao obter TipoReservaes. Erro: {ex.Message} ";
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

            TipoReservaTO TipoReservaTO = new TipoReservaTO();

            try
            {
                TipoReservaTO = TipoReservaService.Obter(id);

                if (!TipoReservaTO.Valido)
                {
                    Session["Mensagem"] = TipoReservaTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var TipoReservaVM = Mapper.Map<TipoReservaTO, TipoReservaVM>(TipoReservaTO);

                return View(TipoReservaVM);
            }
            catch (Exception ex)
            {
                TipoReservaTO.Mensagem = $"Erro ao obter TipoReserva. Erro: {ex.Message}";

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
        public ActionResult Create(TipoReservaVM TipoReserva)
        {
            if (ModelState.IsValid)
            {
                var TipoReservaTO = Mapper.Map<TipoReservaVM, TipoReservaTO>(TipoReserva);

                TipoReservaService.Criar(TipoReservaTO);

                Session["Mensagem"] = TipoReservaTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(TipoReserva);
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
                var TipoReservaTO = TipoReservaService.Obter(id);

                if (!TipoReservaTO.Valido)
                {
                    Session["Mensagem"] = TipoReservaTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var TipoReservaVM = Mapper.Map<TipoReservaTO, TipoReservaVM>(TipoReservaTO);

                return View(TipoReservaVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoReservaVM TipoReservaVM)
        {
            if (ModelState.IsValid)
            {
                var TipoReservaTO = Mapper.Map<TipoReservaVM, TipoReservaTO>(TipoReservaVM);

                TipoReservaService.Atualizar(TipoReservaTO);

                if (!TipoReservaTO.Valido)
                {
                    Session["Mensagem"] = TipoReservaTO.Valido;
                    return RedirectToAction("Index");
                }

                TipoReservaVM = Mapper.Map<TipoReservaTO, TipoReservaVM>(TipoReservaTO);
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
                var TipoReservaTO = TipoReservaService.Obter(id);
                var TipoReservaVM = Mapper.Map<TipoReservaTO, TipoReservaVM>(TipoReservaTO);

                return View(TipoReservaVM);
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
                    var retorno = TipoReservaService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
