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

    const stack: string[] = [];

    for (const char of input) {
      if (char === "(") {
        stack.push(char);
      } else if (char === ")") {
        stack.pop();
      }
    }

    return stack.length === 0;
  }
}
