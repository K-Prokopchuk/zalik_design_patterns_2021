// unset
// pattern bulder

using Patterns.CreaturesFactory;
using Patterns.Vectors;
using System;
using System.Collections.Generic;

namespace Patterns.MapUtils
{
    public class MapBuilder
    {
        private Map _concurrentMap;

        public MapBuilder CreateNewMap() {
            _concurrentMap = new Map();
            return this;
        }

        public MapBuilder SetDimensions(Vector2D dimensions) {
            _concurrentMap.dimensions = dimensions;
            return this;
        }

        public MapBuilder SetTerrainLevel(int hardness) {
            _concurrentMap.terrainLevel = hardness;
            return this;
        }

        public MapBuilder SetMobsDifficulty(int hardness) {
            _concurrentMap.mobsDifficulty = hardness;
            return this;
        }

        public MapBuilder SetCreatureTypes(params CreatureTypes[] creatureTypesArray) {
            _concurrentMap.creatureTypes = creatureTypesArray;
            return this;
        }

        public Map CreateMap() {
            return _concurrentMap.Setup();
        }
    }

    public class Map
    {
        private List<Creature>  _creatures = new List<Creature>();
        public  CreatureTypes[] creatureTypes;
        public  Vector2D        dimensions;
        public  int             mobsDifficulty;
        public  int             terrainLevel;

        public int Area => (int)(dimensions.pos_x * dimensions.pos_y);

        public void Render() { /*...*/
        }

        private void FillTheMap(CreaturesFactory.CreaturesFactory factory) {
            for (int i = 0; i < mobsDifficulty * 10; ++i) {
                _creatures.Add(factory.CreateCreature());
            }
        }

        public Map Setup() {
            foreach (CreatureTypes creature in creatureTypes) {
                switch (creature) {
                    case CreatureTypes.Elf:
                        FillTheMap(new ElfFactory());
                        break;
                    case CreatureTypes.Demon:
                        FillTheMap(new DemonFactory());
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }

            return this;
        }
    }
}