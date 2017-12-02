using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PIM.Database.DatabaseModel;
using PIM.Web.ViewModels;
using PIM.Database.TO;
using PIM.Service.Services;
using AutoMapper;

namespace PIM.Web.Controllers
{
    public class ColaboradoresController : Controller
    {
        public ActionResult Index()
        {
            ListaColaboradorTO listaColaborador = new ListaColaboradorTO();

            try
            {
                listaColaborador = ColaboradorService.Listar();
                var listaColaboradoresVM = Mapper.Map<List<ColaboradorTO>, List<ColaboradorVM>>(listaColaborador.Lista);

                return View(listaColaboradoresVM);
            }
            catch (Exception ex)
            {
                listaColaborador.Mensagem = $"Erro ao obter Colaboradores. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            ColaboradorTO ColaboradorTO = new ColaboradorTO();

            try
            {
                ColaboradorTO = ColaboradorService.Obter(id);

                if (!ColaboradorTO.Valido)
                {
                    Session["Mensagem"] = ColaboradorTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var ColaboradorVM = Mapper.Map<ColaboradorTO, ColaboradorVM>(ColaboradorTO);

                return View(ColaboradorVM);
            }
            catch (Exception ex)
            {
                ColaboradorTO.Mensagem = $"Erro ao obter Colaborador. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ColaboradorVM Colaborador)
        {
            if (ModelState.IsValid)
            {
                var ColaboradorTO = Mapper.Map<ColaboradorVM, ColaboradorTO>(Colaborador);

                ColaboradorService.Criar(ColaboradorTO);

                Session["Mensagem"] = ColaboradorTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Colaborador);
            }
        }

        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var ColaboradorTO = ColaboradorService.Obter(id);

                if (!ColaboradorTO.Valido)
                {
                    Session["Mensagem"] = ColaboradorTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var ColaboradorVM = Mapper.Map<ColaboradorTO, ColaboradorVM>(ColaboradorTO);

                return View(ColaboradorVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ColaboradorVM ColaboradorVM)
        {
            if (ModelState.IsValid)
            {
                var ColaboradorTO = Mapper.Map<ColaboradorVM, ColaboradorTO>(ColaboradorVM);

                ColaboradorService.Atualizar(ColaboradorTO);

                if (!ColaboradorTO.Valido)
                {
                    Session["Mensagem"] = ColaboradorTO.Valido;
                    return RedirectToAction("Index");
                }

                ColaboradorVM = Mapper.Map<ColaboradorTO, ColaboradorVM>(ColaboradorTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var ColaboradorTO = ColaboradorService.Obter(id);
                var ColaboradorVM = Mapper.Map<ColaboradorTO, ColaboradorVM>(ColaboradorTO);

                return View(ColaboradorVM);
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
                    var retorno = ColaboradorService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }
    }
}
