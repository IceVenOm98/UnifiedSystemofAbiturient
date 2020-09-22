using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class ApplicatioN
    {
        private Dictionary<Subjects, int> Points = new Dictionary<Subjects, int>();
        private DateTime CreationDate;

        public User User;
        public University University;
        public ApplicatioN(University university, User user, Subjects[] subjects)
        {
            University = university;
            User = user;
            CreationDate = DateTime.Now;
            foreach (Subjects s in subjects)
            {
                User.Points.TryGetValue(s, out int value);
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
        public override string ToString()
        {
            return "Заявление в университет "+University.Title+" подал "+User.Name+" с баллами егэ:\n"+
                User.Points.Keys.ElementAt(0) + ": "+User.Points.Values.ElementAt(0) + "\n" +
                User.Points.Keys.ElementAt(1) + ": "+User.Points.Values.ElementAt(1) + "\n" +
                User.Points.Keys.ElementAt(2) + ": "+User.Points.Values.ElementAt(2)+ "\n" +
                "Дата подачи: "+CreationDate.ToString();
        }
    }
}