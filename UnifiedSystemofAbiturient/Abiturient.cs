using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class Abiturient
    {
        public List<ApplicatioN> Applications;
        public string Name { get; }

        public Dictionary<Subjects, int> Points;

        public void addApplication(ApplicatioN applicatioN)
        {
            Applications.Add(applicatioN);
        }
        public Abiturient(string name, Dictionary<Subjects, int> points)
        {
            Name = name;
            Points = points;
        }

    }
}