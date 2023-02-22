using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.MyImplementation
{
    public class Squidward
    {
        private IWeapon _attack;
        public void SetStrategy( IWeapon attack)
        {
            _attack = attack;
        }
        public void DoSomeAction()
        {
            _attack.Shoot();
        }
    }
}
