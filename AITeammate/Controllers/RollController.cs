using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AITeammate.Data;
using AITeammate.Models;

namespace AITeammate.Controllers;

public class RollController : Controller
{
    private readonly DinosaurContext _context;

    public RollController(DinosaurContext context)
    {
        _context = context;
    }

    // GET: Roll
    public IActionResult Index()
    {
        return View();
    }

    // POST: Roll/Random
    [HttpPost]
    public async Task<IActionResult> Random(string? rankFilter, string? dietFilter)
    {
        var query = _context.Dinosaurs.AsQueryable();

        // Apply filters
        if (!string.IsNullOrEmpty(rankFilter) && rankFilter != "all")
        {
            if (Enum.TryParse<DinosaurRank>(rankFilter, true, out var rank))
            {
                query = query.Where(d => d.Rank == rank);
            }
        }

        if (!string.IsNullOrEmpty(dietFilter) && dietFilter != "all")
        {
            if (Enum.TryParse<DietType>(dietFilter, true, out var diet))
            {
                query = query.Where(d => d.Diet == diet);
            }
        }

        var dinosaurs = await query.ToListAsync();
        
        if (!dinosaurs.Any())
        {
            TempData["Error"] = "No dinosaurs match your filters!";
            return RedirectToAction(nameof(Index));
        }

        var skins = await _context.Skins.ToListAsync();
        
        var random = new Random();
        var selectedDinosaur = dinosaurs[random.Next(dinosaurs.Count)];
        var selectedSkin = skins[random.Next(skins.Count)];
        var selectedGender = (Gender)random.Next(2);

        var roll = new DinosaurRoll
        {
            Dinosaur = selectedDinosaur,
            Gender = selectedGender,
            ShowDimorphism = selectedDinosaur.HasDimorphism && random.Next(100) < 70, // 70% chance to show dimorphism
            Skin = selectedSkin
        };

        return View("Result", roll);
    }
}
