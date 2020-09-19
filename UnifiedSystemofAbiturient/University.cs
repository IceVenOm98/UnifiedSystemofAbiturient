using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class University
    {
        public string Title { get; }

        private List<ApplicatioN> Applications;
        public University(string title)
        {
            Title = title;
        }

        public void addApplication(ApplicatioN applicatioN)
        {
            Applications.Add(applicatioN);
        }

        internal int getAveragePoint()
        {
            int sum=0;
            foreach (ApplicatioN app in Applications)
            {
                sum += app.getSum();
            }
            return sum / Applications.Count;
        }
    }
}