using Microsoft.EntityFrameworkCore;
using NvtLesson10EFDb.Models;

namespace NvtLesson10EFDb
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// Lấy chuỗi kết nối từ appseting.lson
			var nvtConnectionString = builder.Configuration.GetConnectionString("NvtLesson10EfConnectionString");
			builder.Services.AddDbContext<NvtK24cntt1lesson10EfdbContext>(  x=> x.UseSqlServer(nvtConnectionString));

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
