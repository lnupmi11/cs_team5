using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<AstronomicalObject> PreferredAstronomicalObjects { get; set; }
    }
}
