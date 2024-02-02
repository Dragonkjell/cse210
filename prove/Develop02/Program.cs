using System;

class Program
{
    static void Main(string[] args)
            
    {
        // create a journal instance
        Journal journal = new Journal();

        string userChoice = "";
        while (userChoice != "6")
        {
            Console.WriteLine("JOURNAL");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Add New Entry\n6. Quit");
        
            // read the entered number
            userChoice = Console.ReadLine();

            switch(userChoice)
            {
                    // write
                case "1":
                // give a prompt and save the response
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                // add the entry
                Entry entry = new Entry();
                entry._prompt = prompt;
                entry._response = response;
                entry._date = DateTime.Now;

                // add into the journal
                journal._entries.Add(entry);
                break;

                    // display
                case "2":
                foreach (Entry singleEntry in journal._entries)
                {
                Console.WriteLine($"Date: {singleEntry._date} Prompt: {singleEntry._prompt}\nResponse: {singleEntry._response}\n");
                }
                break;

                    // save
                case "3":
                journal.SaveToFile();
                break;

                    // load
                case "4":
                Console.WriteLine("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFile(filename);
                break;

                    // add new
                case "5":
                break;
            }
        }
    }


}