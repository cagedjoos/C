public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}:");
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.GetDisplayText().Length) + " ");
            }
            else
            {
                Console.Write(word.GetDisplayText() + " ");
            }
        }
    }

    public bool HideRandomWord()
    {
        List<Word> unhidden = IsHidden();
        if (unhidden.Count < 2)
            return false;

        Random random = new Random();
        int randomIndex1 = random.Next(unhidden.Count);
        int randomIndex2;

        do
        {
            randomIndex2 = random.Next(unhidden.Count);
        }

        while (randomIndex1 == randomIndex2);

        unhidden[randomIndex1].Hide();
        unhidden[randomIndex2].Hide();
        return true;
    }

    private List<Word> IsHidden()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }
        return visibleWords;

    }

}
