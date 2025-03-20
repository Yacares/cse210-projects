class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

     public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date} - {entry._promptText}: {entry._entryText}");
        }
        Console.WriteLine();
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine($"Saving to file {file}...");
        using (StreamWriter outputFile = new StreamWriter (file))
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date} - {entry._promptText}: {entry._entryText}");
        }
    }

    public void LoadFromFile()
    {
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.csv");
        
        if (files.Length == 0)
        {
            Console.WriteLine("No files found.");
            return;
        }

        Console.WriteLine("Available files:");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
        }

        Console.Write("Select a file by number: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= files.Length)
        {
            string selectedFile = files[choice - 1];
            Console.WriteLine($"Loading {Path.GetFileName(selectedFile)}...");
            LoadFromFile(selectedFile);
        }
        else
        {
            Console.WriteLine("Invalid choice. Returning to menu.");
        }
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear(); 
        string[] lines = File.ReadAllLines(file);
        Console.WriteLine($"Loaded {lines.Length} lines from {Path.GetFileName(file)}.");

    foreach (string line in lines)
    {
        
        string[] parts = line.Split(new[] { " - " }, 2, StringSplitOptions.None);
        if (parts.Length == 2)
        {
            string date = parts[0];

            
            string[] promptParts = parts[1].Split(new[] { ": " }, 2, StringSplitOptions.None);
            if (promptParts.Length == 2)
            {
                string prompt = promptParts[0];
                string entryText = promptParts[1];

                Entry newEntry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = entryText
                };

                _entries.Add(newEntry);
            }
        }
    }

    Console.WriteLine($"Loaded {_entries.Count} entries into the journal.");
}
}