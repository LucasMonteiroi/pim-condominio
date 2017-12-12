namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Service.Services;
    using AutoMapper;
    using PIM.Web.ViewModels;
    using PIM.Database.TO;
    using System.Linq;

    public class ContratosController : Controller
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

            ListaContratoTO listaContrato = new ListaContratoTO();

            try
            {
                listaContrato = ContratoService.Listar();
                var listaContratosVM = Mapper.Map<List<ContratoTO>, List<ContratoVM>>(listaContrato.Lista);

                NomearVariaveis(null, listaContratosVM);

                return View(listaContratosVM);
            }
            catch (Exception ex)
            {
                listaContrato.Mensagem = $"Erro ao obter Contratoes. Erro: {ex.Message} ";
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

            ContratoTO ContratoTO = new ContratoTO();

            try
            {
                ContratoTO = ContratoService.Obter(id);

                if (!ContratoTO.Valido)
                {
                    Session["Mensagem"] = ContratoTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var ContratoVM = Mapper.Map<ContratoTO, ContratoVM>(ContratoTO);

                return View(ContratoVM);
            }
            catch (Exception ex)
            {
                ContratoTO.Mensagem = $"Erro ao obter Contrato. Erro: {ex.Message}";

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

            ViewBag.Morador = ListarMoradores();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContratoVM Contrato)
        {
            if (ModelState.IsValid)
            {
                Contrato.TipoContrato = Contrato.TipoContrato.Substring(0, 1);
                var ContratoTO = Mapper.Map<ContratoVM, ContratoTO>(Contrato);

                ContratoService.Criar(ContratoTO);

                Session["Mensagem"] = ContratoTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Contrato);
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

            ViewBag.Morador = ListarMoradores();

            if (ModelState.IsValid)
            {
                var ContratoTO = ContratoService.Obter(id);

                if (!ContratoTO.Valido)
                {
                    Session["Mensagem"] = ContratoTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var ContratoVM = Mapper.Map<ContratoTO, ContratoVM>(ContratoTO);

                return View(ContratoVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContratoVM ContratoVM)
        {
            if (ModelState.IsValid)
            {
                ContratoVM.TipoContrato = ContratoVM.TipoContrato.Substring(0, 1);

                var ContratoTO = Mapper.Map<ContratoVM, ContratoTO>(ContratoVM);

                ContratoService.Atualizar(ContratoTO);

                if (!ContratoTO.Valido)
                {
                    Session["Mensagem"] = ContratoTO.Valido;
                    return RedirectToAction("Index");
                }

                ContratoVM = Mapper.Map<ContratoTO, ContratoVM>(ContratoTO);
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
                var ContratoTO = ContratoService.Obter(id);
                var ContratoVM = Mapper.Map<ContratoTO, ContratoVM>(ContratoTO);

                return View(ContratoVM);
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
                    var retorno = ContratoService.Remover(id);

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

        private void NomearVariaveis(ContratoVM contratoVM = null, List<ContratoVM> listaContratoVM = null)
        {
            var listaMoradorTO = MoradorService.Listar().Lista;

            if (listaContratoVM != null && listaContratoVM.Count > 0)
            {
                foreach (var con in listaContratoVM)
                {
                    con.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == con.IdMorador).Nome;
                }
            }

            if (contratoVM != null)
            {
                contratoVM.NomeMorador = listaMoradorTO.FirstOrDefault(x => x.Identificador == contratoVM.IdMorador).Nome;
            }
        }
    }
}
