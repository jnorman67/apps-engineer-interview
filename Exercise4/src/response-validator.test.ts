import { isValidApiResponse } from "./response-validator";

describe("Exercise4", () => {
  describe("exampleFunction", () => {
    it("should return true for the happy path", () => {
      const result = isValidApiResponse({
        status: "success",
        data: {
          results: [
            {
              id: 1,
            },
          ],
        },
      });
      expect(result).toBe(true);
    });
  });
});
