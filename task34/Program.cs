//     Задача 34:
//     Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.  
//     [345, 897, 568, 234] -> 2  

//  ------------------ START -------------

//  Блок методов START ---------------------------------------

int[] FillArrayRandomInt(int size, int lrange, int rrange)  // метод заполнения массива случайными целочисленными значениями
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(lrange, rrange + 1);
    }
    return arr;
}

int ShowCountOfOddNumbersOfArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

//  Блок методов END -----------------------------------------

//  Тело программы START

Console.Clear();

System.Console.WriteLine("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int lRange = 100;
int rRange = 1000;
int[] array = new int[size];

array = FillArrayRandomInt(size, lRange, rRange);  // Заполняем массив положительными трёхзначными числами
Console.WriteLine("[" + string.Join(",", array) + "]");

System.Console.WriteLine($"Количество четных элементов в массиве: {ShowCountOfOddNumbersOfArray(array)}"); //вывод количества четных элементов в массиве

//  Тело программы END


//  ------------------  END --------------