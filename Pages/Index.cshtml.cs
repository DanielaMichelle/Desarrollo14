using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyect1_Publicaciones.Data;
using proyect1_Publicaciones.Models;
using Microsoft.EntityFrameworkCore;

namespace proyect1_Publicaciones.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        // traemos registros
        public IEnumerable<Publicacion> Publicaciones { get; set; }

        public async Task OnGet()
        {
            Publicaciones = await _db.Publicacion.ToListAsync();
        }
    }
}
