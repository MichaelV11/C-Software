using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    internal class Program
    {
        static Hospital hospital = new Hospital();
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            { 
                Console.WriteLine("");
                Console.WriteLine("Bienvenido al Hospital");
                Console.WriteLine("1. Dar de alta un médico");
                Console.WriteLine("2. Dar de alta un paciente");
                Console.WriteLine("3. Dar de alta personal administrativo");
                Console.WriteLine("4. Listar los médicos");
                Console.WriteLine("5. Listar los pacientes de un médico");
                Console.WriteLine("6. Eliminar a un paciente");
                Console.WriteLine("7. Ver la lista de personas del hospital");
                Console.WriteLine("8. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (opcion)
                {
                    case 1:
                        hospital.DarDeAltaMedico();
                        break;
                    case 2:
                        hospital.DarDeAltaPaciente();
                        break;
                    case 3:
                        hospital.DarDeAltaPersonalAdministrativo();
                        break;
                    case 4:
                        hospital.ListarMedicos();
                        break;
                    case 5:
                        hospital.ListarPacientesDeMedico();
                        break;
                    case 6:
                        hospital.EliminarPaciente();
                        break;
                    case 7:
                        hospital.VerListaPersonasHospital();
                        break;
                    case 8:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}
    
