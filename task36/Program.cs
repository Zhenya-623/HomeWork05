/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//метод получения массива заполненного рандомными трёхзначными числами
int[] InitArray(int demension)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-10, 10);
    }

    return arr;
}

//метод нахождения суммы элементов, стоящих на нечётных позициях
int GetSum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i = i + 2)

    {
        sum = sum + array[i];
    }

    return sum;
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
int[] arr = InitArray(6);

//команда для вывода получившегося массива
PrintArray(arr);

//создание переменной result и вложение в нее значения полученного с использованием метода GetSum
int result = GetSum(arr);

//вывод на консоль значение переменной result
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве:  " + result);