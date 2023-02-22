using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.MyImplementation
{
    public class WaterGun : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attack with water gun");
        }
    }

    public class Plunger : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attack with plunger");
        }
    }

    public class Broom : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attack with broom");
        }
    }
}
