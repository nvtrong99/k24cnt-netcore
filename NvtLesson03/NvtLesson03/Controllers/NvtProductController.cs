using Microsoft.AspNetCore.Mvc;
using NvtLesson03.Models;

namespace NvtLesson03.Controllers
{
	public class NvtProductController : Controller
	{
		// tạo mock data
		private readonly List<NvtProduct> _products = new()
		{
			new NvtProduct
			{
				NvtProductId = "P001",
				NvtProductName = "Laptop Dell XPS 13",
				NvtYearRelease = "2024",
				NvtPrice = 32990000m
			},
			new NvtProduct
			{
				NvtProductId = "P002",
				NvtProductName = "iPhone 16 Pro Max",
				NvtYearRelease = "2025",
				NvtPrice = 38990000m
			},
			new NvtProduct
			{
				NvtProductId = "P003",
				NvtProductName = "Samsung Galaxy S25 Ultra",
				NvtYearRelease = "2025",
				NvtPrice = 34990000m
			},
			new NvtProduct
			{
				NvtProductId = "P004",
				NvtProductName = "MacBook Air M4",
				NvtYearRelease = "2025",
				NvtPrice = 31990000m
			},
			new NvtProduct
			{
				NvtProductId = "P005",
				NvtProductName = "iPad Pro 13 inch M4",
				NvtYearRelease = "2024",
				NvtPrice = 29990000m
			},
			new NvtProduct
			{
				NvtProductId = "P006",
				NvtProductName = "Sony WH-1000XM6",
				NvtYearRelease = "2025",
				NvtPrice = 9990000m
			},
			new NvtProduct
			{
				NvtProductId = "P007",
				NvtProductName = "Apple Watch Series 11",
				NvtYearRelease = "2025",
				NvtPrice = 12990000m
			},
			new NvtProduct
			{
				NvtProductId = "P008",
				NvtProductName = "ASUS ROG Strix G18",
				NvtYearRelease = "2024",
				NvtPrice = 45990000m
			},
			new NvtProduct
			{
				NvtProductId = "P009",
				NvtProductName = "Logitech MX Master 3S",
				NvtYearRelease = "2023",
				NvtPrice = 2490000m
			},
			new NvtProduct
			{
				NvtProductId = "P010",
				NvtProductName = "Samsung Odyssey G9 OLED",
				NvtYearRelease = "2024",
				NvtPrice = 38990000m
			}
		};

		public IActionResult Index()
		{
			return Json(_products);
		}
		//get : danh sách sản phẩm
		public IActionResult NvtGetAllProduct()
		{
			ViewData["products"] = _products;
			return View();
		}

		public IActionResult NvtGetListProduct()
		{
			return View(_products);
		}
	}
}
