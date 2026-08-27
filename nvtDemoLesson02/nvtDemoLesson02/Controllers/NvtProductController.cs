using Microsoft.AspNetCore.Mvc;

namespace nvtDemoLesson02.Controllers
{
	public class NvtProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
