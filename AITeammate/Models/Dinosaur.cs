namespace AITeammate.Models;

public enum DinosaurRank
{
    Apex,
    SubApex,
    HighTier,
    MidTier,
    LowTier
}

public enum DietType
{
    Carnivore,
    Herbivore,
    Omnivore
}

public enum Gender
{
    Male,
    Female
}

public class Dinosaur
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DinosaurRank Rank { get; set; }
    public DietType Diet { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool HasDimorphism { get; set; }
    public string? DimorphismDescription { get; set; }
}

public class Skin
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ColorPattern { get; set; } = string.Empty;
    public string? Description { get; set; }
}

public class DinosaurRoll
{
    public Dinosaur Dinosaur { get; set; } = null!;
    public Gender Gender { get; set; }
    public bool ShowDimorphism { get; set; }
    public Skin Skin { get; set; } = null!;
}
