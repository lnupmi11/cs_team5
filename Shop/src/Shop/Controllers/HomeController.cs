using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAstronomicalObjectRepository _astronomicalObjectRepository;
        
        public HomeController(IAstronomicalObjectRepository astronomicalObjectRepository)
        {
            _astronomicalObjectRepository = astronomicalObjectRepository;
        }
        
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredAstronomicalObjects = _astronomicalObjectRepository.PreferredAstronomicalObjects
            };
            return View(homeViewModel);
        }
    }
}
