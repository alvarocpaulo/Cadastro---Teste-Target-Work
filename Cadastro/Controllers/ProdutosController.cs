using Cadastro.Interfaces;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutosViewModelService _produtosViewModelService;
        public ProdutosController(IProdutosViewModelService produtosViewModelService)
        {
            _produtosViewModelService = produtosViewModelService;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var list = _produtosViewModelService.GetAll();
            return View(list);
        }

        // GET: Produtos/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var viewModel = id;
            return View(viewModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel viewModel)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _produtosViewModelService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = id;
            return View(viewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProdutoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtosViewModelService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = id;
            return View(viewModel);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = id;
                return View(viewModel);
            }
            catch
            {
                var viewModel = id;
                return View(viewModel);
            }
        }
    }
}
