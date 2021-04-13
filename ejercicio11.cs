using System;


class ej11
{
  public static void Do ()
  {
    Console.WriteLine("\n[Ejercicio01.11] Declara una variable de tipo entero, asignale un valor e imprime el resultado de dividirla por 0.");

    // Declaramos las variables
    int num;
   
    // Le asignamos un valor a la variable
    num = 10;

    // Imprimimos por consola la division entre dos de la variable
    Console.WriteLine("La division de la variable da como resultado : " + num/0);

    // Dará error porque no se puede dividir por 0
    
    Console.Write("\n***************\n");
  }
}