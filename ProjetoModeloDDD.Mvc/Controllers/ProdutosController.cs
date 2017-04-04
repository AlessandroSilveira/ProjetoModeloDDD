using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Mvc.ViewModels;

namespace ProjetoModeloDDD.Mvc.Controllers
{
    public class ProdutosController : Controller
    {
	    private readonly IProdutoAppService _produtoAppService;
	    private readonly IClienteAppService _clienteAppService;

	    public ProdutosController(IProdutoAppService produtoAppService, IClienteAppService clienteAppService)
	    {
		    _produtoAppService = produtoAppService;
		    _clienteAppService = clienteAppService;
	    }

	    // GET: Produtos
        public ActionResult Index()
        {
			var produtoViewModel =
			   Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAppService.GetAll());

			return View(produtoViewModel);
		}

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
			var produto = _produtoAppService.GetById(id);
			var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
			return View(produtoViewModel);
		}

        // GET: Produtos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(ProdutoViewModel produto)
        {
			if (ModelState.IsValid)
			{
				var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
				_produtoAppService.Add(produtoDomain);

				return RedirectToAction("Index");

			}
			return View(produto);
		}

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
			var produto = _produtoAppService.GetById(id);
			var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
			return View(produtoViewModel);
		}

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoViewModel produto)
        {
			if (ModelState.IsValid)
			{
				var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
				_produtoAppService.Update(produtoDomain);

				return RedirectToAction("Index");
			}
			return View();
		}

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
			var produto = _produtoAppService.GetById(id);
			var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

			return View(produtoViewModel);
		}

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
			var produto = _produtoAppService.GetById(id);
			_produtoAppService.Remove(produto);

			return RedirectToAction("Index");
		}
    }
}
