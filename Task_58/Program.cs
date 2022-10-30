// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18

using static System.Console;
Clear();
WriteLine("Введите размер матрицы А, мин и макс значение через пробел: ");
int[] parametersA = GetArrayFromString(ReadLine()!);
int[,] matrixA = GetMatrixArray(parametersA[0], parametersA[1], parametersA[2], parametersA[3]);

Write("Введите размер матрицы B, мин и макс значение через пробел: ");
int[] parametersB = GetArrayFromString(ReadLine()!);
int[,] matrixB = GetMatrixArray(parametersB[0], parametersB[1], parametersB[2], parametersB[3]);

PrintMatrix(matrixA);
WriteLine();
PrintMatrix(matrixB);
WriteLine();

int[,] NewMatrix = SortMatrix(matrixA, matrixB);
// //SortMatrix(matrix);
PrintMatrix(NewMatrix);


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


int[,] SortMatrix(int[,] matrixA, int[,] matrixB)

{
    int[,] OurMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                OurMatrix[i,j] += matrixA[i,k] * matrixB[k,j];
            }
        }
    }
    return OurMatrix;
}