using System.IO;

namespace FileHandling
{
    internal class Program
    {
        //create struct Student
        public struct Student
        {
            public string firstName;
            public string lastName;
            public string interest;
            public int teamNumber;
        }

        //create struct object
        public static Student[] student = new Student[3];

        //Text file writer and reader
        public static StreamWriter sw;
        public static StreamReader sr;
        
        public static void Main(string[] args)
        {
            FileReader();
            DisplayOutput();
            FileWriter();
        }

        public static void FileReader()
        {
            //interest
            string interest = "Programming 1";
            Random rand = new Random();

            //team number
            int randomGenerator;

            //index
            int i = 0;

            //file reader
            sr = new StreamReader(@"names2.txt");
            while(!sr.EndOfStream && i < student.Length)
            {
                randomGenerator = rand.Next(1, 5);
                student[i].firstName = sr.ReadLine();
                student[i].lastName = sr.ReadLine();
                student[i].interest = interest;
                student[i].teamNumber = randomGenerator;
                i++;
            }
            sr.Close();
        }

        public static void DisplayOutput()
        {
            Console.Write("Team Number".PadRight(20));
            Console.Write("First Name".PadRight(20));
            Console.Write("Last Name".PadRight(20));
            Console.WriteLine("Interest".PadRight(20));

            for(int i = 0; i < student.Length; i++)
            {
                Console.Write($"{student[i].teamNumber}".PadRight(20));
                Console.Write($"{student[i].firstName}".PadRight(20));
                Console.Write($"{student[i].lastName}".PadRight(20));
                Console.WriteLine($"{student[i].interest}".PadRight(20));
            }
        }

        public static void FileWriter()
        {
            sw = new StreamWriter(@"ourClass.txt");
            sw.Write("Team Number".PadRight(20));
            sw.Write("First Name".PadRight(20));
            sw.Write("Last Name".PadRight(20));
            sw.WriteLine("Interest".PadRight(20));

            for (int i = 0; i < student.Length; i++)
            {
                sw.Write($"{student[i].teamNumber}".PadRight(20));
                sw.Write($"{student[i].firstName}".PadRight(20));
                sw.Write($"{student[i].lastName}".PadRight(20));
                sw.WriteLine($"{student[i].interest}".PadRight(20));
            }
            sw.Close();
        }
    }
}
