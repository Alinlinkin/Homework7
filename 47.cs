double[,] FillTwoDimensionalArray(double[,] array, int startRandom, int finishRandom)
{
    Random random = new Random();
    int startValue = startRandom;
    int endValue = finishRandom;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = Math.Round((random.Next(startValue, endValue) - random.NextDouble()), 2, MidpointRounding.ToZero);
        }
    }
    return array;
}

void WriteTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int LineTwoDimensionalArray()
{
    Console.Write("Введите количество строк в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int line);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте число цифрами :) ");
        return LineTwoDimensionalArray();
    }
    else
    {
        return line;
    }
}

int ColumnTwoDimensionalArray()
{
    Console.Write("Введите количество столбцов в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int column);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте число цифрами :) ");
        return ColumnTwoDimensionalArray();
    }
    else
    {
        return column;
    }
}

double[,] MakeTwoDimensionalArray()
{
    int line = LineTwoDimensionalArray();
    int column = ColumnTwoDimensionalArray();
    double[,] array = new double[line, column];
    return array;
}

int RandomNumbersStart()
{

    Console.Write("Введите число, с которого начнется генерация рандомных чисел: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int start);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте число цифрами :)");
        return RandomNumbersStart();
    }
    else
    {
        return start;
    }

}

int RandomNumbersEnd()
{
    Console.Write("Введите число, которым закончится генерация рандомных чисел: ");
    bool parseMIsOk = int.TryParse(Console.ReadLine(), out int finish);
    if (!parseMIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте число цифрами :)");
        return RandomNumbersEnd();
    }
    else
    {
        return finish;
    }
}

double[,] array = MakeTwoDimensionalArray();
int startRandom = RandomNumbersStart();
int finishtRandom = RandomNumbersEnd();
array = FillTwoDimensionalArray(array, startRandom, finishtRandom);
WriteTwoDimensionalArray(array);
