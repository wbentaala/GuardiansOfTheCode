using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOftheCode
{
    public class Werewolf : IEnemy
    {
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Level => throw new NotImplementedException();

        public void Attack(PrimaryPlayer player)
        {
            throw new NotImplementedException();
        }

        public void Defend(PrimaryPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
