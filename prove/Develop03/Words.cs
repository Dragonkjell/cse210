using System.Runtime.CompilerServices;
using System.Linq;

public class Words
{
    private string _words;
    private List<string> _removedWords;


    Reference reference = new Reference();
    Scripture scripture = new Scripture();

    public string GetReference()
    {
        return reference.GetReference();
    }

    public Words(string words)
    {
        _words = words;
        _removedWords = new List<string>();
    }

    public void RemoveWords()
    {
        Random random = new Random();

        int wordsRemovedIndex = random.Next(2, 6); // random number between 2 and 5

        string[] words = _words.Split(' ');

        List<int> indexToRemove = Enumerable.Range(0, words.Length).OrderBy(x => random.Next()).Take(wordsRemovedIndex).ToList();

        foreach (int index in indexToRemove)
        {
            _removedWords.Add(words[index]);
            words[index] = new string('_', words[index].Length);
        }

    }
    public string GetUpdatedWords()
    {
        return string.Join(" ", _words);
    }

    public int WordCount()
    {
        return _words.Split(' ').Length;
    }

    public void PrintNewWords()
    {
        Console.WriteLine(_words);
    }    
}