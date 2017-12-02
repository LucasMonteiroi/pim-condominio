namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Database.TO;
    using PIM.Service.Services;
    using AutoMapper;
    using PIM.Web.ViewModels;

    public class MoradoresController : Controller
    {
        public ActionResult Index()
        {
            ListaMoradorTO listaMorador = new ListaMoradorTO();

            try
            {
                listaMorador = MoradorService.Listar();
                var listaMoradoresVM = Mapper.Map<List<MoradorTO>, List<MoradorVM>>(listaMorador.Lista);

                return View(listaMoradoresVM);
            }
            catch (Exception ex)
            {
                listaMorador.Mensagem = $"Erro ao obter moradores. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            MoradorTO moradorTO = new MoradorTO();

            try
            {
                moradorTO = MoradorService.Obter(id);

                if (!moradorTO.Valido)
                {
                    Session["Mensagem"] = moradorTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var moradorVM = Mapper.Map<MoradorTO, MoradorVM>(moradorTO);

                return View(moradorVM);
            }
            catch (Exception ex)
            {
                moradorTO.Mensagem = $"Erro ao obter morador. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MoradorVM morador)
        {
            if (ModelState.IsValid)
            {
                var moradorTO = Mapper.Map<MoradorVM, MoradorTO>(morador);

                MoradorService.Criar(moradorTO);

                Session["Mensagem"] = moradorTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(morador);
            }
        }

        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var moradorTO = MoradorService.Obter(id);

                if (!moradorTO.Valido)
                {
                    Session["Mensagem"] = moradorTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var moradorVM = Mapper.Map<MoradorTO, MoradorVM>(moradorTO);

                return View(moradorVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MoradorVM moradorVM)
        {
            if (ModelState.IsValid)
            {
                var moradorTO = Mapper.Map<MoradorVM, MoradorTO>(moradorVM);

                MoradorService.Atualizar(moradorTO);

                if (!moradorTO.Valido)
                {
                    Session["Mensagem"] = moradorTO.Valido;
                    return RedirectToAction("Index");
                }

                moradorVM = Mapper.Map<MoradorTO, MoradorVM>(moradorTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var moradorTO = MoradorService.Obter(id);
                var moradorVM = Mapper.Map<MoradorTO, MoradorVM>(moradorTO);

                return View(moradorVM);
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
                    var retorno = MoradorService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
