// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] arrString = {"dog", "cat", "man", "home", "boy", "girls", "day", "joke", "bat", "sun", "month"};
int newArrayLength = 0;

Console.WriteLine("Начальный массив: ");
Console.WriteLine($"{String.Join("; ",arrString )}");

for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length <= 3)
    {
        newArrayLength++;
    }
}

Console.WriteLine();
Console.WriteLine("Финальный массив:");

string[] newArray = new string[newArrayLength];
int k = 0;
for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length <= 3)
    {
        newArray[k] = arrString[i];
        k++;
    }
}

Console.WriteLine($"{String.Join("; ",newArray )}");