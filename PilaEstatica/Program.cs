using System;
using System.Collections;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        MiPila<int> pilaEnteros = new MiPila<int>(5);
        pilaEnteros.Push(1);
        pilaEnteros.Push(2);
        pilaEnteros.Push(3);

        Console.WriteLine("Elementos en la pila de enteros:");
        while (pilaEnteros.Count > 0)
        {
            Console.WriteLine(pilaEnteros.Pop());
        }

        MiPila<string> pilaCadenas = new MiPila<string>(3);
        pilaCadenas.Push("Hola");
        pilaCadenas.Push("Mundo");

        Console.WriteLine("Elementos en la pila de cadenas:");
        while (pilaCadenas.Count > 0)
        {
            Console.WriteLine(pilaCadenas.Pop());
        }
    }
    public class MiPila<T>
    {
        private T[] elementos;
        private int capacidad;
        private int contador;

        public MiPila(int capacidad)
        {
            this.capacidad = capacidad;
            this.elementos = new T[capacidad];
            this.contador = 0;
        }

        public void Push(T elemento)
        {
            if (contador < capacidad)
            {
                elementos[contador] = elemento;
                contador++;
            }
            else
            {
                Console.WriteLine("La pila está llena. No se puede agregar más elementos.");
            }
        }

        public T Pop()
        {
            if (contador > 0)
            {
                contador--;
                T elemento = elementos[contador];
                elementos[contador] = default(T); // Restablecer el valor a su valor predeterminado
                return elemento;
            }
            else
            {
                Console.WriteLine("La pila está vacía. No se pueden sacar más elementos.");
                return default(T); // Valor predeterminado para el tipo T (por ejemplo, null para referencias)
            }
        }

        public T Peek()
        {
            if (contador > 0)
            {
                return elementos[contador - 1];
            }
            else
            {
                Console.WriteLine("La pila está vacía. No hay elementos para ver.");
                return default(T); // Valor predeterminado para el tipo T
            }
        }

        public int Count
        {
            get { return contador; }
        }
    }
}