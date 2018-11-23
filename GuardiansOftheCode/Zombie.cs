using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOftheCode
{
    public class Zombie : IEnemy
    {
        private int _health;
        private int _level;
        public int Health { get => this._health; set => this._health = value; }

        public int Level => this._health;

        
        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Zombie attacking {player.Name}");
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Zombie defending from {player.Name}");
        }
    }
}
