using System;

namespace NameGenerator
{
    class NameGenerator
    {
        static Random random = new Random();
        static string[] con = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        static string[] conCap = new string[] { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
        static string[] vow = new string[] { "a", "e", "i", "o", "u" };
        static string[] vowCap = new string[] { "A", "E", "I", "O", "U" };

        static void Main()
        {
            Console.WriteLine("Welcome to TrahsPanda's Random Name Generator!\nHow many names would you like to generate?");
            int namesToGenerate = Int32.Parse(Console.ReadLine()); // Warning can be safetly ignored
            for (int i = 0; i < namesToGenerate; i++)
            {
                if (random.NextDouble() < 0.1) // Zachary format
                {
                    int conCapIndex = random.Next(conCap.Length); //Z
                    int vowIndex = random.Next(vow.Length); //a
                    int conIndex = random.Next(con.Length); //c
                    int conIndex1 = random.Next(con.Length); //h
                    int vowIndex1 = random.Next(vow.Length); //a
                    int conIndex2 = random.Next(con.Length); //r
                    int conIndex3 = random.Next(con.Length); //y
                    Console.WriteLine(conCap[conCapIndex] + vow[vowIndex] + con[conIndex] + con[conIndex1] + vow[vowIndex1] + con[conIndex2] + con[conIndex3]);
                }
            }
        }
    }
}