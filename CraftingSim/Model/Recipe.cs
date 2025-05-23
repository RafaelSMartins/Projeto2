using System.Collections.Generic;

namespace CraftingSim.Model
{
    public class Recipe : IRecipe
    {

        public Recipe(string name, double successRate) 
        {
            this.Name = name;
    this.SuccessRate = successRate;
   
        }
                public string Name { get; }
        public IReadOnlyDictionary<IMaterial, int> RequiredMaterials { get; }
        public double SuccessRate { get; }
        
        public Recipe(string name, double successRate, Dictionary<IMaterial, int> materials)
        {
            Name = name;
            SuccessRate = successRate;
            RequiredMaterials = materials;
        }
        
        public int CompareTo(IRecipe obj)
        {
            if (obj == null) return 1;
            return Name.CompareTo(obj.Name);
        }
        
    }
}