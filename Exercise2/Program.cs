namespace Exercise2;

class Program
{
    public static void Main(string[] _args)
    {
        var filter = GetFilter();
        var matchingElectors = FilterElectors(filter);

        Console.WriteLine($"Found {matchingElectors.Count} matching electors");

    }

    private static List<Elector> FilterElectors(ElectorFilter filter)
    {
        var allElectors = ElectorDatabase.GetElectors();

        // TODO: Implement the filter
        return [];
    }


    private static ElectorFilter GetFilter()
    {
        return new ElectorFilter
        {
            AgeMin = 30,
        };
    }
}