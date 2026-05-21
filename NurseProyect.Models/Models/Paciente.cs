using System.ComponentModel.DataAnnotations;

namespace EnfermeriaProject.Models.Models
{
    public class Paciente
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

        [Required]
        [MaxLength(200)]
        public string DireccionDomicilio { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Telefono { get; set; }

        public string? InformacionMedica { get; set; }
    }
}