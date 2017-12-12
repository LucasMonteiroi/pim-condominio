namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Database.TO;
    using PIM.Service.Services;
    using AutoMapper;
    using PIM.Web.ViewModels;
    using System.Linq;

    public class DependentesController : Controller
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

            ListaDependenteTO listaDependente = new ListaDependenteTO();

            try
            {
                if (_moradorTO != null)
                    listaDependente = DependenteService.ListarPorMorador(_moradorTO.Identificador);
                else
                    listaDependente = DependenteService.Listar();

                var listaDependenteesVM = Mapper.Map<List<DependenteTO>, List<DependenteVM>>(listaDependente.Lista);
                NomearVariaveis(null, listaDependenteesVM);
                return View(listaDependenteesVM);
            }
            catch (Exception ex)
            {
                listaDependente.Mensagem = $"Erro ao obter Dependentees. Erro: {ex.Message} ";
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

            DependenteTO DependenteTO = new DependenteTO();

            try
            {
                DependenteTO = DependenteService.Obter(id);

                if (!DependenteTO.Valido)
                {
                    Session["Mensagem"] = DependenteTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var DependenteVM = Mapper.Map<DependenteTO, DependenteVM>(DependenteTO);
                NomearVariaveis(DependenteVM, null);
                return View(DependenteVM);
            }
            catch (Exception ex)
            {
                DependenteTO.Mensagem = $"Erro ao obter Dependente. Erro: {ex.Message}";

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

            DependenteVM dependente = new DependenteVM();

            if (_moradorTO != null)
            {
                dependente.IdMorador = _moradorTO.Identificador;
                dependente.NomeMorador = _moradorTO.Nome;
            }

            return View(dependente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DependenteVM Dependente)
        {
            if (ModelState.IsValid)
            {
                var DependenteTO = Mapper.Map<DependenteVM, DependenteTO>(Dependente);

                DependenteService.Criar(DependenteTO);

                Session["Mensagem"] = DependenteTO.Mensagem;
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
            if (ModelState.IsValid)
            {
                var DependenteTO = DependenteService.Obter(id);

                if (!DependenteTO.Valido)
                {
                    Session["Mensagem"] = DependenteTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var DependenteVM = Mapper.Map<DependenteTO, DependenteVM>(DependenteTO);
                NomearVariaveis(DependenteVM, null);
                return View(DependenteVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DependenteVM DependenteVM)
        {
            if (ModelState.IsValid)
            {
                var DependenteTO = Mapper.Map<DependenteVM, DependenteTO>(DependenteVM);

                DependenteService.Atualizar(DependenteTO);

                if (!DependenteTO.Valido)
                {
                    Session["Mensagem"] = DependenteTO.Valido;
                    return RedirectToAction("Index");
                }

                DependenteVM = Mapper.Map<DependenteTO, DependenteVM>(DependenteTO);
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
                var DependenteTO = DependenteService.Obter(id);
                var DependenteVM = Mapper.Map<DependenteTO, DependenteVM>(DependenteTO);
                NomearVariaveis(DependenteVM, null);
                return View(DependenteVM);
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
                    var retorno = DependenteService.Remover(id);

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

        private void NomearVariaveis(DependenteVM DependenteVM = null, List<DependenteVM> listaDependenteVM = null)
        {
            var listaMoradorTO = MoradorService.Listar().Lista;

            if (listaDependenteVM != null && listaDependenteVM.Count > 0)
            {
                foreach (var con in listaDependenteVM)
                {
                    con.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == con.IdMorador).Nome;
                }
            }

            if (DependenteVM != null)
            {
                DependenteVM.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == DependenteVM.IdMorador).Nome;
            }
        }
    }
}
