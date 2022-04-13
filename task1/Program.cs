// 1. Сумма элементов матрицы

void FillArray(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(1, 10);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)

            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumArrayElements(int[,] arr)
{
    int totalSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            totalSum += arr[i, j];
        }
    }
    return totalSum;
}

int n = 4, m = 4;    //Размер массива
int minArrayElement = 1, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);

Console.WriteLine($"Сумма элементов матрицы {SumArrayElements(array)}");



// 2. Произведение элементов матрицы



int MultArrayElements(int[,] arr)
{
    int totalMult = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            totalMult *= arr[i, j];
        }
    }
    return totalMult;
}


Console.WriteLine($"Произведение элементов матрицы: {MultArrayElements(array)}");




// 3. Максимальный элемент матрицы



int MaxArrayElements(int[,] arr)
{
    int maxEl = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > maxEl) maxEl = arr[i, j];
        }
    }
    return maxEl;
}


Console.WriteLine($"Максимальный элемент: {MaxArrayElements(array)}");




// 4. Минимальный элемент матрицы



int MinArrayElements(int[,] arr)
{
    int minEl = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minEl) minEl = arr[i, j];
        }
    }
    return minEl;
}


Console.WriteLine($"Минимальный элимент матрицы: {MinArrayElements(array)}");



// 5. Сумма элементов главной диагонали матрицы



int SumArrayMainDiagonal(int[,] arr)
{
    int sumDiagonal = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumDiagonal += arr[i, i];
    }
    return sumDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Сумма элементов главной диагонали: {SumArrayMainDiagonal(array)}");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");



// 6. Произведение элементов главной диагонали матрицы



int MultArrayMainDiagonal(int[,] arr)
{
    int multDiagonal = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        multDiagonal *= arr[i, i];
    }
    return multDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Произведение элементов диагонали матрицы: {MultArrayMainDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");


// 7. Максимальный элемент, расположенный на главной диагонали матрицы



int MaxElArrayMainDiagonal(int[,] arr)
{
    int maxElDiagonal = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i, i] > maxElDiagonal) maxElDiagonal = arr[i, i];
    }
    return maxElDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Максимальный элемент диагонали: {MaxElArrayMainDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");



// 8. Минимальный элемент, расположенный на главной диагонали матрицы


int MinElArrayMainDiagonal(int[,] arr)
{
    int minElDiagonal = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i, i] < minElDiagonal) minElDiagonal = arr[i, i];
    }
    return minElDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Минимальный элемент матрицы {MinElArrayMainDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");



// 9. Сумма элементов побочной диагонали матрицы



int SumArrayMinorDiagonal(int[,] arr)
{
    int sumMinorDiagonal = 0;
    int maxIndex = arr.GetLength(0) - 1;
    for (int i = maxIndex; i >= 0; i--)
    {
        sumMinorDiagonal += arr[i, maxIndex - i];
    }
    return sumMinorDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Сумма побочной диагонали матрицы: {SumArrayMinorDiagonal(array)}");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");


// 10. Произведение элементов побочной диагонали матрицы



int MultArrayMinorDiagonal(int[,] arr)
{
    int multMinorDiagonal = 1;
    int maxIndex = arr.GetLength(0) - 1;

    for (int i = maxIndex; i >= 0; i--)
    {
        multMinorDiagonal *= arr[i, maxIndex - i];
    }
    return multMinorDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Произведение побочной диагонали матрицы: {MultArrayMinorDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");


// 11. Максимальный элемент, расположенный на побочной диагонали матрицы



int MaxElArrayMinorDiagonal(int[,] arr)
{
    int maxIndex = arr.GetLength(0) - 1;
    int maxElMinorDiagonal = arr[maxIndex, 0];

    for (int i = maxIndex; i >= 0; i--)
    {
        if (arr[i, maxIndex - i] > maxElMinorDiagonal) maxElMinorDiagonal = arr[i, maxIndex - i];
    }
    return maxElMinorDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"Максимальный элемент побочной диагонали: {MaxElArrayMinorDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");


// 12. Минимальный элемент, расположенный на побочной диагонали матрицы



int MinElArrayMinorDiagonal(int[,] arr)
{
    int maxIndex = arr.GetLength(0) - 1;
    int minElMinorDiagonal = arr[maxIndex, 0];

    for (int i = maxIndex; i >= 0; i--)
    {
        if (arr[i, maxIndex - i] < minElMinorDiagonal) minElMinorDiagonal = arr[i, maxIndex - i];
    }
    return minElMinorDiagonal;
}


if (array.GetLength(0) == array.GetLength(1))
    Console.WriteLine($"минимальный элемент матрицы {MinElArrayMinorDiagonal(array)}.");
else
    Console.WriteLine($"Матрица [{array.GetLength(0)}, {array.GetLength(1)}] не квадратная.");


// 13. Поиска минимального из максимальных элементов матрицы, то есть найти максимальный элемент в каждой из строк матрицы и из них выбрать минимальный



int MinFromMaxRowArray(int[,] arr)
{
    int minMax = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int maxRow = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
            if (arr[i, j] > maxRow) maxRow = arr[i, j];
        if (i == 0) minMax = maxRow;
        else
        {
            if (minMax > maxRow) minMax = maxRow;
        }
    }
    return minMax;
}


Console.WriteLine($"Минимальный из максимальных элементов: {MinFromMaxRowArray(array)}.");


// 14. Транспонирование для квадратной матрицы, то есть переворот матрицы относительно главной диагонали



int[,] ArrayTransposition(int[,] arr)
{
    int[,] arrTrans = new int[arr.GetLength(1), arr.GetLength(0)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            arrTrans[j, i] = arr[i, j];
    }
    return arrTrans;
}

Console.WriteLine($"Перевернутая матрица:");
PrintArray(ArrayTransposition(array));


// 15. Сумма двух матриц одинаковых размерностей.



int[,] SumTwoArrays(int[,] arr1, int[,] arr2)
{
    int[,] sumArr = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < sumArr.GetLength(0); i++)
        for (int j = 0; j < sumArr.GetLength(1); j++)
            sumArr[i, j] = arr1[i, j] + arr2[i, j];
    return sumArr;
}


int[,] array1 = new int[n, m];
int[,] array2 = new int[n, m];

FillArray(array1, minArrayElement, maxArrayElement);
FillArray(array2, minArrayElement, maxArrayElement);

Console.WriteLine("Данная матрица 1: ");
PrintArray(array1);
Console.WriteLine("Данная матрица 2: ");
PrintArray(array2);

Console.WriteLine("Сумма 2 матриц: ");
PrintArray(SumTwoArrays(array1, array2));

// 16. Печать матрицы на экран

Console.WriteLine("Данная матрица: ");
PrintArray(array);