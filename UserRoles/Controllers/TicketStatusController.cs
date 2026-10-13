using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRoles.Data;
using UserRoles.Models;

namespace UserRoles.Controllers
{
    public class TicketStatusController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TicketStatusController(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<TicketStatus> TicketStatusList = _appDbContext.TicketStatus.ToList();
            return View(TicketStatusList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TicketStatus ticketStatus)
        {
            
            if (string.IsNullOrEmpty(ticketStatus.Id))
            {
                ticketStatus.Id = Guid.NewGuid().ToString();

                ModelState.Remove("Id");
            }

            if (ModelState.IsValid)
            {
                _appDbContext.TicketStatus.Add(ticketStatus);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketStatus);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var ticketStatus = _appDbContext.TicketStatus.Find(id);
            if (ticketStatus == null)
            {
                return NotFound();
            }
            return View(ticketStatus);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TicketStatus ticketStatus)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.TicketStatus.Update(ticketStatus);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketStatus);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id) 
        {
            var ticketStatus = _appDbContext.TicketStatus.Find(id);
            if (ticketStatus == null)
            {
                return NotFound();
            }

            _appDbContext.TicketStatus.Remove(ticketStatus);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}