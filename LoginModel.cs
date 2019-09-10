using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;

namespace RazorPagesContacts.Pages 
{
    public class LoginModel : PageModel 
    {
        private readonly AppDbContext _db;

        public LoginModel(AppDbContext db) 
        {
            _db = db;
        }

        [BindProperty]
        public Users Users { get; set; }

        public async Task<IActionResult> OnPostAsync() 
        {
            if (!ModelState.IsValid) 
            {
                return Page();
            }

            _db.Users.Add(Users);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Vehicles");
        }
    }
}