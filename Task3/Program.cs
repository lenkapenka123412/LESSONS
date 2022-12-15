// Сортировка массива

Console.Clear();

int[] arr = {1, 3, 9, 8, 7, 2, 5, 4, 5, 8, 6, 9, 7, 3};
void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPositoin = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPositoin]) minPositoin = j;
        }
        int temporary = array[i];
        array[i] = array[minPositoin];
        array[minPositoin] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);