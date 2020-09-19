using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public enum Subjects
    {
        Math,
        Rus,
        IT,
        Phys
    }
    public class SystemController
    {
        private List<University> Universities = new List<University>();
        private List<Abiturient> Abiturients=new List<Abiturient>();
        public SystemController()
        {
            ApplicationCreator = new ApplicationCreator();
            RaitingCreator = new RaitingCreator();
        }

        private ApplicationCreator ApplicationCreator;
        private RaitingCreator RaitingCreator;

        public void createApplication(University university, Abiturient abiturient, Subjects[] subjects)
        {
            ApplicationCreator.createApplication(university, abiturient, subjects);
        }

        public void newUniversity(String title)
        {
            Universities.Add(new University(title));
        }

        public void newAbiturient(String name, Dictionary<Subjects, int> points)
        {
            Abiturients.Add(new Abiturient(name, points));
        }

        public List<University> createRaiting(List<University> universities)
        {
            return RaitingCreator.createRaiting(universities);
        }
    }
}