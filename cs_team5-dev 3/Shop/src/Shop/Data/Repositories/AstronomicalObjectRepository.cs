using Shop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repositories
{
    public class AstronomicalObjectRepository : IAstronomicalObjectRepository
    {
        private readonly AppDbContext _appDbContext;

        public AstronomicalObjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<AstronomicalObject> AstronomicalObjects => _appDbContext.AstronomicalObjects.Include(c => c.Category);

        public IEnumerable<AstronomicalObject> PreferredAstronomicalObjects => _appDbContext.AstronomicalObjects.Where(p => p.IsPreferredAstronomicalObject).Include(c => c.Category);

        public AstronomicalObject GetAstronomicalObjectById(int astronomicalObjectId) => _appDbContext.AstronomicalObjects.FirstOrDefault(p => p.AstronomicalObjectId == astronomicalObjectId);
    }
}
