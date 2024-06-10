namespace GestionHospital
{
    internal class Persona
    {
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }
        public Persona(string pnombre)
        {
            nombre = pnombre;
        }
        public override string ToString()
        {
             
            return "Nombre: " + nombre;
        }
    }

}
