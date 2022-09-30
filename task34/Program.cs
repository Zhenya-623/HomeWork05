/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
//метод получения массива заполненного рандомными трёхзначными числами
int[] InitArray(int demension)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }

    return arr;
}

//метод получения количества четных чисел в массиве
int GetCountOfNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
         count = count + 1;
    }

    return count;
}

//метод вывода массива на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//команда для создания массива длиной в 5 чисел с использованием метода InitArray
int[] arr = InitArray(5);

//команда для вывода получившегося массива
PrintArray(arr);

//создание переменной result и вложение в нее значения полученного с использованием метода GetCountOfNumbers
int result = GetCountOfNumbers(arr);

//вывод на консоль значение переменной result
Console.WriteLine("Количество чётных чисел в массиве:  " + result);