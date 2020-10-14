using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using cw1_asp.net.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw1_asp.net.Controllers
{
    public class ExchangeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ExchangeModel exchange)
        {
            var viewModel = new ExchangeAddedViewModel
            {
                NumberOfCharsInName = exchange.Name.Length,
                NumberOfCharsInDescription = exchange.Description.Length,
                IsHidden = !exchange.IsVisible
            };
            return View("ExchangeAdded", viewModel);
        }
    }
}
