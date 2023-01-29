// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите слова через запятую: ");
string words = Console.ReadLine();
string[] firstArray = words.Split(",");
string[] newArray = new string[firstArray.Length];
int count = 0;
Console.WriteLine();

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != " ") count++;
}

{
    Console.WriteLine($"Ваша строка из слов:");
    for (int i = 0; i < firstArray.Length; i++)
    {
        Console.Write(firstArray[i] + ", ");
    }

    FillNewArray(firstArray, newArray);
    Console.WriteLine("\nНовый массив из строк, длина которых меньше либо равна 3 символам: ");
    PrintArray(newArray);
}

void FillNewArray(string[] firstArray, string[] newArray)
{
    count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[count] = firstArray[i];
            count++;
        }
    }
}
void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
}


