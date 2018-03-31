using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.Data.Mocks;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Data.Controllers
{
    public class AstronomicalObjectController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAstronomicalObjectRepository _astronomicalObjectRepository;

        public AstronomicalObjectController(ICategoryRepository categoryRepository, IAstronomicalObjectRepository astronomicalObjectRepository)
        {
            _categoryRepository = categoryRepository;
            _astronomicalObjectRepository = astronomicalObjectRepository;
        }

        public ViewResult List()
        {
            var astronomicalObjects = _astronomicalObjectRepository.AstronomicalObjects;
            return View(astronomicalObjects);
        }
    }
}
