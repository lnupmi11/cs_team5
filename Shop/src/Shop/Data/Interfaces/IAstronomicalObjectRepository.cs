using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IAstronomicalObjectRepository
    {
        IEnumerable<AstronomicalObject> AstronomicalObjects { get; }

        IEnumerable<AstronomicalObject> PreferredAstronomicalObjects { get; }

        AstronomicalObject GetAstronomicalObjectById(int AOId);
    }
}
