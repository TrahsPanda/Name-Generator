using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace NameGenerator
{
    class NameGenerator
    {
        string folderName = @"c:\";
        string pathString = @"c:\";
        string fileNameFirst = "FirstNames";

        public static Random random = new Random();
        public static TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public static string[] con = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        public static string[] vow = new string[] { "a", "e", "i", "o", "u" };
        public static int conLength = con.Length;
        public static int vowLength = vow.Length;
        public static async Task Main()
        {
            Console.WriteLine("Welcome to TrahsPanda's Random Name Generator!\nHow many names would you like to generate?");
            int namesToGenerate = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < namesToGenerate; i++)
            {
                int firstDecider = random.Next(6);
                int secondDecider = random.Next(4);

                // FIRST NAMES
                if (firstDecider == 0) // CVCCVCC 
                {
                    int conIndex = random.Next(conLength); 
                    int vowIndex = random.Next(vowLength); 
                    int conIndex1 = random.Next(conLength); 
                    int conIndex2 = random.Next(conLength); 
                    int vowIndex1 = random.Next(vowLength); 
                    int conIndex3 = random.Next(conLength); 
                    int conIndex4 = random.Next(conLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + con[conIndex4]);
                }
                else if (firstDecider == 1) // CVCVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex2 = random.Next(vowLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1] + con[conIndex2] + vow[vowIndex2]);
                }
                else if (firstDecider == 2) // CVCC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2]);
                }
                else if (firstDecider == 3) // CVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1]);
                }
                else if (firstDecider == 4) // VCV
                {
                    int vowIndex = random.Next(vowLength);
                    int conIndex = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    string name = ti.ToTitleCase(vow[vowIndex] + con[conIndex] + vow[vowIndex1]);
                }
                else if (firstDecider == 5) // C 2V CV
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1]);
                }
                Console.Write(" ");

                // LAST NAMES
                if (secondDecider == 0) // CVCCVCC 
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex3 = random.Next(conLength);
                    int conIndex4 = random.Next(conLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + con[conIndex4]);
                }
                else if (secondDecider == 1) // CVCVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex2 = random.Next(vowLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1] + con[conIndex2] + vow[vowIndex2]);
                }
                else if (secondDecider == 2) // CVCC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    string name = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2]);
                }
                else if (secondDecider == 3) // VCCVCV
                {
                    int vowIndex = random.Next(vowLength);
                    int conIndex = random.Next(conLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex3 = random.Next(conLength);
                    int vowIndex2 = random.Next(vowLength);
                    string name = ti.ToTitleCase(vow[vowIndex] + con[conIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + vow[vowIndex2]);
                }

            }
        }
    }
}