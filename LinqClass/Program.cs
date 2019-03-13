using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song> () ;
            var allSongs = new List<Song> ();

            var funSong = new Song("Imagine Dragons", "Bleeding Out");

            allSongs.Add(funSong);
            allSongs.Add(new Song("Imagine Dragons", "Fire"));
            allSongs.Add(new Song("Imagine Dragons", "Whatever It Takes"));
            allSongs.Add(new Song("Imagine Dragons", "Friction"));
            allSongs.Add(new Song("Imagine Dragons", "Amsterdam"));
            allSongs.Add(new Song("Imagine Dragons", "Shots"));
            allSongs.Add(new Song("Imagine Dragons", "Believer"));
            allSongs.Add(new Song("Imagine Dragons", "Demons"));
            allSongs.Add(new Song("Imagine Dragons", "Walking The Wire"));
            allSongs.Add(new Song("Imagine Dragons", "Radioactive"));
            allSongs.Add(new Song("Imagine Dragons", "It's Time"));
            allSongs.Add(new Song("Imagine Dragons", "Is It Time?"));
            allSongs.Add(new Song("Imagine Dragons", "It Is Time"));
            allSongs.Add(new Song("Elton John", "Tiny Dancer"));

            goodSongs = (from Song in allSongs
                        where Song.Artist != "Imagine Dragons"
                        select Song).ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
            Console.ReadLine();

        }
    }
}
