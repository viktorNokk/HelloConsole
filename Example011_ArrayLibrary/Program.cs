void FillArray(int[] collection) //void используется, если метод ничего не возвращает (отсутствует return)
{
    int length = collection.Length; //получить длинну массива collection
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //положить в collection новое целое число из диапазона 1-10
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)  //печать массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

} 

int IndexOf(int[] collection, int find) //метод будет возвращать позицию
{
    int count = collection.Length; //определяем кол-во элементов
    int index = 0;
    //int position = 0;
    int position = -1; //искуственный прием, если искомого элемента нет в массиве
    while(index<count)
    {
        if(collection[index]==find)
        {
            position = index;
            break; //для отображения первого вхождения элемента в массиве
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив, в которм будет 10 элементов (по-умолчанию будут нули)

FillArray(array); //заполняет массив
array[4] = 4; //принудительно добавим 4
array[6] = 4;
PrintArray(array); //респечатывает массив
Console.WriteLine(); //пустая строчка, для уверености что не является частью вывода массива

int pos = IndexOf(array, 444); //в переменную pos кладем результат работы IndexOf (будем искать 4 в массиве)
Console.WriteLine(pos);
 