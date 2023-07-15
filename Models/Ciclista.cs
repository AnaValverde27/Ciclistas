using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ciclistas.Models
{
    public class Ciclista
    {
        [Display(Name = "ID Corredor")]
        [Required(ErrorMessage = "Id es requerido")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es requerido")]
        public string Nombre { get; set; }
        [Display(Name = "Tiempo (minutos, segundos)")]
        public TimeSpan Tiempo { get; set; }
        [Display(Name = "Metros por segundos")]
        public double Metros { get; set; }
    }
}