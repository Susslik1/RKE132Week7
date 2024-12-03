
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();


PrintAnyWord(userInput); // userImput- argument


static void PrintAnyWord(string anyString) // anystring - parameeter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine (anyString);
    }
  
}
