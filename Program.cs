using System.Globalization;
using System.Diagnostics;

namespace NameGenerator
{
    class NameGenerator
    {
        public static Stopwatch watch = new Stopwatch();

        public static Random random = new Random();
        public static TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        public static string[] con = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        public static string[] vow = new string[] { "a", "e", "i", "o", "u" };
        public static int conLength = con.Length;
        public static int vowLength = vow.Length;
        public static string? firstName;
        public static string? lastName;

        public static string path1 = @"c:\tmp\FirstNames.txt";
        public static string path2 = @"c:\tmp\LastNames.txt";

        // Creates a FirstNames.txt and LastNames.txt if not already existing
        public static void Create()
        {
            if (!File.Exists(path1))
            {
                using (StreamWriter sw = File.CreateText(path1)) { }
            }
            if (!File.Exists(path2))
            {
                using (StreamWriter sw = File.CreateText(path2)) { }
            }
        }

        public static void Main()
        {
            Create();
            Console.WriteLine("Welcome to TrahsPanda's Random Name Generator!\nHow many names would you like to generate?");
            int namesToGenerate = Convert.ToInt32(Console.ReadLine());
            int namesGoal = 0;
            Console.Clear();
            Console.WriteLine("Please wait...");
            for (int i = 0; i < namesToGenerate; i++)
            {
                watch.Start();
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
                    firstName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + con[conIndex4]);
                    using (StreamWriter sw = File.AppendText(path1))
                    {
                        sw.WriteLine(firstName);
                    }
                }
                else if (firstDecider == 1) // CVCVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex2 = random.Next(vowLength);
                    firstName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1] + con[conIndex2] + vow[vowIndex2]);
                    using (StreamWriter sw = File.AppendText(path1))
                    {
                        sw.WriteLine(firstName);
                    }
                }
                else if (firstDecider == 2) // CVCC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    firstName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2]);
                    using (StreamWriter sw = File.AppendText(path1))
                    {
                        sw.WriteLine(firstName);
                    }
                }
                else if (firstDecider == 3) // CVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    firstName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1]);
                    using (StreamWriter sw = File.AppendText(path1))
                    {
                        sw.WriteLine(firstName);
                    }
                }
                else if (firstDecider == 4) // VCV
                {
                    int vowIndex = random.Next(vowLength);
                    int conIndex = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    firstName = ti.ToTitleCase(vow[vowIndex] + con[conIndex] + vow[vowIndex1]);
                    using (StreamWriter sw = File.AppendText(path1))
                    {
                        sw.WriteLine(firstName);
                    }
                }
                else if (firstDecider == 5) // C 2V CV
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    firstName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1]);
                    using (StreamWriter sw = File.AppendText(path1))
                    {
                        sw.WriteLine(firstName);
                    }
                }

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
                    lastName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + con[conIndex4]);
                    using (StreamWriter sw = File.AppendText(path2))
                    {
                        sw.WriteLine(lastName);
                    }
                }
                else if (secondDecider == 1) // CVCVC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int vowIndex1 = random.Next(vowLength);
                    int conIndex2 = random.Next(conLength);
                    int vowIndex2 = random.Next(vowLength);
                    lastName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + vow[vowIndex1] + con[conIndex2] + vow[vowIndex2]);
                    using (StreamWriter sw = File.AppendText(path2))
                    {
                        sw.WriteLine(lastName);
                    }
                }
                else if (secondDecider == 2) // CVCC
                {
                    int conIndex = random.Next(conLength);
                    int vowIndex = random.Next(vowLength);
                    int conIndex1 = random.Next(conLength);
                    int conIndex2 = random.Next(conLength);
                    lastName = ti.ToTitleCase(con[conIndex] + vow[vowIndex] + con[conIndex1] + con[conIndex2]);
                    using (StreamWriter sw = File.AppendText(path2))
                    {
                        sw.WriteLine(lastName);
                    }
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
                    lastName = ti.ToTitleCase(vow[vowIndex] + con[conIndex] + con[conIndex1] + con[conIndex2] + vow[vowIndex1] + con[conIndex3] + vow[vowIndex2]);
                    using (StreamWriter sw = File.AppendText(path2))
                    {
                        sw.WriteLine(lastName);
                    }
                }
                namesGoal++;
                if (watch.Elapsed.TotalSeconds > 2)
                {
                    Console.Clear();
                    Console.WriteLine("You have printed " + namesGoal + " out of " + namesToGenerate);
                    watch.Reset();
                }

            }
        }
    }
}