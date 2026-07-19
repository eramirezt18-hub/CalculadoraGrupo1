using System;

class Program
{
    static void Main()
{
    bool continuar = true;
    
    while (continuar)
    {
        Console.Clear();
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
        
        try
        {
            int opcion = Convert.ToInt32(Console.ReadLine());
            
            if (opcion == 5)
            {
                continuar = false;
                Console.WriteLine("¡Hasta luego!");
                break;
            }
            
            if (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción inválida. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }
            
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            double resultado = 0;
            string operacion = "";
            
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    operacion = "suma";
                    break;
                case 2:
                    resultado = num1 - num2;
                    operacion = "resta";
                    break;
                case 3:
                    resultado = num1 * num2;
                    operacion = "multiplicación";
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        Console.ReadKey();
                        continue;
                    }
                    resultado = num1 / num2;
                    operacion = "división";
                    break;
            }
            
            Console.WriteLine($"El resultado de la {operacion} es: {resultado}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido.");
            Console.ReadKey();
        }
    }
}

    // TODO: Implementar funciones de suma, resta, multiplicación, división
}
//esto la partees
// parte agregado de Willson Humblers
