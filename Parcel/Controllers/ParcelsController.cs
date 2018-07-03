using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Parcel.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet("/parcels/form")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpGet("/parcels/cost")]
        public ActionResult Cost()
        {
            // info from the form
            var length = int.Parse(Request.Query["length"]);
            var height = int.Parse(Request.Query["height"]);
            var width = int.Parse(Request.Query["width"]);
            var weight = int.Parse(Request.Query["weight"]);
            ShippingItem newShippingItem = new ShippingItem(length, width, height, weight);
            return View(newShippingItem);
            
        }
    }
}
