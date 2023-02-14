bool CheckValue(int Value)
{
    if (Value >= 100)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetThirdNumb(int Value)
{
    while (Value > 999)
    {
        Value /= 10;
    }
    return Value % 10;
}

Console.WriteLine("Введите  число:");
int Value = Convert.ToInt32(Console.ReadLine());
if (CheckValue(Value) == true)
{
    Console.WriteLine(GetThirdNumb(Value));

}
else
{
    Console.WriteLine("Третьей цифры нет");
};
