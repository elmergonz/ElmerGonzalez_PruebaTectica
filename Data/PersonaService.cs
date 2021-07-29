using System;
using System.Linq;
using System.Threading.Tasks;
using ElmerGonzalez_PruebaTectica.Models;

namespace ElmerGonzalez_PruebaTectica.Data
{
    public class PersonaService
    {
        public Task<Persona[]> GetPersonasAsync()
        {
            return Task.FromResult(new bcwi0rmh1y8kmv36xayuContext().Personas.ToArray());
        }
    }
}
