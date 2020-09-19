using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class ApplicatioN
    {
        private Dictionary<Subjects, int> Points;
        public Abiturient Abiturient
        {
            get => default;
            set
            {
            }
        }
        public University University
        {
            get => default;
            set
            {
            }
        }
        public ApplicatioN(University university, Abiturient abiturient, Subjects[] subjects)
        {
            University = university;
            Abiturient = abiturient;
            foreach (Subjects s in subjects)
            {
                abiturient.Points.TryGetValue(s, out int value);
                Points.Add(s, value);
            }
        }

        public int getSum()
        {
            int sum = 0;
            foreach (KeyValuePair<Subjects, int> point in Points)
            {
                sum += point.Value;
            }
            return sum;
        }
    }
}