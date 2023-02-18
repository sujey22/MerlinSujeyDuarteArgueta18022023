// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using MerlinSujeyDuarteArgueta18022023.Entidades;
using MerlinSujeyDuarteArgueta18022023.Negocio;

Palabras palabras = new Palabras();
ClsPalabras clsPalabras = new ClsPalabras();

Console.WriteLine("Digite su palabra");
palabras.palabras = Console.ReadLine();

Console.WriteLine("El numero de letras que hay en la palabra es: "+ clsPalabras.Contador(palabras));



