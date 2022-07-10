using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Firma.Data.Data;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>? _logger;
        private readonly FirmaContext _context;

        public HomeController(FirmaContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            // ViewBag lub ViewData to taki listonosz, który przenosi dane pomiędzy kontrolerem a widokiem
            ViewBag.ModelStrony =
                (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
            ).ToList();
             
            ViewBag.ModelAktualnosci = (
                from aktualnosc in _context.Aktualnosc
                orderby aktualnosc.Pozycja
                select aktualnosc
            ).ToList();

            if (id == null)
                //przekazuję pierwszą stronę, gdy id jest null
                //dlatego "Strona główna" i pierwszy generowany link wskazują na tę samą stronę
                id = _context.Strona.First().IdStrony;
            var item = _context.Strona.Find(id);

            // item może być typu do którego przekażę wiele różnych danych
            return View(item); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}