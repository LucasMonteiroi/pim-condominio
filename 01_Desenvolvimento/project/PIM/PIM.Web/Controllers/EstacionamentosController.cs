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

    public class EstacionamentosController : Controller
    {
        public ActionResult Index()
        {
            ListaEstacionamentoTO listaEstacionamento = new ListaEstacionamentoTO();

            try
            {
                listaEstacionamento = EstacionamentoService.Listar();
                var listaEstacionamentosVM = Mapper.Map<List<EstacionamentoTO>, List<EstacionamentoVM>>(listaEstacionamento.Lista);
                NomearVariaveis(null, listaEstacionamentosVM);
                return View(listaEstacionamentosVM);
            }
            catch (Exception ex)
            {
                listaEstacionamento.Mensagem = $"Erro ao obter Estacionamentoes. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.Apartamentos = ListarApartamentos();

            EstacionamentoTO EstacionamentoTO = new EstacionamentoTO();

            try
            {
                EstacionamentoTO = EstacionamentoService.Obter(id);

                if (!EstacionamentoTO.Valido)
                {
                    Session["Mensagem"] = EstacionamentoTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var EstacionamentoVM = Mapper.Map<EstacionamentoTO, EstacionamentoVM>(EstacionamentoTO);
                NomearVariaveis(EstacionamentoVM);
                return View(EstacionamentoVM);
            }
            catch (Exception ex)
            {
                EstacionamentoTO.Mensagem = $"Erro ao obter Estacionamento. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Apartamentos = ListarApartamentos();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacionamentoVM Estacionamento)
        {
            if (ModelState.IsValid)
            {
                var EstacionamentoTO = Mapper.Map<EstacionamentoVM, EstacionamentoTO>(Estacionamento);

                EstacionamentoService.Criar(EstacionamentoTO);

                Session["Mensagem"] = EstacionamentoTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Estacionamento);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Apartamentos = ListarApartamentos();
            if (ModelState.IsValid)
            {
                var EstacionamentoTO = EstacionamentoService.Obter(id);

                if (!EstacionamentoTO.Valido)
                {
                    Session["Mensagem"] = EstacionamentoTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var EstacionamentoVM = Mapper.Map<EstacionamentoTO, EstacionamentoVM>(EstacionamentoTO);
                NomearVariaveis(EstacionamentoVM);
                return View(EstacionamentoVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacionamentoVM EstacionamentoVM)
        {
            if (ModelState.IsValid)
            {
                var EstacionamentoTO = Mapper.Map<EstacionamentoVM, EstacionamentoTO>(EstacionamentoVM);

                EstacionamentoService.Atualizar(EstacionamentoTO);

                if (!EstacionamentoTO.Valido)
                {
                    Session["Mensagem"] = EstacionamentoTO.Valido;
                    return RedirectToAction("Index");
                }

                EstacionamentoVM = Mapper.Map<EstacionamentoTO, EstacionamentoVM>(EstacionamentoTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ViewBag.Apartamentos = ListarApartamentos();

            if (id > 0)
            {
                var EstacionamentoTO = EstacionamentoService.Obter(id);
                var EstacionamentoVM = Mapper.Map<EstacionamentoTO, EstacionamentoVM>(EstacionamentoTO);
                NomearVariaveis(EstacionamentoVM);
                return View(EstacionamentoVM);
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
                    var retorno = EstacionamentoService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }

        private SelectList ListarApartamentos()
        {
            var listaApartamentoTO = ApartamentoService.Listar();
            var listaApartamentoVM = Mapper.Map<List<ApartamentoTO>, List<ApartamentoVM>>(listaApartamentoTO.Lista);
            return new SelectList(listaApartamentoVM, "Identificador", "Numero");
        }

        private void NomearVariaveis(EstacionamentoVM estacionamentoVM = null, List<EstacionamentoVM> listaEstacionamentoVM = null)
        {
            var listaApartamentoTO = ApartamentoService.Listar().Lista;

            if (listaEstacionamentoVM != null && listaEstacionamentoVM.Count > 0)
            {
                foreach (var est in listaEstacionamentoVM)
                {
                    var apa = listaApartamentoTO.FirstOrDefault(x => x.Identificador == est.IdApartamento);

                    est.Apartamento = $"Bloco: {apa.Bloco} - Número: {apa.Numero}";
                }
            }

            if (estacionamentoVM != null)
            {
                var apa = listaApartamentoTO.FirstOrDefault(x => x.Identificador == estacionamentoVM.IdApartamento);

                estacionamentoVM.Apartamento = $"Bloco: {apa.Bloco} - Número: {apa.Numero}";
            }
        }
    }
}