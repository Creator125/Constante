using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Programa para calcular el area");

    double r;
    const double pi = 3.14;


    Console.WriteLine("Ingrese el radio");
    r = double.Parse(Console.ReadLine());

    double A = pi * Math.Pow(r,2);
    Console.WriteLine("El area de la circuferencia es: "+ A);
  }
}