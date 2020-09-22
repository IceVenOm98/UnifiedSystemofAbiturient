using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class AbiturientCreator : UserCreator
    {
        public override User newUser(User user)
        {
            Abiturient a = new Abiturient();
            a.setUser(user);
            return a;
        }

    }
}