namespace GestionHospital
{
    internal class Paciente : Persona
    {
        private int edad;
        private Medico medicoAsignado;

        public int Edad { get => edad; set => edad = value; }
        internal Medico MedicoAsignado { get => medicoAsignado; set => medicoAsignado = value; }

        public Paciente(string pnombre, int edad, Medico medicoAsignado) : base(pnombre)
        {
            this.edad = edad;
            this.medicoAsignado = medicoAsignado;
        }
        public override string ToString()
        {
            return base.ToString() + ", Edad: " + this.edad + ", Médico Asignado: " + this.medicoAsignado.Nombre;
        }
    }
}
