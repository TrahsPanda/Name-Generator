using System.Globalization;
using System.Diagnostics;

namespace NameGenerator
{
    class NameGenerator
    {
        public static Stopwatch watch = new Stopwatch();
        public static double seconds = 0;
        public static double minutes = 0;
        public static Random random = new Random();
        public static TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        public static string[] conList = new string[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        public static string[] vowList = new string[] { "a", "e", "i", "o", "u" };
        public static int conLength = conList.Length;
        public static int vowLength = vowList.Length;
        public static string[] firstNameList = new string[] { "CVCCVCC", "CVCVC", "CVCC", "CVC", "VCV", "CVVCV" };
        public static string[] lastNameList = new string[] { "CCVCCVCCVC", "CCVVCC", "CCVCC", "VCCVCV", "CVCCVVCC", "CVCCVC" };
        public static int firstNameListLength = firstNameList.Length;
        public static int lastNameListLength = lastNameList.Length;
        public static string? firstName;
        public static string? lastName;
        public static string path1 = @"c:\tmp\FirstNames.txt";
        public static string path2 = @"c:\tmp\LastNames.txt";

        // Creates a FirstNames.txt and LastNames.txt if not already existing
        public static void Create()
        {
            if (!File.Exists(path1))
            {
                using StreamWriter sw = File.CreateText(path1);
            }
            if (!File.Exists(path2))
            {
                using StreamWriter sw = File.CreateText(path2);
            }
        }

        public static void Main()
        {
            Create();
            // All the cool basic intro stuff for more user friendliness :D
            Console.WriteLine("Welcome to TrahsPanda's Random Name Generator!\n");
            Console.WriteLine("==================== IMPORTANT INFORMATION ====================");
            Console.WriteLine("This program generates first and last names.\nIf you want to generate 100 names, you will generate 100 first and last names.\nNames are stored at c:/tmp in two text files.");
            Console.WriteLine("===============================================================\n");
            Console.WriteLine("Knowing all of this, how many names would you like to generate?");
            int namesToGenerate = Convert.ToInt32(Console.ReadLine());
            int namesGoal = 0;
            Console.Clear();
            Console.WriteLine("Please wait...");
            // The program actually starts here
            for (int i = 0; i < namesToGenerate; i++)
            {
                watch.Start();
                int firstNameFormatIndex = random.Next(firstNameListLength);
                int lastNameFormatIndex = random.Next(lastNameListLength);

                foreach (char c in firstNameList[firstNameFormatIndex])
                {
                    if (c == 'C')
                    {
                        int conIndex = random.Next(conLength);
                        firstName += conList[conIndex];
                    }
                    if (c == 'V')
                    {
                        int vowIndex = random.Next(vowLength);
                        firstName += vowList[vowIndex];
                    }
                }
                firstName = ti.ToTitleCase(firstName);
                using (StreamWriter sw = File.AppendText(path1))
                    sw.WriteLine(firstName);
                firstName = "";

                foreach (char c in lastNameList[lastNameFormatIndex])
                {
                    if (c == 'C')
                    {
                        int conIndex = random.Next(conLength);
                        lastName += conList[conIndex];
                    }
                    if (c == 'V')
                    {
                        int vowIndex = random.Next(vowLength);
                        lastName += vowList[vowIndex];
                    }
                }
                lastName = ti.ToTitleCase(lastName);
                using (StreamWriter sw = File.AppendText(path2))
                    sw.WriteLine(lastName);
                lastName = "";

                namesGoal++;
                if (watch.Elapsed.TotalSeconds > 1)
                {;
                    seconds++;
                    Console.Clear();
                    Console.WriteLine("You have printed {0} out of {1} names", namesGoal, namesToGenerate);
                    if (seconds == 60)
                    {
                        minutes++;
                        seconds = 0;
                    }
                    Console.WriteLine("Time elapsed: {0}m {1}s", minutes, seconds);
                    watch.Reset();
                }

            }
        }
    }
}