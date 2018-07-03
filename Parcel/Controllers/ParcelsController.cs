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

        [HttpPost("/parcels/cost")]
        public IActionResult Cost(int length, int height, int width, int weight)
        {
            ShippingItem newShippingItem = new ShippingItem(length, width, height, weight);
            return View(newShippingItem);
        }
    }
}
