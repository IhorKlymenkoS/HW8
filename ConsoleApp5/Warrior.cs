using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Warrior : Unit
    {
        private const int BaseHP = 200;
        private const int BaseAD = 35;
        private const double AttackMultiplier = 0.5;
        private const double DefenceMultiplier = 0.7;

        public Warrior() : base(BaseHP, BaseAD)
        {
        }

        protected override double AttackAmount => AD * AttackMultiplier;

        protected override double DefenceAmount => DefenceMultiplier;
    }
}
