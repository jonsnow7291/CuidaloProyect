using System.ComponentModel.DataAnnotations;

namespace EnfermeriaProject.Models.Models
{
    public class Enfermero
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string DocumentoIdentidad { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Especialidad { get; set; }

        [MaxLength(20)]
        public string? Telefono { get; set; }

        public bool EstaDisponible { get; set; } = true;
    }
}