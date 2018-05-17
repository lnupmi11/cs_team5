using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<AstronomicalObject> astronomicalObjects;

            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                astronomicalObjects = _astronomicalObjectRepository.AstronomicalObjects.OrderBy(n => n.AstronomicalObjectId);
                currentCategory = "All Asteroids";
            }
            else
            {
                if(string.Equals("C-type asteroids", _category, System.StringComparison.OrdinalIgnoreCase))
                {
                    astronomicalObjects = _astronomicalObjectRepository.AstronomicalObjects.Where(p => p.Category.CategoryName.Equals("C-type asteroids")).OrderBy(p => p.Name);
                }
                else if(string.Equals("S-type asteroids", _category, System.StringComparison.OrdinalIgnoreCase))
                {
                    astronomicalObjects = _astronomicalObjectRepository.AstronomicalObjects.Where(p => p.Category.CategoryName.Equals("S-type asteroids")).OrderBy(p => p.Name);
                }
                else
                {
                    astronomicalObjects = _astronomicalObjectRepository.AstronomicalObjects.Where(p => p.Category.CategoryName.Equals("M-type asteroids")).OrderBy(p => p.Name);
                }

                currentCategory = _category;
            }

            var astronomicalObjectListViewModel = new AstronomicalObjectListViewModel
            {
                AstronomicalObjects = astronomicalObjects,
                CurrentCategory = currentCategory
            };

            return View(astronomicalObjectListViewModel);
        }
    }
}
