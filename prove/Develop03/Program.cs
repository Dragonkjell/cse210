using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Word word = new Word();
        Reference reference = new Reference();
        
        Console.Write("Would you like to [1] use the default scripture or [2} enter your own?");
        string choice = Console.ReadLine();
        int choiceInt = int.Parse(choice);

        if (choiceInt == 2)
        {
            Console.Write("Enter the book of the scripture: ");
            string book = Console.ReadLine();
            reference.Book = book;

            Console.Write("Enter the chapter of the scripture: ");
            string chapter = Console.ReadLine();
            reference.Chapter = chapter;

            Console.Write("Enter the verse of the scripture: ");
            string verse = Console.ReadLine();
            reference.Verse = verse;

            Console.Write("Enter the text of the verse: ");
            string verseText = Console.ReadLine();
            scripture.ScriptureText(verseText);

            Console.Clear();
            Console.WriteLine(scripture.ScriptureReference(reference.Book, reference.Chapter, reference.Verse));
            Console.WriteLine(scripture.ScriptureText(verseText));
            Console.WriteLine(scripture.UpdatedScripture());

        }
        else
        {
            Console.Clear();
            Console.WriteLine(scripture.ScriptureReference());
            Console.WriteLine(scripture.UpdatedScripture());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        }


        while (true)
        {
            if (Console.ReadLine() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.Clear();

            Console.WriteLine(scripture.ScriptureReference(reference.Book, reference.Chapter, reference.Verse));
            Console.WriteLine(scripture.UpdatedScripture());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        }
    }
}