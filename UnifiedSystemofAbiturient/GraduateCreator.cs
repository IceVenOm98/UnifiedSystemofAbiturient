using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class GraduateCreator : UserCreator
    {
        public override User newUser(User user)
        {
            Graduate g = new Graduate();
            g.setUser(user);
            return g;
        }
    }
}