using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class UniversityCreator
    {
        List<University> Universities;
        public void setUniversities(List<University> universities)
        {
            Universities = universities;
        }
        public University newUniversity(string title, int places)
        {
            if (Universities.Exists(item => item.Title == title))
                return Universities.Find(item => item.Title == title);
            else
            {
                University u = new University(title, places);
                Universities.Add(u);
                return u;
            }
        }
    }
}