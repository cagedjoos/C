using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        _entries.Clear();

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entryText = parts[2];

            entry._date = date;
            entry._promptText = prompt;
            entry._entryText = entryText;

            AddEntry(entry);
        }
    }

}
