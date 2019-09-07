using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesContacts.Pages 
{
    public class VehiclesModel : PageModel 
    {
        private readonly AppDbContext _db;

        public VehiclesModel(AppDbContext db) 
        {
            _db = db;
        }

        public IList<Vehicle> Vehicles { get; private set; }

        public async Task OnGetAsync() 
        {
            Vehicles = await _db.Vehicles.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id) 
        {
            var vehicle = await _db.Vehicles.FindAsync(id);

            if (vehicle != null) 
            {
                _db.Vehicles.Remove(vehicle);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        } 
    }
}