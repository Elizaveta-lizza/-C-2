bool CheckDay(int Day)
{
    if (Day >= 1 && Day <= 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool CheckDayOff(int Day)
{
    if (Day >= 6 && Day <= 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите  день недели:");
int Day = Convert.ToInt32(Console.ReadLine());
if (CheckDay(Day) == true)
{
    if (CheckDayOff(Day) == true)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введен не день недели");
};

