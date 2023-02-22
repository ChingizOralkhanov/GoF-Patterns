using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Strategy.MyImplementation
{
    public class Hero
    {
        public readonly string _name;
        private IWeapon? _weapon;

        public void SetWeapon(IWeapon weapon)
        {
           _weapon = weapon;
        }
        public Hero(string name)
        {
            _name = name;
        }
        public void Attack()
        {
            Console.WriteLine(">>>>");
            if (_weapon is null)
            {
                Console.WriteLine($"{_name} cant attack. Set a weapon");
                return;
            }
            Console.WriteLine($"{_name} stands menacingly");
            Console.Write($"{_name} ");
            _weapon.Shoot();
            Console.WriteLine($"{_name} ceases to stand menacingly");

        }
    }
}
