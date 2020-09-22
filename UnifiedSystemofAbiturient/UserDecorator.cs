using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public abstract class UserDecorator : User
    {
        protected User User;

        public void setUser(User user)
        {
            User = user;
        }
    }
}