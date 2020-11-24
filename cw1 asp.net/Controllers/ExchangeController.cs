using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using cw1_asp.net.Models;
using Microsoft.AspNetCore.Mvc;
using cw1_asp.net.Database;

namespace cw1_asp.net.Controllers
{
    public class ExchangeController : Controller
    {
        private readonly ExchangesDbContext _dbContext;
        public ExchangeController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ExchangeModel item)
        {
            var entity = new ExchangeModel
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
            return View("Add",entity);
        }

        [HttpGet]
        public IActionResult ExchangeAdded(int itemId)
        {
            return View(itemId);
        }
    }
}