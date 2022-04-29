using pruebaEB.Controlador;
using pruebaEB.Modelo;
using System.Data.Entity.Validation;

namespace pruebaEB
{
    public partial class Form1 : Form
    {
        public PersonaController personaController;

        public Form1()
        {
            InitializeComponent();

            var db = new DB();
            this.personaController = new PersonaController(db);
            listTablePerson();

        }

        public void listTablePerson()
        {
            var tablaPersonas = this.personaController.listPersonas();
            //haces referencia a la tabla del formulario
            table_personas.DataSource = tablaPersonas;
            //le añades los datos
        }


        public void agregarPersona()
        {

            try
            {
                //extraer valores del input

                var personaTemp = new PersonaModel
                {
                    nombres = "Pepito",
                    apellidos = "Castilla",
                };


                this.personaController.crearPersona(personaTemp);
            }
            catch(DbEntityValidationException ex)
            {
                var errors = ex.EntityValidationErrors.First();
                Console.WriteLine(errors.ToString());
            }

            
        }

    }
}