
namespace Exercise2;

class Program
{
    static void Main(string[] args)
    {
        var filter = GetFilter();
        var matchingElectors = FilterElectors(filter);

        Console.WriteLine($"Found {matchingElectors.Count} matching electors");

    }

    static List<Elector> FilterElectors(ElectorFilter filter)
    {
        var electors = ElectorDatabase.GetElectors();
        // TODO: Implement the filter
        return [];

    }


    static ElectorFilter GetFilter()
    {
        return new ElectorFilter
        {
            AgeMin = 30,
        };
    }
}