Console.WriteLine("Введите количество строчных элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

string[] array = new string[n];

void FillArray(int n, string[] mass)
{
for (int i = 0; i<n; i++)
{
    Console.WriteLine("Введите элемент под номером "+(i+1)+":");
    mass[i] = Console.ReadLine()!;
}
}

void PrintArray (string[] array)
{
    Console.WriteLine("Элементы массива:");
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
}

FillArray(n,array);
PrintArray(array);