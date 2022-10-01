using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;
using CapaEntidad;

namespace Parcial_juan_salcedo
{
    public class Menu
    {
        public void Titulo(string TituloOpcion)
        {
            Console.Clear();
            Console.WriteLine(TituloOpcion);
        }
        public void EscogerAlumnoCrear()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("¿Que tipo de alumno desea crear?");
                Console.WriteLine("1. Pregrado");
                Console.WriteLine("2. Postgrado");
                Console.WriteLine("3. Volver");
                Console.WriteLine("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Titulo("Opcion 1 - Alumno pregrado");
                        CrearAlumnoPregrado();
                        break;
                    case 2:
                        Titulo("Opcion 2 - Alumno postrado");
                        CrearAlumnoPostgrado();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        OpcionDefault(opcion);
                        break;
                }
            } while (opcion != 3);
        }

        public void EscogerAlumnoListar()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("¿Que tipo de alumos desea listar?");
                Console.WriteLine("1. Pregrado");
                Console.WriteLine("2. Postgrado");
                Console.WriteLine("3. Volver");
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Titulo("Opcion 1 - Alumnos de pregrado");
                        ServicioPregradoImpl servicioPregradoImpl = new ServicioPregradoImpl();
                        Console.WriteLine("Listar alumnos de pregrado");
                        servicioPregradoImpl.Leer();
                        Console.WriteLine("Presione enter para regresar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Titulo("Opcion 2 - Alumnos de postgrado");
                        ServicioPostgradoImpl servicioPostgradoImpl = new ServicioPostgradoImpl();
                        Console.WriteLine("Listar alumnos de postgrado");
                        servicioPostgradoImpl.Leer();
                        Console.WriteLine("Presione enter para regresar");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        OpcionDefault(opcion);
                        break;


                }
            } while (opcion != 3);
        }


        public void EscogerAlumnoEliminar()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("¿Que tipo de alumno desea crear?");
                Console.WriteLine("1. Pregrado");
                Console.WriteLine("2. Postgrado");
                Console.WriteLine("3. Volver");
                Console.WriteLine("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        ServicioPregradoImpl servicioPregradoImpl = new ServicioPregradoImpl();
                        Console.WriteLine("Eliminar alumno de pregrado");
                        break;
                    case 2:
                        Titulo("Eliminar alumno postgrado");
                        ServicioPostgradoImpl servicioPostgradoImpl = new ServicioPostgradoImpl();
                        Console.WriteLine("Eliminar alumno de postgrado");
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        OpcionDefault(opcion);
                        break;
                }
            } while (opcion != 3);
        }

        public void OpcionDefault(int opcion)
        {
            Console.Clear();
            Console.WriteLine("Opcion ingresada: " + opcion);
            Console.Write("Error: Opcion no valida");
            Console.ReadKey();
        }

        public void CrearAlumnoPregrado()
        {
            Console.Write("Ingrese el numero de documento: ");
            int noDocumento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese el programa: ");
            string programapregado = Console.ReadLine();

            Console.Write("Ingrese el semestre: ");
            int semestre = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la primera nota del corte: ");
            double promediocorte1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota del corte: ");
            double promediocorte2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la tercera nota del corte: ");
            double promediocorte3 = int.Parse(Console.ReadLine());

            Pregrado alumnoPregrado = new Pregrado(noDocumento, nombre, apellido, programapregado, semestre, promediocorte1, promediocorte2, promediocorte3);

            ServicioPregradoImpl servicioPregradoImpl = new ServicioPregradoImpl();

            servicioPregradoImpl.Crear(alumnoPregrado);
            Console.WriteLine("El siguiente alumno fue creado con exito");
            Console.Write(alumnoPregrado);
            Console.Clear();

        }
        public void CrearAlumnoPostgrado()
        {
            Console.Write("Ingrese el numero de documento: ");
            int noDocumento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese el programa: ");
            string programapostgado = Console.ReadLine();

            Console.Write("Ingrese el semestre: ");
            int semestre = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el promedio: ");
            double promediosemestre = int.Parse(Console.ReadLine());

            Postgrado alumnoPostgrado = new Postgrado(noDocumento, nombre, apellido, programapostgado, semestre, promediosemestre);

            ServicioPostgradoImpl servicioPostgradoImpl = new ServicioPostgradoImpl();

            servicioPostgradoImpl.Crear(alumnoPostgrado);
            Console.WriteLine("El siguiente alumno fue creado con exito");
            Console.Write(alumnoPostgrado);
            Console.Clear();
        }
        public void MostrarMenu()
        {
            int opcion = 0;

            do
            {
                Console.WriteLine("Sistema de alumnos");
                Console.WriteLine("1. Agregar alumno");
                Console.WriteLine("2. Listar alumnos");
                Console.WriteLine("3. Modificar alumnos");
                Console.WriteLine("4. Eliminnar alumno");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Titulo("Opcion 1 - Agregar alumno");
                        EscogerAlumnoCrear();
                        break;
                    case 2:
                        Titulo("Opcion 2 - Listar alumno");
                        EscogerAlumnoListar();
                        break;
                    case 3:
                        Titulo("Opcion 3 - Modificar alumno");
                        break;
                    case 4:
                        Titulo("Opcion 4 - Modificar alumno");
                        break;
                    case 5:
                        Titulo("Sistema finalizado");
                        break;
                    default:
                        OpcionDefault(opcion);
                        Console.Clear();
                        break;
                }
            } while (opcion != 5);
        }
        public void Menu_P()
        {
            MostrarMenu();
        }

    }
}
