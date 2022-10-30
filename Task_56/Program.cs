// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
//будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с
//наименьшей суммой элементов: 1 строка


using static System.Console;
Clear();
Write("Введите размер матрицы, мин и макс значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);

PrintMatrix(matrix);
WriteLine();
GetSortMatrixArray(matrix);

int NumberString = GetSortMatrixArray(matrix);
WriteLine($"Строка с минимальной суммой элементов: {NumberString}");


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)

{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
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
            Write($"{inMatrix[i, j]} ");
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

    
int GetSortMatrixArray(int [,] NewMatrix)

{
    int SumString = 0;
    int[] StringMatrix = new int[NewMatrix.GetLength(0)];
    for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            SumString += NewMatrix[i,j];
        }
        StringMatrix[i] = SumString;
    WriteLine($"Сумма элементов {i} строки равна {SumString}");
    SumString = 0;
    }
    
    int minString = StringMatrix[0];
    int minStringMatrix = 0;
    for (int i = 0; i < StringMatrix.Length; i++)
    {
        if(StringMatrix[i] < minString)
        {
            minString = StringMatrix[i];
            minStringMatrix = i;
        }
    }
    return minStringMatrix;
    
}    