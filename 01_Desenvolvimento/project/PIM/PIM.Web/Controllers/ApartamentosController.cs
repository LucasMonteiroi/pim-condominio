namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using PIM.Database.DatabaseModel;
    using PIM.Service.Services;
    using PIM.Web.ViewModels;
    using PIM.Database.TO;
    using AutoMapper;

    public class ApartamentosController : Controller
    {
        public ActionResult Index()
        {
            ListaApartamentoTO listaApartamento = new ListaApartamentoTO();

            try
            {
                listaApartamento = ApartamentoService.Listar();
                var listaApartamentosVM = Mapper.Map<List<ApartamentoTO>, List<ApartamentoVM>>(listaApartamento.Lista);

                NomearVariaveis(null, listaApartamentosVM);

                return View(listaApartamentosVM);
            }
            catch (Exception ex)
            {
                listaApartamento.Mensagem = $"Erro ao obter Apartamentoes. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.Contratos = ListarContratos();

            ApartamentoTO ApartamentoTO = new ApartamentoTO();

            try
            {
                ApartamentoTO = ApartamentoService.Obter(id);

                if (!ApartamentoTO.Valido)
                {
                    Session["Mensagem"] = ApartamentoTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var apartamentoVM = Mapper.Map<ApartamentoTO, ApartamentoVM>(ApartamentoTO);
                NomearVariaveis(apartamentoVM);
                return View(apartamentoVM);
            }
            catch (Exception ex)
            {
                ApartamentoTO.Mensagem = $"Erro ao obter Apartamento. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Contratos = ListarContratos();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ApartamentoVM Apartamento)
        {
            if (ModelState.IsValid)
            {
                var ApartamentoTO = Mapper.Map<ApartamentoVM, ApartamentoTO>(Apartamento);

                ApartamentoService.Criar(ApartamentoTO);

                Session["Mensagem"] = ApartamentoTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Apartamento);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Contratos = ListarContratos();

            if (ModelState.IsValid)
            {
                var ApartamentoTO = ApartamentoService.Obter(id);

                if (!ApartamentoTO.Valido)
                {
                    Session["Mensagem"] = ApartamentoTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var apartamentoVM = Mapper.Map<ApartamentoTO, ApartamentoVM>(ApartamentoTO);
                NomearVariaveis(apartamentoVM);
                return View(apartamentoVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ApartamentoVM ApartamentoVM)
        {
            if (ModelState.IsValid)
            {
                var ApartamentoTO = Mapper.Map<ApartamentoVM, ApartamentoTO>(ApartamentoVM);

                ApartamentoService.Atualizar(ApartamentoTO);

                if (!ApartamentoTO.Valido)
                {
                    Session["Mensagem"] = ApartamentoTO.Valido;
                    return RedirectToAction("Index");
                }

                ApartamentoVM = Mapper.Map<ApartamentoTO, ApartamentoVM>(ApartamentoTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ViewBag.Contratos = ListarContratos();

            if (id > 0)
            {
                var ApartamentoTO = ApartamentoService.Obter(id);
                var apartamentoVM = Mapper.Map<ApartamentoTO, ApartamentoVM>(ApartamentoTO);

                NomearVariaveis(apartamentoVM);

                return View(apartamentoVM);
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
                    var retorno = ApartamentoService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }

        private SelectList ListarContratos()
        {
            var listaContratoTO = ContratoService.Listar();
            var listaContratoVM = Mapper.Map<List<ContratoTO>, List<ContratoVM>>(listaContratoTO.Lista);
            return new SelectList(listaContratoVM, "Identificador", "Descricao");
        }

        private void NomearVariaveis(ApartamentoVM ApartamentoVM = null, List<ApartamentoVM> listaApartamentosVM = null)
        {
            var listaContratoTO = ContratoService.Listar().Lista;

            if (listaApartamentosVM != null && listaApartamentosVM.Count > 0)
            {
                foreach (var apa in listaApartamentosVM)
                {
                    apa.DescricaoContrato = listaContratoTO.FirstOrDefault(x => x.Identificador == apa.IdContrato).Descricao;
                }
            }

            if (ApartamentoVM != null)
            {
                ApartamentoVM.DescricaoContrato = listaContratoTO.FirstOrDefault(x => x.Identificador == ApartamentoVM.IdContrato).Descricao;
            }
        }
    }
}
