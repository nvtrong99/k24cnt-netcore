using Microsoft.EntityFrameworkCore;
using NghiemVanTrong2410900077_exam.Models;

namespace NghiemVanTrong2410900077_exam
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// Lấy chuỗi kết nối từ appsettings.json
			var nvtConnection = builder.Configuration.GetConnectionString("NvtLesson10EfConnectionString");
			builder.Services.AddDbContext<NghiemVanTrongStudienContext>(
				x => x.UseSqlServer(nvtConnection));

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseRouting();

			app.UseAuthorization();

			app.MapStaticAssets();
			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}")
				.WithStaticAssets();

			app.Run();
		}
	}
}