using AiDevsDashboard.Components;

namespace AiDevsDashboard
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents();

			// Dodajemy rejestrację serwisu OpenAI
			builder.Services.AddHttpClient();
			builder.Services.AddScoped<IFileService, FileService>();
			builder.Services.AddScoped<IOpenAIService, OpenAIService>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();
			app.UseAntiforgery();

			app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}
