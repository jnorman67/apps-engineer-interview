namespace Parentheses;

public static class ParenthesesValidator
{
    public static bool AreParenthesesValid(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return true;
        }

        int count = 0;

        foreach (char c in input)
        {
            if (c == '(')
            {
                count++;
            }
            else if (c == ')')
            {
                count--;
            }

        }

        return count == 0;
    }
}