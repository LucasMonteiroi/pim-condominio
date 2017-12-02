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
        public ActionResult Index()
        {
            ListaVisitanteTO listaVisitante = new ListaVisitanteTO();

            try
            {
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
            ViewBag.Morador = ListarMoradores();
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
            else
            {
                return View(Visitante);
            }
        }

        public ActionResult Edit(int id)
        {
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

        private SelectList ListarMoradores()
        {
            var listaMoradorTO = MoradorService.Listar();
            var listaMoradorVM = Mapper.Map<List<MoradorTO>, List<MoradorVM>>(listaMoradorTO.Lista);
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
