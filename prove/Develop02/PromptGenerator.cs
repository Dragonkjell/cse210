using System;

public class PromptGenerator
{
 public List<string> _prompt = new List<string>()
{
    "What am I grateful for today?",
    "What are three things I did well today?",
    "What are my top priorities for the week ahead?",
    "Reflect on a mistake I made recently and what I learned from it.",
    "If I had one thing I could do over today, what would it be?",
    "What are three things I can do to take care of myself today?"
 };
//  public string []_prompt = new string[]
//  {
//     "What am I grateful for today?",
//     "What are three things I did well today?",
//     "What are my top priorities for the week ahead?",
//     "Reflect on a mistake I made recently and what I learned from it.",
//     "If I had one thing I could do over today, what would it be?",
//     "What are three things I can do to take care of myself today?"
//  };

 public string GetPrompt()
 {
    Random randomNumber = new Random();
    int promptIndex = randomNumber.Next(_prompt.Count);
    return _prompt[promptIndex];
 }
}