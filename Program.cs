int[,] ChangeArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) 
    {
        Console.WriteLine("Ошибка: невозможно заменить строки на столбцы. Введите одинаковое число строк и столбцов");
        return array;
    }
    else
    {
        int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[i, j] = array[j, i];
            }
        }
        return newArray;
    }
}

