using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int AttackDamage { get; set; }
        public int Defense { get; set; }

        public virtual void Attack(GameCharacter target)
        {
            target.TakeDamage(this.AttackDamage);
        }

        public void TakeDamage(int damage)
        {
            this.Health -= damage;
            if (this.Health < 0) this.Health = 0;
        }

        public virtual string GetInfo()
        {
            return $"{this.Name} ({this.GetType().Name}) - Level: {this.Level}, Health: {this.Health}, Attack Damage: {this.AttackDamage}, Defense: {this.Defense}";
        }
    }

    public class Infantryman : GameCharacter
    {
        public Infantryman()
        {
            this.Name = "Infantryman";
            this.Health = 100;
            this.Level = 1;
            this.AttackDamage = 10;
            this.Defense = 5;
        }
    }

    public class Spearman : GameCharacter
    {
        public Spearman()
        {
            this.Name = "Spearman";
            this.Health = 120;
            this.Level = 1;
            this.AttackDamage = 15;
            this.Defense = 3;
        }
    }

    public class Archer : GameCharacter
    {
        public Archer()
        {
            this.Name = "Archer";
            this.Health = 80;
            this.Level = 1;
            this.AttackDamage = 20;
            this.Defense = 2;
        }

        public override void Attack(GameCharacter target)
        {
            base.Attack(target);
            Console.WriteLine($"{this.Name} fired an arrow at {target.Name}!");
        }
    }

}
