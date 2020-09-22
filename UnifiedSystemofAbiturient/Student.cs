using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class Student : UserDecorator
    {
        public Student()
        {
        }
        public string showYearOfEducation()
        {
            return "3";
        }
    }
}