bool CheckValue(int Value)
{
    if (Value >= 100 && Value <= 999)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetSecondNumb(int Value)
{
    int result = Value / 10;
    return result % 10;
}

Console.WriteLine("Введите трехзначное число:");
int Value = Convert.ToInt32(Console.ReadLine());
if (CheckValue(Value) == true)
{
    Console.WriteLine(GetSecondNumb(Value));
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
};