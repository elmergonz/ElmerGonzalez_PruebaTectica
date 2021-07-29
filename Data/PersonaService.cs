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

        public void PostPersona(Persona persona)
        {
            bcwi0rmh1y8kmv36xayuContext context = new();
            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public bool PutPersona(Persona persona)
        {
            bcwi0rmh1y8kmv36xayuContext context = new();
            Persona oldPersona = context.Personas.First(p => p.Id == persona.Id);
            
            if (oldPersona != null)
            {
                oldPersona.Nombre = persona.Nombre;
                oldPersona.FechaNacimiento = persona.FechaNacimiento;
                context.SaveChanges();
                
                return true;
            }

            return false;
        }

        public bool DeletePersona(int Id)
        {
            bcwi0rmh1y8kmv36xayuContext context = new();
            Persona persona = context.Personas.First(p => p.Id == Id);

            if (persona != null)
            {
                context.Personas.Remove(persona);
                context.SaveChanges();
                
                return true;
            }

            return false;
        }
    }
}
