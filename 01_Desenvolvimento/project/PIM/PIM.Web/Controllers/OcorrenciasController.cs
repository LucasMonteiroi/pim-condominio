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

    public class OcorrenciasController : Controller
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

            ListaOcorrenciaTO listaOcorrencia = new ListaOcorrenciaTO();

            try
            {
                if (_moradorTO != null)
                    listaOcorrencia = OcorrenciaService.ListarPorMorador(_moradorTO.Identificador);
                else
                    listaOcorrencia = OcorrenciaService.Listar();
                var listaOcorrenciaesVM = Mapper.Map<List<OcorrenciaTO>, List<OcorrenciaVM>>(listaOcorrencia.Lista);
                NomearVariaveis(null, listaOcorrenciaesVM);
                return View(listaOcorrenciaesVM);
            }
            catch (Exception ex)
            {
                listaOcorrencia.Mensagem = $"Erro ao obter Ocorrenciaes. Erro: {ex.Message} ";
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

            if (Session["UsuarioTO"] != null)
            {
                _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
                if (!_usuarioTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }
            else if (Session["MoradorTO"] != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (!_moradorTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }

            OcorrenciaTO OcorrenciaTO = new OcorrenciaTO();

            try
            {
                OcorrenciaTO = OcorrenciaService.Obter(id);

                if (!OcorrenciaTO.Valido)
                {
                    Session["Mensagem"] = OcorrenciaTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var OcorrenciaVM = Mapper.Map<OcorrenciaTO, OcorrenciaVM>(OcorrenciaTO);
                NomearVariaveis(OcorrenciaVM, null);
                return View(OcorrenciaVM);
            }
            catch (Exception ex)
            {
                OcorrenciaTO.Mensagem = $"Erro ao obter Ocorrencia. Erro: {ex.Message}";

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

            if (Session["UsuarioTO"] != null)
            {
                _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
                if (!_usuarioTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }
            else if (Session["MoradorTO"] != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (!_moradorTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }

            ViewBag.Morador = ListarMoradores();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OcorrenciaVM Ocorrencia)
        {
            if (ModelState.IsValid)
            {
                var OcorrenciaTO = Mapper.Map<OcorrenciaVM, OcorrenciaTO>(Ocorrencia);

                OcorrenciaService.Criar(OcorrenciaTO);

                Session["Mensagem"] = OcorrenciaTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Ocorrencia);
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

            if (Session["UsuarioTO"] != null)
            {
                _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
                if (!_usuarioTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }
            else if (Session["MoradorTO"] != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (!_moradorTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }

            ViewBag.Morador = ListarMoradores();
            if (ModelState.IsValid)
            {
                var OcorrenciaTO = OcorrenciaService.Obter(id);

                if (!OcorrenciaTO.Valido)
                {
                    Session["Mensagem"] = OcorrenciaTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var OcorrenciaVM = Mapper.Map<OcorrenciaTO, OcorrenciaVM>(OcorrenciaTO);
                NomearVariaveis(OcorrenciaVM, null);
                return View(OcorrenciaVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OcorrenciaVM OcorrenciaVM)
        {
            if (ModelState.IsValid)
            {
                var OcorrenciaTO = Mapper.Map<OcorrenciaVM, OcorrenciaTO>(OcorrenciaVM);

                OcorrenciaService.Atualizar(OcorrenciaTO);

                if (!OcorrenciaTO.Valido)
                {
                    Session["Mensagem"] = OcorrenciaTO.Valido;
                    return RedirectToAction("Index");
                }

                OcorrenciaVM = Mapper.Map<OcorrenciaTO, OcorrenciaVM>(OcorrenciaTO);
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

            if (Session["UsuarioTO"] != null)
            {
                _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
                if (!_usuarioTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }
            else if (Session["MoradorTO"] != null)
            {
                _moradorTO = (MoradorTO)Session["MoradorTO"];

                if (!_moradorTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }

            if (id > 0)
            {
                var OcorrenciaTO = OcorrenciaService.Obter(id);
                var OcorrenciaVM = Mapper.Map<OcorrenciaTO, OcorrenciaVM>(OcorrenciaTO);
                NomearVariaveis(OcorrenciaVM, null);
                return View(OcorrenciaVM);
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
                    var retorno = OcorrenciaService.Remover(id);

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

        private void NomearVariaveis(OcorrenciaVM OcorrenciaVM = null, List<OcorrenciaVM> listaOcorrenciaVM = null)
        {
            var listaMoradorTO = MoradorService.Listar().Lista;

            if (listaOcorrenciaVM != null && listaOcorrenciaVM.Count > 0)
            {
                foreach (var con in listaOcorrenciaVM)
                {
                    con.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == con.IdMorador).Nome;
                }
            }

            if (OcorrenciaVM != null)
            {
                OcorrenciaVM.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == OcorrenciaVM.IdMorador).Nome;
            }
        }
    }
}
