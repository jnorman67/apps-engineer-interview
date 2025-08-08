import { isValidDateRange } from "./date-range-validator";

describe("isValidDateRange", () => {
  test("should return true for valid date range", () => {
    expect(isValidDateRange("2023-01-01", "2023-01-02")).toBe(true);
    expect(isValidDateRange("2023-12-31", "2024-01-01")).toBe(true);
    expect(isValidDateRange("2023-01-01T00:00:00", "2023-01-01T23:59:59")).toBe(
      true
    );
  });

  test("should return false when start date is after end date", () => {
    expect(isValidDateRange("2023-01-02", "2023-01-01")).toBe(false);
    expect(isValidDateRange("2024-01-01", "2023-12-31")).toBe(false);
    expect(isValidDateRange("2023-01-01T23:59:59", "2023-01-01T00:00:00")).toBe(
      false
    );
  });

  // A date with time zone: "2023-01-01T00:00:00Z"
});
