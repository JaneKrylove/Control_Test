// Задача: 
// "Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа."

string[] array = { "hello", "2", "world", ":-)", "1234", "1567"};

string PrintArray(string[] array)  
{
    return string.Join(",", array);
}

int CountStringArray(string[] input)
{
    int size = array.Length;
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= maxLengthString)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] myArray, int countWords)
{
    int size = myArray.Length;
    string[] finalArray = new string[countWords];
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < size; i++)
    {
        if (myArray[i].Length <= maxLengthString)
        {
            finalArray[count] = myArray[i];
            count++;
        }
    }
    return finalArray;
}

