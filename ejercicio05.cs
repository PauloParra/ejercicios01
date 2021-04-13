using System;


class ej05
{
  public static void Do ()
  {
    Console.WriteLine("\n[Ejercicio01.5] Declara dos variables, asignales un valor e imprime por pantalla la concatenación de ambas.");

    // Declaramos las variable.
    string texto1;
    string texto2;

    // Le asignamos un valor
    texto1 = "Esto es el texto de la variable 1.";
    texto2 = "Esto es el texto de la variable 2.";


    // Tambien podemos declararlo y asignarle un valor a la vez
    // string texto1 = "Esto es el texto de la variable 1.";
    // string texto2 = "Esto es el texto de la variable 2.";

    // Imprimimos el texto por consola
    Console.WriteLine("\nHemoc concatenado dos textos : " + texto1+texto2);
    
    Console.Write("\n***************\n");

  }
}