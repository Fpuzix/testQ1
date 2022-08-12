// Создание первоначального массива после указания размера массива.

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("input " + i + " elemets: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

// вывод массива

void ShowArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// main

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myRandomArray = CreateArray(size);
ShowArray(myRandomArray);

Console.WriteLine();

int length = 0;
int j = 0;

for (int i = 0; i < myRandomArray.Length; i++)
{

    string temp = myRandomArray[i];
    length = temp.Length;
    if (length <= 3)
    {
        j++;
    }

}

string[] ResultArray = new string[j];

j = 0;

for (int i = 0; i < myRandomArray.Length; i++)
{
    string temp = myRandomArray[i];

    length = temp.Length;
    if (length <= 3)
    {
        ResultArray[j] = temp;
        j++;
    }

}

ShowArray(ResultArray);


