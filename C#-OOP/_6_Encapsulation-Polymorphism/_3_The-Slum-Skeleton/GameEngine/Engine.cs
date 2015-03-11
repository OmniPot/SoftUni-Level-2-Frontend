using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Characters;
using TheSlum.Interfaces;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class Engine
    {
        private const int GameTurns = 4;
        private static int characterCount = 0;

        protected List<Character> characterList = new List<Character>();
        protected List<Bonus> timeoutItems;

        public virtual void Run()
        {
            ReadUserInput();
            InitializeTimeoutItems();
            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in characterList)
                {
                    if (character.IsAlive)
                    {
                        ProcessTargetSearch(character);
                    }
                }
                ProcessItemTimeout(timeoutItems);
            }
            PrintGameOutcome();
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != "")
            {
                string[] parameters = inputLine.Split(
                    new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public void InitializeTimeoutItems()
        {
            timeoutItems = characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }

        protected virtual void CreateCharacter(string[] inputParams)
        {
            switch (inputParams[1])
            {
                case "warrior": characterList.Add(new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                    (Team)Enum.Parse(typeof(Team), inputParams[5])));
                    break;
                case "mage": characterList.Add(new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                    (Team)Enum.Parse(typeof(Team), inputParams[5])));
                    break;
                case "healer": characterList.Add(new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                    (Team)Enum.Parse(typeof(Team), inputParams[5])));
                    break;
                default:
                    break;
            }
            characterCount++;
        }

        protected void AddItem(string[] inputParams)
        {
            Item newItem = null;
            switch (inputParams[2])
            {
                case "shield": newItem = new Shield(inputParams[3]); break;
                case "axe": newItem = new Axe(inputParams[3]); break;
                case "pill": newItem = new Pill(inputParams[3]); break;
                case "injection": newItem = new Injection(inputParams[3]); break;
                default:
                    break;
            }
           
            Character itemReciever = GetCharacterById(inputParams[1]);
            itemReciever.AddToInventory(newItem);

        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = characterList
                .Where(t => IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range))
                .ToList();
            if (availableTargets.Count == 0)
            {
                return;
            }
            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }
            ProcessInteraction(currentCharacter, target);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY,
            int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) +
                (attackerY - targetY) * (attackerY - targetY));
            return distance <= (double)range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
            Console.ReadKey(false);
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);
            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }
            var aliveCharacters = characterList.Where(c => c.IsAlive);
            PrintCharactersStatus(aliveCharacters);
        }
    }
}
