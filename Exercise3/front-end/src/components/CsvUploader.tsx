import { useState } from "react";

export function CsvUploader() {
  const [result, setResult] = useState<Record<string, number> | null>(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const handleUpload = async (e: React.ChangeEvent<HTMLInputElement>) => {
    const file = e.target.files?.[0];
    if (!file) return;

    setLoading(true);
    setError(null);

    const text = await file.text();

    try {
      const res = await fetch("/api/contact-summary", {
        method: "POST",
        headers: { "Content-Type": "text/plain" },
        body: text,
      });

      if (!res.ok) throw new Error(`Server error ${res.status}`);
      const data = await res.json();
      setResult(data);
    } catch (err) {
      setError("Failed to summarize CSV. Please try again.");
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="space-y-4">
      <input
        type="file"
        accept=".csv"
        onChange={handleUpload}
        disabled={loading}
      />
      {loading && <p>Processing...</p>}
      {error && <p className="text-red-500">{error}</p>}
      {result && (
        <ul className="bg-white rounded p-4 shadow">
          {Object.entries(result).map(([key, value]) => (
            <li key={key}>// Display key and value</li>
          ))}
        </ul>
      )}
    </div>
  );
}
