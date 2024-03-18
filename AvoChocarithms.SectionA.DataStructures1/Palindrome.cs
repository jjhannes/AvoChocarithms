
namespace AvoChocarithms.SectionA.DataStructures1
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string Input)
        {
            return ByIteration(Input);
        }

        [Obsolete]
        private static bool ByForbiddenReverse(string Input)
        {
            int halfLengthRoundedDown = Input.Length / 2;
            string firstSegment = Input.Substring(0, halfLengthRoundedDown);
            string lastSegment = string.Join(string.Empty, Input.Reverse()).Substring(0, halfLengthRoundedDown);

            return firstSegment == lastSegment;
        }

        private static bool ByIteration(string Input)
        {
            int halfLengthRoundedDown = Input.Length / 2;

            for (int index = 0; index < halfLengthRoundedDown; index++)
            {
                if (Input[index] != Input[Input.Length - 1 - index])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
