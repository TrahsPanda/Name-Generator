using System;
using System.Globalization;

namespace NameGenerator
{
    class NameGenerator
    {
        public static Random random = new Random();
        public static TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public static string[] con = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        public static string[] vow = new string[] { "a", "e", "i", "o", "u" };
        public static int conLength = con.Length;
        public static int vowLength = vow.Length;
        public static void Main()
        {
            Console.WriteLine("Welcome to TrahsPanda's Random Name Generator!\nHow many names would you like to generate?");
            int namesToGenerate = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < namesToGenerate; i++)
            {
                int firstDecider = random.Next(11);
                int secondDecider = random.Next(11);
                if (firstDecider == 0) // CVCCVCC 
                {
                    int conIndex = random.Next(conLength); 
                    int vowIndex = random.Next(vowLength); 
                    int conIndex1 = random.Next(conLength); 
                    int conIndex2 = random.Next(conLength); 
                    int vowIndex1 = random.Next(vowLength); 
                    int conIndex3 = random.Next(conLength); 
                    int conIndex4 = random.Next(conLength); 
                    Console.Write(ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + con[conIndex4]));
                }
                else if (firstDecider == 1) // CVCVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex2 = random.Next(vowLength);
                    Console.Write(ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1] + con[conIndex2] + vow[vowIndex2]));
                }
                else if (firstDecider == 2) // CVCC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    Console.Write(ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2]));
                }
                
            }
        }
    }
}