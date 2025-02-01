using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> _words;

    public List<Word> Words => _words;  // Public property to access the words list

    public Scripture(string referenceText, string scriptureText)
    {
        ScriptureReference = new Reference(referenceText);
        _words = scriptureText.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(ScriptureReference);
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        var unhiddenWords = _words.Where(w => !w.IsHidden).ToList();
        if (unhiddenWords.Any())
        {
            Random rand = new Random();
            int index = rand.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
        }
    }

    public bool IsFullyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
