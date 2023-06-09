using CandyCrushLogic;
namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nr of rows> <nr of columns>");
                return;
            }
            int numberOfRows = int.Parse(args[0]);
            int numberOfColumns = int.Parse(args[1]);

            Program MyProgram = new Program();
            MyProgram.Start(numberOfRows, numberOfColumns);
        }
        void Start(int numberOfRows, int numberOfColumns)
        {
            RegularCandies[,] playingField = new RegularCandies[numberOfRows, numberOfColumns];
            InitCandies(playingField);
            DisplayCandies(playingField);

            if (CandyCrushLogic.CandyCrusher.ScoreRowPresent(playingField))
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }
            if (CandyCrushLogic.CandyCrusher.ScoreColumnPresent(playingField))
            {
                Console.WriteLine("column score");
            }
            else
            {
                Console.WriteLine("no column score");
            }
        }
        void InitCandies(RegularCandies[,] playingField)
        {
            Random rnd = new Random();
            int min = (int)RegularCandies.JellyBean;
            int max = (int)RegularCandies.JujubeCluster;
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int col = 0; col < playingField.GetLength(1); col++)
                {
                    RegularCandies rndCandies = (RegularCandies)rnd.Next(min, max + 1);
                    playingField[row, col] = rndCandies;
                }
            }
        }
        void DisplayCandies(RegularCandies[,] playingField)
        {
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                for (int col = 0; col < playingField.GetLength(1); col++)
                {
                    switch (playingField[row, col])
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                    }
                    Console.Write("#");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
    
