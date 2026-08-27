using Microsoft.AspNetCore.Mvc;
using nvtDemoLesson02.Models;

namespace nvtDemoLesson02.Controllers
{
	public class NvtProductController : Controller
	{
		public IActionResult Index()
		{
			// đưa dữ liệu ra view 
			ViewBag.name = "Văn Trọng";
			ViewData["address"] = "Fit NTU ";
			TempData["UNI"] = "Trường Đại học Nguyễn Trãi";

			return View();
		}

		// chi tiết sản phẩm
		public IActionResult GetProduct()
		{
			//Mock data
			NvtProduct nvtproduct = new NvtProduct()
			{
				ProductId = "PP001",
				ProductName = "Laptop Dell Vostro",
				YearRelease = 2024,
				Price = 12000000,

			};

			ViewData["productVD"] = nvtproduct;
			ViewBag.productVB = nvtproduct;
			return View();
		}

	}
}
