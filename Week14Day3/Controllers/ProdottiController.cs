using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week14Day3.Core.BusinessLayer;
using Week14Day3.Helper;
using Week14Day3.Models;

namespace Week14Day3.Controllers
{
    public class ProdottiController : Controller
    {

        private readonly IBusinessLayer BL;
        public ProdottiController(IBusinessLayer BL)
        {
            this.BL = BL;
        }

        #region CRUD-Prodotto
        public IActionResult Index()
        {
            var prodotti = BL.GetAllProducts();
            List<ProdottoViewModel> prodottiViewModel = new List<ProdottoViewModel>();
            foreach (var p in prodotti)
            {
                prodottiViewModel.Add(p.toProdottoViewModel());
            }

            return View(prodottiViewModel);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var prodotto = BL.GetAllProducts().Where(p => p.Id == id).FirstOrDefault();
            var prodottoViewModel = prodotto.toProdottoViewModel();

            return View(prodottoViewModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid)
            {
                var prodotto = prodottoViewModel.toProdotto();
                BL.AddProduct(prodotto);
                return RedirectToAction(nameof(Index));
            }

            return View(prodottoViewModel);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var prodotto = BL.GetAllProducts().Where(p => p.Id == id).FirstOrDefault();
            var prodottoViewModel = prodotto.toProdottoViewModel();

            return View(prodottoViewModel);
        }

        [HttpPost]
        public IActionResult Update(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid)
            {
                var prodotto = prodottoViewModel.toProdotto();
                BL.EditProduct(prodotto);
                return RedirectToAction(nameof(Index));
            }
            return View(prodottoViewModel);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var prodotto = BL.GetAllProducts().Where(p => p.Id == id).FirstOrDefault();
            var prodottoViewModel = prodotto.toProdottoViewModel();
            return View(prodottoViewModel);
        }

        [HttpPost]
        public IActionResult Delete(ProdottoViewModel prodottoViewModel)
        {
            if (ModelState.IsValid)
            {

                var prodotto = prodottoViewModel.toProdotto();
                BL.DeleteProduct(prodotto.Id);
                return RedirectToAction(nameof(Index));

            }
            return View(prodottoViewModel);
        }
        #endregion
    }
}
