using System;
using System.Collections.Generic;

namespace GestionHospital
{
    internal class Medico : Persona
    {
        private int idMed;
        private string especialidad;
        public List<Medico> medicos = new List<Medico>();

        public int IdMed { get => idMed; set => idMed = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

        //contructor con 2 parametros + 1 parametro de herencia Persona
        public Medico(string especialidad, int idMed, string pnombre) : base(pnombre)
        {
            this.idMed = idMed;
            this.especialidad = especialidad;
        }
        public override string ToString()
        {
            return base.ToString() + ", ID: " + IdMed + ", Especialidad: " + Especialidad;
        }
    }
}