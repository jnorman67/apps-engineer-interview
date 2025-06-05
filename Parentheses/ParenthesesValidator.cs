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
            
            // The subtle bug is here - we should check if count goes negative
            // during iteration, not just at the end. This will incorrectly
            // return true for cases like ")(", where closing comes before opening
        }
        
        return count == 0;
    }
} 