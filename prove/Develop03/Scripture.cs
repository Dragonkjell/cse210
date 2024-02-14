public class Scripture

{
    private string _scripture;

    Reference reference = new Reference();

    public string ScriptureReference()
    {
        return reference.GetReference();
    }
    public string ScriptureText()
    {
        return reference.GetText();
    }

    public void UpdateScripture(string UpdateScripture)
    {
        _scripture = UpdateScripture;
    }
}