using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockAstronomicalObjectRepository : IAstronomicalObjectRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<AstronomicalObject> AstronomicalObjects {
            get
            {
                return new List<AstronomicalObject>
                {
                    new AstronomicalObject {
                        Name = "16 Psyche",
                        Price = 100000M,
                        ShortDescription = "16 Psyche is one of the ten most massive asteroids in the asteroid belt.",
                        LongDescription = "It is over 200 km (120 mi) in diameter and contains a little less than 1% of the mass of the entire asteroid belt. It is thought to be the exposed iron core of a protoplanet. It is the most massive metallic M-type asteroid. This is a unique object in our solar system, estimated at 10,000 quadrillion US dollars. The whole world economics is worth about 74 trillion dollars. Extraction of materials from this asteroid will change the work of the entire economics of the Earth.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg",
                        InStock = true,
                        IsPreferredAstronomicalObject = true,
                        ImageThumbnailUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg"
                    },
                    new AstronomicalObject {
                        Name = "10 Hygiea",
                        Price = 100000M,
                        ShortDescription = "10 Hygiea is the fourth-largest asteroid in the Solar System by volume and mass.",
                        LongDescription = "It is located in the asteroid belt. With somewhat oblong diameters of 350–500 kilometres (220–310 mi) and a mass estimated to be 2.9% of the total mass of the belt,[7] it is the largest of the class of dark C-type asteroids with a carbonaceous surface.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg",
                        InStock = true,
                        IsPreferredAstronomicalObject = true,
                        ImageThumbnailUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg"
                    },
                    new AstronomicalObject {
                        Name = "21 Lutetia",
                        Price = 100000M,
                        ShortDescription = "Lutetia is a large asteroid in the asteroid belt of an unusual spectral type.",
                        LongDescription = "It measures about 100 kilometers in diameter (120 km along its major axis). It was discovered in 1852 by Hermann Goldschmidt, and is named after Lutetia, the Latin name of Paris.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg",
                        InStock = true,
                        IsPreferredAstronomicalObject = true,
                        ImageThumbnailUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg"
                    },
                    new AstronomicalObject {
                        Name = "57 Mnemosyne",
                        Price = 100000M,
                        ShortDescription = "57 Mnemosyne is a large main belt asteroid.",
                        LongDescription = "It is an S-type asteroid in composition. It was discovered by Robert Luther on 22 September 1859 from Düsseldorf. Its name was chosen by Martin Hoek, director of the Utrecht Observatory, in reference to Mnemosyne, a Titaness in Greek mythology. In astrology, the asteroid Mnemozina symbolizes the memory of the past, giving impetus to creativity.",
                        Category = _categoryRepository.Categories.ElementAt(1),
                        ImageUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg",
                        InStock = true,
                        IsPreferredAstronomicalObject = true,
                        ImageThumbnailUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg"
                    },
                    new AstronomicalObject {
                        Name = "100 Hekate",
                        Price = 100000M,
                        ShortDescription = "100 Hekate is a large main belt asteroid.",
                        LongDescription = "It orbits in the same region of space as the Hygiea asteroid family, though it is actually an unrelated interloper. Its albedo of 0.19 is too high, and it is of the wrong spectral class to be part of the dark carbonaceous Hygiea family. It is listed as a member of the Hecuba group of asteroids that orbit near the 2:1 mean-motion resonance with Jupiter. It is named after Hecate, the goddess of witchcraft in Greek mythology.",
                        Category = _categoryRepository.Categories.ElementAt(1),
                        ImageUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg",
                        InStock = true,
                        IsPreferredAstronomicalObject = true,
                        ImageThumbnailUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg"
                    },
                     new AstronomicalObject {
                        Name = "149 Medusa",
                        Price = 100000M,
                        ShortDescription = "149 Medusa is a bright-coloured, stony main-belt asteroid.",
                        LongDescription = "149 Medusa was discovered by French astronomer J. Perrotin on September 21, 1875, and named after the Gorgon Medusa, a snake-haired monster in Greek mythology. When it was discovered, Medusa was by far the smallest asteroid found (although this was not known at that time). Since then, many thousands of smaller asteroids have been found. It was also the closest asteroid to the Sun discovered up to that point, beating the long-held record of 8 Flora. It remained the closest asteroid to the Sun until 1898.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg",
                        InStock = true,
                        IsPreferredAstronomicalObject = true,
                        ImageThumbnailUrl = "https://r.hswstatic.com/w_907/gif/asteroidflorence-1.jpg"
                    },
                };
             }
        }

        public IEnumerable<AstronomicalObject> PreferredAstronomicalObjects { get; }
        public AstronomicalObject GetAstronomicalObjectById(int AOId)
        {
            throw new NotImplementedException();
        }
    }
}
