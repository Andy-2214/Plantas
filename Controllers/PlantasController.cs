using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plantas.Data;
using Plantas.Models;

namespace Plantas.Controllers
{
    public class PlantasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlantasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Plantas()
        {
    
            var plantas = await _context.Plantas.ToListAsync();
            return View(plantas);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var planta = await _context.Plantas
                .FirstOrDefaultAsync(p => p.Id == id);

            if (planta == null) return NotFound();

            return View(planta);
        }
    }
}