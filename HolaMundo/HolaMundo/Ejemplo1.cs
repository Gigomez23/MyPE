namespace HolaMundo
{
    internal class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, World! ");
            Console.WriteLine("Gabriel Gomez");

            //tipo de dato primitivo
            int edad = 20;
            Console.WriteLine($"Tu edad es: {edad}");

            //ctrl+d duplica linea
            string nombre = "Gabriel Ivan Gomez Matamoros";
            Console.WriteLine($"Tu nombre completo es: {nombre}");
            Console.WriteLine($"Tu nombre completo es: {nombre.ToUpper()}");
            Console.WriteLine($"Tu nombre completo es: {nombre.ToLower()}");
            Console.WriteLine($"Tu nombre completo tiene {nombre.Length} caracteres");

            //Variables con doble precision
            Double precio = 29.99;
            Console.WriteLine($"El precio es de: ${precio}");
            Console.WriteLine($"El precio es de: ${precio++}");
            Console.WriteLine($"El precio es de: ${++precio}");

            /*Valores Logicos
             */
            Boolean isSingle = true;
            Console.WriteLine($"Tu eres soltero? {isSingle}");
            Console.WriteLine($"Tu eres soltero? {!isSingle}");
            Console.WriteLine($"Tu eres soltero? {isSingle}");


        }
    }
}

