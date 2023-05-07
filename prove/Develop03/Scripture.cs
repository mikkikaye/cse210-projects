using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _scriptureWords;
    private Reference _reference;

    public Scripture(Reference reference, string scriptureWords)
    {
        _scriptureWords = new List<Word>();
        CreateWords(scriptureWords);
        _reference = reference;
    }
    private void CreateWords(string scriptureWords)
    {
        string[] words = scriptureWords.Split(' ');

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _scriptureWords.Add(newWord);
        }
    }
    public void DisplayScripture()
    {
        
        
        string output = _reference.DisplayReference();
        foreach (Word word in _scriptureWords)
        {
            if (word.GetShown())
            {
                output += word.GetWord();
                output += " ";
            }
            else
            {
                output += new string('\x5f', word.GetWord().Count());
                output += " ";
            }

        }
        Console.Clear();
        Console.WriteLine(output);

    }
    public void RemoveWord()
    {
        int index = 0;
        bool wasShown;
        do 
            {
            Random randomWord = new Random();
            index = randomWord.Next(_scriptureWords.Count);
            wasShown = _scriptureWords[index].GetShown();
            _scriptureWords[index].SetShown(false);  
            if (HasWordsLeft() == false)
            {
                foreach( Word word in _scriptureWords)
                {
                    word.SetShown(true);
                }
            }
            } while (wasShown == false);
    }
    public bool HasWordsLeft()
    {
        foreach (Word word in _scriptureWords)
        {
           if (word.GetShown())
            {
                return true;
            }
        }
        return false;
    }
    // public void LoadFromTXT()
    // {
    //     using (StreamReader reader = new StreamReader("lds-scriptures.txt"))
    //     {
            
    //     }
    // }
}