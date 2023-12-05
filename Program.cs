// See https://aka.ms/new-console-template for more information
Console.WriteLine("Question Description");
/* 

int SamDaily = 0; int KellyDaily = 0; int Contador = 0;

Console.WriteLine("Ingrese las soluciones diarias de Sam");
int SamTareas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese las soluciones diarias de Kelly");
int KellyTareas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la diferencia");
int Diferencia = Convert.ToInt32(Console.ReadLine());
SamDaily += Diferencia;

while (SamDaily >= KellyDaily || Contador <= 100)
{
    Contador += 1;
    SamDaily += SamTareas;
    KellyDaily += KellyTareas;
}
if (Contador <= 100)
{
    Console.WriteLine("Output: " + Contador);
}
else
{
    Console.WriteLine("-1");
}
 */

Console.WriteLine("Ingrese el tamaño del array");
int Tamaño = Convert.ToInt32(Console.ReadLine());
int [] ListaNumeros = new int[Tamaño];

for (int i = 0; i < Tamaño; i++)
{
    ListaNumeros[i] = new Random().Next(0, 1000000000);
}

