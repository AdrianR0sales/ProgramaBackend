using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRoles.Data;
using UserRoles.Models;

namespace UserRoles.Controllers
{
    public class PriorityTicketController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public PriorityTicketController(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _appDbContext.PriorityTicket.AsNoTracking().ToListAsync();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PriorityTicket priorityTicket)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.PriorityTicket.Add(priorityTicket);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(priorityTicket);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var priorityTicket = await _appDbContext.PriorityTicket.FindAsync(id);
            if (priorityTicket == null)
            {
                return NotFound();
            }
            return View(priorityTicket);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PriorityTicket priorityTicket)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.PriorityTicket.Update(priorityTicket);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(priorityTicket);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var priorityTicket = await _appDbContext.PriorityTicket.FindAsync(id);
            if (priorityTicket == null)
            {
                return NotFound();
            }
            _appDbContext.PriorityTicket.Remove(priorityTicket);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}