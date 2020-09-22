using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class Abiturient:UserDecorator
    {

        public List<ApplicatioN> Applications;

        public void addApplication(ApplicatioN applicatioN)
        {
            Applications.Add(applicatioN);
        }

    }
}