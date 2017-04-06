using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto { Id = 1,
                    Name = "New Yourk city",
                    Description = "Someting about NY",
                    PointsOfInterest = new List<PointOfInterestDto>
                    {
                        new PointOfInterestDto
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Very nice and big park"
                        },
                                                new PointOfInterestDto
                        {
                            Id = 2,
                            Name = "Empire state building",
                            Description = "Scyscraper"
                        }
                    }
                },
                new CityDto { Id = 2, Name = "Berlin", Description = "Stolica szwabow"},
                new CityDto { Id = 3, Name = "Wroclaw", Description = "Moje miasto"},
                new CityDto { Id = 4, Name = "Warsov", Description = "jak to napisac do angieslku"},
                new CityDto { Id = 5, Name = "Poznan", Description = "Po prostu pyry"}
            };
        }
    }
}