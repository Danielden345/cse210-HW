using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

public class PromptGenerator()
{
    List<string> _prompts = new List<string>{
        "What have I learned today?",
        "How have I seen the hand of God in my life today?",
        "What am I grateful for?",
        "Who did I talk to today?",
        "What helped me today?",
        "What could I improve?",
        "How did I serve others today?",
        "If I could do today over, what would I change?"
    };

    public string GeneratePrompt()
    {
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }
}