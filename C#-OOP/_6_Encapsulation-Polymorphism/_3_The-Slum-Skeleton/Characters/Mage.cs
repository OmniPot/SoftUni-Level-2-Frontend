namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using TheSlum.Interfaces;
    using System.Linq;

    public class Mage : Character, IAttack
    {
        private int attackPoints = 300;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, 150, 50, team, 5) { }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var attackableTargets = targetsList
                .Where(t => t.IsAlive == true && !t.Team.Equals(this.Team)).ToList();
            if (attackableTargets.Count == 0)
            {
                return null;
            }
            return attackableTargets.Last();
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
