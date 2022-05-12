ShowStartMessage();

Console.Write("Please enter a value (X to end):");
double total = 0, lowest = 0, highest = 0, mean;
int count = 0;
string? answer;
bool isFirstTime = true;
while((answer = Console.ReadLine()) != "X")
{
    bool isDouble = Double.TryParse(answer, out double value);
    if (isDouble)
    {
        total += value;
        if (isFirstTime)
        {
            lowest = value;
            highest = value;
            isFirstTime = false;
        }
        else
        {
            DetermineLowestAndHighest(value, ref lowest, ref highest);
        }
        count++;
    }
    else
    {
        Console.WriteLine("Please enter a number or X to end.");
    }
    Console.Write("Please enter a value (X to end):");
}
if(count > 0)
{
    mean = total / count;
    Console.WriteLine($"The total is {total}. The lowest value is {lowest}.");
    Console.WriteLine($"The highest value is {highest}. The mean is {mean}.");
}
else
{
    Console.WriteLine("No values were entered.");
}

static void ShowStartMessage()
{
    Console.WriteLine("This program reads a set of values and then displays the");
    Console.WriteLine("total, the lowest value, the highest value, and the mean.");
}

static void DetermineLowestAndHighest(double value, ref double lowest, ref double highest)
{
    if (value < lowest)
    {
        lowest = value;
    }
    if (value > highest)
    {
        highest = value;
    }
}
