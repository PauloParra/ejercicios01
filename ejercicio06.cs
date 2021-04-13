using System;


class ej06
{
 public static void Do ()
  {
    Console.WriteLine("\n[Ejercicio01.6] Pide un texto por consola al usuario e imprimelo por pantalla.");

    // Declaramos las variable y pedimos al usuario que introduzca un texto.
    string entradaTeclado;
    Console.WriteLine("Introduce un texto.");

    // Le asignamos un valor
    entradaTeclado = Console.ReadLine();

    // Imprimimos el texto por consola
    Console.WriteLine("Has escrito : " + entradaTeclado);
    
    Console.Write("\n***************\n");
  }
}