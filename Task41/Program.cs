// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Добрый День. Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];
int count = 0;

for (int i = 0; i < size; i++)
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());

    numbers[i] = num;

    if (num > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество чисел, больше нуля: " + count + ". Досвидания.");
