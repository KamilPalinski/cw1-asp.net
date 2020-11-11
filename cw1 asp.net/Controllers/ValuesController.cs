using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw1_asp.net.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw1_asp.net.Controllers
{
	[Route("api/Exchange")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		public IActionResult Post(ExchangeModel itemModel)
		{
			ExchangeAddedViewModel response = new ExchangeAddedViewModel
			{
				ID = itemModel.Id,
				NumberOfCharsInName = itemModel.Name.Length,
				NumberOfCharsInDescription = itemModel.Description.Length,
				IsHidden = !itemModel.IsVisible
			};

			return Ok(response);
		}
	}
}
