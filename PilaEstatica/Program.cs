using System;

class Program
{
    static void Main(string[] args)
    {
        const int MaxSize = 5; // Tamaño máximo de la pila
        int[] stack = new int[MaxSize];
        int top = -1; // Inicialmente, la pila está vacía

        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Push (Insertar elemento)");
            Console.WriteLine("2. Pop (Eliminar elemento)");
            Console.WriteLine("3. Mostrar la pila");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (top < MaxSize - 1)
                    {
                        Console.Write("Ingresa un valor para agregar a la pila: ");
                        int value = int.Parse(Console.ReadLine());
                        top++;
                        stack[top] = value;
                        Console.WriteLine($"Elemento {value} agregado a la pila.");
                    }
                    else
                    {
                        Console.WriteLine("La pila está llena. No se puede agregar más elementos.");
                    }
                    break;

                case 2:
                    if (top >= 0)
                    {
                        int removedItem = stack[top];
                        top--;
                        Console.WriteLine($"Elemento {removedItem} eliminado de la pila.");
                    }
                    else
                    {
                        Console.WriteLine("La pila está vacía. No se puede eliminar ningún elemento.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Elementos en la pila:");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                    break;
            }
        }
    }
}