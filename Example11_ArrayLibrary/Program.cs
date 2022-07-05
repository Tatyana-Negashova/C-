void FillArray(int[] collection) // наполняем массив. int collection -название массива 
{
    int length = collection.Length;  //получаем длину массива
    int index = 0;
    while (index < length) // пока индекс элемента меньше длины массива
    {
        collection[index] = new Random().Next(1, 10); // кладем новое случайное число на позицию индекса из диапазона 1-10
        index++;
    }
}

void PrintArray(int[] col) //метод,который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //аргумент-массив collection + элемент find
{

    int count = collection.Length; //определяем количество элементов
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];  // создай массив из 10 элементов. По умолчанию наполнен нулями
FillArray(array); //метод для наполнения массива
PrintArray(array); // метод для вывода массив на экран
System.Console.WriteLine();

int pos = IndexOf(array, 6);
System.Console.WriteLine(pos);
