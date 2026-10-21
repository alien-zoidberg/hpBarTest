/*
Write "What is you're max hp?"
console.readline for the response
tryparse the result (result must be between or equal to 1 and 20)
if faliure:
    that's not a number
if success:
    forloop (i = {result}; i >= 0; i--)
    {
    forloop (l = result; l > 0; l--)
    {
    console.write "=" 
    }
    console.writeline();
    }

*/

Console.WriteLine("What is you're max hp?");
int check;
while (true)
{
    string maxHp = Console.ReadLine();
    bool success = int.TryParse(maxHp, out check);

    if (success == false)
    {
        Console.WriteLine("That's not a number, please answer with an intiger.");
    }
    else if (check >= 1 && check <= 20)
    {
        break;
    }
    else
    {
        Console.WriteLine("That number is invalid.");
    }
}

int hpReduction = 0;
for (int i = check; i > 0; i--)
{
    Console.Write("[");
    for (int l = check - hpReduction; l > 0; l--)
    {
        Console.Write("=");
    }
    Console.Write("]");
    hpReduction++;
    Console.WriteLine();
}
Console.ReadLine();