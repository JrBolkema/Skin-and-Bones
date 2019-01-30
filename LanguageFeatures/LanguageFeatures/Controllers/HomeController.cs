using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			List<string> results = new List<string>();
			foreach (Product product in Product.GetProducts())
			{
				string name = product?.Name;
				decimal? price = product?.Price;
				string relatedName = product?.Related?.Name;
				results.Add($"Name: {name}, Price: {price},Related: {relatedName}");
			}
			return View(results);
			//return View(new string[] { "C#", "Language", "Features" });

		}
	}
}
