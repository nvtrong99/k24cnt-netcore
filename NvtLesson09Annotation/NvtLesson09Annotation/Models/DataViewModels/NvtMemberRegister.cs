using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NvtLesson09Annotation.Models.DataViewModels
{
	public class NvtMemberRegister
	{
		
			public int NvtMemberId { get; set; }
			[DisplayName("Tên Đăng Nhập")]
			[Required(ErrorMessage = "Tên đăng nhập không để trống")]
			[StringLength(20, MinimumLength = 3, ErrorMessage = " Tên đăng đăng có phải từ 8 -20 kí tự bao gồm cả chữ và số ")]

			public string NvtUserName { get; set; }
			[DisplayName("Mật khẩu")]
			[Required(ErrorMessage = "Mật khẩu không được để chống")]
			[DataType(DataType.Password)]

			public string NvtPassword { get; set; }
			public string NvtEmail { get; set; }
			public string NvtNumberphone { get; set; }
			public string NvtFullName { get; set; }
			public DateTime NvtBirthday { get; set; }


	}
}
