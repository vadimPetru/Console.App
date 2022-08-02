
bool word = true;
do
{
    if (int.TryParse(Console.ReadLine(), out var number))
    {
        Console.Write($"{number}");
        word = false;
    }
} while (word);

 
    



