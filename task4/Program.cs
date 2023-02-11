/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
 int GetLeinght(string msg){
    int result = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введите коректное число!");
    }
    return result;
}
int[,,] GetArray(int rows,int columns,int count){
    int[,,] array = new int[rows,columns,count];
    Random rand = new Random(DateTime.Now.Ticks.GetHashCode());;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                
                array[i,j,k] = rand.Next(10,100);
                
            }  
       }     
    }
    return array;
}
void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {       
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write($" {array[i,j,k]}({j},{k},{i})");
            } 
        }  
    }
}
int rows = GetLeinght("Введите кол-во строк: ");
int columns = GetLeinght("Введите кол-во столбцов: ");
int count = GetLeinght("Введите кол-во матриц: ");
int[,,] array = GetArray(rows,columns,count);
Console.WriteLine($"Cгенирована первая матрица с {rows} строками , {columns} столбцами и {count} и количеством: ");
PrintArray(array);
Console.WriteLine();