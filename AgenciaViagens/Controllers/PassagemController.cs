using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaViagens.Models;

namespace AgenciaViagens.Controllers
{
  public class PassagemController : Controller
  {
    private readonly DataBaseContext _context;

    public PassagemController(DataBaseContext context)
    {
      _context = context;
    }

    // GET: Passagem
    public async Task<IActionResult> Index()
    {
      var dataBaseContext = _context.Passagens.Include(p => p.usuario).Include(p => p.viagens);
      return View(await dataBaseContext.ToListAsync());
    }

    // GET: Passagem/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var passagem = await _context.Passagens
          .Include(p => p.usuario)
          .Include(p => p.viagens)
          .FirstOrDefaultAsync(m => m.id == id);
      if (passagem == null)
      {
        return NotFound();
      }

      return View(passagem);
    }

    // GET: Passagem/Create
    public IActionResult Create()
    {
      ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "nome");
      ViewData["viagemId"] = new SelectList(_context.Viagens, "id", "destinoViagem");
      return View();
    }

    // POST: Passagem/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("usuarioId,viagemId,id")] Passagem passagem)
    {
      if (ModelState.IsValid)
      {
        _context.Add(passagem);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }
      ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "nome", passagem.usuarioId);
      ViewData["viagemId"] = new SelectList(_context.Viagens, "id", "destinoViagem", passagem.viagemId);
      return View(passagem);
    }

    // GET: Passagem/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var passagem = await _context.Passagens.FindAsync(id);
      if (passagem == null)
      {
        return NotFound();
      }
      ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "nome", passagem.usuarioId);
      ViewData["viagemId"] = new SelectList(_context.Viagens, "id", "destinoViagem", passagem.viagemId);
      return View(passagem);
    }

    // POST: Passagem/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("usuarioId,viagemId,id")] Passagem passagem)
    {
      if (id != passagem.id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        try
        {
          _context.Update(passagem);
          await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!PassagemExists(passagem.id))
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
      ViewData["usuarioId"] = new SelectList(_context.Usuarios, "id", "nome", passagem.usuarioId);
      ViewData["viagemId"] = new SelectList(_context.Viagens, "id", "destinoViagem", passagem.viagemId);
      return View(passagem);
    }

    // GET: Passagem/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }

      var passagem = await _context.Passagens
          .Include(p => p.usuario)
          .Include(p => p.viagens)
          .FirstOrDefaultAsync(m => m.id == id);
      if (passagem == null)
      {
        return NotFound();
      }

      return View(passagem);
    }

    // POST: Passagem/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var passagem = await _context.Passagens.FindAsync(id);
      _context.Passagens.Remove(passagem);
      await _context.SaveChangesAsync();
      return RedirectToAction(nameof(Index));
    }

    private bool PassagemExists(int id)
    {
      return _context.Passagens.Any(e => e.id == id);
    }
  }
}
