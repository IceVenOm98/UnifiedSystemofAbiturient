using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class SelectionByOrder : Selection
    {
        public override List<University> get(List<University> universities)
        {
            List<University> universities1 = new List<University>();
            foreach(University u in universities)
            {
                universities1.Prepend(u);
            }
            
            return universities1;
        }
    }
}