// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.
/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int SumNegativ(int[] array) // метод считает сумму отрицательных элементов
{
    int sum = 0;
    for (int i=0; i < array.Length; ++i)
        if(array[i]<0) sum += array[i];
    return sum;
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray  = CreateRandomArray(length, min, max);
ShowArray(myArray);
int negativsum = SumNegativ(myArray);
Console.WriteLine(" Sum of negativ is" + negativsum);*/

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.


/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int [] Revers(int[] array)
{
    for(int i=0; i<array.Length; i++)
    array[i]*= -1;
    return array;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray  = CreateRandomArray(length, min, max);
ShowArray(myArray);

Revers(myArray);
ShowArray(myArray);*/




// Задайте массив. Напишите программу, которая определяет, присутствует ли 
//заданное число в массиве.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

bool HaveNumber (int[] array, int n)
{
    for( int i=0; i<array.Length; i++)
        if(array[i] == n) return true;
    return false;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myArray  = CreateRandomArray(length, min, max);
ShowArray(myArray);

Console.WriteLine(HaveNumber(myArray, num));*/




// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых 
//лежат в отрезке [a,b].

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int Count(int[] array, int min, int max)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i]>min && array[i]<max) count += 1;
    return count;
}
Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posible value: ");
int minvalue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posible value: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min : ");
int min  = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max : ");
int max  = Convert.ToInt32(Console.ReadLine());

int[] myArray  = CreateRandomArray(length, minvalue, maxvalue);
ShowArray(myArray);
Console.WriteLine(Count(myArray,min, max));