string StringWriteInConsole(string msg)
{
    Console.Write(msg);
    string text = Console.ReadLine();
    return text;
}
int NumberWriteInConsole(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
string[] ArrayStringCreate (int arrayLenght)
{
    string[] array = new string[arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        array[i] = StringWriteInConsole($"Введите значиние для элемента массива №{i+1}:    ");
    }
    return array;
}
string[] ArrayStringModificate(string[] array)
{
    int count = 0;
    int limitLength = 4;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < limitLength) count++;
    }
    string[] resultArray = new string[1];
    if (count > 0)
    {
        resultArray = new string[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < limitLength) 
            {
                resultArray[count] = array[i];
                count++;
            }
        }
    }
    else
    {
        resultArray[0] = "Элементы, соответсвующие критериям отбора, отсутствуют";
    }
    return resultArray;
}
void ArraiStringPrint(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}.  {array[i]}");
    }
}
Console.WriteLine("Решение контрольной работы");
Console.WriteLine();
int arrayLength = NumberWriteInConsole("Введите желаемое количество элементов массива:   ");
Console.WriteLine();
string[] arrayStart = ArrayStringCreate(arrayLength);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
ArraiStringPrint(arrayStart);
Console.WriteLine();
string[] arrayFinish = ArrayStringModificate(arrayStart);
Console.WriteLine("Окончательный массив:");
ArraiStringPrint(arrayFinish);
