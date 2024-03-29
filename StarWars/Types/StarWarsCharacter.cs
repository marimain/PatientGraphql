using System;
using System.Collections.Generic;

namespace StarWars.Types;

public abstract class StarWarsCharacter
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string[] Friends { get; set; }
    public int[] AppearsIn { get; set; }
}

public class Human : StarWarsCharacter
{
    public string HomePlanet { get; set; }
}

public class Droid : StarWarsCharacter
{
    public string PrimaryFunction { get; set; }
}
public class Patient : StarWarsCharacter
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime dob { get; set; }
}

