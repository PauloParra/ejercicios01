using System;


class ej07
{
  public static void Do ()
  {
    Console.WriteLine("\n[Ejercicio01.7] Pide dos textos por consola al usuario e imprime la concatenacion de ambos por pantalla.");

    // Declaramos las variable y pedimos al usuario que introduzca un texto.
    string entradaTeclado1;
    string entradaTeclado2;

    Console.WriteLine("Introduce un texto.");
    // Le asignamos un valor a la primera variable
    entradaTeclado1 = Console.ReadLine();
    
    Console.WriteLine("Introduce un texto.");
    // Le asignamos un valor a la segunda variable
    entradaTeclado2 = Console.ReadLine();

    // Imprimimos el texto por consola
    Console.WriteLine("Hemos concatenado tus palabras : " + entradaTeclado1 + entradaTeclado2);
    
    Console.Write("\n***************\n");
  }
}