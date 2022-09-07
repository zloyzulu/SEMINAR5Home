//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
void NumPlusArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[num];
NumPlusArray(numbers);
Console.WriteLine();

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) count += 1;
}
Console.WriteLine($"Количество четных чисел: {count}");

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

/*

 void arrayRu(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

void arraySu(int[] array)
{   
    Console.Write($" Элементы:");
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
        Console.Write($"{array[i]} ");
    }    
        Console.WriteLine();
        Console.Write($"Сумма элементов, стоящих на нечётных позициях = {sum} ");
}
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
arrayRu(array);
arraySu(array);

*/



//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

/*
int [] CoolRandArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
    array[i]  = new Random().Next(1, 100);
    }
    return array;
}

void SlowArray(int[] array){
    int minNumber = array[0];
    int maxNumber = array[0];
    
    for(int i = 0; i < array.Length; i++){
        if( array[i] > maxNumber) {
            maxNumber = array[i];
        }
        else{
            if(array[i] < minNumber){
                minNumber = array[i];
            }
        }
        Console.Write($"{array[i]}  "); 
    }
    int res = maxNumber - minNumber;
    Console.WriteLine();         
    Console.Write($"Разница между {maxNumber} и {minNumber} = {res}");
    Console.WriteLine();
}

Console.WriteLine("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
SlowArray(CoolRandArray(size));
 

 */





