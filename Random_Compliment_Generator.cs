```CSharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> compliments = new List<string>()
        {
            "You are an awesome friend.",
            "You are a gift to those around you.",
            "You are a smart cookie.",
            "You are amazing!",
            "You are really courageous.",
            "Your potential is limitless.",
            "You're more helpful than you realize.",
            "You have a great sense of humor.",
            "You've got all the right moves!",
            "Is that your picture next to 'charming' in the dictionary?"
        };

        Random random = new Random();
        int index = random.Next(compliments.Count);
        Console.WriteLine("Here is your compliment: " + compliments[index]);
    }
}
```