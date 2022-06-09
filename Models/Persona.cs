namespace PruebaTecnica.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; } 
        public int NumeroIdentificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        

// Columna calculada número de identificación con tipo de identificación concatenados
// Columna calculada nombres y apellidos concatenados
// Un store procedure para consultar las personas creadas       
    }
}