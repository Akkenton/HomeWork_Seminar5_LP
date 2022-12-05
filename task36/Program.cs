//     Задача 36:
//     Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.  
//     [3, 7, 23, 12] -> 19  
//     [-4, -6, 89, 6] -> 0  
//     Здесь период я задаю самостоятельно - выбрал от -100 до 100 включительно

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

int SumNumbersOfOddIndex(int[] arr) // Метод суммирования значений элементов на нечетных индексах
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) summ += arr[i];
    }
    return summ;
}

//  Блок методов END -----------------------------------------

//  Тело программы START

Console.Clear();

System.Console.WriteLine("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int lRange = -100;
int rRange = 100;
int[] array = new int[size];

array = FillArrayRandomInt(size, lRange, rRange); // Заполняем массив случаныйми числами
Console.WriteLine("[" + string.Join(",", array) + "]");

System.Console.WriteLine($"Сумма элементов массива на нечетных индексах: {SumNumbersOfOddIndex(array)}"); //вывод суммы

//  Тело программы END

//  ------------------  END --------------