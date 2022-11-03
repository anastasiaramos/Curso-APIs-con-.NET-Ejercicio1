using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public enum Nivel { Basico, Intermedio, Avanzado }
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public string? DescripcionLarga { get; set; }
        public string? PublicoObjetivo { get; set; }
        public string? Objetivos { get; set; }
        public string? Requisitos { get; set; }
        [Required]
        public Nivel Nivel { get; set; } = Nivel.Basico;
    }
}
