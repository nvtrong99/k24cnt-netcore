namespace nvtrong_lesson1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();

			app.MapGet("/", () => "Hello Van Trong !");

			app.Run();
		}
	}
}
