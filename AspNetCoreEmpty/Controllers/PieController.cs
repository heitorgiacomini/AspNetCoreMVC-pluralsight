using AspNetCoreEmpty.Models;
using AspNetCoreEmpty.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(
            IPieRepository pieRepository,
            ICategoryRepository categoryRepository
        )
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }


        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.CurrentCategory = "Cheese cakes";
            piesListViewModel.Pies = _pieRepository.Pies;
            return View(piesListViewModel);
        }
    }
}
