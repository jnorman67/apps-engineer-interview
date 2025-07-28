import { ParenthesesValidator } from "./ParenthesesValidator";

describe("ParenthesesValidator", () => {
  describe("areParenthesesBalanced", () => {
    it("should return true for empty string", () => {
      const result = ParenthesesValidator.areParenthesesBalanced("");
      expect(result).toBe(true);
    });

    it("should return true for null input", () => {
      const result = ParenthesesValidator.areParenthesesBalanced(null as any);
      expect(result).toBe(true);
    });

    it("should return true for undefined input", () => {
      const result = ParenthesesValidator.areParenthesesBalanced(
        undefined as any
      );
      expect(result).toBe(true);
    });
  });
});
