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

int CountArrayElements (string[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
        {
           count+=1; 
        }
    }
    return count;
}

void NewArray (string[] array, int count)
{
    Console.WriteLine("Новый массив:");
    int k = 0;
    string[] newarray = new string [count];
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            k+=1;
            newarray[k-1] = array[i];
            Console.WriteLine(newarray[k-1]);
        }

    }
}

FillArray(n,array);
PrintArray(array);
NewArray(array,CountArrayElements(array));

