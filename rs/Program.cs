using Microsoft.EntityFrameworkCore;
using rs.Models;

namespace rs
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();


			builder.Services.AddSession();
			var cs = "Server=NIMRA\\SQLSERVER;Initial Catalog=RestaurantManagementWebsite;User ID =sa;Password=aptech;TrustServerCertificate=True";
			builder.Services.AddDbContext<rsDbContext>(op => op.UseSqlServer(cs));
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseSession();
			app.UseHttpsRedirection();
			app.UseStaticFiles();
            app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

            app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Admin}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
