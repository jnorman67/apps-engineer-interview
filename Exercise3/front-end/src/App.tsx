import { CsvUploader } from './components/CsvUploader';

function App() {
  return (
    <div className="min-h-screen p-6 bg-gray-100">
      <h1 className="text-2xl font-semibold mb-4">CSV Contact Summary</h1>
      <CsvUploader />
    </div>
  );
}

export default App;