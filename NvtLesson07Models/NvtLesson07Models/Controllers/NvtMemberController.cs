using Microsoft.AspNetCore.Mvc;
using NvtLesson07Models.Models.DataModels;

namespace NvtLesson07Models.Controllers
{
	public class NvtMemberController : Controller
	{
		// Mock Data
		protected static List<NvtMember> _members = new List<NvtMember>
		{
			 new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "trongdz",
				NvtPassword = "123456",
				NvtFullName = "Nghiêm Văn Trọng",
				NvtEmail = "trongdz@example.com"
			},
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "tranthibinh",
				NvtPassword = "123456",
				NvtFullName = "Trần Thị Bình",
				NvtEmail = "tranthibinh@example.com"
			},
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "levancuong",
				NvtPassword = "123456",
				NvtFullName = "Lê Văn Cường",
				NvtEmail = "levancuong@example.com"
			},
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "phamthiduyen",
				NvtPassword = "123456",
				NvtFullName = "Phạm Thị Duyên",
				NvtEmail = "phamthiduyen@example.com"
			},
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "hoangminhduc",
				NvtPassword = "123456",
				NvtFullName = "Hoàng Minh Đức",
				NvtEmail = "hoangminhduc@example.com"
			}
		};

		public IActionResult Index()
		{
			return View(_members);
		}

		public IActionResult GetMember()
		{
			var member = new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "trongdz",
				NvtPassword = "password123",
				NvtFullName = "Nghiêm Văn Trọng",
				NvtEmail = "trongdz@gmail.com"
			};

			//ViewBag.Member = member;
			return View(member);
		}

		// Đưa dữ liệu dạng List ra View
		public IActionResult GetMembers()
		{
			// Lấy từ mock data
			ViewBag.Members = _members;
			return View();
		}

		// GET: Create member
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		// POST: Create member
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(NvtMember member)
		{
			if (ModelState.IsValid)
			{
				member.NvtMemberId = Guid.NewGuid().ToString();
				_members.Add(member);
				return RedirectToAction(nameof(Index));
			}
			return View(member);
		}
	}
}