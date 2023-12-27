using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IServiceCollection services = new ServiceCollection();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IKategoriDal,KategoriDal>();
builder.Services.AddScoped<IUrunlerDal,UrunlerDal>();
builder.Services.AddScoped<IKategorilerService,KategoriService>();
builder.Services.AddScoped<IUrunlerService,UrunlerService>();

builder.Services.AddDbContext<EfNorthwindContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
