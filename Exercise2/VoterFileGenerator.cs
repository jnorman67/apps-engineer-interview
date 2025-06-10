using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2;

public static class VoterFileGenerator
{
    private static readonly Random Random = new Random();

    private static readonly string[] FirstNames = new[]
    {
        "James", "Mary", "John", "Patricia", "Robert", "Jennifer", "Michael", "Linda",
        "William", "Elizabeth", "David", "Barbara", "Richard", "Susan", "Joseph", "Jessica",
        "Thomas", "Sarah", "Charles", "Karen", "Christopher", "Nancy", "Daniel", "Lisa",
        "Matthew", "Margaret", "Anthony", "Betty", "Mark", "Sandra", "Donald", "Ashley",
        "Steven", "Kimberly", "Paul", "Emily", "Andrew", "Donna", "Joshua", "Michelle"
    };

    private static readonly string[] LastNames = new[]
    {
        "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis",
        "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson",
        "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson",
        "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker",
        "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores"
    };

    private static readonly string[] States = new[]
    {
        "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
        "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
        "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
        "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
        "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
    };

    private static readonly string[] Parties = new[]
    {
        "Democrat", "Republican", "Independent", "Libertarian", "Green", "Unaffiliated"
    };

    private static readonly string[] StreetNames = new[]
    {
        "Main", "Oak", "Maple", "Cedar", "Pine", "Elm", "Washington", "Lake", "Hill",
        "Park", "Spring", "North", "South", "East", "West", "River", "Forest", "Meadow"
    };

    private static readonly string[] StreetTypes = new[]
    {
        "St", "Ave", "Blvd", "Dr", "Ln", "Rd", "Way", "Cir", "Ct"
    };

    private static string GenerateAddress()
    {
        return $"{Random.Next(1, 9999)} {StreetNames[Random.Next(StreetNames.Length)]} {StreetTypes[Random.Next(StreetTypes.Length)]}";
    }

    private static string GenerateCity(string state)
    {
        // This is a simplified version - in reality, you'd want a proper city/state mapping
        return $"City{Random.Next(1, 100)}";
    }

    private static string GenerateZipCode()
    {
        return $"{Random.Next(10000, 99999)}";
    }

    public static List<Elector> GenerateVoterFile(int count = 1000)
    {
        var voters = new List<Elector>();

        for (int i = 0; i < count; i++)
        {
            var state = States[Random.Next(States.Length)];
            var city = GenerateCity(state);

            var voter = new Elector
            {
                NameFirstDisplay = FirstNames[Random.Next(FirstNames.Length)],
                NameLastDisplay = LastNames[Random.Next(LastNames.Length)],
                NameMiddleDisplay = Random.Next(10) == 0 ? FirstNames[Random.Next(FirstNames.Length)] : null,
                AddrResidentialLine1 = GenerateAddress(),
                AddrResidentialState = state,
                AddrResidentialCity = city,
                AddrResidentialZipCode = GenerateZipCode(),
                AddrResidentialLatitude = (float)(Random.NextDouble() * 180 - 90),
                AddrResidentialLongitude = (float)(Random.NextDouble() * 360 - 180),
                AddrPrecision = "ROOFTOP",
                AddrResidentialGeohash = "dummy_geohash", // In reality, this would be calculated from lat/long
                Registered = Random.Next(10) < 8, // 80% registered
                PartyRegistration = Parties[Random.Next(Parties.Length)],
                PrecinctName = $"Precinct {Random.Next(1, 100)}",
                Lean = Random.Next(1, 101),
                Age = Random.Next(18, 100)
            };

            voters.Add(voter);
        }

        return voters;
    }
}