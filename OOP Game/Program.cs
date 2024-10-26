namespace OOP_Game
{
    class Warrior
    {
        public string Name { get; set; } = "";
        public double Health { get; set; } = 0.0;
        public double AttackMax { get; set; } = 0.0;
        public double BlockMax { get; set; } = 0.0;

        Random random = new Random();

        public Warrior(
            string name = "Warrior",
            double health = 100.0,
            double attackMax = 10.0,
            double blockMax = 5.0
        )
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return random.Next(1, (int)AttackMax);
        }

        public double Block()
        {
            return random.Next(1, (int)BlockMax);
        }
    }

    class Battle
    {
        public static void StartFight(Warrior attacker, Warrior defender)
        {
            while (true)
            {
                if (GetAttackResult(attacker, defender) == "defender")
                {
                    Console.WriteLine($"{attacker.Name} has won the fight!");
                    break;
                }

                if (GetAttackResult(defender, attacker) == "attacker")
                {
                    Console.WriteLine($"{defender.Name} has won the fight!");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior attacker, Warrior defender)
        {
            double warAttackAmount = attacker.Attack();
            double warBlockAmount = defender.Block();

            double damageToDefender = warAttackAmount - warBlockAmount;

            if (damageToDefender > 0)
            {
                defender.Health -= damageToDefender;
            }
            else
            {
                damageToDefender = 0;
            }

            Console.WriteLine(
                $"{attacker.Name} attacks {defender.Name} for {warAttackAmount} damage. {defender.Name} blocks {warBlockAmount} damage. {defender.Name} takes {damageToDefender} damage."
            );
            Console.WriteLine($"{defender.Name} has {defender.Health} health left.");

            if (defender.Health <= 0)
            {
                Console.WriteLine($"{defender.Name} has died.");
                return "defender";
            }
            else
            {
                return "attacker";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior1 = new Warrior("Warrior 1", 100.0, 10.0, 5.0);
            Warrior warrior2 = new Warrior("Warrior 2", 120.0, 12.0, 4.0);

            Battle.StartFight(warrior1, warrior2);
        }
    }
}
