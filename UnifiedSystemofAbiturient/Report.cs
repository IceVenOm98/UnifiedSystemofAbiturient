using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class Report
    {
        private string UniversityTitle;

        private string AbiturientName;

        private List<KeyValuePair<Subjects, int>> Points;

        public Report(string universityTitle, string abiturientName, List<KeyValuePair<Subjects, int>> points)
        {
            UniversityTitle = universityTitle;
            AbiturientName = abiturientName;
            Points = points;
        }

    }
}