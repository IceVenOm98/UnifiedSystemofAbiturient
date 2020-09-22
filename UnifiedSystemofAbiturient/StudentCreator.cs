using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class StudentCreator : UserCreator
    {
        public override User newUser(User user)
        {
            Student s = new Student();
            s.setUser(user);
            return s;
        }
    }
}