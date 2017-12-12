namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Web.ViewModels;
    using PIM.Database.TO;
    using AutoMapper;
    using PIM.Service.Services;
    using System.Linq;

    public class ReservasController : Controller
    {
        UsuarioTO _usuarioTO;
        MoradorTO _moradorTO;

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

            ListaReservaTO listaReserva = new ListaReservaTO();

            try
            {
                if (_moradorTO != null)
                    listaReserva = ReservaService.ListarPorMorador(_moradorTO.Identificador);
                else
                    listaReserva = ReservaService.Listar();
                var listaReservasVM = Mapper.Map<List<ReservaTO>, List<ReservaVM>>(listaReserva.Lista);
                NomearVariaveis(null, listaReservasVM);
                return View(listaReservasVM);
            }
            catch (Exception ex)
            {
                listaReserva.Mensagem = $"Erro ao obter Reservaes. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
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

            ReservaTO ReservaTO = new ReservaTO();

            try
            {
                ReservaTO = ReservaService.Obter(id);

                if (!ReservaTO.Valido)
                {
                    Session["Mensagem"] = ReservaTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var ReservaVM = Mapper.Map<ReservaTO, ReservaVM>(ReservaTO);
                NomearVariaveis(ReservaVM, null);
                return View(ReservaVM);
            }
            catch (Exception ex)
            {
                ReservaTO.Mensagem = $"Erro ao obter Reserva. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
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


            ViewBag.Morador = ListarMoradores();
            ViewBag.TipoReserva = ListarTipoReservas();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservaVM Reserva)
        {
            if (ModelState.IsValid)
            {
                Reserva.ConfirmacaoReserva = Reserva.Confirmacao ? "S" : "N";

                var ReservaTO = Mapper.Map<ReservaVM, ReservaTO>(Reserva);

                ReservaService.Criar(ReservaTO);

                Session["Mensagem"] = ReservaTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Reserva);
            }
        }

        public ActionResult Edit(int id)
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

            ViewBag.Morador = ListarMoradores();
            ViewBag.TipoReserva = ListarTipoReservas();

            if (ModelState.IsValid)
            {
                var ReservaTO = ReservaService.Obter(id);

                if (!ReservaTO.Valido)
                {
                    Session["Mensagem"] = ReservaTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var ReservaVM = Mapper.Map<ReservaTO, ReservaVM>(ReservaTO);
                NomearVariaveis(ReservaVM, null);
                return View(ReservaVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservaVM ReservaVM)
        {
            if (ModelState.IsValid)
            {
                ReservaVM.ConfirmacaoReserva = ReservaVM.Confirmacao ? "S" : "N";
                var ReservaTO = Mapper.Map<ReservaVM, ReservaTO>(ReservaVM);

                ReservaService.Atualizar(ReservaTO);

                if (!ReservaTO.Valido)
                {
                    Session["Mensagem"] = ReservaTO.Valido;
                    return RedirectToAction("Index");
                }

                ReservaVM = Mapper.Map<ReservaTO, ReservaVM>(ReservaTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
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

            if (id > 0)
            {
                var ReservaTO = ReservaService.Obter(id);
                var ReservaVM = Mapper.Map<ReservaTO, ReservaVM>(ReservaTO);
                NomearVariaveis(ReservaVM, null);
                return View(ReservaVM);
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
                    var retorno = ReservaService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }

        private SelectList ListarMoradores()
        {
            var listaMoradorTO = MoradorService.Listar();
            var listaMoradorVM = Mapper.Map<List<MoradorTO>, List<MoradorVM>>(listaMoradorTO.Lista);
            return new SelectList(listaMoradorVM, "Identificador", "Nome");
        }

        private SelectList ListarTipoReservas()
        {
            var listaTipoReservaTO = TipoReservaService.Listar();
            var listaTipoReservaVM = Mapper.Map<List<TipoReservaTO>, List<TipoReservaVM>>(listaTipoReservaTO.Lista);
            return new SelectList(listaTipoReservaVM, "Identificador", "Tipo");
        }

        private void NomearVariaveis(ReservaVM ReservaVM = null, List<ReservaVM> listaReservaVM = null)
        {
            var listaMoradorTO = MoradorService.Listar().Lista;
            var listaTipoReservaTO = TipoReservaService.Listar().Lista;

            if (listaReservaVM != null && listaReservaVM.Count > 0)
            {
                foreach (var con in listaReservaVM)
                {
                    con.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == con.IdMorador).Nome;
                    con.TipoReserva = listaTipoReservaTO.FirstOrDefault(x => x.Identificador == con.IdTipoReserva).Tipo;
                    con.Confirmacao = "S".Equals(con.ConfirmacaoReserva);
                }
            }

            if (ReservaVM != null)
            {
                ReservaVM.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == ReservaVM.IdMorador).Nome;
                ReservaVM.TipoReserva = listaTipoReservaTO.FirstOrDefault(x => x.Identificador == ReservaVM.IdTipoReserva).Tipo;
                ReservaVM.Confirmacao = "S".Equals(ReservaVM.ConfirmacaoReserva);
            }
        }
    }
}
