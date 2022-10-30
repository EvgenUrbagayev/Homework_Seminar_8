// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2],parameters[3], parameters[4]);

PrintMatrix(matrix);
//WriteLine();


int[,,] GetMatrixArray(int rows, int columns, int third, int minValue, int maxValue)

{
    int[,,] resultMatrix = new int[rows, columns, third];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(2); k++)
            {
                resultMatrix[i,j,k] = new Random().Next(minValue, maxValue);
            }
            
        }
    }
    return resultMatrix;

}


void PrintMatrix(int[,,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(2); k++)
            {
                Write($"{inMatrix[i,j,k]} ");
                Write($"({i},{j},{k})\t");
            }
            WriteLine();
        }
        WriteLine();
    }
    WriteLine();
}


int[] GetArrayFromString(string parameters)

{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
   
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}