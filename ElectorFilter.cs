using System;
using System.Collections.Generic;

namespace Parentheses;

public class ElectorFilter
{
    public string NameFirstDisplay { get; set; }
    public string NameLastDisplay { get; set; }
    public string AddrResidentialState { get; set; }
    public string AddrResidentialCity { get; set; }
    public string AddrResidentialZipCode { get; set; }
    public string PartyRegistration { get; set; }
    public string PrecinctName { get; set; }

    private int? _ageMin;
    public int? AgeMin
    {
        get => _ageMin;
        set
        {
            if (value.HasValue && (value.Value < 0 || value.Value > 999))
                throw new ArgumentOutOfRangeException(nameof(value), "AgeMin must be between 0 and 999");
            _ageMin = value;
        }
    }

    private int? _ageMax;
    public int? AgeMax
    {
        get => _ageMax;
        set
        {
            if (value.HasValue && (value.Value < 0 || value.Value > 999))
                throw new ArgumentOutOfRangeException(nameof(value), "AgeMax must be between 0 and 999");
            _ageMax = value;
        }
    }

    private int? _leanMin;
    public int? LeanMin
    {
        get => _leanMin;
        set
        {
            if (value.HasValue && (value.Value < 1 || value.Value > 100))
                throw new ArgumentOutOfRangeException(nameof(value), "LeanMin must be between 1 and 100");
            _leanMin = value;
        }
    }

    private int? _leanMax;
    public int? LeanMax
    {
        get => _leanMax;
        set
        {
            if (value.HasValue && (value.Value < 1 || value.Value > 100))
                throw new ArgumentOutOfRangeException(nameof(value), "LeanMax must be between 1 and 100");
            _leanMax = value;
        }
    }

    public bool? Registered { get; set; }

    public bool IsValid()
    {
        if (AgeMin.HasValue && AgeMax.HasValue && AgeMin.Value > AgeMax.Value)
            return false;

        if (LeanMin.HasValue && LeanMax.HasValue && LeanMin.Value > LeanMax.Value)
            return false;

        return true;
    }

    public bool Matches(Elector elector)
    {
        return true;
    }
}