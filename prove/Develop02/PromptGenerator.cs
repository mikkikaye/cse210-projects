using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("Did something fun happen today?");
        _prompts.Add("Did anything funny happen today?");
        _prompts.Add("Did you go on a trip recently?");
        _prompts.Add("Describe what your job entailed today.");
        _prompts.Add("Did you have a spiritual experience/prompting today?");
    }
    public string GetRandomPrompt()
    {

        Random random = new Random();
        int numberPrompts = random.Next(_prompts.Count);
        string randomPrompt = _prompts[numberPrompts];

        // Console.WriteLine(randomPrompt);
        return randomPrompt;

    }
}