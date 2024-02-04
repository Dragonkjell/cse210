using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // save the journal to a new file
    public void SaveToFile()
    {
        Console.WriteLine("Enter a file name to save your journal into");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry);
                }
            }
            Console.WriteLine($"Saved successfully to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void LoadFile(string filename)
    {
        try
        {
            // clear any existing entries before loading the file
            _entries.Clear();

            // open the file
            using (StreamReader fileReader = new StreamReader(filename))
            {
                string line;
                while ((line = fileReader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    // parse the date to be the specified format
                    DateTime date;
                    Entry entry = new Entry();
                    if (DateTime.TryParseExact(parts[0], "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out date))
                    {
                        entry._date = DateTime.Parse(parts[0]);
                        entry._prompt = parts[1];
                        entry._response = parts[2];
                    };
                    _entries.Add(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}