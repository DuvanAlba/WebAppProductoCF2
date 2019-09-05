using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProductoCF.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El nombtre no debe tener mas de 50 caracteres, ni menos de 3 caracteres")]

        public string Nombre { get; set; }
        [StringLength(255,
            ErrorMessage = "Ladescrpcion no debe tener mas 26556 caracteres")]
        [Display(Name = "Descripcion")]

        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
