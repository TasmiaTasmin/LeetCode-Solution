using System.Collections.Generic;

List<string> array = new List<string>();

for (int i=1; i<=15; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        const string fizzBuzz = "FizzBuzz";
        array.Add(fizzBuzz);
    }
    else if (i % 3 == 0)
    {
        const string fizz = "Fizz";
        array.Add(fizz);
    }
    else if (i % 5 == 0)
    {
        const string buzz = "Buzz";
        array.Add(buzz);
    }
    else
    {
        array.Add(i.ToString());
    }
}

string output = "[" + string.Join(",", array.Select(s => $"\"{s}\"")) + "]";
Console.WriteLine(output);

foreach (var item in array)
{
    Console.WriteLine(item);
}



