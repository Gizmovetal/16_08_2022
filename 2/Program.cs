Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
Console.WriteLine("сумма цифр в числе А");
Console.WriteLine($"\t{num} -> {GetSumDigits(num)}");
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

// Возвращает сумму цифр в числе number добавил обработку отрицательных чисел
int GetSumDigits(int number)
{
    if (number>0)
    {
        int sum = 0;
        while(number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    else
    {
        int sum = 0;
        while(number < 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}