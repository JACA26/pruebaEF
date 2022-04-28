using pruebaEB.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaEB.Controlador
{
    public class PersonaController
    {
        public DB dbContext;

        public PersonaController(DB dbContext)
        {
            this.dbContext = dbContext;
        }


        //listar personas
        public List<PersonaModel> listPersonas()
        {

            var personas = this.dbContext.Personas.Where(persona => persona.activo == true).ToList();

            return personas;
        }


        //crear persona
        public void crearPersona(PersonaModel persona)
        {
            this.dbContext.Personas.Add(persona);
            this.dbContext.SaveChanges();
        
        }








    }
}
