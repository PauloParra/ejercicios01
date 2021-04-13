using System;


class ej08
{
  public static void Do ()
  {
    Console.WriteLine("\n[Ejercicio01.8] Declara dos variables de tipo entero, asignales un valor, suma sus valores y muestralos por pantalla.");

    // Declaramos las variables
    int num1;
    int num2;
    // Declaramos una variable para guardar el resutlado
    int resultado;

    // Le asignamos un valor a cada variable
    num1 = 10;
    num2 = 40;
    resultado = num1 + num2;

    // Imprimimos por consola la suma de ambas variables
    Console.WriteLine("La suma de las dos variables da como resultado : " + resultado);
    
    Console.Write("\n***************\n");
  }
}