//     Задача 38:
//     Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.  
//     [3 7 22 2 78] -> 76

// Так как в задаче сказано задать массив ВЕЩЕСТВЕННЫМ числами, пришлось поколдовать с рандомом типа double.
// Чтобы не плодить километры записи элемента в массиве, сделано ограничение до 2 знаков после запятой.
// Однако, в примере к задаче, похоже, идет округление до целого. Видимо для удобного чтения.
// Так что сильно не пинайте за небольшое своеволие :)

//  ------------------ START -------------

//  Блок методов START ---------------------------------------

double[] FillArrayRandomInt(int size, double lrange, double rrange)  // метод заполнения массива случайными ВЕЩЕСТВЕННЫМИ значениями
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(lrange + rand.NextDouble() * (rrange - lrange), 2);  // здесь округляем рандом типа double до 2 знаком после запятой
    }
    return arr;
}

double FindSubtractionMaxMin(double[] arr) // метод поиска разницы между max и min в массиве
{
    double subtraction = 0;
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)   // цикл перебора массива для определения min / max
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    System.Console.WriteLine($"Max: {max}");  // здесь для удобство выводим min / max
    System.Console.WriteLine($"Min: {min}");
    subtraction = max - min;
    return subtraction;
}

//  Блок методов END -----------------------------------------

//  Тело программы START

System.Console.WriteLine("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int lRange = -10;
int rRange = 10;
double[] array = new double[size];

array = FillArrayRandomInt(size, lRange, rRange); // Заполняем массив случаныйми числами
Console.WriteLine("[" + string.Join(",", array) + "]");

System.Console.WriteLine($"Искомая разница между максимальным и минимальным значением элементов массива: {FindSubtractionMaxMin(array)}");

//  Тело программы END

//  ------------------  END --------------
