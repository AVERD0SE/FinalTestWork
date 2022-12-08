// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.



string[] inputArray = new string[] {"1234", "1567", "-2", "computer science"};
string[] resultArray = new string[inputArray.Length];
void stringTrimmingMethod(string[] inputArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
    if(inputArray[i].Length <= 3)
        {
        resultArray[count] = inputArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
stringTrimmingMethod(inputArray, resultArray);
PrintArray(resultArray);
