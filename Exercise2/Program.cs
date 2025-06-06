using System;
using System.IO;
using System.Text;

namespace Exercise2;

class Program
{
    static void Main(string[] args)
    {
        var voters = VoterFileGenerator.GenerateVoterFile(1000);
        var sb = new StringBuilder();

        // Start of file
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine();
        sb.AppendLine("namespace Exercise2;");
        sb.AppendLine();
        sb.AppendLine("public class ElectorDatabase");
        sb.AppendLine("{");
        sb.AppendLine("    private static readonly Elector[] _electors = new Elector[]");
        sb.AppendLine("    {");

        // Add each voter
        foreach (var voter in voters)
        {
            sb.AppendLine($"        new Elector {{ " +
                $"NameFirstDisplay = \"{voter.NameFirstDisplay}\", " +
                $"NameLastDisplay = \"{voter.NameLastDisplay}\", " +
                $"AddrResidentialLine1 = \"{voter.AddrResidentialLine1}\", " +
                $"AddrResidentialState = \"{voter.AddrResidentialState}\", " +
                $"AddrResidentialCity = \"{voter.AddrResidentialCity}\", " +
                $"AddrResidentialZipCode = \"{voter.AddrResidentialZipCode}\", " +
                $"AddrResidentialLatitude = {voter.AddrResidentialLatitude}f, " +
                $"AddrResidentialLongitude = {voter.AddrResidentialLongitude}f, " +
                $"AddrPrecision = \"{voter.AddrPrecision}\", " +
                $"AddrResidentialGeohash = \"{voter.AddrResidentialGeohash}\", " +
                $"Registered = {voter.Registered.ToString().ToLower()}, " +
                $"PartyRegistration = \"{voter.PartyRegistration}\", " +
                $"PrecinctName = \"{voter.PrecinctName}\", " +
                $"Lean = {voter.Lean}, " +
                $"Age = {voter.Age} }},");
        }

        // End of file
        sb.AppendLine("    };");
        sb.AppendLine();
        sb.AppendLine("    public static Elector[] GetElectors()");
        sb.AppendLine("    {");
        sb.AppendLine("        return _electors;");
        sb.AppendLine("    }");
        sb.AppendLine("}");

        // Write to file
        File.WriteAllText("ElectorDatabase.cs", sb.ToString());
        Console.WriteLine("Generated ElectorDatabase.cs with 1000 electors");
    }
}