using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Word word = new Word();
        
        Console.WriteLine(scripture.ScriptureReference());
        Console.WriteLine(scripture.ScriptureText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        Console.ReadLine();

        while (Console.ReadLine() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.ScriptureReference());
            Console.WriteLine(scripture.UpdatedScripture());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            Console.ReadLine();

        }
    }
}