using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    public class Hospital
    {
        static List<Medico> medicos = new List<Medico>();
        static List<Paciente> pacientes = new List<Paciente>();
        static List<PersonalAdministrativo> personalAdministrativo = new List<PersonalAdministrativo>();


        public void DarDeAltaMedico()
        {
            Console.Write("Ingrese el nombre del médico: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la especialidad del médico: ");
            string especialidad = Console.ReadLine();
            Console.Write("Ingrese ID (números): ");
            int idMed = Convert.ToInt32(Console.ReadLine());
            medicos.Add(new Medico(especialidad, idMed, nombre));
            Console.WriteLine("---Médico dado de alta exitosamente.---");
        }

        public void DarDeAltaPaciente()
        {
            Console.Write("Ingrese el nombre del paciente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del paciente: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Lista de médicos disponibles. \n");
            foreach (Medico medico in medicos) 
            {
                    Console.WriteLine(medico);
            }
            Console.WriteLine("");
            Console.WriteLine("Asigne un médico al paciente. Ingrese el ID: ");
            int idMedico = Convert.ToInt32(Console.ReadLine()); 
            Medico medicoAsignado = medicos.Find(m => m.IdMed == idMedico);
            if (medicoAsignado != null)
            {
                pacientes.Add(new Paciente(nombre, edad, medicoAsignado));
                Console.WriteLine("---Paciente dado de alta exitosamente.---");
            }
            else
            {
                Console.WriteLine("No se encontró ningún médico con el ID especificado.");
            }
        }
        public void DarDeAltaPersonalAdministrativo()
        {
            Console.Write("Ingrese el nombre del personal administrativo: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el cargo del personal administrativo: ");
            string cargo = Console.ReadLine();
            personalAdministrativo.Add(new PersonalAdministrativo(nombre, cargo));
            Console.WriteLine("---Personal administrativo dado de alta exitosamente.---");
        }

        public void ListarMedicos()
        {
            Console.WriteLine("Lista de Médicos:");
            foreach (Medico medico in medicos)
            {
                Console.WriteLine(medico);
            }
        }

        public void ListarPacientesDeMedico()
        {
            Console.Write("Ingrese el ID del médico para listar sus pacientes: ");
            int idMedico = Convert.ToInt32(Console.ReadLine());
            Medico medicoSeleccionado = medicos.Find(m => m.IdMed == idMedico);
            if (medicoSeleccionado != null)
            {
                Console.WriteLine("Pacientes del Médico:");
                foreach (Paciente paciente in pacientes)
                {
                    if (paciente.MedicoAsignado.IdMed == idMedico)
                    {
                        Console.WriteLine(paciente);
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontró ningún médico con el ID especificado.");
            }
        }
        public void EliminarPaciente()
        {
            Console.Write("Ingrese el nombre del paciente que desea eliminar: ");
            string nombrePaciente = Console.ReadLine();
            Paciente pacienteAEliminar = pacientes.Find(p => p.Nombre == nombrePaciente);
            if (pacienteAEliminar != null)
            {
                pacientes.Remove(pacienteAEliminar);
                Console.WriteLine("---Paciente eliminado exitosamente.---");
            }
            else
            {
                Console.WriteLine("No se encontró ningún paciente con el nombre especificado.");
            }
        }

        public void VerListaPersonasHospital()
        {
            Console.WriteLine("Lista de Personas del Hospital: \n");
            Console.WriteLine("Médicos:");
            foreach (Medico medico in medicos)
            {
                Console.WriteLine(medico);
            }
            Console.WriteLine("");
            Console.WriteLine("Pacientes:");
            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine(paciente);
            }
            Console.WriteLine("");
            Console.WriteLine("Personal Administrativo:");
            foreach (PersonalAdministrativo personal in personalAdministrativo)
            {
                Console.WriteLine(personal);
            }
        }
    }
}
