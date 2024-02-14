using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Words words = new Words(scripture.ScriptureText());
        
        Console.WriteLine(scripture.ScriptureReference());
        Console.WriteLine(scripture.ScriptureText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        Console.ReadLine();

        while (words.WordCount() > 0 && Console.ReadLine() != "quit")
        {

            Console.Clear();

            words.RemoveWords();
            scripture.UpdateScripture(words.GetUpdatedWords());

            Console.WriteLine(scripture.ScriptureReference());
            words.RemoveWords();
            words.PrintNewWords();
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            Console.ReadLine();
        }
    }
}