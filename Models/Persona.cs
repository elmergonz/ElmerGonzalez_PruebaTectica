using System;
using System.Collections.Generic;

#nullable disable

namespace ElmerGonzalez_PruebaTectica.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
