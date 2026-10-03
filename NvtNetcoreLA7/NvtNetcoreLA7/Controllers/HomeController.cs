using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NvtNetcoreLA7.Models;

namespace NvtNetcoreLA7.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
