Console.Clear();
int[] array = new int[8];
int num = 0;
int count = array.Length;
for (int i = 0; i < count; i++)
    {
        array[i]= GetNumberFromUser($"Введите {i}-е число в массиве ","Ошибка ввода!");
    }   

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} , ");
    }
        Console.WriteLine();
}

PtintArray(array);   