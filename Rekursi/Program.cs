// Перестановки
// (Время: 1 сек. Память: 16 Мб Сложность: 44%)
// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

// Входные данные
// Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.

//   void Massiv(string[] array)
// {
    

// }



string NewMassive(string[] resultArray)
{
  string n = resultArray[0];
  for (int i = 0; i <resultArray.Length ; i++)
       if (i<resultArray.Length)
        {
        n=resultArray[i];
        }
    
    return n;
 } 
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine()!);
string[] beginArray = new string[n];
string[] resultArray = new string [n];
Console.WriteLine("Введите значение элементов: ");    
for (int i = 0; i < n; i++)
    beginArray[i] = (Console.ReadLine()!);

Console.WriteLine($"Начальный массив: [{string.Join(" ", beginArray)}]");
NewMassive(resultArray);
Console.WriteLine($"Конечный массив: [{string.Join(" ", resultArray)}]");

