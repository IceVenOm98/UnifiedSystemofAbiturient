using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public abstract class Selection
    {
        public abstract List<University> get(List<University> universities);
    }
}