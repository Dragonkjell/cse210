using System.Runtime.CompilerServices;
// using System.Linq;

public class Word
{
    public string WordText { get; set; }
    public bool IsHidden { get; set; }
    private string _words;
    private List<string> _removedWords;

    Reference reference = new Reference();
    Scripture scripture = new Scripture();
}