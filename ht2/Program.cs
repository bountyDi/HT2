int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task10()
{
    int number = Input("enter a 3-digit number");
    int s_digit = number/10%10;
    Console.WriteLine(s_digit);
}

void Task13()
{
    int Promt(string message)
    {
        Console.Write(message);
        string value = Console.ReadLine();
        int result = Convert.ToInt32(value);
        return result;
    }
    int GetThirdRank(int number)
    {
        while (number>999)
        {
            number /= 10;
        }
        return number % 10;
    }
    bool ValidateNumber(int number)
    {
        if (number < 100)
        {
            Console.WriteLine("third digit doesn't exist");
            return false;
        }
        return true;
    }
    int number = Promt("Enter a number > ");
    if (ValidateNumber(number))
    {
        Console.WriteLine(GetThirdRank(number));
    }
}

void Task15()
{
    int number = Input("enter a day of the week number");
    if (number>=6)
    {
        Console.WriteLine("yes");
    }
    else 
    {
        Console.WriteLine("no");
    }
}
Task15();
