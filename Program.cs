namespace BikeLocker
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@""); // insert file directory to list of words here
            while ((line = file.ReadLine()) != null)
            {
                if (line.Length == 4)
                {
                    var wordChars = line.ToCharArray();
                    if ("stdmrfblpw".Contains(wordChars[0]) && "wryuaioleh".Contains(wordChars[1]) && "koalermtns".Contains(wordChars[2]) && "kmstepyldg".Contains(wordChars[3]))
                    {
                        System.Console.WriteLine(line);
                        counter++;
                    }
                }
            }
            file.Close();
            System.Console.WriteLine("There were {0} valid words.", counter);
        }
    }
}
