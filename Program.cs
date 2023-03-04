// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void NewArray(string[] text)
{
    for (int i = 0; i < text.Length; i++)
    {
        Console.WriteLine($"{i + 1}-й текст: ");
        text[i] = Console.ReadLine();
    }
}
string[] text = new string[5];
Console.WriteLine("Введите 5 различных наборов символов: ");
NewArray(text);
Console.WriteLine("Ваш массив: [" + string.Join(", ", text) + "]");

int newSize = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i].Length <= 3)
    {
        newSize++;
    }
}

if (newSize == 0) Console.WriteLine("В вашем массиве нет элементов длиной 3 и менее символов");
else
{
    string[] text2 = new string[newSize];
    int j = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            text2[j] = text[i];
            j++;
        }
    }
    Console.WriteLine("Массив, состоящий из элементов от 3-х и менее символов: [" + string.Join(", ", text2) + "]");
}
