using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }
        void Start()
        {
            ChessPiece[,] chessBoard = new ChessPiece[8, 8];

            InitChessboard(chessBoard);
            DisplayChessboard(chessBoard);
            PlayChess(chessBoard);
        }

        void InitChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    chessboard[row, column] = null;
                }
                PutChessPieces(chessboard);
            }     
        }

        void DisplayChessboard(ChessPiece[,] chessboard)
        {
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                Console.Write(8 - row + " ");
                for (int column = 0; column < chessboard.GetLength(1); column++)
                {
                    if ((row + column) % 2 == 0) Console.BackgroundColor = ConsoleColor.Gray;
                    else Console.BackgroundColor = ConsoleColor.DarkYellow;

                    DisplayChessPiece(chessboard[row, column]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h");
        }


        void PutChessPieces(ChessPiece[,] chessboard)
        {
            ChessPieceType[] order = { ChessPieceType.Rook, ChessPieceType.Knight, ChessPieceType.Bishop, ChessPieceType.Queen, ChessPieceType.King, ChessPieceType.Bishop, ChessPieceType.Knight, ChessPieceType.Rook };

            for (int column = 0; column < chessboard.GetLength(1); column++)
            {
                chessboard[1, column] = new ChessPiece
                {
                    type = ChessPieceType.Pawn,
                    color = ChessPieceColor.black
                };

                chessboard[6, column] = new ChessPiece
                {
                    type = ChessPieceType.Pawn,
                    color = ChessPieceColor.white
                };

                chessboard[0, column] = new ChessPiece
                {
                    type = order[column],
                    color = ChessPieceColor.black
                };

                chessboard[7, column] = new ChessPiece
                {
                    type = order[column],
                    color = ChessPieceColor.white
                };
            }
        }

        public void DisplayChessPiece(ChessPiece chessPiece)
        {
            if (chessPiece == null)
            {
                Console.Write("   ");
            }

            else
            {
                if (chessPiece.color == ChessPieceColor.black)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                char c = ' ';
                if (chessPiece.type == ChessPieceType.Pawn) c = 'p';
                else if (chessPiece.type == ChessPieceType.Rook) c = 'r' ;
                else if (chessPiece.type == ChessPieceType.Knight) c = 'k';
                else if (chessPiece.type == ChessPieceType.Bishop) c = 'b';
                    else if (chessPiece.type == ChessPieceType.King) c = 'K';
                else if (chessPiece.type == ChessPieceType.Queen) c = 'Q';

                Console.Write($" {c} ");
                Console.ResetColor();
            }
        }
        Position String2Position(string pos)
        {
            Position position = new Position();

            int column = pos[0] - 'a';
            int row = 8 - int.Parse(pos[1].ToString());

            if (row < 0 || row > 7 || column < 0 || column > 7)
            {
                throw new Exception($"Invalid position: {pos}");
            }
            position.row = row;
            position.column = column;
            return position;
        }
        public void PlayChess(ChessPiece[,] chessboard)
        {
            while (true)
            {
                Console.WriteLine("Enter a move (e.g. a2 a3): ");
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                string[] enteredMove = input.Split(' ');
                try
                {
                    Position from = String2Position(enteredMove[0]);
                    Position to = String2Position(enteredMove[1]);

                    Console.WriteLine($"move from {enteredMove[0]} to {enteredMove[1]}");
                    // Console.WriteLine();
                    DoMove(chessboard, from, to);
                    DisplayChessboard(chessboard);
                }
                catch (Exception exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exception.Message);
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }

        public void DoMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            CheckMove(chessboard, from, to);
            chessboard[to.row, to.column] = chessboard[from.row, from.column];
            chessboard[from.row, from.column] = null;
        }
        public void CheckMove(ChessPiece[,] chessboard, Position from, Position to)
        {
            int ver = Math.Abs(from.row - to.row);
            int hor = Math.Abs(from.column - to.column);

            Console.ForegroundColor = ConsoleColor.Red;



            if (chessboard[from.row, from.column] == null)
            {
                Console.WriteLine();
                throw new Exception("No chess piece at from-position");
            }
            if (chessboard[to.row, to.column] != null)
            {
                Console.WriteLine();
                throw new Exception("Can not take a chess piece of same color");
            }
            Console.WriteLine();
            bool exception = false;
            switch (chessboard[from.row, from.column].type)
            {
                case ChessPieceType.Pawn:
                    if (hor == 0 && ver == 1) exception = true;
                    break;

                case ChessPieceType.Rook:
                    if (hor * ver == 0) exception = true;
                    break;

                case ChessPieceType.Knight:
                    if (hor * ver == 2) exception = true;
                    break;

                case ChessPieceType.Bishop:
                    if (hor == ver) exception = true;
                    break;

                case ChessPieceType.Queen:
                    if (hor * ver == 0 || hor == ver) exception = true;
                    break;

                case ChessPieceType.King:
                    if (hor == 1 || ver == 1 || (hor == 1 && ver == 1)) exception = true;
                    break;
            }

            if (exception == false)
                throw new Exception($"Invalid move for chess piece {chessboard[from.row, from.column].type}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
 }

    
