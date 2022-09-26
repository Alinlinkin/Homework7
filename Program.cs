int LineTwoDimensionalArray()
{
    Console.Write("Введите количество строк в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int line);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте написать число :) ");
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
        Console.WriteLine("Введено значение некорректного формата, попробуйте написать число :) ");
        return ColumnTwoDimensionalArray();
    }
    else
    {
        return column;
    }
}

int[,] MakeTwoDimensionalArray()
{
    int line = LineTwoDimensionalArray();
    int column = ColumnTwoDimensionalArray();
    int[,] array = new int[line, column];
    return array;
}

int RandomNumbersStart()
{

    Console.Write("Введите число, с которого начнется генерация рандомных цифр: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int start);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте написать число :) ");
        return RandomNumbersStart();
    }
    else
    {
        return start;
    }

}

int RandomNumbersEnd()
{
    Console.Write("Введите число, которым закончится генерация рандомных цифр: ");
    bool parseMIsOk = int.TryParse(Console.ReadLine(), out int finish);
    if (!parseMIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, попробуйте написать число :) ");
        return RandomNumbersEnd();
    }
    else
    {
        return finish;
    }
}

int[,] FillTwoDimensionalArray(int[,] array, int startRandom, int finishRandom)
{
    Random random = new Random();
    int startValue = startRandom;
    int endValue = finishRandom;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = random.Next(startValue, endValue);
        }
    }
    return array;
}

void WriteTwoDimensionalArray(int[,] array)
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

string ArithmeticMeanOfElements(int[,] array)
{
    string result = string.Empty;
    double count = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)

        {
            count = count + array[j, i];
        }

        count = count / array.GetLength(0);
        if (i == (array.GetLength(1) - 1)) result = result + count + ".";
        else result = result + count + "; ";
        count = 0;
    }
    return result;
}

int[,] array = MakeTwoDimensionalArray();
int startRandom = RandomNumbersStart();
int finishtRandom = RandomNumbersEnd();
array = FillTwoDimensionalArray(array, startRandom, finishtRandom);
WriteTwoDimensionalArray(array);
Console.WriteLine();
string result = ArithmeticMeanOfElements(array);
Console.WriteLine($"Среднее арифметическое каждого столбца : {result}");
