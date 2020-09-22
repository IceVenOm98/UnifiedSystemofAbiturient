using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class Graduate : UserDecorator
    {
        private string UniversityTitle;
        public string graduatedUniversity()
        {
            return UniversityTitle;
        }
    }
}