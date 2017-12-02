namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Database.TO;
    using AutoMapper;
    using PIM.Web.ViewModels;
    using PIM.Service.Services;
    using System.Linq;

    public class AdvertenciasController : Controller
    {
        public ActionResult Index()
        {
            ListaAdvertenciaTO listaAdvertencia = new ListaAdvertenciaTO();

            try
            {
                listaAdvertencia = AdvertenciaService.Listar();
                var listaAdvertenciaesVM = Mapper.Map<List<AdvertenciaTO>, List<AdvertenciaVM>>(listaAdvertencia.Lista);
                NomearVariaveis(null, listaAdvertenciaesVM);
                return View(listaAdvertenciaesVM);
            }
            catch (Exception ex)
            {
                listaAdvertencia.Mensagem = $"Erro ao obter Advertenciaes. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            AdvertenciaTO AdvertenciaTO = new AdvertenciaTO();

            try
            {
                AdvertenciaTO = AdvertenciaService.Obter(id);

                if (!AdvertenciaTO.Valido)
                {
                    Session["Mensagem"] = AdvertenciaTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var AdvertenciaVM = Mapper.Map<AdvertenciaTO, AdvertenciaVM>(AdvertenciaTO);
                NomearVariaveis(AdvertenciaVM, null);
                return View(AdvertenciaVM);
            }
            catch (Exception ex)
            {
                AdvertenciaTO.Mensagem = $"Erro ao obter Advertencia. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Ocorrencia = ListarOcorrencias();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdvertenciaVM Advertencia)
        {
            if (ModelState.IsValid)
            {
                var AdvertenciaTO = Mapper.Map<AdvertenciaVM, AdvertenciaTO>(Advertencia);

                AdvertenciaService.Criar(AdvertenciaTO);

                Session["Mensagem"] = AdvertenciaTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Advertencia);
            }
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Ocorrencia = ListarOcorrencias();

            if (ModelState.IsValid)
            {
                var AdvertenciaTO = AdvertenciaService.Obter(id);

                if (!AdvertenciaTO.Valido)
                {
                    Session["Mensagem"] = AdvertenciaTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var AdvertenciaVM = Mapper.Map<AdvertenciaTO, AdvertenciaVM>(AdvertenciaTO);
                NomearVariaveis(AdvertenciaVM, null);
                return View(AdvertenciaVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdvertenciaVM AdvertenciaVM)
        {
            if (ModelState.IsValid)
            {
                var AdvertenciaTO = Mapper.Map<AdvertenciaVM, AdvertenciaTO>(AdvertenciaVM);

                AdvertenciaService.Atualizar(AdvertenciaTO);

                if (!AdvertenciaTO.Valido)
                {
                    Session["Mensagem"] = AdvertenciaTO.Valido;
                    return RedirectToAction("Index");
                }

                AdvertenciaVM = Mapper.Map<AdvertenciaTO, AdvertenciaVM>(AdvertenciaTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var AdvertenciaTO = AdvertenciaService.Obter(id);
                var AdvertenciaVM = Mapper.Map<AdvertenciaTO, AdvertenciaVM>(AdvertenciaTO);
                NomearVariaveis(AdvertenciaVM, null);
                return View(AdvertenciaVM);
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
                    var retorno = AdvertenciaService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }

        private SelectList ListarOcorrencias()
        {
            var listaOcorrenciaTO = OcorrenciaService.Listar();
            var listaOcorrenciaVM = Mapper.Map<List<OcorrenciaTO>, List<OcorrenciaVM>>(listaOcorrenciaTO.Lista);
            return new SelectList(listaOcorrenciaVM, "Identificador", "Motivo");
        }

        private void NomearVariaveis(AdvertenciaVM AdvertenciaVM = null, List<AdvertenciaVM> listaAdvertenciaVM = null)
        {
            var listaOcorrenciaTO = OcorrenciaService.Listar().Lista;

            if (listaAdvertenciaVM != null && listaAdvertenciaVM.Count > 0)
            {
                foreach (var con in listaAdvertenciaVM)
                {
                    con.MotivoOcorrencia = listaOcorrenciaTO.FirstOrDefault(x => x.Identificador == con.IdOcorrencia).Motivo;
                }
            }

            if (AdvertenciaVM != null)
            {
                AdvertenciaVM.MotivoOcorrencia = listaOcorrenciaTO.FirstOrDefault(x => x.Identificador == AdvertenciaVM.IdOcorrencia).Motivo;
            }
        }
    }
}
