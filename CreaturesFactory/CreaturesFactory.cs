// unset

using System;
namespace Patterns.CreaturesFactory
{
    public abstract class CreaturesFactory
    {
        public abstract Creature CreateCreature();
    }

    class DemonFactory : CreaturesFactory
    {
        public override Creature CreateCreature() {
            Random rand   = new Random();
            int    level  = rand.Next(5, 25);
            float  health = (float)rand.NextDouble() * level * 300;
            return new Demon(level,health);
        }
    }
    
    class ElfFactory : CreaturesFactory
    {
        public override Creature CreateCreature() {
            Random rand   = new Random();
            int    level  = rand.Next(5, 25);
            float  health = (float)rand.NextDouble() * level * 200;
            return new Elf(level,health);
        }
    }

    public abstract class Creature
    {
        public          int   level;
        public          float health;

        public Creature(int _level) {
            level = _level;
        }
        
        public Creature(float _health) {
            health = _health;
        }
        
        public Creature(int _level, float _health) {
            level = _level;
            health = _health;
        }

    }

    public class Demon : Creature
    {
        public void Eat(Creature creature) {
            creature.health -= level * 10;
        }

        public Demon(int _level) : base(_level) {
        }

        public Demon(float _health) : base(_health) {
        }

        public Demon(int _level, float _health) : base(_level, _health) {
        }
    }
    
    public class Elf : Creature
    {
        public void ShootArrow(Creature creature) {
            creature.health -= level * 8;
        }

        public Elf(int _level) : base(_level) {
        }

        public Elf(float _health) : base(_health) {
        }

        public Elf(int _level, float _health) : base(_level, _health) {
        }
    }

    public enum CreatureTypes : Int32
    {
        Elf,
        Demon
    }
    
}