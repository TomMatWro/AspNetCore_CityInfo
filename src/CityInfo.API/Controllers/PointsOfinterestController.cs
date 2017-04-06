using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class PointsOfinterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterested")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterested/{id}")]
        public IActionResult GetPointOfinterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            var pointOfInterested = city.PointsOfInterest.FirstOrDefault(p => p.Id == id);
            if (pointOfInterested == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterested);
        }
    }
}