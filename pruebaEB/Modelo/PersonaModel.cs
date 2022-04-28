using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaEB.Modelo
{
    public class PersonaModel
    {
        public int? id;

        [Required]
        [StringLength(50)]
        public string nombres;

        [Required]
        [StringLength(50)]
        public string apellidos;

        public bool activo = true;
    }
}
