using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            Word wordToHide = _words[randomIndex];

            if (!wordToHide.IsHidden()) // Only hide words that are visible
            {
                wordToHide.Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " "; // Display the reference
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; // Display words or underscores
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // If any word is visible, return false
            }
        }
        return true; // All words are hidden
    }
}
