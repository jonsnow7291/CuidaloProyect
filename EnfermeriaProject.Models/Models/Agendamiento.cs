using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnfermeriaProject.Models
{
    public class Agendamiento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PacienteId { get; set; }
        [ForeignKey("PacienteId")]
        public Paciente? Paciente { get; set; }

        [Required]
        public int EnfermeroId { get; set; }
        [ForeignKey("EnfermeroId")]
        public Enfermero? Enfermero { get; set; }

        [Required]
        public int ServicioId { get; set; }
        [ForeignKey("ServicioId")]
        public Servicio? Servicio { get; set; }

        [Required]
        public DateTime FechaHoraReserva { get; set; }

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; } = "Pendiente"; // Pendiente, En curso, Completado, Cancelado

        [MaxLength(500)]
        public string? Observaciones { get; set; }
    }
}