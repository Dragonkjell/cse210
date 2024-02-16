using System.Text;
using System.Linq;

public class Scripture

{
    private List<Word> _words = new List<Word>();

    Reference reference = new Reference();

    public string ScriptureReference()
    {
        return reference.GetReference();
    }

    //constructor for no arguments
    public string ScriptureText()
    {
        string verse = "And they would have had no children; wherefore they would have remained in a state of innocence, having no joy, for they knew no misery; doing no good, for they knew no sin.\nBut behold, all things have been done in the wisdom of him who knoweth all things.\nAdam fell that men might be; and men are, that they might have joy.";

        string[] words = verse.Split(" ");

        foreach (string wordOfVerse in words)
        {
            Word word = new Word();
            word.WordText = wordOfVerse;
            word.IsHidden = false;

            _words.Add(word);
        }

        return verse;
    }

    //constructor with one arguement
    public string ScriptureText(string passedVerse)
    {
        string verse = passedVerse;

        string[] words = verse.Split(" ");

        foreach (string wordOfVerse in words)
        {
            Word word = new Word();
            word.WordText = wordOfVerse;
            word.IsHidden = false;

            _words.Add(word);
        }

        return verse;
    }

    // method for updating the scripture
    public string UpdatedScripture()
    { 
        Random random = new Random();

        // filter out the hidden words
        List<Word> notHidden = _words.Where(word => !word.IsHidden).ToList();

        // select a random number of words
        int indexCount = random.Next(3, 6);

        for (int i = 0; i < indexCount; i++)
        {
            // select a random word at a random index
            int index = random.Next(notHidden.Count);

            notHidden[index].IsHidden = true;
        }

        // concatenate the words into a string
        StringBuilder updatedScripture = new StringBuilder();

        foreach (Word word in _words)
        {
            if (word.IsHidden)
            {
                updatedScripture.Append(new string('_', word.WordText.Length) + " "); 
            }

            else
            {
                updatedScripture.Append(word.WordText + " ");
            }
            
        }
        return updatedScripture.ToString();
    }

    public bool IsCompletelyHidden()
    {
        if (_words.All(word => word.IsHidden == true))
        {
            return true;
        }

        return false;
    }
}