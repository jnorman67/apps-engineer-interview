export function isValidDateRange(start: string, end: string): boolean {
  const startDate = new Date(start);
  const endDate = new Date(end);
  if (startDate && endDate && startDate < endDate) return true;
  return false;
}
