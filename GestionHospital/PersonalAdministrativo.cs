using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class PersonalAdministrativo: Persona
    {
        private string cargo;
        public string Cargo { get => cargo; set => cargo = value; }

        public PersonalAdministrativo(string pnombre, string cargo) : base(pnombre)
        {
            this.cargo = cargo;
        }
        public override string ToString()
        {
            return base.ToString() + ", Cargo: " + Cargo;
        }
    }
}
