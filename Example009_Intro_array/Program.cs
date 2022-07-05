//поиск максимального числа bp трех
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 14, 42, 43, 44, 65, 466, 97, 58, 19 };
array[0] = 12;// каким образом обратиться к массиву и записать в него значение
System.Console.WriteLine(array[4]);//обратиться к массиву и получить значение элемента по индексу

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.WriteLine(max);
