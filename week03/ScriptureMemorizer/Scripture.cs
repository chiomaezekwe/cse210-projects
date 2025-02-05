using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor to initialize the scripture with reference and text.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text into words.
        string[] wordArray = text.Split(' ');  
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a defined number of random words in the scripture displayed.
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(_words.Count);
            // check to ensure that the same word is not hidden multiple times (as a stretch challenge).
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
            else
            {
                i--;  // Retry if the word is already hidden.
            }
        }
    }

    // Method to get the display text of the scripture with hidden words.
    public string GetDisplayText()
    {
        string displayText = $"Scripture: {_reference.GetDisplayText()}\n";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.TrimEnd();
    }

    // Method to check if all words are hidden.
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
