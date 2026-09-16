using System.ComponentModel;

namespace NvtLesson08Models.Models
{
	public class NvtMember
	{
		public string NvtMemberId { get; set; }

		public string NvtUserName { get; set; }

		public string NvtPassword { get; set; }

		[DisplayName("Họ và tên")]
		public string NvtFullName { get; set; }

		public string NvtEmail { get; set; }
	}
}