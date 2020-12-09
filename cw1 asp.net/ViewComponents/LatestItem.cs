using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cw1_asp.net.Database;

namespace cw1_asp.net.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;

        public LatestItem(ExchangesDbContext dBContext)
        {
            _dbContext = dBContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items.OrderByDescending(x => x.Id).First();

            return View("Index", latestItem);
        }
    }
}

