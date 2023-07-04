// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] CreateNewArray (int size_array)
{
    int [] randomArray = new int[size_array];    
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(100,1000);
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " "); 
    Console.WriteLine();
}

void FindChetNum (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    Console.WriteLine($"Количество четных элементов в массиве -> {count}");
}

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateNewArray(size);
PrintArray(array);
FindChetNum(array);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] CreateNewArray (int size_array)
{
    int [] randomArray = new int[size_array];    
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(-99,100);
    }
    return randomArray;
}

void PrintArray (int [] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " "); 
    Console.WriteLine();
}

void FindSumNechetElem (int [] array)
{
    int SumNechetElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)   
            SumNechetElem += array[i];     
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumNechetElem}");
}

//Console.WriteLine("Введите количество элементов массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
int [] massiv = CreateNewArray(4);
PrintArray(massiv);
FindSumNechetElem(massiv);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double [] RandomArray ()
{
    int size = 6;
    double [] randomArray = new double [size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = Math.Round((new Random().Next(0, 100) + new Random().NextDouble()),2);
    }
    return randomArray;
}

void PrintArray(double [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void FindDiff (double [] array)
{
    double minVal = array[0];
    double maxVal = array[0]; 
    for (int i = 0; i < array.Length; i++)
    {
        if  (array[i] < minVal)
                minVal = array[i]; 
        else
            {
               if (array[i] > maxVal)
                    maxVal = array[i];    
            } 
    }
    Console.WriteLine($"Разность между максимальным и минимальным значением элементов массива -> {maxVal} - {minVal} = {maxVal - minVal}");
}

double [] massiv = RandomArray();
PrintArray(massiv);
FindDiff(massiv);
