using System.Collections.Concurrent;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

public class Reference
{
    public string Book { get; set; }
    public string Chapter { get; set; }
    public string Verse { get; set; }
    public string EndingVerse { get; set; }


    public Reference()
    {
        Book = "2 Nephi";
        Chapter = "2";
        Verse = "23";
        EndingVerse = "25";
    }

    public Reference(string book, string chapter, string verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public string GetReference()
    {
        return $"{Book} {Chapter} {Verse}";
    }

    public string GetReference(string Book, string Chapter, string Verse)
    {
        return $"{Book} {Chapter} {Verse}";
    }

}