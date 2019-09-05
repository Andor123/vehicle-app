using System.Threading.Tasks;
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
    }
}