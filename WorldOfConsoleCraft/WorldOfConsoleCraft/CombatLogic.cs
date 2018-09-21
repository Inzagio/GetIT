using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfConsoleCraft
{
    class CombatLogic
    {
        public Character Character;
        public static Monster Monster;

        private static Random random = new Random();

        public void DamageModifier(int Damage)
        {
            var player = Character.Damage;
            var monster = Monster.Damage;

            if (monster == 1)
            {
                Damage = random.Next(1, 101);
            }

            if (player == 1)
            {
                Damage = random.Next(5, 15);
            }

        }

        public static void HpCheck()
        {
            var player = CoreGameLogic.Character.HealthPoints;
            var monster = Monster.HealthPoints;

            if (player == 0)
            {
                Console.WriteLine($"{CoreGameLogic.Character.Name} has died!");
            }

            if (monster == 0)
            {
                Console.WriteLine($"You killed a {Monster.Name}, you are awarded {CoreGameLogic.Character.ExperiencePoints}");
            }
        }
    }
}
