using Firma.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Firma.PortalWWW.Controllers;

public class SklepController : Controller
{
    private readonly FirmaContext _context;

    public SklepController(FirmaContext context)
    {
        _context = context;
    }

    //wyświetla wszystkie produkty
    //widok wyświetla produkty z kategorii i identyfikuje ją po id
    public async Task<IActionResult> Index(int? id)
    {
        //pobiera wszystkie rodzaje by wyświetlić je w menu
        ViewBag.ModelRodzaje = await _context.Rodzaj.ToListAsync();
        //przy pierwszych odwiedzinach strony żadna kategoria nie jest wybrana
        //domyślnie ustawiamy ją na pierwszą kategorię lub promocje
        if (id == null)
        {
            var pierwszaKategoria = await _context.Rodzaj.FirstAsync();
            id = pierwszaKategoria.IdRodzaju;
        }

        //do widoku przekazujemy listę towarów z danej kategorii
        //można to co przekazujemy prze ViewBag i to co poniżej włożyć do jednego obiektu
        //i przekazać to tylko za pomocą View
        return View(await _context.Towar.Where(t => t.IdRodzaju == id)
            .ToListAsync());
    }

    //wyświetla szczegóły klikniętego towaru i id nie może być puste
    public async Task<IActionResult> Szczegoly(int id)
    {
        ViewBag.ModelRodzaje = await _context.Rodzaj.ToListAsync();

        //do widoku przekazuję ten towar który kliknięto
        return View(await _context.Towar.Where(t => t.IdTowaru == id)
            .FirstOrDefaultAsync());
    }
}