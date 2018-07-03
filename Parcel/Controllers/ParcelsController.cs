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
            int length = 2;
            int height = 2;
            int width = 2;
            var weight = int.Parse(Request.Query["weight"]);
            ShippingItem newShippingItem = new ShippingItem(length, width, height, weight);
            int calculatedCost = newShippingItem.CalculateCost();
            return View(calculatedCost);
           
        }
    }
}
