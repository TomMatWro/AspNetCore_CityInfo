using System.Collections.Generic;
using System.Linq;
using CityInfo.API.Entities;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }
            var cities = new List<City>
            {
                new City {
                    Name = "New Yourk city",
                    Description = "Someting about NY",
                    PointsOfInterest = new List<PointOfInterest>
                    {
                        new PointOfInterest
                        {
                            Name = "Central Park",
                            Description = "Very nice and big park"
                        },
                        new PointOfInterest
                        {
                            Name = "Empire state building",
                            Description = "Scyscraper"
                        }
                    }
                },
                new City { Name = "Berlin", Description = "Stolica szwabow"},
                new City { Name = "Wroclaw", Description = "Moje miasto"},
                new City { Name = "Warsov", Description = "jak to napisac do angieslku"},
                new City { Name = "Poznan", Description = "Po prostu pyry"}
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}