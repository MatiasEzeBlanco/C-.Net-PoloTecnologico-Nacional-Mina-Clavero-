//Clase 5 -------------------------------
Console.ReadLine("Cuantas vueltas quiere dar?");

var totalDeVueltas = int.Parse(Console.ReadLine());
var contador = 0;

while (contador <= totalDeVueltas)
{
    contador++;
    Console.WriteLine("seguimos dando vueltas,vuelta numero: " + contador);
}
