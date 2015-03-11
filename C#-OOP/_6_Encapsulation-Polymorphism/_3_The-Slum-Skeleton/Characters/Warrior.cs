namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class Warrior : Character, IAttack
    {
        private int attackPoints = 150;

        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, 200, 100, team, 2) { }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var attackableTargets = targetsList
                .Where(t => t.IsAlive == true && !t.Team.Equals(this.Team)).ToList();
            return attackableTargets.First();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            this.AttackPoints -= item.AttackEffect;
            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 1;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Team: {2}, Health: {1}, Defense: {3}, Attack: {4}",
                this.Id, this.HealthPoints, this.Team.ToString(), this.DefensePoints, this.AttackPoints);
        }
    }
}
