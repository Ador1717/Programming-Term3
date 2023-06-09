using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class LingoGame
    {
            public string lingoWord;
            public string playerWord;
            public void Init(string lingoWords)
            {
                this.lingoWord = lingoWords;
                this.playerWord = "";
            }
            public bool WordGussed()
            {
                return lingoWord == playerWord;
            }
            public LetterState[] ProcessWord(string playerWord)
            {
                this.playerWord = playerWord;
                LetterState[] states = new LetterState[this.playerWord.Length];
                List<char> chars = new List<char>();

                for (int i = 0; i < this.lingoWord.Length; i++)
                {
                    if (lingoWord[i] != playerWord[i])
                    {
                        chars.Add(lingoWord[i]);
                    }
                }
                for (int i = 0; i < this.lingoWord.Length; i++)
                {
                    if (lingoWord[i] == playerWord[i])
                    {
                        states[i] = LetterState.Correct;
                    }
                    else
                    {
                        if (chars.Contains(playerWord[i]))
                        {
                            states[i] = LetterState.WrongPosition;
                            chars.Remove(playerWord[i]);
                        }
                        else
                        {
                            states[i] = LetterState.Incorrect;
                        }
                    }
                }
                return states;
            }
    }
}
