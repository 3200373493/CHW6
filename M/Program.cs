// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void ShowArray(int[] array)
{
    Console.Write("СОЗДАН МАССИВ: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void AboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { count = count + 1; }
    }
    Console.Write($"КОЛЛИЧЕСТВО ЧИСЕЛ БОЛЬШЕ НОЛЯ = {count}");
}

int[] EnterMas(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("ВВЕДИТЕ {0}-й ЭЛЕМЕНТ", i + 1);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


Console.Clear();
Console.Write("ВВЕДИТЕ М = ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Array1 = EnterMas(M);
ShowArray(Array1);
AboveZero(Array1);

