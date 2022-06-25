//Ejercicio 1      Clase-9------------------------------
//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

//1)      Pedir al usuario la longitud de un vector
//2)      Crear el vector del tamaño ingresado.
//3)      Llenar el mismo con datos aleatorios
//4)      Mostrar el vector por pantalla
//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
//Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
//6)      Mostrar el vector nuevamente.

//Mi respuesta---------------

Console.WriteLine("Escriba la longitud del vector");
int n=int.Parse(Console.ReadLine());
int[] miVector=new int[n];
Random aleatorio = new Random();

for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = aleatorio.Next(100);
}
foreach (int i in miVector)
{
    Console.Write(i+",");
}
n= miVector.Length;
while (n > 0)
{
    Console.WriteLine(miVector[n]);
    n--;
}

