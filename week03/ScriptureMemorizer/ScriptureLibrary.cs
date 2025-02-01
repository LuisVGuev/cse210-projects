using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        LoadScriptures();
    }

    public void AddScripture(string reference, string text)
    {
        scriptures.Add(new Scripture(reference, text));
    }

    private void LoadScriptures()
    {
        scriptures.Add(new Scripture("John 3:16", "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));
        scriptures.Add(new Scripture("Psalm 23:1", "The Lord is my shepherd; I shall not want."));
        scriptures.Add(new Scripture("Philippians 4:13", "I can do all things through Christ who strengthens me."));
        scriptures.Add(new Scripture("Matthew 11:28", "Come unto me, all ye that labour and are heavy laden, and I will give you rest."));
    }

    public Scripture GetRandomScripture()
    {
        Random rand = new Random();
        int index = rand.Next(scriptures.Count);
        return scriptures[index];
    }
}
