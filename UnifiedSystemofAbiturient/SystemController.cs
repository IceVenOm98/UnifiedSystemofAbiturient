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
        private List<User> Users=new List<User>();
        private ActiveUserCreator ActiveUserCreator = new ActiveUserCreator();
        private AbiturientCreator AbiturientCreator = new AbiturientCreator();
        private StudentCreator StudentCreator = new StudentCreator();
        private GraduateCreator GraduateCreator = new GraduateCreator();
        private SelectionContext SelectionContext = new SelectionContext();
        public SystemController()
        {
            ApplicationCreator = new ApplicationCreator();
            RaitingCreator = new SelectionContext();
        }

        private ApplicationCreator ApplicationCreator;
        private SelectionContext RaitingCreator;

        public void createApplication(University university, Abiturient abiturient, Subjects[] subjects)
        {
            ApplicatioN applicatioN = ApplicationCreator.createApplication(university, abiturient, subjects);
            university.addApplication(applicatioN);
            abiturient.addApplication(applicatioN);
        }

        public void newUniversity(string title, int places)
        {
            Universities.Add(new University(title,places));
        }

        public User newActiveUser(String name, Dictionary<Subjects, int> points)
        {
            ActiveUser au = (ActiveUser)ActiveUserCreator.newUser(null);
            au.Name = name;
            au.Points = points;
            Users.Add(au);
            return au;
        }
        public void newAbiturient(User user, String name, Dictionary<Subjects, int> points)
        {
            if (user == null)
            {
                user = newActiveUser(name, points);
            }
            Abiturient a = (Abiturient)AbiturientCreator.newUser(user);
            Users.Add(a);
        }
        public void newStudent(User user, String name, Dictionary<Subjects, int> points)
        {
            if (user == null)
            {
                user = newActiveUser(name, points);
            }
            Student s = (Student)StudentCreator.newUser(user);
            Users.Add(s);
        }
        public void newGraduate(User user, String name, Dictionary<Subjects, int> points)
        {
            if (user == null)
            {
                user = newActiveUser(name, points);
            }
            Graduate g = (Graduate)GraduateCreator.newUser(user);
            Users.Add(g);
        }

        public List<University> getSelection(int selectionNumber)
        {
            switch (selectionNumber)
            {
                case 0:
                    SelectionContext.setSelection(new SelectionByOrder());
                    break;
                case 1:
                    SelectionContext.setSelection(new SelectionByRait());
                    break;
                case 2:
                    SelectionContext.setSelection(new SelectionByPlaces());
                    break;
                default:
                    return Universities;
            }
            return SelectionContext.getSelection(Universities);
        }
    }
}