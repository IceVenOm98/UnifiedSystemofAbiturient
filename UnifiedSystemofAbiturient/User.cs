using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public abstract class User
    {
        public Dictionary<Subjects, int> Points;
        public string Name
        {
            get => default;
            set
            {
            }
        }

        public User() { }

        public User(string name, Dictionary<Subjects, int> points)
        {
            Name = name;
            Points = points;
        }
        public void setPoints(Dictionary<Subjects, int> points)
        {
            Points = points;
        }
    }
}