using Microsoft.AspNetCore.Mvc;
using NvtLesson08Models.Models;

namespace NvtLesson08Models.Controllers
{
	public class NvtMemberController : Controller
	{
		// Mock data - NvtMember
		private static List<NvtMember> _members = new List<NvtMember>()
		{
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "TrongNv",
				NvtPassword = "Password123!",
				NvtFullName = "Nghiêm Văn Trọng",
				NvtEmail = "Trongdzooo.com"
			},
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "tranthib",
				NvtPassword = "SecurePass456#",
				NvtFullName = "Trần Thị B",
				NvtEmail = "tranthib@outlook.com"
			},
			new NvtMember
			{
				NvtMemberId = Guid.NewGuid().ToString(),
				NvtUserName = "levanc",
				NvtPassword = "MyPassword789$",
				NvtFullName = "Lê Văn C",
				NvtEmail = "levanc@company.com"
			}
		};

		// GET: Danh sách thành viên
		public IActionResult Index()
		{
			return View(_members);
		}

		[HttpGet]
		public IActionResult NvtCreate()
		{
			var member = new NvtMember();
			return View(member);
		}

		[HttpPost]
		public IActionResult NvtCreate(NvtMember nvtMember)
		{
			nvtMember.NvtMemberId = Guid.NewGuid().ToString();
			_members.Add(nvtMember);

			return RedirectToAction("Index");
			//return View(nvtMember);
		}

		[HttpGet]
		public IActionResult NvtEdit(string id)
		{
			var member = _members.Where(x => x.NvtMemberId.Equals(id)).FirstOrDefault();
			return View(member);
		}

		[HttpPost]
		public IActionResult NvtEdit(string id, NvtMember nvtMember)
		{
			for (int i = 0; i < _members.Count; i++)
			{
				if (_members[i].NvtMemberId == id)
				{
					_members[i].NvtUserName = nvtMember.NvtUserName;
					_members[i].NvtPassword = nvtMember.NvtPassword;
					_members[i].NvtFullName = nvtMember.NvtFullName;
					_members[i].NvtEmail = nvtMember.NvtEmail;

					return RedirectToAction("Index");
				}
			}

			return View();
		}

		[HttpGet]
		public IActionResult NvtDetails(string id)
		{
			var member = _members.Where(x => x.NvtMemberId.Equals(id)).FirstOrDefault();
			return View(member);
		}

		[HttpGet]
		public IActionResult NvtDelete(string id)
		{
			var member = _members.Where(x => x.NvtMemberId.Equals(id)).FirstOrDefault();
			return View(member);
		}

		[HttpPost]
		public IActionResult NvtDeleted(string id)
		{
			foreach (var item in _members)
			{
				if (item.NvtMemberId.Equals(id))
				{
					_members.Remove(item);
					return RedirectToAction("Index");
				}
			}

			return View("NvtDelete");
		}
	}
}