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
     string myJournal = "myJournal.txt";
     FileStream filestream = File.Create(myJournal);
     

     
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
   public static List<Entry> LoadFromCSV(string filePath)
   {
        List<Entry> entry = new List<Entry>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split("|");
                string _date = fields[0];
                string _prompt = fields[1];
                string _response = fields[2];
            }
        }
    return entry;
   }
}

        