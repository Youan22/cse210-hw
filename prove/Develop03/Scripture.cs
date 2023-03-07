using System;
using System.Collections.Generic;

public class Scripture
{
    public string Reference { get; }
    private List<Word> words;
    private Random random;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        words = new List<Word>();
        random = new Random();

        // Split text into individual words
        string[] wordArray = text.Split(' ');

        // Add each word to the list of words
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public string GetRenderedText()
    {
        string renderedText = Reference + "\n\n";

        // Render each word, hiding some at random
        foreach (Word word in words)
        {
            if (word.IsHidden)
            {
                renderedText += "____ ";
            }
            else
            {
                renderedText += word.Text + " ";
            }
        }

        return renderedText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }

        return true;
    }

    public void HideWords()
    {
        // Choose a random number of words to hide
        int numWordsToHide = random.Next(1, words.Count / 2);

        // Choose random words to hide
        for (int i = 0; i < numWordsToHide; i++)
        {
            int randomIndex = random.Next(words.Count);
            words[randomIndex].Hide();
        }
    }
}
