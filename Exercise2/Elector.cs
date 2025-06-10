using System;

namespace Exercise2;

public class Elector
{
    public required string NameFirstDisplay { get; set; }
    public string? NameMiddleDisplay { get; set; }
    public required string NameLastDisplay { get; set; }
    public required string AddrResidentialLine1 { get; set; }
    public required string AddrResidentialState { get; set; }
    public required string AddrResidentialCity { get; set; }
    public required string AddrResidentialZipCode { get; set; }
    public float AddrResidentialLatitude { get; set; }
    public float AddrResidentialLongitude { get; set; }
    public required string AddrPrecision { get; set; }
    public required string AddrResidentialGeohash { get; set; }
    public bool Registered { get; set; }
    public required string PartyRegistration { get; set; }
    public required string PrecinctName { get; set; }

    private int _lean;
    public int Lean
    {
        get => _lean;
        set
        {
            if (value < 1 || value > 100)
                throw new ArgumentOutOfRangeException(nameof(value), "Lean must be between 1 and 100");
            _lean = value;
        }
    }

    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 999)
                throw new ArgumentOutOfRangeException(nameof(value), "Age must be between 0 and 999");
            _age = value;
        }
    }
}