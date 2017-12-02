namespace PIM.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using PIM.Service.Services;
    using PIM.Database.TO;
    using PIM.Web.ViewModels;
    using AutoMapper;
    using System.Linq;

    public class UsuariosController : Controller
    {
        public ActionResult Index()
        {
            ListaUsuarioTO listaUsuario = new ListaUsuarioTO();

            try
            {
                listaUsuario = UsuarioService.Listar();
                var listaUsuariosVM = Mapper.Map<List<UsuarioTO>, List<UsuarioVM>>(listaUsuario.Lista);

                NomearVariaveisVM(null, listaUsuariosVM);

                return View(listaUsuariosVM);
            }
            catch (Exception ex)
            {
                listaUsuario.Mensagem = $"Erro ao obter Usuarioes. Erro: {ex.Message} ";
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            UsuarioTO UsuarioTO = new UsuarioTO();

            try
            {
                UsuarioTO = UsuarioService.Obter(id);

                if (!UsuarioTO.Valido)
                {
                    Session["Mensagem"] = UsuarioTO.Mensagem;

                    return RedirectToActionPermanent("Index");
                }

                var usuarioVM = Mapper.Map<UsuarioTO, UsuarioVM>(UsuarioTO);

                NomearVariaveisVM(usuarioVM);

                return View(usuarioVM);
            }
            catch (Exception ex)
            {
                UsuarioTO.Mensagem = $"Erro ao obter Usuario. Erro: {ex.Message}";

            }

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Colaborador = ListarColaboradores();
            ViewBag.Grupo = ListarGrupos();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioVM Usuario)
        {
            if (ModelState.IsValid)
            {
                var UsuarioTO = Mapper.Map<UsuarioVM, UsuarioTO>(Usuario);

                UsuarioService.Criar(UsuarioTO);

                Session["Mensagem"] = UsuarioTO.Mensagem;
                return RedirectToAction("Index");
            }
            else
            {
                return View(Usuario);
            }
        }

        public ActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Colaborador = ListarColaboradores();
                ViewBag.Grupo = ListarGrupos();

                var UsuarioTO = UsuarioService.Obter(id);

                if (!UsuarioTO.Valido)
                {
                    Session["Mensagem"] = UsuarioTO.Mensagem;
                    return RedirectToAction("Index");
                }

                var usuarioVM = Mapper.Map<UsuarioTO, UsuarioVM>(UsuarioTO);

                NomearVariaveisVM(usuarioVM);

                return View(usuarioVM);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioVM UsuarioVM)
        {
            if (ModelState.IsValid)
            {
                var UsuarioTO = Mapper.Map<UsuarioVM, UsuarioTO>(UsuarioVM);

                UsuarioService.Atualizar(UsuarioTO);

                if (!UsuarioTO.Valido)
                {
                    Session["Mensagem"] = UsuarioTO.Valido;
                    return RedirectToAction("Index");
                }

                UsuarioVM = Mapper.Map<UsuarioTO, UsuarioVM>(UsuarioTO);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var UsuarioTO = UsuarioService.Obter(id);
                var usuarioVM = Mapper.Map<UsuarioTO, UsuarioVM>(UsuarioTO);

                NomearVariaveisVM(usuarioVM);

                return View(usuarioVM);
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
                    var retorno = UsuarioService.Remover(id);

                    Session["Mensagem"] = retorno.Mensagem;
                }
            }

            return RedirectToAction("Index");
        }

        private SelectList ListarGrupos()
        {
            var listaGrupoTO = GrupoUsuarioService.Listar();
            var listaGrupoVM = Mapper.Map<List<GrupoUsuarioTO>, List<GrupoUsuarioVM>>(listaGrupoTO.Lista);
            return new SelectList(listaGrupoVM, "Identificador", "Nome");
        }

        private SelectList ListarColaboradores()
        {
            var listaColaboradorTO = ColaboradorService.Listar();
            var listaColaboradorVM = Mapper.Map<List<ColaboradorTO>, List<ColaboradorVM>>(listaColaboradorTO.Lista);
            return new SelectList(listaColaboradorVM, "Identificador", "Nome");
        }

        private void NomearVariaveisVM(UsuarioVM usuarioVM = null, List<UsuarioVM> listaUsuarioVM = null)
        {
            var listaGrupoTO = GrupoUsuarioService.Listar().Lista;
            var listaColaboradorTO = ColaboradorService.Listar().Lista;

            if (listaUsuarioVM != null && listaUsuarioVM.Count > 0)
            {
                foreach (var usu in listaUsuarioVM)
                {
                    usu.NomeColaborador = listaColaboradorTO.FirstOrDefault(x => x.Identificador == usu.IdColaborador).Nome;
                    usu.NomeGrupoUsuario = listaGrupoTO.FirstOrDefault(x => x.Identificador == usu.IdGrupo).Nome;

                }
            }

            if (usuarioVM != null)
            {
                usuarioVM.NomeColaborador = listaColaboradorTO.FirstOrDefault(x => x.Identificador == usuarioVM.IdColaborador).Nome;
                usuarioVM.NomeGrupoUsuario = listaGrupoTO.FirstOrDefault(x => x.Identificador == usuarioVM.IdGrupo).Nome;
            }

        }
    }
}
