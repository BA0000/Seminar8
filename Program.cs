
// ---------------------------------------------------------------------------------------------------------------------------------------------------------
// Прошу меня простить, но данное ДЗ пошло очень плохо, со скрипом. Если поставите удовл. (если он есть на ГБ, конечно), буду безмерно благодарен. :)
// ---------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. (ГОТОВО)

// Console.Write("input lines: ");
// int lines = Convert.ToInt32(Console.ReadLine());

// Console.Write("input columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[lines, columns]; 



// GiveMeArray(array);

// Console.WriteLine("First massive: ");

// ShowMeArray(array);



//     for(int i = 0; i < array.GetLength(0); i++ )
//     {
//         for(int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for(int x = 0; x < array.GetLength(1) - 1; x++)
//             {
//                 if(array[i,x] > array[i,x + 1])
//                 {
//                     int temp = 0;
//                     temp =array[i, x];
//                     array[i, x] = array[i, x + 1];
//                     array[i, x + 1] = temp;
                    
//                 }
                
//             }
//         }
//     }


// Console.WriteLine("Chanched massive: ");
// ShowMeArray(array);




// void GiveMeArray(int[,] array)
// {
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     array[i, j] = new Random().Next(0, 10);
//   }
// }


// void ShowMeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine();
//     }
// }


// ------------------------------------------------------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------------------------------------------------------



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. (НЕ ГОТОВО)


// Console.Write("input lines: ");
// int lines = Convert.ToInt32(Console.ReadLine());

// Console.Write("input columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[lines, columns]; 

// GiveMeArray(array);
// ShowMeArray(array);

//     int minSum = 0;


//     for(int i = 0; i < array.GetLength(0); i++)
//     {    
//         int sum = 0;
        
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum +array[i, j];
//         }
        
//     }



// void GiveMeArray(int[,] array)
// {
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     array[i, j] = new Random().Next(0, 10);
//   }
// }


// void ShowMeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine();
//     }
// }

// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. (ГОТОВО)

// Console.Write("input lines: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.Write("input columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("input colums2: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());


// int[,] firstMatrix = new int[lines,columns];
// GiveMeArray(firstMatrix);
// Console.WriteLine("First matrix: ");
// ShowMeArray(firstMatrix);


// int[,] secondMatrix = new int[columns, columns2];
// GiveMeArray(secondMatrix);
// Console.WriteLine("Second matrix: ");
// ShowMeArray(secondMatrix);


// int[,] therdMtrix = new int[lines,columns2];


//  MulMatrix(firstMatrix, secondMatrix, therdMtrix);
// Console.WriteLine("Two matrix multiplication: ");
// ShowMeArray(therdMtrix);


// void MulMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] therdMatrix)
// {

// for(int i = 0; i < therdMtrix.GetLength(0); i++)
// {
//     {
//         for(int j = 0; j < therdMtrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for(int x = 0; x < firstMatrix.GetLength(1); x++)
//             {
//                 sum += firstMatrix[i,x] * secondMatrix[j,x];
//             }
//             therdMatrix[i,j] = sum;
//         }

//     }
// }
// }

// void GiveMeArray(int[,] array)
// {
//   for(int i = 0; i < array.GetLength(0); i++)
//   {
//     for(int j = 0; j < array.GetLength(1); j++)
//     array[i, j] = new Random().Next(0, 10);
//   }
// }


// void ShowMeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine();
//     }
// }

// -----------------------------------------------------------------------------------------------------------------------------------------------------------
// -----------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. (НЕ ГОТОВО)


// Console.WriteLine("Input x , y and z");

// Console.Write("Enter x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter z: ");
// int z = Convert.ToInt32(Console.ReadLine());


// int[,,] array3d = new int[x, y, z];
// GiveMeArray(array3d);
// ShowMeArray(array3d);


// void ShowMeArray(int[,,] array3d)
// {
//     for(int i = 0; i < array3d.GetLength(0); i++)
//     {
//         for(int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for(int b = 0; b < array3d.GetLength(2); b++)
//             {
//                 Console.Write(array3d[i, j, b] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// void GiveMeArray (int[,,] array3d)
// {
//     for(int i = 0; i < array3d.GetLength(0); i ++)
//     {
//         for(int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for(int b = 0; b < array3d.GetLength(2); b++)
//             array3d[i, j, b] = new Random().Next(20, 30, 40);
//         }
//     }
// }


// ----------------------------------------------------------------------------------------------------------------------------------------------------------
// ----------------------------------------------------------------------------------------------------------------------------------------------------------



// Задача 62. Заполните спирально массив 4 на 4. (НЕ ГОТОВО)


















































