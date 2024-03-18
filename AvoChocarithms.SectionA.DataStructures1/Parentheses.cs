using System.Collections;

namespace AvoChocarithms.SectionA.DataStructures1
{
    public static class Parentheses
    {
        public static bool IsBalanced(string Input)
        {
            return ByStackAlgorithm(Input);
        }
        
        private static bool ByCount(string Input)
        {
            return Input.Count(c => c == '(') == Input.Count(c => c == ')');
        }

        private static bool ByCountAlgorithms(string Input)
        {
            int openParenthises = 0;

            foreach (char c in Input)
            {
                if (c == '(')
                {
                    openParenthises++;
                }
                else if (c == ')')
                {
                    if (openParenthises <= 0)
                    {
                        return false;
                    }

                    openParenthises--;
                }
            }

            return openParenthises == 0;
        }

        private static bool ByStackAlgorithm(string Input)
        {
            Stack<char> openParenthises = new Stack<char>();

            foreach (char c in Input)
            {
                if (c == '(')
                {
                    openParenthises.Push(c);
                }
                else if (c == ')')
                {
                    if (!openParenthises.Any())
                    {
                        return false;
                    }

                    openParenthises.Pop();
                }
            }

            return openParenthises.Count == 0;
        }
    }
}
