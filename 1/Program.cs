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

int toThePower(int a, int b)
{   
    int tempA = a;
    for (int i = 1; i < b; i++)
    {
        a = a*tempA; 
    }
    return a;
}

int A = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int B = GetNumberFromUser("Введите целое число B: ","Ошибка ввода!");

Console.WriteLine($"{A} в степени {B} = {toThePower(A, B)}");