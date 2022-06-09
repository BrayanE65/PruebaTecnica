using Microsoft.AspNetCore.Identity;

namespace PruebaTecnica.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }  
        
    }
}