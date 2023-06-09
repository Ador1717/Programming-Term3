using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrushLogic
{
    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] playingField)
        {
            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                int count = 1;
                for (int col = 1; col < playingField.GetLength(1); col++)
                {
                    if (playingField[row, col] == playingField[row, col - 1])
                    {
                        count++;
                        if (count == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return false;
        }
        public static bool ScoreColumnPresent(RegularCandies[,] playingField)
        {
            for (int col = 0; col < playingField.GetLength(0); col++)
            {
                int count = 1;
                for (int row = 1; row < playingField.GetLength(0); row++)
                {
                    if (playingField[row, col] == playingField[row - 1, col])
                    {
                        count++;
                        if (count == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return false;
        }
    }
}
