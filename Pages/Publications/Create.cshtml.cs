using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proyect1_Publicaciones.Models;
using proyect1_Publicaciones.Data;

namespace proyect1_Publicaciones.Pages.Publications
{
    public class CreateModel : PageModel
    {
        // inicializamos contexto de base de datos
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Publicacion Publicacion { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _db.Add(Publicacion);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
