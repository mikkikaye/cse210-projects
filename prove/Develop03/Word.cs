using System;
using System.Collections.Generic;

public class Word
{
    private bool _shown;
    private string _word;

    public Word(string word)
    {
        _shown = true;
        _word = word;
    } 
    public string GetWord()
    {
        return _word;

    }
    public bool GetShown()
    {
        return _shown;
    }
    public void SetShown(bool status)
    {
        _shown = status;
    }
}