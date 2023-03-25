// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.03 7.85 22.13 2.05 78.48] -> 76.43
    void Massiv(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100 + 0, 2);
}
double Max(double[]array)
{
    double max = array[0];
    for (int i = 0; i <array.Length; i++)
    {
        if (max<array[i])
        {
            max=array[i];
        }
    }
    return max;
}
double Min(double[]array)
{
    double min = array[0];
    for (int i = 0; i <array.Length; i++)
    {
        if (min>array[i])
        {
            min=array[i];
        }
    }
    return min;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
Massiv(array);
System.Console.WriteLine($"array: [{string.Join(" , " , array)}]");
double s = Math.Sqrt(Math.Pow(Max(array) - Min(array), 2));
System.Console.WriteLine(($"Max {Max(array)} - Min {Min(array)} = {Math.Round (s,2)}"));