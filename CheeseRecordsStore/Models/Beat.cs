using System.ComponentModel.DataAnnotations;

namespace CheeseRecordsStore.Models
{
    public class Beat
    {
        [Key] // Esto le dice a PostgreSQL que este es el ID principal
        public int Id { get; set; }

        [Required(ErrorMessage = "¡Hey! Olvidaste ponerle nombre al beat.")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "El archivo de la portada es obligatorio.")]
        public string ImagenUrl { get; set; } = "";
    }
}