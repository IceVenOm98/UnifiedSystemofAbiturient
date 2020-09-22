using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public enum Subjects
    {
        Математика,
        Русский,
        Информатика,
        Физика,
        Обществознание,
        История
    }
    public class SystemController
    {
        private List<University> Universities = new List<University>();
        private List<User> Users=new List<User>();
        private UniversityCreator UniversityCreator = new UniversityCreator();
        private ActiveUserCreator ActiveUserCreator = new ActiveUserCreator();
        private AbiturientCreator AbiturientCreator = new AbiturientCreator();
        private StudentCreator StudentCreator = new StudentCreator();
        private GraduateCreator GraduateCreator = new GraduateCreator();
        private SelectionContext SelectionContext = new SelectionContext();
        private ApplicationCreator ApplicationCreator;
        private SelectionContext RaitingCreator;
        public SystemController()
        {
            ApplicationCreator = new ApplicationCreator();
            RaitingCreator = new SelectionContext();
            UniversityCreator.setUniversities(Universities);
        }

        public List<User> getUsers()
        {
            return Users;
        }
        public List<University> getUniversities()
        {
            return Universities;
        }

        public void createApplication(University university, User user, Subjects[] subjects)
        {
            if (user.GetType() != typeof(Abiturient))
            {
                user = newAbiturient(user,null,null);
            }
            ApplicatioN applicatioN = ApplicationCreator.createApplication(university, user, subjects);
            university.addApplication(applicatioN);
            ((Abiturient)user).addApplication(applicatioN);
        }

        public University newUniversity(string title, int places)
        {
            University u = UniversityCreator.newUniversity(title, places);
            return u;
        }

        public User newActiveUser(string name, Dictionary<Subjects, int> points)
        {
            ActiveUser au = (ActiveUser)ActiveUserCreator.newUser(null);
            au.Name = name;
            au.Points = points;
            Users.Add(au);
            return au;
        }
        public Abiturient newAbiturient(User user, String name, Dictionary<Subjects, int> points)
        {
            if (user == null)
            {
                user = newActiveUser(name, points);
            }
            Users.Remove(user);
            Abiturient a = (Abiturient)AbiturientCreator.newUser(user);
            Users.Add(a);
            return a;
        }
        public Student newStudent(User user, String name, Dictionary<Subjects, int> points)
        {
            if (user == null)
            {
                user = newActiveUser(name, points);
            }
            Users.Remove(user);
            Student s = (Student)StudentCreator.newUser(user);
            Users.Add(s);
            return s;
        }
        public Graduate newGraduate(User user, String name, Dictionary<Subjects, int> points)
        {
            if (user == null)
            {
                user = newActiveUser(name, points);
            }
            Users.Remove(user);
            Graduate g = (Graduate)GraduateCreator.newUser(user);
            Users.Add(g);
            return g;
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