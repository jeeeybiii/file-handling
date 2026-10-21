using System.IO;

namespace FileHandling
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //Write into a file.
            StreamWriter sw = new StreamWriter(@"test.txt");
            sw.WriteLine("Author: Krissi Wood");
            sw.WriteLine("Date: " + DateTime.Now);
            sw.WriteLine("This will write the data as a new line");
            sw.Close();

            //Read a file
            StreamReader sr = new StreamReader(@"test.txt");
            string aline, everyline = sr.ReadToEnd();
            while (!sr.EndOfStream)
            {
                aline = sr.ReadLine();
                Console.WriteLine(aline);
            }
            Console.WriteLine(everyline);
            sr.Close();
        }
    }
}
