using System;

class Program
 {
 static void Main(string[] args)
 {
 int positivos = 0; int contar = 0; int numero;
 Console.WriteLine("Introduce número ");
 numero = Int32.Parse(Console.ReadLine());
 while (numero != 999)
 {
 contar = contar + 1;
 if (numero > 0) positivos = positivos + 1;
 Console.WriteLine("Introduce otro número ");
 numero = Int32.Parse(Console.ReadLine());
 }
 Console.WriteLine("Has introducido un total {0} ",contar);
//Console.WriteLine(contar);
 Console.WriteLine("y son positivos {0}", positivos);


 } //fin Main
 }