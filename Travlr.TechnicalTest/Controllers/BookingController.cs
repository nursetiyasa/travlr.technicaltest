using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Travlr.TechnicalTest.Applications.Interfaces;
using Travlr.TechnicalTest.Core;

namespace Travlr.TechnicalTest.Controllers
{
    public class BookingController : Controller
    {
        private readonly IProductRepository _product;
        private readonly IPaxRepository _pax;

        public BookingController(IProductRepository product, IPaxRepository pax)
        {
            _product = product;
            _pax = pax;
        }

        public async Task<IActionResult> Booking(int productId)
        {
            var product = await _product.Get(productId);
            return View(product);
        }
        public async Task<IActionResult> FinalizePayment(int productId, string productName, string firstName, string lastName, string email, string selectDateFrom, string selectDateFromHour, string selectDateFromMinute, string selectDateTo, string selectDateToHour, string selectDateToMinute)
        {
            var pax = await _pax.Post(firstName, lastName, email);
            var checkInDate =
                StringExtensions.TravlrDateFormat(selectDateFrom, selectDateFromHour, selectDateFromMinute);
            var totalNights = StringExtensions.TotalNights(selectDateFrom, selectDateFromHour, selectDateFromMinute,
                selectDateTo, selectDateToHour, selectDateToMinute);
            //TODO: Proceed Booking

            TempData["product"] = productName;
            TempData["checkin"] = $"{selectDateFrom} {selectDateFromHour}:{selectDateFromMinute}";
            TempData["nights"] = totalNights.ToString();

            return View(pax);
        }
    }
}