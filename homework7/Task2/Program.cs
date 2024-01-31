//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

void ReverseArray(int[] array, int index) 
{ 
    if (index > array.Length - 1 || index < 0) 
        return; 
    ReverseArray(array, index + 1); 
    Console.Write($"{array[index]} "); 
}

int[] arr = {1, 2, 5, 0, 10, 34};
ReverseArray(arr, 0);