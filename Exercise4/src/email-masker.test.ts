import { maskEmail } from "./email-masker";

describe("maskEmail", () => {
  describe("valid email addresses", () => {
    it("should mask a standard email address", () => {
      const result = maskEmail("john.doe@example.com");
      expect(result).toBe("j***e@example.com");
    });
  });
});
