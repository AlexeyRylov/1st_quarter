int CalcOutSize(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3) { count += 1; }
    }
    return count;
}

string[] FillingResultArray(string[] inArray, string[] outArray)
{
    int j = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            outArray[j] = inArray[i];
            j++;
        }
    }
    return outArray;
}

void PrintArray(string[] outString)
{
    for (int i = 0; i < outString.Length; i++)
    {
        Console.Write(outString[i] + "\t");
    }
}

Console.WriteLine("Введите строки, разделите их пробелами: ");
string initString = Console.ReadLine();
string[] initSplit = initString.Split(' ');

int sizeOut = CalcOutSize(initSplit);

string[] outString = new string[sizeOut];
outString = FillingResultArray(initSplit, outString);

PrintArray(outString);


