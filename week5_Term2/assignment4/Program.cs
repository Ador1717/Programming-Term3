namespace assignment4
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
            Program myProgram = new Program();
            myProgram.Start(filename);
        }

        void Start(string filename)
        {
            List<string> words = ReadWords(filename, 5);
            string lingoWord = SelectWord(words);
            LingoGame lingoGame = new LingoGame();
            //lingoWord = SelectWord(words);
            lingoGame.Init(lingoWord);
            // PlayLingo(lingoGame);
            if (PlayLingo(lingoGame))
            {
                Console.WriteLine("You have guessed the word!");
            }
            else
            {
                Console.WriteLine($"Too bad, you did not guess the word({lingoWord})");
            }
        }
        List<string> ReadWords(string filename, int wordLength)
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader(filename);

            while (!reader.EndOfStream)
            {
                string last = reader.ReadLine().ToLower();
                if (last.Length == wordLength)
                {
                    words.Add(last);
                }
            }
            reader.Close();
            return words;
        }

        string SelectWord(List<string> words)
        {
            Random rnd = new Random();
            return words[rnd.Next(words.Count)];
        }
        bool PlayLingo(assignment4.LingoGame lingoGame)
        {
            int attLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;
            int count = 1;

            while (attLeft > 0 && !lingoGame.WordGussed())
            {
                Console.Write($"Enter a ({wordLength}- letter) word, attempt {count}: ");
                string playerWord = ReadPlayerWord(wordLength);
                LetterState[] letterResults = lingoGame.ProcessWord(playerWord);
                DisplayPlayerWord(playerWord, letterResults);
                Console.WriteLine();
                attLeft--;
                count++;
            }
            return lingoGame.WordGussed();
        }
        string ReadPlayerWord(int wordlength)
        {
            string word = "";
            do
            {
                word = Console.ReadLine();
            } while (word.Length != wordlength);
            return word;
        }
        void DisplayPlayerWord(string playerWord, LetterState[] letter)
        {
            for (int i = 0; i < playerWord.Length; i++)
            {
                if (letter[i] == LetterState.Correct)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (letter[i] == LetterState.WrongPosition)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                Console.Write(playerWord[i]);
                Console.ResetColor();
            }

        }
    }
}