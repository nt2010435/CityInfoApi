using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);

            //return new JsonResult(new List<object>()
            //{
            //    new { id=1, Name="New York City"},
            //    new { id=2, Name="Antwerp"}
            //});
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
            );
        }
    }
}
