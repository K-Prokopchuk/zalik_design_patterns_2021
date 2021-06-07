using Patterns.CreaturesFactory;
using Patterns.MapUtils;
using Patterns.Vectors;
using System;

namespace Patterns
{
    
    class Program
    {
        static void Main(string[] args) {
            Vector2D dimensions = new Vector2D(1500, 1500);
            Map map = new MapBuilder()
                          .CreateNewMap()
                          .SetDimensions(dimensions)
                          .SetMobsDifficulty(5)
                          .SetTerrainLevel(5)
                          .SetCreatureTypes(CreatureTypes.Demon, CreatureTypes.Elf)
                          .CreateMap()
                          .Setup();
            
            
        }
    }
}
