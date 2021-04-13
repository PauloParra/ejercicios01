using System;


class ej12
{
  public static void Do ()
  {
    Console.WriteLine("\n[Ejercicio01.12] Pide 3 numeros por consola y muestra el valor de la media de las 3.");

    // Declaramos las variables para pedir los numeros
    // Pedimos al usuario que introduzca los numeros

    Console.WriteLine("Introduce una nota");
    string lecturaNum1 = Console.ReadLine();
    Console.WriteLine("Introduce una nota");
    string lecturaNum2 = Console.ReadLine();
    Console.WriteLine("Introduce una nota");
    string lecturaNum3 = Console.ReadLine();

    // Declaramos las varaibles para convertir los numeros a float
    // Convertimos los valor introducidos a floats
    float num1 = float.Parse(lecturaNum1);
    float num2 = float.Parse(lecturaNum2);
    float num3 = float.Parse(lecturaNum3);

    // Declaramos una variable para guardar el resultado de la media
    float media = (num1+num2+num3)/3F;
    
    // Imprimimos por consola la media de las variables
    Console.WriteLine("La media de las variable da como resultado : " + media);
    
    Console.Write("\n***************\n");
  }
}