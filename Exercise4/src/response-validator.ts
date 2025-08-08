/*
Return true if:
- The response has a status field equal to "success".
- There is a data object.
- The data object has a results array with at least one element.

*/

export function isValidApiResponse(response: any): boolean {
  // @ts-expect-error
  if (!response.status === "success") return false;
  if (!response.data) return false;
  if (!Array.isArray(response.data.results) && response.data.results.length > 0)
    return false;
  return true;
}
