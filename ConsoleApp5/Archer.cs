using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Archer : Unit
    {
        private const int BaseHP = 120;
        private const int BaseAD = 35;
        private const double CritChance = 0.33;
        private const double CritDamage = 1.7;
        private const double DodgeChange = 0.25;
        private const double DefenceMultiplier = 1.2;

        private readonly Random _random;

        public static int DodgeCount { get; private set; }
        public static int AttackCount { get; private set; }

        static Archer()
        {
            DodgeCount = 0;
            AttackCount = 0;
        }

        public Archer() : base(BaseHP, BaseAD)
        {
            _random = new Random();
        }

        protected override double AttackAmount
        {
            get
            {
                bool isCrit = (1 - _random.NextDouble()) <= CritChance;
                double damage = isCrit ? AD * CritDamage : AD;
                AttackCount++;

                return damage;
            }
        }

        protected override double DefenceAmount
        {
            get
            {
                var isDodge = (1 - _random.NextDouble()) <= DodgeChange;
                DodgeCount += isDodge ? 1 : 0;

                return isDodge ? 0 : DefenceMultiplier;
            }
        }
    }
}
