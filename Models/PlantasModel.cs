using System.ComponentModel.DataAnnotations;

namespace Plantas.Models
{
    public class Plant
    {
        public int Id { get; set; } 

        [Required]
        public string Nombre { get; set; } = string.Empty;   

        [Required]
        public string Origen { get; set; } = "Perú";   
        [Required]
        public string Especie { get; set; } = string.Empty; 

        [Display(Name = "Altura_Máxima (m)")]
        public double? Altura_Maxima { get; set; }   

        [Display(Name = "Notas")]
        public string? Notas { get; set; }

        [Display(Name = "Imagen (URL)")]
        [Url]
        public string? Imagen { get; set; }     
    }
}