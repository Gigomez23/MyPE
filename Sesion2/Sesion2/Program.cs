/**
 * Archivo: Main
 * autor: Gabriel Gómez
 * descripcion: Ejercicios para sesion dos de
 * Metodologia 
 */
using Sesion2.modelos;
using System.Security.Cryptography.X509Certificates;

namespace Sesion2
{
    internal class Program
    {
        //Funcion que ejecuta el ejercicio de nota de estudiantes
        static void EstudianteEjercicio()
        {
            Console.Clear();
            Estudiante est = new Estudiante();
            String nombre, carrera;
            int notaUno, notaDos, notaTres;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Carrera: ");
            carrera = Console.ReadLine();
            Console.Write("Primera Nota: ");
            notaUno = int.Parse(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            notaDos = int.Parse(Console.ReadLine());
            Console.Write("Tercera Nota: ");
            notaTres = int.Parse(Console.ReadLine());

            est.Nombre = nombre;
            est.Carrera = carrera;
            est.Nota1 = notaUno;
            est.Nota2 = notaDos;
            est.Nota3 = notaTres;

            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(est.ToString());
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
        }

        //Funcion que ejecuta el ejercicio precio por numero de producto
        static void PrecioEjercicio()
        {
            Console.Clear();
            Producto producto = new Producto();
            string nombreProducto;
            double precio;
            int cantidad;

            Console.Write("Nombre del producto: ");
            nombreProducto = Console.ReadLine();
            Console.Write("Costo de producto: C$");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad a comprar: ");
            cantidad = int.Parse(Console.ReadLine());

            producto.NombreProducto = nombreProducto;
            producto.PrecioProducto = precio;
            producto.CantidadProducto = cantidad;

            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(producto.ToString());
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
        }

        //Funcion que ejecuta el ejercicio de calcular el cubo
        static void CuboEjercicio()
        {

            Console.Clear();
            Cubo cubo = new Cubo();
            double NumeroEntrada;

            Console.Write("Digite el numero para encontrar el cubo: ");
            NumeroEntrada = double.Parse(Console.ReadLine());

            cubo.Numero = NumeroEntrada;

            Console.WriteLine(cubo.ToString());
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
        }

        //Funcion que ejecuta el ejercicio de calcular la raíz
        static void RaizEjercisio()
        {
            Console.Clear();
            Raiz raiz = new Raiz();
            double NumeroEntrada;

            Console.Write("Digite el numero para encontrar raíz: ");
            NumeroEntrada = double.Parse(Console.ReadLine());

            raiz.Numero = NumeroEntrada;

            Console.WriteLine(raiz.ToString());
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
        }

        //Funcion que ejecuta el ejercisio de calcular el area de un circulo
        static void AreaDeCirculoEjercisio()
        {
            Console.Clear();
            AreaCirculo areaCirculo = new AreaCirculo();
            double NumeroEntrada;

            Console.Write("Digite el radio del circulo: ");
            NumeroEntrada = double.Parse(Console.ReadLine());

            areaCirculo.Numero = NumeroEntrada;

            Console.WriteLine(areaCirculo.ToString());
            Console.WriteLine("Presione cualquier tecla para continuar . . .");
            Console.ReadKey();
        }
        
        //Funcion que imprime las opciones del menu
        static void MenuOpciones()
        {
            Console.WriteLine("Digite el ejercicio que quiere revisar");
            Console.WriteLine("Ejercicio Estudiantes......1");
            Console.WriteLine("Ejercicio Productos........2");
            Console.WriteLine("Ejercicio Cubo.............3");
            Console.WriteLine("Ejercicio Raíz.............4");
            Console.WriteLine("Ejercicio Area de Circulo..5");
            Console.WriteLine("Salir......................0");
        }
        
        //Funcion que contiene el menu
        static void Menu()
        {
            bool Active = true;
            int opcion;

            while (Active != false)
            {
                Console.Clear();
                MenuOpciones();
                Console.Write("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 0:
                        Console.WriteLine("Saliendo del programa");
                        Console.WriteLine("Presione cualquier tecla para salir . . .");
                        Console.ReadKey();
                        Active = false;
                        break;
                    case 1: 
                        EstudianteEjercicio();
                        break;
                    case 2:
                        PrecioEjercicio();
                        break;
                    case 3:
                        CuboEjercicio();
                        break;
                    case 4:
                        RaizEjercisio();
                        break;
                    case 5:
                        AreaDeCirculoEjercisio();
                        break;
                    default:
                        Console.WriteLine("Esa no es una opcion valida.");
                        Console.ReadKey();
                        break;
                }
            }

        }

        //Programa principal
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
