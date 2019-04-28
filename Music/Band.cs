﻿using System;
using System.Collections.Generic;

namespace Music
{
    public class Band : Entity
    {
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; } = new List<Song>();

        public void Print()
        {
            Console.WriteLine($"Title: {Name}");
            Console.WriteLine($"Number of songs: {Songs.Count}");
        }
    }
}