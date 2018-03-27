using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    interface IAstronomicalObjectRepository
    {
        IEnumerable<AstronomicalObject> AstronomicalObjects { get; set; }

        IEnumerable<AstronomicalObject> PreferredAstronomicalObjects { get; set; }

        AstronomicalObject GetAstronomicalObjectById(int AOId);
    }
}
