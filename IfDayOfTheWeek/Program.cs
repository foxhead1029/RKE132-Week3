
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

Console.WriteLine(weekDay);

if (weekDay == 0)
{
    Console.WriteLine("It's Sunday");
}
else if (weekDay == 1)
{
    Console.WriteLine("It's Monday");
}
else if (weekDay == 2)
{
    Console.WriteLine("It's Tuesday");
}
else if (weekDay == 3)
{
    Console.WriteLine("It's Wednsday");
}
else if (weekDay == 4)
{
    Console.WriteLine("Its Thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("It's Friday");
}
else
{
    Console.Write("It's Saturday");
}