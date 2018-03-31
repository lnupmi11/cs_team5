using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "C-type asteroids", Description = "Carbonaceous asteroids" },
                    new Category { CategoryName = "S-type asteroids", Description = "Silicaceous asteroids" },
                    new Category { CategoryName = "M-type asteroids", Description = "Metallic core asteroids" },
                };
            }
        }
    }
}
