using AITeammate.Models;

namespace AITeammate.Data;

public static class SeedData
{
    public static void Initialize(DinosaurContext context)
    {
        if (context.Dinosaurs.Any())
        {
            return; // DB has been seeded
        }

        var dinosaurs = new Dinosaur[]
        {
            // Apex Predators
            new() { Name = "Tyrannosaurus Rex", Rank = DinosaurRank.Apex, Diet = DietType.Carnivore, 
                Description = "The king of dinosaurs. Massive size and devastating bite force make it the ultimate apex predator.", 
                HasDimorphism = true, DimorphismDescription = "Females are larger and more robust than males." },
            new() { Name = "Giganotosaurus", Rank = DinosaurRank.Apex, Diet = DietType.Carnivore, 
                Description = "Slightly larger than T-Rex with a longer skull. Pack hunter with incredible power.", 
                HasDimorphism = false },
            new() { Name = "Spinosaurus", Rank = DinosaurRank.Apex, Diet = DietType.Carnivore, 
                Description = "Semi-aquatic apex predator with a distinctive sail. Longest known carnivorous dinosaur.", 
                HasDimorphism = true, DimorphismDescription = "Males have larger, more vibrant sails." },
            
            // Sub-Apex
            new() { Name = "Allosaurus", Rank = DinosaurRank.SubApex, Diet = DietType.Carnivore, 
                Description = "Powerful pack hunter from the Jurassic period. Swift and intelligent.", 
                HasDimorphism = false },
            new() { Name = "Carnotaurus", Rank = DinosaurRank.SubApex, Diet = DietType.Carnivore, 
                Description = "Fast runner with distinctive horns. Built for speed rather than raw power.", 
                HasDimorphism = true, DimorphismDescription = "Males have larger horns used for display and combat." },
            new() { Name = "Acrocanthosaurus", Rank = DinosaurRank.SubApex, Diet = DietType.Carnivore, 
                Description = "Large theropod with a ridge along its back. Formidable hunter.", 
                HasDimorphism = false },
            
            // High-Tier
            new() { Name = "Ceratosaurus", Rank = DinosaurRank.HighTier, Diet = DietType.Carnivore, 
                Description = "Medium-sized predator with a prominent nose horn. Agile and dangerous.", 
                HasDimorphism = true, DimorphismDescription = "Males have more pronounced nasal horns." },
            new() { Name = "Baryonyx", Rank = DinosaurRank.HighTier, Diet = DietType.Carnivore, 
                Description = "Fish-eating specialist with long claws. Adapted for both land and water hunting.", 
                HasDimorphism = false },
            new() { Name = "Triceratops", Rank = DinosaurRank.HighTier, Diet = DietType.Herbivore, 
                Description = "Heavily armored herbivore with three horns. Can defend against most predators.", 
                HasDimorphism = true, DimorphismDescription = "Males have longer horns and larger frills." },
            new() { Name = "Ankylosaurus", Rank = DinosaurRank.HighTier, Diet = DietType.Herbivore, 
                Description = "Living tank with armored body and club tail. Nearly impervious to attacks.", 
                HasDimorphism = false },
            
            // Mid-Tier
            new() { Name = "Velociraptor", Rank = DinosaurRank.MidTier, Diet = DietType.Carnivore, 
                Description = "Small but intelligent pack hunter with deadly claws. Cunning and coordinated.", 
                HasDimorphism = false },
            new() { Name = "Dilophosaurus", Rank = DinosaurRank.MidTier, Diet = DietType.Carnivore, 
                Description = "Early theropod with distinctive double crests. Fast and agile.", 
                HasDimorphism = true, DimorphismDescription = "Males have larger, more colorful crests." },
            new() { Name = "Stegosaurus", Rank = DinosaurRank.MidTier, Diet = DietType.Herbivore, 
                Description = "Plated herbivore with tail spikes. Slow but well-defended.", 
                HasDimorphism = false },
            new() { Name = "Iguanodon", Rank = DinosaurRank.MidTier, Diet = DietType.Herbivore, 
                Description = "Large herbivore with thumb spikes for defense. Can move on two or four legs.", 
                HasDimorphism = false },
            
            // Low-Tier
            new() { Name = "Gallimimus", Rank = DinosaurRank.LowTier, Diet = DietType.Omnivore, 
                Description = "Ostrich-like dinosaur built for speed. Relies on running to escape danger.", 
                HasDimorphism = false },
            new() { Name = "Parasaurolophus", Rank = DinosaurRank.LowTier, Diet = DietType.Herbivore, 
                Description = "Duck-billed herbivore with distinctive head crest. Lives in herds for protection.", 
                HasDimorphism = true, DimorphismDescription = "Males have longer, more elaborate crests." },
            new() { Name = "Pachycephalosaurus", Rank = DinosaurRank.LowTier, Diet = DietType.Herbivore, 
                Description = "Thick-skulled herbivore that headbutts rivals. Limited defensive capabilities.", 
                HasDimorphism = true, DimorphismDescription = "Males have thicker skulls for ramming contests." },
            new() { Name = "Compsognathus", Rank = DinosaurRank.LowTier, Diet = DietType.Carnivore, 
                Description = "Tiny predator that hunts in packs. Preys on small creatures.", 
                HasDimorphism = false }
        };

        context.Dinosaurs.AddRange(dinosaurs);

        var skins = new Skin[]
        {
            new() { Name = "Forest Green", ColorPattern = "Deep green with brown stripes", 
                Description = "Perfect for blending into dense jungle environments." },
            new() { Name = "Desert Sand", ColorPattern = "Sandy tan with darker spots", 
                Description = "Ideal camouflage for arid environments." },
            new() { Name = "Volcanic Ash", ColorPattern = "Dark grey with red undertones", 
                Description = "Intimidating coloration suggesting volcanic regions." },
            new() { Name = "Ocean Blue", ColorPattern = "Vibrant blue with white underbelly", 
                Description = "Striking aquatic coloration." },
            new() { Name = "Crimson Hunter", ColorPattern = "Deep red with black markings", 
                Description = "Warning coloration of a dangerous predator." },
            new() { Name = "Midnight Black", ColorPattern = "Pure black with subtle purple sheen", 
                Description = "Excellent for night hunting." },
            new() { Name = "Arctic White", ColorPattern = "Pure white with grey accents", 
                Description = "Adapted for cold, snowy environments." },
            new() { Name = "Toxic Yellow", ColorPattern = "Bright yellow with green spots", 
                Description = "Warning coloration suggesting toxicity." },
            new() { Name = "Copper Scales", ColorPattern = "Metallic copper with bronze highlights", 
                Description = "Unique metallic appearance." },
            new() { Name = "Purple Royalty", ColorPattern = "Royal purple with gold trim", 
                Description = "Majestic and rare coloration." },
            new() { Name = "Tiger Orange", ColorPattern = "Bright orange with black stripes", 
                Description = "Bold predator pattern." },
            new() { Name = "Storm Grey", ColorPattern = "Dark storm clouds with lightning white streaks", 
                Description = "Dramatic weather-inspired pattern." },
            new() { Name = "Jungle Camo", ColorPattern = "Multi-green camouflage pattern", 
                Description = "Perfect jungle concealment." },
            new() { Name = "Albino", ColorPattern = "Pure white with pink or red eyes", 
                Description = "Rare genetic variation." },
            new() { Name = "Melanistic", ColorPattern = "Completely black pigmentation", 
                Description = "Rare dark variant." }
        };

        context.Skins.AddRange(skins);
        context.SaveChanges();
    }
}
