using System;

namespace Tarea
{
    internal class Program
    {
        //Funcion para escribir Hola Mundo
        static void HolaMundo()
        {
            Console.Clear();
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("");
            Console.ReadKey();
        }

        //funcion que suma dos numeros
        static void SumaDeNumeros()
        {
            Console.Clear();
            //pide datos de entrada 
            Console.Write("Digite el primer numero: ");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            int numeroDos = Convert.ToInt32(Console.ReadLine());

            int respuesta = numeroUno + numeroDos;
            Console.WriteLine($"La suma de los numeros {numeroUno} y {numeroDos} es de: {respuesta}");
            Console.WriteLine("");
            Console.ReadKey();
        }

        //Funcion para saludar usuario
        static void SaludoNombre()
        {
            Console.Clear();
            //Pide datos de entrada
            Console.Write("¿Cual es su nombre?: ");
            string Nombre = Console.ReadLine();

            //saluda al usuario
            Console.WriteLine($"Hola {Nombre}");
            Console.WriteLine("");
            Console.ReadKey();
        }

        //Funcion para calcular area de circulo
        static void RadioDeCirculo()
        {
            Console.Clear();
            //Pide al usuario que digite el radio
            Console.Write("Digite el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            //Calcula el area y lo muestra en consola
            double area = 3.14 * (radio * radio);
            Console.WriteLine($"El area del circulo con radio de {radio} es de: {area}");
            Console.WriteLine("");
            Console.ReadKey();
        }

        //Funcion para imprimir datos de trabajador
        static void InfoTrabajador()
        {
            Console.Clear();
            //Pide al usuario digitar los datos
            Console.Write("Digite su nombre: ");
            string nombreTrabajador = Console.ReadLine();
            Console.Write("Digite su cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Digite su salario: ");
            double salarioInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            //Calcula nuevo salario
            double salarioFinal = salarioInicial + (salarioInicial * 0.1);

            //Digita los datos del trabajador
            Console.Clear();
            Console.WriteLine($"Nombre del colaborador: {nombreTrabajador}");
            Console.WriteLine($"Cargo del colaborador: {cargo}");
            Console.WriteLine($"Salario inicial: ${salarioInicial}");
            Console.WriteLine($"Salario con aumento: ${salarioFinal}");
            Console.WriteLine("");
            Console.ReadKey();
        }

        //Funcion para determinar numero par o impar
        static void ParImpar()
        {
            Console.Clear();
            //Pide al usuario que digite los numeros
            Console.Write("Digite el numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            //if que determina si es par o impar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es impar");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        //Funcion que determina que numero es mayor
        static void NumeroMayor()
        {
            Console.Clear();
            double[] NumeroMayor = new double[3];
            //Pide al usuario digitar los numeros
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite un numero: ");
                double numeroDigitado = Convert.ToDouble(Console.ReadLine());
                NumeroMayor[i] = numeroDigitado;
            }
            
            //Se ordena el arreglo
            Array.Sort(NumeroMayor);

            //Imprime el numero mayor
            Console.WriteLine($"El numero mayor es: {NumeroMayor[2]}");
            Console.ReadKey();
        }
        
        //Funcion que imprime las opciones
        static void OpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione el ejercicio que desea ver: ");
            Console.WriteLine("0.......Salir");
            Console.WriteLine("1.......Hola Mundo");
            Console.WriteLine("2.......Saludo");
            Console.WriteLine("3.......Suma");
            Console.WriteLine("4.......Area de Circulo");
            Console.WriteLine("5.......Aumento de Salario");
            Console.WriteLine("6.......Numero par o impar");
            Console.WriteLine("7.......Numero Mayor");
        }

        //Funcion para guiar usuario a pagina deseada
        static void GestionadorMenu(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    HolaMundo();
                    break;
                case 2:
                    SaludoNombre();
                    break;
                case 3:
                    SumaDeNumeros();
                    break;
                case 4:
                    RadioDeCirculo();
                    break;
                case 5:
                    InfoTrabajador();
                    break;
                case 6:
                    ParImpar();
                    break;
                case 7:
                    NumeroMayor();
                    break;
                case 8:

                default:
                    //Console.WriteLine("La opcion no es valida");
                    Console.Write("Presione cualquier teclar para salir . . .");
                    Console.ReadKey();
                    break;
            }
        }

        //Funcion del menu
        static void Menu()
        {
            int seleccion = 8;
            while (seleccion != 0)
            {
                OpcionesMenu();
                Console.Write("Digite su seleccion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                seleccion = opcion;
                GestionadorMenu(seleccion);
            }
            
        }

        //Funcion principal
        static void Main(string[] args)
        {
            Menu();

        }
    }
}
