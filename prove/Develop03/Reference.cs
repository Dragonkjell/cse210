using System.Dynamic;

public class Reference
{
    public string Book { get; set; }
    public string Chapter { get; set; }
    public string Verse { get; set; }


    public Reference()
    {
        Book = "2 Nephi";
        Chapter = "2:23-25";
        Verse = "And they would have had no children; wherefore they would have remained in a state of innocence, having no joy, for they knew no misery; doing no good, for they knew no sin.\nBut behold, all things have been done in the wisdom of him who knoweth all things.\nAdam fell that men might be; and men are, that they might have joy.";
    }

    public string GetReference()
    {
        return $"{Book} {Chapter}";
    }

    public string GetText() 
    {
        return $"{Verse}";
    }
}