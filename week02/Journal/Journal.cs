using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries { get; set; }

    public Journal()
    {
        // Constructor
        _entries = new List<Entry>();    }

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

        foreach (var entry in _entries)
        {
            entry.Display();
        }

    }

    public void SaveToFile(string file)
    {
        
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
        
    }

    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
            foreach (var line in File.ReadLines(file))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2]) { _date = parts[0] });
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }
    }
        
}