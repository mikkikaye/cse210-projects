using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
   List<Entry> _entries; 

   public Journal()
   {
        _entries = new List<Entry>();
   }
   public void CreateJournalEntry()
   {
        PromptGenerator getPrompt = new PromptGenerator();
        string prompt= getPrompt.GetRandomPrompt();
        DateTime date = DateTime.Now;
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        string entryResponse = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry._prompt = prompt;
        newEntry._date = date;
        newEntry._response = entryResponse;
        _entries.Add(newEntry);
     //    Console.ReadLine();
        return;
   }
   public void DisplayJournal()
   {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.ReadLine();
   }
   public bool SavetoCSV()
   {
     // string myJournal = "myJournal.txt";
     // FileStream filestream = File.Create(myJournal);
     

     
     using (StreamWriter streamWriter = new StreamWriter("myJournal.txt"))
     {
          foreach (Entry entry in _entries)
          {
               string listEntries = entry.GetEntryAsCSV();
               streamWriter.WriteLine(listEntries);
          }
     }
     return true;

   } 
   public void LoadFromCSV()
   {
        List<Entry> entry = new List<Entry>();
        using (StreamReader reader = new StreamReader("myJournal.txt"))
        {
            string line = "a";
            while ((line = reader.ReadLine()) != null)
            {
               // Console.WriteLine(line);
                string[] fields = line.Split("|");
                string date = fields[0];
                DateTime _date = DateTime.Parse(date);
                string _prompt = fields[1];
                string _response = fields[2];
                Entry oldEntry = new Entry();
                oldEntry._prompt = _prompt;
                oldEntry._date = _date;
                oldEntry._response = _response;
                _entries.Add(oldEntry);
               //  Console.WriteLine();
            }
        }
   }
}

        