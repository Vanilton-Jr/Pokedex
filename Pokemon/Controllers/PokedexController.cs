using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

namespace Pokemon.Controllers
{
    public class PokedexController : Controller
    {
        private readonly Pokemon.Data.AppC _appC;

        public PokedexController(Pokemon.Data.AppC appC)
        {
            _appC = appC;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var poke = await _appC.Pokedex.ToListAsync();
            return View(poke);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pokedex pokedex, IList<IFormFile> Img)
        {
            IFormFile uploadedImage = Img.FirstOrDefault();
            MemoryStream ms = new MemoryStream();
            if (Img.Count > 0)
            {
                uploadedImage.OpenReadStream().CopyTo(ms);
                pokedex.Default = ms.ToArray();
            }
            _appC.Pokedex.Add(pokedex);
            await _appC.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poke = await _appC.Pokedex.FirstOrDefaultAsync(f => f.Id == id);

            if (poke == null)
            {
                return BadRequest();
            }
            return View(poke);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poke = await _appC.Pokedex.FirstOrDefaultAsync(f => f.Id == id);

            if (poke == null)
            {
                return BadRequest();
            }
            return View(poke);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid? id, Pokedex pokedex, IList<IFormFile> Img)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dadosAntigos = _appC.Pokedex.AsNoTracking().FirstOrDefault(p => p.Id == id);

            IFormFile uploadedImage = Img.FirstOrDefault();
            MemoryStream ms = new MemoryStream();
            if (Img.Count > 0)
            {
                uploadedImage.OpenReadStream().CopyTo(ms);
                pokedex.Default = ms.ToArray();
            }
            else
            {
                pokedex.Default = dadosAntigos.Default;
            }
            if (ModelState.IsValid)
            {
                _appC.Update(pokedex);
                await _appC.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokedex);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var poke = await _appC.Pokedex.FindAsync(id);
            if (poke == null)
            {
                return BadRequest();
            }

            _appC.Pokedex.Remove(poke);
            await _appC.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
