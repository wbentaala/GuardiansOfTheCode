using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOftheCode
{
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        private PrimaryPlayer()
        {
        }
        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer {
                Name = "wassim", 
                Level = 1
            };
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public static PrimaryPlayer Instance {
            get => _instance;
        }
    }
}
