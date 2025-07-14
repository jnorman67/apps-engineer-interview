# Canvassing Summary

## Scenario

Door-to-door canvassers record voter responses and submit `.csv` files containing data about voter contact attempts. Write logic to process these files and return a summary of contact outcomes. Then expose that summary through a simple API.

---

## Part 1: Parse and Summarize CSV Input

### Instructions

Write a function that takes a CSV string and returns a summary of voter contact outcomes.

### Sample Input

```
voter_id,outcome
1234,contacted
5678,no_answer
9012,contacted
3456,bad_address
7890,no_answer
```

### Expected Output

```json
{
  "contacted": 2,
  "no_answer": 2,
  "bad_address": 1
}
```

### Suggested Function Signature

**TypeScript:**

```ts
function summarizeOutcomes(csv: string): Record<string, number>;
```

**C#:**

```csharp
Dictionary<string, int> SummarizeOutcomes(string csv)
```

### Notes

- The first row is a header.
- Ignore empty lines.
- Handle unexpected or malformed rows gracefully.

---

## Part 2: Design the API Layer

### Instructions

Imagine you've implemented the logic to summarize outcomes. Design an API endpoint that:

- Accepts the CSV content via a `POST` request
- Returns the summary as JSON

### Describe:

- The route and HTTP method
- Expected request body format
- Expected response format
- Error handling (e.g. malformed CSV, empty input)

### Example:

```http
POST /api/contact-summary
Content-Type: text/plain

[voter contact CSV here]
```

**Response:**

```json
{
  "contacted": 2,
  "no_answer": 2,
  "bad_address": 1
}
```
