/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
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

int[,] SortArray(int[,] array){
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k] < array[i,k+1])
                {
                int temp = array[i,k+1];
                array[i,k+1] = array[i,k];
                array[i,k] = temp;
                }
            }
           
        }
    }
    return array;
}

int rows = GetLeinght("Введите кол-во строк: ");
int columns = GetLeinght("Введите кол-во столбцов: ");
int[,] array = GetArray(rows,columns);
Console.WriteLine($"Cгенирована матрица с {rows} строками и {columns} столбцами: ");
PrintArray(array);
int[,] sortArray = SortArray(array);
Console.WriteLine();
Console.WriteLine($"\nОтсортированная матрица(cтроки со столбцами свапнуты): ");
PrintArray(sortArray);


