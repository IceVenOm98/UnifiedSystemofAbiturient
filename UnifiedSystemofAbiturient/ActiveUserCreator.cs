using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class ActiveUserCreator : UserCreator
    {
        //TODO придумать, как избавиться от конструктора с параметров
        public override User newUser(User user)
        {
            return new ActiveUser();
        }
    }
}