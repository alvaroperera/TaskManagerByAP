using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerAPI.Models
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descripcion { get; set; } = string.Empty;

        public bool Completada { get; set; } = false;

        [Required]
        public int ProyectoId { get; set; }

        [ForeignKey("ProyectoId")]
        public Proyecto Proyecto { get; set; } = null!;
    }
}