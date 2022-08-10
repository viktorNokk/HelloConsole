int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, };

//подзадача вывести массив на экран

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// напишем метод который будет упорядичивать массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // пробежаться по все элементам массива
    {
        int minPosition = i; //запоминаем позицию рабочего элемента
        
        for (int j = i + 1; j < array.Length; j++) //ищем min элемент
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; //временная рабочая переменная 
        array[i] = array[minPosition]; //простой обмен 2х переменных местами
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);