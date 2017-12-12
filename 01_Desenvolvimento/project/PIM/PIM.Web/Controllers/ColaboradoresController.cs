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

            ListaColaboradorTO listaColaborador = new ListaColaboradorTO();

            try
            {
                listaColaborador = ColaboradorService.Listar();
                var listaColaboradoresVM = Mapper.Map<List<ColaboradorTO>, List<ColaboradorVM>>(listaColaborador.Lista);

                foreach(var c in listaColaboradoresVM)
                {
                    c.DataAdimissao = c.DataContrato.GetValueOrDefault().ToString("dd/MM/yyyy");
                    c.ValorSalario = c.Salario.HasValue ? string.Format("R$ {0:C}", c.Salario.Value) : string.Empty;
                }

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
                ColaboradorVM.CPF = ColaboradorVM.CPF.Replace(".", "").Replace("-", "");
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
            if (Session["MoradorTO"] != null)
            {
                return RedirectToActionPermanent("AccessDenied", "ErrorHandler");
            }

            if (Session["UsuarioTO"] != null)
            {
                _usuarioTO = (UsuarioTO)Session["UsuarioTO"];
                if (!_usuarioTO.Valido)
                    return RedirectToActionPermanent("Login", "Home");
            }

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
