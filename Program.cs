// ====================================================================================================================
// Задача 1.
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Указание:
// Использовать рекурсию, не использовать циклы.

// Функция вывода на экран чисел заданного диапазона
void PrintAllNaturalNumbersInTheInterval(int numberFrom, int numberTo)
{
    if (numberFrom > numberTo) return;
    Console.Write(numberFrom++ + " ");
    PrintAllNaturalNumbersInTheInterval(numberFrom, numberTo);
}

Console.WriteLine("Задача 1. Сейчас будет магия. Введите значния и я выведу все натурные числа в заданном промежутке");

int numberStart = 0;
int numberEnd = 0;

// Ожидаем ввод стартового числа
bool CorrectInput = false;
while (!CorrectInput)
{
    Console.WriteLine("Введите начальное значение");
    CorrectInput = int.TryParse(Console.ReadLine(), out numberStart);
    if (!CorrectInput) Console.WriteLine("Введёное значние некорректно. Повторите ввод натурального числа");
}

// Ожидаем ввод конечного числа
CorrectInput = false;
while (!CorrectInput)
{
    Console.WriteLine("Введите конечное значение");
    CorrectInput = int.TryParse(Console.ReadLine(), out numberEnd);
    if (!CorrectInput) Console.WriteLine("Введёное значние некорректно. Повторите ввод натурального числа");
}

PrintAllNaturalNumbersInTheInterval(numberStart, numberEnd);
Console.WriteLine("\n");

// ====================================================================================================================
// Задача 2.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.

// Функция Аккермана
int FuncAkkerman(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = FuncAkkerman(n, m - 1);
        }
        n--;
    }
    return m + 1;
}

Console.WriteLine("Задача 2. Сейчас будет магия. Введите два неотрицательных числа и я верну Вам значение с помощью функции Аккермана");

int M = 0;
int N = 0;

// Ожидаем ввод стартового числа
CorrectInput = false;
while (!CorrectInput)
{
    Console.WriteLine("Введите значение \"N\"");
    CorrectInput = int.TryParse(Console.ReadLine(), out N) && N >= 0;
    if (!CorrectInput) Console.WriteLine("Введёное значние некорректно. Повторите ввод натурального неотрицательного числа");
}

// Ожидаем ввод конечного числа
CorrectInput = false;
while (!CorrectInput)
{
    Console.WriteLine("Введите значение \"M\"");
    CorrectInput = int.TryParse(Console.ReadLine(), out M) && M >= 0;
    if (!CorrectInput) Console.WriteLine("Введёное значние некорректно. Повторите ввод натурального неотрицательного числа");
}

Console.WriteLine(FuncAkkerman(N, M));
Console.WriteLine("\n");

// ====================================================================================================================
// Задача 3.
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Указание:
// Использовать рекурсию, не использовать циклы.

// Создаем массив, заданной длины
int[] CreateArray(int length)
{
    int[] array = new int[length];
    return array;
}

// Заполняем массив значениями
int[] GeneratedNumberArray(int index, int[] array, int start, int end)
{
    if (index >= array.Length)
    {
        Console.WriteLine();
        return array;
    }
    array[index] = new Random().Next(start, end);
    Console.Write(array[index++] + " ");
    return GeneratedNumberArray(index, array, 0, 10);
}

// Вывод на экран элентов массива, в обратном порядке
void PrintArrayConverted(int index, int[] array)
{
    if (index >= array.Length)
    {
        return;
    }
    Console.Write(array[array.Length - 1 - index++] + " ");
    PrintArrayConverted(index, array);
}

Console.WriteLine("Задача 3.");
PrintArrayConverted(0, GeneratedNumberArray(0, CreateArray(10), 0, 10));