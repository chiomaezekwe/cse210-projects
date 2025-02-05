using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor, initializing the word.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Method to hide the word (by replacing the word with underscores).
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word (restore the words to its original form).
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text of the word, either the word itself or underscores.
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}