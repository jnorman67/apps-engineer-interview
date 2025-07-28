/**
 * Validates if parentheses in a string are balanced.
 * A string has balanced parentheses if every opening parenthesis '(' has a corresponding closing parenthesis ')'.
 */
export class ParenthesesValidator {
  /**
   * Checks if the parentheses in the input string are balanced.
   * @param input - The string to check for balanced parentheses
   * @returns true if parentheses are balanced, false otherwise
   */
  public static areParenthesesBalanced(input: string): boolean {
    if (!input || input.length === 0) {
      return true;
    }

    let count = 0;

    for (const char of input) {
      if (char === "(") {
        count++;
      } else if (char === ")") {
        count--;
      }
    }

    return count === 0;
  }
}
