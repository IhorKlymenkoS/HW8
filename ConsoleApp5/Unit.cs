using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class Unit
    {
        private int _hp;
        private int _attackDamage;
        private int _team;

        public int AD => _attackDamage;
        public int HP => _hp;

        protected Unit(int hp, int attackDamage)
        {
            _hp = hp;
            _attackDamage = attackDamage;
        }

        protected abstract double AttackAmount { get; }
        protected abstract double DefenceAmount { get; }

        public int Team
        {
            get
            {
                return _team;
            }
            set
            {
                if (value > 0)
                {
                    _team = value;
                }
            }
        }

        public void Attack(Unit unit)
        {
            var damage = AttackAmount * unit.DefenceAmount;
            Console.WriteLine($"{GetType()} attacked {unit.GetType()}:");
            if(damage != 0)
            {
                //Console.WriteLine($"{damage} damage done!");
            }
            else
            {
               //Console.WriteLine($"{unit.GetType()} dodged!");
            }

            Console.WriteLine();

            unit.TakeDamage((int)damage);
        }

        private void TakeDamage(int damage)
        {
            _hp -= damage;
        }
    }
}
