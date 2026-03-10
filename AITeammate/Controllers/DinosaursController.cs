using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AITeammate.Data;
using AITeammate.Models;

namespace AITeammate.Controllers;

public class DinosaursController : Controller
{
    private readonly DinosaurContext _context;

    public DinosaursController(DinosaurContext context)
    {
        _context = context;
    }

    // GET: Dinosaurs
    public async Task<IActionResult> Index()
    {
        var dinosaurs = await _context.Dinosaurs.OrderBy(d => d.Rank).ToListAsync();
        return View(dinosaurs);
    }

    // GET: Dinosaurs/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var dinosaur = await _context.Dinosaurs
            .FirstOrDefaultAsync(m => m.Id == id);
        if (dinosaur == null)
        {
            return NotFound();
        }

        return View(dinosaur);
    }

    // GET: Dinosaurs/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Dinosaurs/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Rank,Diet,Description,HasDimorphism,DimorphismDescription")] Dinosaur dinosaur)
    {
        if (ModelState.IsValid)
        {
            _context.Add(dinosaur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(dinosaur);
    }

    // GET: Dinosaurs/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var dinosaur = await _context.Dinosaurs.FindAsync(id);
        if (dinosaur == null)
        {
            return NotFound();
        }
        return View(dinosaur);
    }

    // POST: Dinosaurs/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Rank,Diet,Description,HasDimorphism,DimorphismDescription")] Dinosaur dinosaur)
    {
        if (id != dinosaur.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(dinosaur);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DinosaurExists(dinosaur.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(dinosaur);
    }

    // GET: Dinosaurs/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var dinosaur = await _context.Dinosaurs
            .FirstOrDefaultAsync(m => m.Id == id);
        if (dinosaur == null)
        {
            return NotFound();
        }

        return View(dinosaur);
    }

    // POST: Dinosaurs/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var dinosaur = await _context.Dinosaurs.FindAsync(id);
        if (dinosaur != null)
        {
            _context.Dinosaurs.Remove(dinosaur);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool DinosaurExists(int id)
    {
        return _context.Dinosaurs.Any(e => e.Id == id);
    }
}
