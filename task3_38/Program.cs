//Задача 38: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
double[] doubleArray = new double[size];

for (int i = 0; i < doubleArray.Length; i++)
{
    doubleArray[i] = Math.Round((new Random().NextDouble()*100),2);
    Console.Write($"{doubleArray[i]} ");
}
Console.WriteLine();

double max = doubleArray[0];
double min = doubleArray[0];

for (int i = 0; i < doubleArray.Length; i++)
{
    if (doubleArray[i] > max)
    {
        max = doubleArray[i];
    }
    if (doubleArray[i] < min)
    {
        min = doubleArray[i];
    }
}

double result = Math.Round((max - min), 2);

Console.WriteLine($"Разница между максимальным {max} и минимальным {min} числами = {result}");