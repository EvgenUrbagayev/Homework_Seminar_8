//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2


using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrix(matrix);
WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)

{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;

}


void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(0); j++)
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    } 
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


void SortMatrix(int[,] InMatrix)
{
    
    for (int k = 0; k < InMatrix.GetLength(0); k++)
    {
        for (int i = 0; i < InMatrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < InMatrix.GetLength(1); j++)
            {
                int tmp = 0;
                if (InMatrix[k,i] < InMatrix[k,j])
                {
                    tmp = InMatrix[k, i];
                    InMatrix[k, i] = InMatrix[k, j];
                    InMatrix[k, j] = tmp;
                }
            }
        }
    }
}

