using BusinessLayer.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using RepositoryDesign.Models;
using System.Diagnostics;

namespace RepositoryDesign.Controllers
{
	public class HomeController : Controller
	{
		private readonly IKategorilerService _kategoriService;
		private readonly IUrunlerService _urunlerService;

		public HomeController(ILogger<HomeController> logger, IKategorilerService kategoriService, IUrunlerService urunlerService)
		{
			this._kategoriService = kategoriService;
			this._urunlerService = urunlerService;
		}
		public IActionResult Index()
		{
			KategoriViewModels kategoriViewModels = new()
			{
				Kategori = _kategoriService.GetAll()
			};
			return View(kategoriViewModels);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		
	}
}