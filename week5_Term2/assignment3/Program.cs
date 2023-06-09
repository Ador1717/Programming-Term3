using System.IO.Enumeration;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("invalid number arguments!");
                return;
            }
            string filename = args[0];
            Program MyProgram = new Program();
            MyProgram.Start(filename);
        }
        void Start(string filename)
        {
           TranslateWords(ReadWords(filename));        
        }
        Dictionary<string, string> ReadWords(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            Dictionary<string, string> dictinary = new Dictionary<string, string>();    
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(';');
                dictinary.Add(words[0], words[1]);
            }
            return dictinary;
        }
        void TranslateWords(Dictionary<string, string> words)
        {
            string NewWord;
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            while (word != "stop")
            {
                if (words.ContainsKey(word))
                {
                    words.TryGetValue(word, out NewWord);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"{word} => {NewWord}");
                    Console.ResetColor();
                }
                else if (word == "listall")
                {
                    ListAllWords(words);
                }
                else
                {
                    Console.WriteLine($"word '{word}' not found");
                }
                Console.Write("Enter a word: ");
                word = Console.ReadLine();
            }
            void ListAllWords(Dictionary<string, string> words)
            {
                foreach (var word in words)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{word.Key} => {word.Value}");
                }
                Console.ResetColor();
            }
        }   
    }
}