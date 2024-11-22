using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using techcareer.Data;

namespace techcareer.Controllers{

    public class BootcampController : Controller{
        private readonly DataContext _context;
        public BootcampController(DataContext context){
            _context = context;
        }
        public async Task<IActionResult> Index(){
            return View(await _context.Bootcamps.ToListAsync());
        }
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Bootcamp model){
            _context.Bootcamps.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id){
            if(id == null){
                return NotFound();
            }

             var btc = await _context.Bootcamps.FindAsync(id);
           //  var ogr = await _context.Bootcampler.FirstOrDefaultAsync(o=>o.BootcampId == id);

            if(btc == null){
                return NotFound();
            }
            return View(btc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id, Bootcamp model){

            if(id != model.BootcampId){
                return NotFound();
            }
            if(ModelState.IsValid){
                try{
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException){
                    if(!_context.Bootcamps.Any(o=>o.BootcampId == model.BootcampId)){
                        return NotFound();
                    }else{
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult>Delete(int? id){
            if(id == null){
                return NotFound();
            }
            var Bootcamp = await _context.Bootcamps.FindAsync(id);
            if(Bootcamp == null){
                return NotFound();
            }
            return View(Bootcamp);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromForm]int id){
            var Bootcamp = await _context.Bootcamps.FindAsync(id);
            if(Bootcamp == null){
                return NotFound();
            }
            _context.Bootcamps.Remove(Bootcamp);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}