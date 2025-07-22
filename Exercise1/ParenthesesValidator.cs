namespace Exercise1;

public static class ParenthesesValidator
{
    public static bool AreParenthesesBalanced(string input)
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