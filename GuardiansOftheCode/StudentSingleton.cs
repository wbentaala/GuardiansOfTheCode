using System;
using System.Collections.Generic;
using System.Text;

namespace GuardiansOftheCode
{
    public sealed class StudentSingleton
    {
        private static readonly StudentSingleton _instance;
        private StudentSingleton()
        {
        }
        static StudentSingleton()
        {
            _instance = new StudentSingleton {
                Name="Student"
            };
        }
        public static StudentSingleton Instance{
            get => _instance;
        }
        public string Name { get; set; }
    }
}
