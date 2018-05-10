using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class AstronomicalObjectListViewModel
    {
        public IEnumerable<AstronomicalObject> AstronomicalObjects { get; set; }
        public string CurrentCategory { get; set; }
    }
}
