/* Задача 58: Задайте две матрицы. Напишите программу,
 которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
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
int[,] MultiMatrix(int[,] firstArray,int[,] secondArray){
    int[,] resultArray=new int[firstArray.GetLength(0),secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i,j] = 0;
            for (int k = 0; k < secondArray.GetLength(1); k++)
            {
                resultArray[i,j] +=firstArray[i,k] * secondArray[k,j]; 
            }
            
        }
    }
    return resultArray;
}
int rows = GetLeinght("Введите кол-во строк: ");
int columns = GetLeinght("Введите кол-во столбцов: ");
int[,] array = GetArray(rows,columns);
int[,] matrix = GetArray(rows,columns);
Console.WriteLine($"Cгенирована первая матрица с {rows} строками и {columns} столбцами: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"\nCгенирована вторая матрица с {rows} строками и {columns} столбцами: ");
PrintArray(matrix);
int[,] multiArray = MultiMatrix(array,matrix);
Console.WriteLine();
Console.WriteLine($"\nПроизведение двух матриц: ");
PrintArray(multiArray);

