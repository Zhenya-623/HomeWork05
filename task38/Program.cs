/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//метод получения массива заполненного рандомными трёхзначными числами
double[] InitArray(int demension)
{
    double[] arr = new double[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }

    return arr;
}

//метод для поиска максимального и минимального значения массива
(double, double) FindMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }

    return (max, min);
}

//метод вывода массива на консоль
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//команда для создания массива длиной в 5 чисел с использованием метода InitArray
double[] arr = InitArray(10);

//команда для вывода получившегося массива
PrintArray(arr);

//команда для получения максимального и минимального значения массива
(double max, double min) = FindMaxMin(arr);

//полчение разницы между максимальным и минимальным значением
double result = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементом массива:  " + result);

