using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyect1_Publicaciones.Models
{
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string usuario_id { get; set; }
        public string texto { get; set; }
    }
}
