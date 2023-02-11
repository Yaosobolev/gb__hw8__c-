/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
 с наименьшей суммой элементов: 1 строка */
 int GetLeinght(string msg){
    int result = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введите коректное число!");
    }
    return result;
}

int[,] GetArray(int rows,int columns){
    int[,] array = new int[rows,columns];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j]=rand.Next(1,10);
       } 
        
       
    }
    return array;
}
void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {       
        Console.WriteLine();   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }  
    }
}

int[] SumArray(int[,] array){
    int[] sum = new int[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] +=array[i,j] ;
           
        }
    }
    return sum;
}
int MinElement(int[] sum){
    int min = sum[0];
    int minI = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if(sum[i]<min){
            min = sum[i];
            minI = i+1;
        } 
    }
    return minI;
}
/* void PrintArr(int[] array){  Вывод суммы каждой строки
    for (int i = 0; i < array.GetLength(0); i++)
    {       
          
        
        Console.Write($" {array[i]} ");
          
    }
} */

int rows = GetLeinght("Введите кол-во строк: ");
int columns = GetLeinght("Введите кол-во столбцов: ");
int[,] array = GetArray(rows,columns);
Console.WriteLine($"Cгенирована матрица с {rows} строками и {columns} столбцами: ");
PrintArray(array);
int[] sumArray = SumArray(array);
Console.WriteLine();
Console.Write($"\n Номер строки с наименьшей суммой элементов: ");
// PrintArr(sumArray);

int min = MinElement(sumArray);
Console.WriteLine(min);