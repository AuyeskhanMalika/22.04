using System;
using System.Collections.Generic;

namespace Music
{

    public class Song : Entity
    {
        public string Name { get; set; }
        public long DurationSeconds { get; set; }
        public int Rating { get; set; }
        public Band Band { get; set; }
        public ICollection<string> Words { get; set; } = new List<string>();
    
        public void Print()
        {
            Console.WriteLine($"Title: {Name}");
            long mins, seconds;
            mins = DurationSeconds / 60;
            seconds = DurationSeconds % 60;
            Console.WriteLine($"Duration: {mins}:{seconds}");
            Console.WriteLine($"Rating: {Rating}");
            Console.WriteLine($"Executor: {Band.Name}");
            Console.WriteLine($"Words: ");
            foreach (var word in Words)
            {
                Console.Write(word + " ");
            }
        }
    }
}