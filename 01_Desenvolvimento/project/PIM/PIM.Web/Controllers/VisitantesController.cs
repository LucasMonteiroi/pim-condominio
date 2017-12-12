namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Web.ViewModels;
    using AutoMapper;
    using PIM.Service.Services;
    using PIM.Database.TO;
    using System.Linq;

    public class VisitantesController : Controller
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

            ListaVisitanteTO listaVisitante = new ListaVisitanteTO();

            try
            {
                if (_moradorTO != null)
                    listaVisitante = VisitanteService.ListarPorMorador(_moradorTO.Identificador);
                else
                    listaVisitante = VisitanteService.Listar();
                var listaVisitantesVM = Mapper.Map<List<VisitanteTO>, List<VisitanteVM>>(listaVisitante.Lista);
                NomearVariaveis(null, listaVisitantesVM);
                return View(listaVisitantesVM);
            }
            catch (Exception ex)
            {
                listaVisitante.Mensagem = $"Erro ao obter Visitantees. Erro: {ex.Message} ";
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

            VisitanteTO VisitanteTO = new VisitanteTO();

            try
            {
                VisitanteTO = VisitanteService.Obter(id);

                if (!VisitanteTO.Valido)
                {
                    Session["Mensagem"] = VisitanteTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var VisitanteVM = Mapper.Map<VisitanteTO, VisitanteVM>(VisitanteTO);

                NomearVariaveis(VisitanteVM, null);

                return View(VisitanteVM);
            }
            catch (Exception ex)
            {
                VisitanteTO.Mensagem = $"Erro ao obter Visitante. Erro: {ex.Message}";

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
                else if (_usuarioTO.IdGrupo == 3)
                    return RedirectToActionPermanent("Index");
                ViewBag.Morador = ListarMoradores();
            }
            else if (_moradorTO != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (_moradorTO != null)
                {
                    _moradorTO = (MoradorTO)Session["MoradorTO"];
                    if (!_moradorTO.Valido)
                        return RedirectToActionPermanent("Login", "Home");
                    ViewBag.Morador = ListarMoradores(_moradorTO.Identificador);
                }
            }
            else
            {
                return RedirectToActionPermanent("Login", "Home");
            }


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VisitanteVM Visitante)
        {
            if (ModelState.IsValid)
            {
                var VisitanteTO = Mapper.Map<VisitanteVM, VisitanteTO>(Visitante);

                VisitanteService.Criar(VisitanteTO);

                Session["Mensagem"] = VisitanteTO.Mensagem;
                return RedirectToAction("Index");
            }

            return View();
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
                else if (_usuarioTO.IdGrupo == 3)
                    return RedirectToActionPermanent("Index");

                ViewBag.Morador = ListarMoradores();
            }
            else if (_moradorTO != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (_moradorTO != null)
                {
                    _moradorTO = (MoradorTO)Session["MoradorTO"];
                    if (!_moradorTO.Valido)
                        return RedirectToActionPermanent("Login", "Home");
                    ViewBag.Morador = ListarMoradores(_moradorTO.Identificador);
                }
            }
            else
            {
                return RedirectToActionPermanent("Login", "Home");
            }

            ViewBag.Morador = ListarMoradores();
            if (ModelState.IsValid)
            {
                var VisitanteTO = VisitanteService.Obter(id);

                if (!VisitanteTO.Valido)
                {
                    Session["Mensagem"] = VisitanteTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var VisitanteVM = Mapper.Map<VisitanteTO, VisitanteVM>(VisitanteTO);
                NomearVariaveis(VisitanteVM, null);
                return View(VisitanteVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VisitanteVM VisitanteVM)
        {
            if (ModelState.IsValid)
            {
                var VisitanteTO = Mapper.Map<VisitanteVM, VisitanteTO>(VisitanteVM);

                VisitanteService.Atualizar(VisitanteTO);

                if (!VisitanteTO.Valido)
                {
                    Session["Mensagem"] = VisitanteTO.Valido;
                    return RedirectToAction("Index");
                }

                VisitanteVM = Mapper.Map<VisitanteTO, VisitanteVM>(VisitanteTO);
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
                else if (_usuarioTO.IdGrupo == 3)
                    return RedirectToActionPermanent("Index");

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
                var VisitanteTO = VisitanteService.Obter(id);
                var VisitanteVM = Mapper.Map<VisitanteTO, VisitanteVM>(VisitanteTO);
                NomearVariaveis(VisitanteVM, null);
                return View(VisitanteVM);
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
                    var retorno = VisitanteService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }

        private SelectList ListarMoradores(int id = 0)
        {
            ListaMoradorTO listaMoradorTO;
            List<MoradorVM> listaMoradorVM;

            if (id > 0)
            {
                listaMoradorTO = MoradorService.Listar();
                listaMoradorVM = Mapper.Map<List<MoradorTO>, List<MoradorVM>>(listaMoradorTO.Lista.Where(x => x.Identificador == id).ToList());
            }
            else
            {
                listaMoradorTO = MoradorService.Listar();
                listaMoradorVM = Mapper.Map<List<MoradorTO>, List<MoradorVM>>(listaMoradorTO.Lista);
            }

            return new SelectList(listaMoradorVM, "Identificador", "Nome");
        }

        private void NomearVariaveis(VisitanteVM VisitanteVM = null, List<VisitanteVM> listaVisitanteVM = null)
        {
            var listaMoradorTO = MoradorService.Listar().Lista;

            if (listaVisitanteVM != null && listaVisitanteVM.Count > 0)
            {
                foreach (var con in listaVisitanteVM)
                {
                    con.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == con.IdMorador).Nome;
                }
            }

            if (VisitanteVM != null)
            {
                VisitanteVM.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == VisitanteVM.IdMorador).Nome;
            }
        }
    }
}
