using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class RaitingCreator
    {
        public List<University> createRaiting(List<University> universities)
        {
            int avaragePoint;
            foreach (University u in universities)
            {
                avaragePoint = u.getAveragePoint();
            }
            return universities;
        }
    }
}